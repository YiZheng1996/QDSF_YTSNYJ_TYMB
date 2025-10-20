using Polly;
using Polly.CircuitBreaker;
using Polly.Timeout;
using RestSharp;
using System.Reflection;

namespace MainUI.CurrencyHelper
{
    /// <summary>
    /// Get/Post 接口访问
    /// </summary>
    /// <param name="baseUrl">地址</param>
    /// <param name="retryCount">重试次数</param>
    /// <param name="retryDelayInSeconds">重试延迟秒数</param>
    /// <param name="circuitBreakerFailureThreshold">触发熔断器的阈值，即 在指定时间段内允许失败的连续次数。</param>
    /// <param name="circuitBreakerDurationInMinutes">熔断器开启后的持续时间，即 熔断器被触发进入“开启”状态后，系统需要等待多长时间才能再次允许操作尝试执行</param>
    /// <param name="timeoutInSeconds">超时时间</param>
    public class HttpClientWithPolly(string baseUrl, int retryCount = 3, int retryDelayInSeconds = 2,
        int circuitBreakerFailureThreshold = 2, int circuitBreakerDurationInMinutes = 1, int timeoutInSeconds = 30)
    {
        private readonly RestClient _client = new(baseUrl);
        private readonly int _retryCount = retryCount;
        private readonly TimeSpan _retryDelay = TimeSpan.FromSeconds(retryDelayInSeconds);
        private readonly int _circuitBreakerFailureThreshold = circuitBreakerFailureThreshold;
        private readonly TimeSpan _circuitBreakerDuration = TimeSpan.FromMinutes(circuitBreakerDurationInMinutes);
        private readonly TimeSpan _timeoutDuration = TimeSpan.FromSeconds(timeoutInSeconds);

        public async Task<T> GetAsync<T>(string resource, Dictionary<string, string> parameters = null) where T : new()
        {
            var request = new RestRequest(resource, Method.Get);
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    request.AddParameter(param.Key, param.Value);
                }
            }
            return await ExecuteRequestAsync<T>(request);
        }

        public async Task<T> PostAsync<T>(object body = null, string resource = null, string token = null) where T : new()
        {
            var request = new RestRequest(resource, Method.Get);
            if (body != null)
            {
                request.AddBody("Content-Type", "multipart/form-data");
                PropertyInfo[] properties = body.GetType().GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    request.AddParameter(property.Name, property.GetValue(body).ToString());
                    Debug.WriteLine("Property Name: " + property.Name);
                    Debug.WriteLine("Property Value: " + property.GetValue(body));
                }
            }
            if (!string.IsNullOrEmpty(token))
            {
                request.AddHeader("Authorization", $"Bearer {token}");
            }
            return await ExecuteRequestAsync<T>(request);
        }

        // 使用策略的方式，进行请求组合
        private async Task<T> ExecuteRequestAsync<T>(RestRequest request) where T : new()
        {
            // 重试策略
            var retryPolicy = Policy
                .Handle<Exception>()
                .WaitAndRetryAsync(_retryCount, retryAttempt => _retryDelay);

            // 熔断器策略
            var circuitBreakerPolicy = Policy
                .Handle<Exception>()
                .CircuitBreakerAsync(_circuitBreakerFailureThreshold, _circuitBreakerDuration);

            // 超时策略
            var timeoutPolicy = Policy
                .TimeoutAsync(_timeoutDuration, TimeoutStrategy.Pessimistic);

            // 组合策略
            var policyWrap = Policy.WrapAsync(retryPolicy, circuitBreakerPolicy, timeoutPolicy);

            // 执行 HTTP 请求，通过策略管理失败和重试
            try
            {
                return await policyWrap.ExecuteAsync(async () =>
                {
                    var response = await _client.ExecuteAsync<T>(request);
                    if (response.IsSuccessful)
                    {
                        return response.Data;
                    }
                    else
                    {
                        throw new Exception($"HTTP请求失败，状态码：{response.StatusCode}");
                    }
                });
            }
            catch (BrokenCircuitException)
            {
                Debug.WriteLine("熔断器开启，跳过请求。");
                throw;
            }
            catch (TimeoutRejectedException)
            {
                Debug.WriteLine("请求超时。");
                throw;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"请求失败: {ex.Message}");
                throw;
            }
        }
    }
}