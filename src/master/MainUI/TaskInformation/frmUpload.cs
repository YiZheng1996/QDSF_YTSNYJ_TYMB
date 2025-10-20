using AntdUI;
using MainUI.CurrencyHelper;
using MainUI.Model.StateModel;
using Newtonsoft.Json;

namespace MainUI.TaskInformation
{
    public partial class FrmUpload : UIForm
    {
        public FrmUpload() => InitializeComponent();

        readonly MainTaskBLL taskBLL = new();
        readonly HoldTaskBLL holdTaskBLL = new();
        readonly NewTaskBLL newTask = new();

        private void TaskView_Load(object sender, EventArgs e)
        {
            InitTableTitle();
            AddCobData(selectProjectNumber, taskBLL.GetCobProjectNumber());
            AddCobData(selectCarCode, taskBLL.GetCobCarCode());
            AddCobData(selectTrainCode, taskBLL.GetCobTrainNo());
        }

        private void InitTableTitle()
        {
            table1.Columns = [
                new ColumnCheck("Check"){ Fixed = true ,Checked=false},
                new Column("projectNumber","车型编码"){ Fixed = true ,Align = ColumnAlign.Center},
                new Column("trainCode","配属列号"){ Fixed = true ,Align = ColumnAlign.Center},
                new Column("carCode","配属辆号"){ Fixed = true ,Align = ColumnAlign.Center},
                new Column("trainNo","车列号"){ Fixed = true ,Align = ColumnAlign.Center},
                new Column("detailId","明细ID"){ Visible = true ,Align = ColumnAlign.Center},
                new Column("holdTaskId","施工任务ID"){ Visible = true ,Align = ColumnAlign.Center},
                new Column("holdItemId","耐压子任务ID"){ Visible = true ,Align = ColumnAlign.Center},
                new Column("ID","子表ID"){ Visible = false},
                new Column("stepName","步骤名称"),
                new Column("stepBom","操作区域"),
                new Column("stepContent","操作内容"),
                new Column("testTemperature","环境温度(℃)"),
                new Column("testHumidity","环境湿度(%)"),
                new Column("applyVoltage","实际施加电压(V)"),
                new Column("testValue","试验结果值"),
                new Column("testProcessValues","耐压试验过程结果数组"){ Visible = false},
                new Column("remark","备注"),
                new Column("operatePersonName","操作人姓名"),
                new Column("operatePerson","操作人工号"),
                new Column("operateTime","操作时间"),
                new Column("operateResult","自检结果"),
                new Column("stepNo","操作排序"){ Visible = false},
                new Column("isOperateCell","是否操作位置"){ Visible = false},
                new Column("resultContent","结果默认内容"),
                new Column("recordType","结果记录类型"){ Visible = false},
                new Column("resultStandard","结果记录范围标准"),
                new Column("resultUnit","结果单位"),
                new Column("auxiliariesName1","辅助姓名1"),
                new Column("auxiliariesCode1","辅助人工号1"),
                new Column("auxiliariesName2","辅助姓名2"),
                new Column("auxiliariesCode2","辅助人工号2"),
                new Column("auxiliariesName3","辅助姓名3"),
                new Column("auxiliariesCode3","辅助人工号3"),
                new Column("auxiliariesName4","辅助姓名4"),
                new Column("auxiliariesCode4","辅助人工号4"),
                new Column("mutualPersonName","互检人姓名"),
                new Column("mutualPerson","互检人工号"),
                new Column("mutualTime","互检时间"),
                new Column("mutualResult","互检结果"),
                new Column("qualityPersonName","质检人姓名"),
                new Column("qualityPerson","质检人工号"),
                new Column("qualityTime","质检时间"),
                new Column("qualityResult","质检结果"),
                new Column("RedoBtns","操作",ColumnAlign.Center){ Fixed = true , Width = "130"}
            ];
            var data = newTask.GetNewTasks(new NewTaskModel { isComplete = 1 });
            table1.Tag = data.Count;
            table1.DataSource = data.OrderByDescending(a => a.ID).Take(100);
        }

