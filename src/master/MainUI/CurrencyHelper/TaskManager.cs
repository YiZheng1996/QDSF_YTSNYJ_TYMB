namespace MainUI.CurrencyHelper
{
    internal class TaskManager : BaseTest
    {
        private readonly Dictionary<string, TaskInfo> tasks = [];

        /// <summary>
        /// 启动
        /// </summary>
        /// <param name="taskId"></param>
        public void StartTask(string taskId)
        {
            if (!tasks.ContainsKey(taskId))
            {
                CancellationTokenSource cancellationTokenSource = new();
                Task task = Task.Run(() => TaskMethod(taskId, cancellationTokenSource.Token), cancellationTokenSource.Token);
                tasks.Add(taskId, new TaskInfo { Task = task, CancellationTokenSource = cancellationTokenSource });
                Debug.WriteLine($"Task {taskId} 启动");
            }
            else
            {
                Debug.WriteLine($"Task {taskId} 正在运行");
            }
        }

        /// <summary>
        /// 暂停
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public async Task PauseTaskAsync(string taskId)
        {
            if (tasks.TryGetValue(taskId, out TaskInfo value))
            {
                CancellationTokenSource cancellationTokenSource = value.CancellationTokenSource;
                cancellationTokenSource?.Cancel();
                await value.Task;
                Debug.WriteLine($"Task {taskId} 暂停");
            }
            else
            {
                Debug.WriteLine($"Task {taskId} 未运行");
            }
        }

        /// <summary>
        /// 继续
        /// </summary>
        /// <param name="taskId"></param>
        public void ResumeTask(string taskId)
        {
            if (tasks.TryGetValue(taskId, out TaskInfo value))
            {
                value.CancellationTokenSource?.Dispose();
                value.CancellationTokenSource = new CancellationTokenSource();
                Task task = Task.Run(() => TaskMethod(taskId, value.CancellationTokenSource.Token), value.CancellationTokenSource.Token);
                value.Task = task;
                Debug.WriteLine($"Task {taskId} 重新开始");
            }
            else
            {
                Debug.WriteLine($"Task {taskId} 未运行");
            }
        }

        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public async Task StopTaskAsync(string taskId)
        {
            if (tasks.TryGetValue(taskId, out TaskInfo value))
            {
                CancellationTokenSource cancellationTokenSource = value.CancellationTokenSource;
                cancellationTokenSource?.Cancel();

                try
                {
                    await value.Task; //等待任务完成
                }
                catch (TaskCanceledException)
                {
                    //任务已取消
                }
                finally
                {
                    cancellationTokenSource?.Dispose(); // 释放 CancellationTokenSource 资源
                    tasks.Remove(taskId);               // 从任务列表中移除任务信息
                    Debug.WriteLine($"Task {taskId} 停止并释放资源");
                }
            }
            else
            {
                Debug.WriteLine($"Task {taskId} 未运行");
            }
        }

        /// <summary>
        /// 是否在线
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public bool IsTaskRunning(string taskId)
        {
            if (tasks.TryGetValue(taskId, out TaskInfo value))
            {
                TaskStatus status = value.Task.Status;
                return status == TaskStatus.Running || status == TaskStatus.WaitingToRun || status == TaskStatus.WaitingForActivation;
            }
            return false;
        }

        /// <summary>
        /// 试验过程
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="cancellationToken"></param>
        private void TaskMethod(string taskId, CancellationToken cancellationToken)
        {
            switch (taskId)
            {
                case "离线试验":
                    OfflineTaskLogic(cancellationToken);
                    break;
                case "在线试验":
                    OnLineTaskLogic(cancellationToken);
                    break;
                case "耐压试验过程结果数组":
                    PressurizationTaskLogic(cancellationToken);
                    break;
                case "合闸语音播报":
                    BroadcastTaskLogic(cancellationToken);
                    break;
                default:
                    Debug.WriteLine($"Task {taskId} 没有定义的逻辑");
                    break;
            }
        }

        private async void OfflineTaskLogic(CancellationToken cancellationToken)
        {
            try
            {
                OfflineTest offline = new(cancellationToken);
                await offline.Execute();
                Debug.WriteLine($"Task1 已暂停或取消");
            }
            catch (OperationCanceledException)
            {
                Debug.WriteLine("触发手动停止试验！");
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("Task1错误：" + ex);
            }
        }

        private async void OnLineTaskLogic(CancellationToken cancellationToken)
        {
            try
            {
                OnLineTest onLine = new(cancellationToken);
                await onLine.Execute();
                Debug.WriteLine($"Task2 已暂停或取消");
            }
            catch (OperationCanceledException)
            {
                Debug.WriteLine("触发手动停止试验！");
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("Task2错误：" + ex);
            }
        }

        private async void PressurizationTaskLogic(CancellationToken cancellationToken)
        {
            try
            {
                PressurizationTest curve = new(cancellationToken);
                await curve.Execute();
                Debug.WriteLine($"Task3 已暂停或取消");
            }
            catch (OperationCanceledException)
            {
                Debug.WriteLine("触发手动停止试验！");
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("Task3错误：" + ex);
            }
        }

        private async void BroadcastTaskLogic(CancellationToken cancellationToken)
        {
            try
            {
                BroadcastTest curve = new(cancellationToken);
                await curve.Execute();
                Debug.WriteLine($"Task4 已暂停或取消");
            }
            catch (OperationCanceledException)
            {
                Debug.WriteLine("触发手动停止试验！");
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("Task4错误：" + ex);
            }
        }

        private class TaskInfo
        {
            public Task Task { get; set; }
            public CancellationTokenSource CancellationTokenSource { get; set; }
        }

    }
}
