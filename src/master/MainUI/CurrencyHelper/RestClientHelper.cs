using System.Net.NetworkInformation;
using System.Reflection;
using System.Windows.Forms;
using Irony.Parsing;
using Newtonsoft.Json;
using RestSharp;

namespace MainUI.CurrencyHelper
{
    public class RestClientHelper(string baseUrl)
    {
        private readonly RestClient _client = new(baseUrl);

        // GET 请求方法
        public async Task<T> GetAsync<T>(string resource, object parameters = null, string token = null)
            where T : new()
        {
            var request = new RestRequest(resource, Method.Get);
            if (parameters != null)
                request.AddObject(parameters);

            if (!string.IsNullOrEmpty(token))
                request.AddHeader("Authorization", $"Bearer {token}");

            var response = await _client.ExecuteAsync(request);
            if (response.IsSuccessful)
                return JsonConvert.DeserializeObject<T>(response.Content);
            else
                // 处理错误情况，这里可以抛出一个异常  
                throw new Exception($"Get获取失败，状态代码为: {response.StatusCode}");
        }

        // Get 请求方法
        public async Task<T> GetAsync<T>(object body = null, string resource = null, int timeoutMilliseconds = 5000, string token = null) where T : new()
        {
            try
            {
                var request = new RestRequest(resource, Method.Get);
                if (body != null)
                {
                    request.AddBody("Content-Type", "multipart/form-data");
                    PropertyInfo[] properties = body.GetType().GetProperties();
                    foreach (PropertyInfo property in properties)
                    {
                        request.AddParameter(property.Name, property.GetValue(body).ToString());
                        //Debug.WriteLine("Property Name: " + property.Name);
                        //Debug.WriteLine("Property Value: " + property.GetValue(body));
                    }
                }
                if (!string.IsNullOrEmpty(token))
                {
                    request.AddHeader("Authorization", $"Bearer {token}");
                }

                var response = await _client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    //NlogHelper.Default.Debug("body：" + body + ",Get数据：" + response.IsSuccessful);
                    return JsonConvert.DeserializeObject<T>(response.Content);
                }
                if (string.IsNullOrEmpty(response.Content))
                    throw new Exception($"Get获取失败，状态代码为: {response.Content}");
                else
                    throw new Exception($"Get获取失败，状态代码为: {response.StatusCode}");

            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("Get获取失败:", ex);
                throw new Exception($"Get获取失败：" + ex.Message);
            }
        }


        // POST 请求方法
        public async Task<T> PostAsync<T>(string json) where T : new()
        {
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddStringBody(json, DataFormat.Json);
            var response = await _client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<T>(response.Content);
            }
            if (string.IsNullOrEmpty(response.Content))
                throw new Exception($"Post获取失败，状态代码为: {response.Content}");
            else
                throw new Exception($"Post获取失败，状态代码为: {response.StatusCode}");
        }



        // PUT 请求方法
        public async Task<RestResponse> PutAsync(string resource, object body = null, string token = null)
        {
            var request = new RestRequest(resource, Method.Put);
            if (body != null)
            {
                request.AddJsonBody(body);
            }
            if (!string.IsNullOrEmpty(token))
            {
                request.AddHeader("Authorization", $"Bearer {token}");
            }
            return await _client.ExecuteAsync(request);
        }

        // DELETE 请求方法
        public async Task<RestResponse> DeleteAsync(string resource, object parameters = null, string token = null)
        {
            var request = new RestRequest(resource, Method.Delete);
            if (parameters != null)
            {
                request.AddObject(parameters);
            }
            if (!string.IsNullOrEmpty(token))
            {
                request.AddHeader("Authorization", $"Bearer {token}");
            }
            return await _client.ExecuteAsync(request);
        }

        // 检查响应状态
        public bool IsSuccessful(RestResponse response) => response.IsSuccessful;

        // 获取原始响应内容
        public string GetContent(RestResponse response) => response.Content;

        // 获取响应状态码
        public System.Net.HttpStatusCode GetStatusCode(RestResponse response) => response.StatusCode;

        // 获取错误信息
        public string GetErrorMessage(RestResponse response) => response.ErrorMessage;

        // 获取所有网络接口 MAC 地址
        public IEnumerable<string> GetMacAddresses()
        {
            //获取所有网络接口
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                //获取 MAC 地址
                PhysicalAddress macAddr = ni.GetPhysicalAddress();
                if (macAddr != null)
                {
                    // 格式化 MAC 地址
                    string macAddress = string.Join(":", macAddr.GetAddressBytes().Select(b => b.ToString("X2")));
                    yield return $"Interface: {ni.Name} - MAC Address: {macAddress}";
                }
            }
        }


    }
}