        private void Table1_CellButtonClick(object sender, TableButtonEventArgs e)
        {
            if (e.Record is NewTaskModel data)
            {
                if (AntdUI.Modal.open(new Modal.Config(this, $"请确认任务是否重做？", new Modal.TextLine[] {
                    new($"步骤名称：{data.stepName}\n操作步骤：{data.stepBom}\n操作内容：{data.stepContent}",AntdUI.Style.Db.Error),
                }, TType.Info)
                {
                    Width = 600,
                    OkText = "确认",
                    Keyboard = false,
                    CancelText = "取消",
                    MaskClosable = false,
                    OkType = TTypeMini.Info,
                    Font = new Font("宋体", 16),
                }) == DialogResult.OK)
                {
                    table1.Spin(new Spin.Config()
                    {
                        Text = "任务还原中...",
                        Font = new Font("宋体", 15),
                        Back = Color.FromArgb(189, 179, 172),
                    }, () =>
                    {
                        Thread.Sleep(1500);
                    }, () =>
                    {
                        Invoke(() =>
                        {
                            if (holdTaskBLL.TaskRedo(new NewTaskModel { ID = data.ID, isComplete = 0 }))
                            {
                                var data = newTask.GetNewTasks(new NewTaskModel { isComplete = 1 });
                                table1.DataSource = data;
                                table1.Tag = data.Count;
                                MessageHelper.MessageOK(this, "任务还原成功，可在[任务查看]界面中查看任务！");
                            }
                            else MessageHelper.MessageOK(this, "任务还原失败！");
                        });
                    });
                }
            }
        }

        private int AddCobData(Select select, List<string> strings)
        {
            Invoke(() =>
            {
                select.Items.Clear();
                for (int i = 0; i < strings.Count; i++)
                    select.Items.AddRange([strings[i]]);
                return strings.Count;
            });
            return strings.Count;
        }

        private void selectProjectNumber_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            Invoke(() =>
            {
                selectCarCode.Text = "--请选择--";
                selectTrainCode.Text = "--请选择--";
                var value = taskBLL.GetCobCarCode(selectProjectNumber.SelectedValue.ToString());
                AddCobData(selectCarCode, value);
            });
        }

