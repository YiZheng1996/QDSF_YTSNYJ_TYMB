using MainUI.CurrencyHelper;

namespace MainUI
{
    public partial class frmNLogs : UIForm
    {
        NlogsBLL nlogsBLL = new();

        public frmNLogs()
        {
            InitializeComponent();
            AddColumns();
            cboType.SelectedIndex = 0;
            dtpStartBig.Value = DateTime.Now.ToDateTime();
        }


        private void AddColumns()
        {
            lstViewNlg.Columns.Add("日志等级", -2, HorizontalAlignment.Left);
            lstViewNlg.Columns.Add("记录时间", -2, HorizontalAlignment.Left);
            lstViewNlg.Columns.Add("用户名", -2, HorizontalAlignment.Left);
            lstViewNlg.Columns.Add("操作信息", -2, HorizontalAlignment.Left);
            lstViewNlg.Columns.Add("信息来源", -2, HorizontalAlignment.Left);
        }

        public void LoadData()
        {
            try
            {
                var StartTime = dtpStartBig.Value.Date + new TimeSpan(0, 0, 0);
                var StopTime = dtpStartBig.Value.Date + new TimeSpan(23, 59, 59);
                List<NlogsModel> nlogs = nlogsBLL.FindList(cboType.SelectedText, StartTime.ToString("yyyy-MM-dd HH:mm:ss"), StopTime.ToString("yyyy-MM-dd HH:mm:ss"));
                lstViewNlg.Items.Clear();
                for (int i = 0; i < nlogs.Count; i++)
                {
                    ListViewItem listView = new(nlogs[i].Level);
                    listView.SubItems.Add(nlogs[i].MessTime.ToString("HH:mm:ss fff"));
                    listView.SubItems.Add(nlogs[i].UserName);
                    listView.SubItems.Add(nlogs[i].MessageName);
                    listView.SubItems.Add(nlogs[i].Source);
                    listView.ImageIndex = cboType.SelectedIndex;
                    lstViewNlg.Items.Add(listView);
                }
                AutoResizeColumnWidth(nlogs);
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Fatal("日志查询失败：", ex);
            }

        }

        private void frmNLogs_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 自动调整ListView的列宽的方法
        /// </summary>
        /// <param name="nlogs"></param>
        public void AutoResizeColumnWidth(List<NlogsModel> nlogs)
        {
            if (nlogs.Count > 0)
            {
                //先调整内容自适应
                lstViewNlg.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                //再调整标题宽度自适应
                for (int i = 0; i < lstViewNlg.Columns.Count; i++)
                    lstViewNlg.Columns[i].Width = -2;
            }
        }
    }
}