        private void selectCarCode_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            Invoke(() =>
            {
                try
                {
                    selectTrainCode.Text = "--请选择--";
                    AddCobData(selectTrainCode, taskBLL.GetCobTrainNo(selectProjectNumber.SelectedValue.ToString(), selectCarCode.SelectedValue.ToString()));
                }
                catch (Exception ex)
                {
                    MessageHelper.MessageOK(this, "[任务上传界面]选择配属辆号错误，请检查是否车型编码未选择！：" + ex.Message);
                }
            });

        }

        private void btnSeek_Click(object sender, EventArgs e)
        {
            try
            {
                NewTaskBLL bLL = new();
                var data = bLL.GetNewTasks(new NewTaskModel()
                {
                    isComplete = 1,
                    projectNumber = selectProjectNumber.SelectedValue?.ToString() ?? default,
                    carCode = selectCarCode.SelectedValue?.ToString() ?? default,
                    trainNo = selectTrainCode.SelectedValue?.ToString() ?? default,
                });
                table1.DataSource = data;
                table1.Tag = data.Count;
            }
            catch (Exception ex)
            {
                MessageHelper.MessageOK(this, "查询错误：" + ex.Message);
            }

        }

        private async void btnDataBackhaul_Click(object sender, EventArgs e)
        {
            try
            {
                //if (string.IsNullOrEmpty(VarHelper.deviceConfig.Authentication)) throw new Exception("设备未认证！请先认证设备");
                if (table1.Tag.ToInt32() < 1) { MessageHelper.MessageOK(this, "当前没有可以上传的任务！"); return; }

                UploadResultsModel upload = new();
                frmAuxiliary auxiliary = new();
                VarHelper.ShowDialogWithOverlay(this, auxiliary);
                upload = auxiliary.uploadResultsModel;
                if (auxiliary.DialogResult == DialogResult.No) return;

                TaskDownload taskDownload = new(this);
                for (int i = 0; i < table1.Tag.ToInt32(); i++)
                {
                    var ListTaskModel = new List<TaskUploadList>();
                    var data = table1[i].record as NewTaskModel;
                    if (data.Check)
                    {
                        var MainModel = new TaskUploadModel
                        {
                            procedureType = "7",
                            deviceNumber = VarHelper.deviceConfig.Authentication,
                            personCode = NewUsers.NewUserInfo.JobNumber,
                            holdTaskId = data.holdTaskId,
                            holdItemId = data.holdItemId,
                            list = ListTaskModel,
                        };
                        var HoldModel = new TaskUploadList
                        {
                            detailId = data.detailId,
                            testTemperature = data.testTemperature,
                            testHumidity = data.testHumidity,
                            applyVoltage = data.applyVoltage,
                            testValue = data.testValue,
                            testProcessValues = data.testProcessValues,
                            remark = data.remark,
                            operatePersonName = data.operatePersonName,
                            operatePerson = data.operatePerson,
                            operateTime = data.operateTime,
                            operateResult = data.operateResult,
                            auxiliariesName1 = data.auxiliariesName1,
                            auxiliariesCode1 = data.auxiliariesCode1,
                            auxiliariesName2 = data.auxiliariesName2,
                            auxiliariesCode2 = data.auxiliariesCode2,
                            auxiliariesName3 = data.auxiliariesName3,
                            auxiliariesCode3 = data.auxiliariesCode3,
                            auxiliariesName4 = data.auxiliariesName4,
                            auxiliariesCode4 = data.auxiliariesCode4,
                            mutualPersonName = data.mutualPersonName,
                            mutualPerson = data.mutualPerson,
                            mutualTime = upload.mutualTime,
                            mutualResult = upload.mutualResult,
                            qualityPersonName = data.qualityPersonName,
                            qualityPerson = data.qualityPerson,
                            qualityTime = upload.qualityTime,
                            qualityResult = upload.qualityResult,
                        };
                        ListTaskModel.Add(HoldModel);
                        string json = JsonConvert.SerializeObject(MainModel);
                        var result = await taskDownload.TaskBackhaul(json);
                        if (result != null && result.state == "1")
                        {
                            holdTaskBLL.TaskBackhaul(new NewTaskModel
                            {
                                mutualResult = upload.mutualResult,
                                mutualTime = upload.mutualTime,
                                qualityResult = upload.qualityResult,
                                qualityTime = upload.qualityTime,
                                isComplete = 1,
                                ID = data.ID,
                            });
                            Debug.WriteLine($"明细ID:{HoldModel.detailId},耐压任务结果回传成功!");
                        }
                        else
                        {
                            Debug.WriteLine($"明细ID:{HoldModel.detailId},耐压任务结果回传失败!");
                            MessageHelper.MessageOK(this, $"耐压任务结果回传失败:{result.msg}"); return;
                        }
                    }
                }
                MessageHelper.MessageOK(this, "耐压任务结果回传成功！");
            }
            catch (Exception ex)
            {
                MessageHelper.MessageOK(this, "任务上传错误：" + ex.Message);
            }
        }

        private void btnColose_Click(object sender, EventArgs e)
        {
            Close();
        }


        // ✅ 新增: 双击单元格事件处理 - 批量修改主表和子表
        private void Table1_CellDoubleClick(object sender, TableClickEventArgs e)
        {
            try
            {
                // 获取双击的行数据
                if (e.Record is NewTaskModel data)
                {
                    // 1. 查询该主任务下有多少条子任务记录
                    int affectedCount = GetAffectedRecordCount(data.holdTaskId, data.holdItemId);

                    NlogHelper.Default.Info($"双击编辑任务ID - 当前记录ID:{data.ID}, holdTaskId:{data.holdTaskId}, holdItemId:{data.holdItemId}, 影响记录数:{affectedCount}");

                    // 2. 打开编辑对话框
                    FrmEditTaskId editForm = new FrmEditTaskId(
                        data.holdTaskId,
                        data.holdItemId,
                        affectedCount
                    );

                    VarHelper.ShowDialogWithOverlay(this, editForm);

                    // 3. 如果用户点击了确定
                    if (editForm.DialogResult == DialogResult.OK)
                    {
                        // 显示加载动画
                        table1.Spin(new Spin.Config()
                        {
                            Text = "正在批量更新任务ID...",
                            Font = new Font("宋体", 15),
                            Back = Color.FromArgb(189, 179, 172),
                        }, () =>
                        {
                            Thread.Sleep(500); // 模拟耗时操作
                        }, () =>
                        {
                            // 4. 批量更新主表和子表
                            var result = BatchUpdateTaskIds(
                                data.holdTaskId,
                                data.holdItemId,
                                editForm.HoldTaskId,
                                editForm.HoldItemId
                            );

                            Invoke(() =>
                            {
                                if (result.Success)
                                {
                                    NlogHelper.Default.Info($"批量修改任务ID成功 - 主表更新:{result.MainTableCount}条, 子表更新:{result.SubTableCount}条");

                                    // 5. 重新查询并刷新表格
                                    btnSeek_Click(null, null);

                                    MessageHelper.MessageOK(this,
                                        $"任务ID修改成功!\n\n" +
                                        $"主任务表: 更新 {result.MainTableCount} 条记录\n" +
                                        $"子任务表: 更新 {result.SubTableCount} 条记录");
                                }
                                else
                                {
                                    NlogHelper.Default.Error($"批量修改任务ID失败: {result.ErrorMessage}");
                                    MessageHelper.MessageOK(this, $"任务ID修改失败!\n\n错误信息: {result.ErrorMessage}");
                                }
                            });
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("双击编辑任务ID错误:", ex);
                MessageHelper.MessageOK(this, "双击编辑任务ID错误:" + ex.Message);
            }
        }

        // ✅ 新增: 查询受影响的记录数
        private int GetAffectedRecordCount(string oldHoldTaskId, string oldHoldItemId)
        {
            try
            {
                // 查询该主任务下有多少条子任务记录
                var count = VarHelper.fsql.Select<HoldTaskModel>()
                    .Where(m => m.holdTaskId == oldHoldTaskId && m.holdItemId == oldHoldItemId)
                    .Count();

                return (int)count;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("查询受影响记录数失败:", ex);
                return 0;
            }
        }

        // ✅ 修正版: 批量更新主表和子表的任务ID (不使用CreateUnitOfWork)
        private BatchUpdateResult BatchUpdateTaskIds(
            string oldHoldTaskId,
            string oldHoldItemId,
            string newHoldTaskId,
            string newHoldItemId)
        {
            var result = new BatchUpdateResult();

            try
            {
                NlogHelper.Default.Info($"开始批量更新任务ID - 旧值:({oldHoldTaskId},{oldHoldItemId}) 新值:({newHoldTaskId},{newHoldItemId})");

                // 1. 更新主任务表(MainTaskTable)
                var mainTableCount = VarHelper.fsql.Update<MainTaskModel>()
                    .Set(m => m.holdTaskId, newHoldTaskId)
                    .Set(m => m.holdItemId, newHoldItemId)
                    .Where(m => m.holdTaskId == oldHoldTaskId && m.holdItemId == oldHoldItemId)
                    .ExecuteAffrows();

                NlogHelper.Default.Info($"主任务表更新结果 - 影响行数:{mainTableCount}");

                // 2. 更新子任务表(HoldTaskTable)
                var subTableCount = VarHelper.fsql.Update<HoldTaskModel>()
                    .Set(m => m.holdTaskId, newHoldTaskId)
                    .Set(m => m.holdItemId, newHoldItemId)
                    .Where(m => m.holdTaskId == oldHoldTaskId && m.holdItemId == oldHoldItemId)
                    .ExecuteAffrows();

                NlogHelper.Default.Info($"子任务表更新结果 - 影响行数:{subTableCount}");

                result.Success = true;
                result.MainTableCount = mainTableCount;
                result.SubTableCount = subTableCount;

                NlogHelper.Default.Info($"批量更新任务ID成功 - 主表:{mainTableCount}条, 子表:{subTableCount}条");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.ErrorMessage = ex.Message;
                NlogHelper.Default.Error("批量更新任务ID失败:", ex);
            }

            return result;
        }

        // ✅ 新增: 批量更新结果类
        private class BatchUpdateResult
        {
            public bool Success { get; set; }
            public int MainTableCount { get; set; }
            public int SubTableCount { get; set; }
            public string ErrorMessage { get; set; }
        }
    }

}
