using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RW.Data;
using System.Data;
using MainUI.Model;
using RW.Components.Core.BLL;
using System.Windows.Forms;
using System.IO;

namespace MainUI.BLL
{
    public class TypeBLL : DriverDeviceBaseBLL
    {
        protected override void Init()
        {
            this.TableName = "Type";
            base.Init();

        }
        public DataTable GetAllKind(int id)
        {
            string sql = string.Format("select ID,Name,Mark from Type where typeID ={0} order by ID", id);


            return this.GetDataTable(sql);
        }
        public DataTable GetAllKindByCon(string condition)
        {
            string sql = "select a.ID, Name,a.typeid,b.modeltype,a.mark from Type a,Model b where a.typeID = b.ID " + condition + " order by a.id";

            return this.GetDataTable(sql);
        }

        /// <summary>
        /// true 表示存在；false 不存在。
        /// </summary>
        /// <param name="modelName"></param>
        /// <returns></returns>
        public bool IsExist(int typeid, string modelname, string mark)
        {
            string sql = string.Format("select Name from Type where TypeID={0} and Name='{1}'and mark='{2}'", typeid, modelname, mark);
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool Add(string modelName, int typeid, string mark, string lxname)
        {
            NewFile(SpecificSymbol(lxname), SpecificSymbol(modelName));

            string sql = string.Format("insert into Type(Name,TypeID,mark,CreateTime) values('{0}',{1},'{2}','{3}')", modelName, typeid, mark, System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            return this.Connection.ExecuteNonQuery(sql) >= 1 ? true : false;
        }

        public bool Delete(int modelID, string lxname, string xhname)
        {
            deleteFile(SpecificSymbol(lxname), SpecificSymbol(xhname));
            string sql = string.Format("delete from Type where ID={0}", modelID);
            return this.Connection.ExecuteNonQuery(sql) >= 1 ? true : false;
        }

        public bool Update(int modelID, string name, int typeid, string mark, string lxname, string oldxhname)
        {
            changeFileName(SpecificSymbol(name), SpecificSymbol(oldxhname), SpecificSymbol(lxname));
            string sql = string.Format("update Type set name='{1}',typeid={2},mark='{3}',UpdateTime='{4}' where ID={0}", modelID, name, typeid, mark, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            return Connection.ExecuteNonQuery(sql) >= 1 ? true : false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="LX">类型</param>
        /// <param name="newName">新型号名称</param>
        void NewFile(string LX, string newName)
        {
            string rootDirectory = Application.StartupPath + "\\proc\\" + LX + "\\";
            bool s = AddFileName(rootDirectory + newName, false);
            if (s)
                MoveStepPara(LX, newName);
        }
        public bool AddFileName(string newFile, bool isFile)
        {
            if (isFile && !System.IO.File.Exists(newFile))
            {
                System.IO.File.Create(newFile);
            }

            if (!isFile && !System.IO.Directory.Exists(newFile))
            {
                System.IO.Directory.CreateDirectory(newFile);
            }

            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="LX">类型</param>
        /// <param name="filename">型号名称</param>
        void deleteFile(string LX, string filename)
        {
            string rootDirectory = Application.StartupPath + "\\proc\\" + LX + "\\";
            string path = rootDirectory + filename;
            bool s = DelFileName(path);
        }
        public bool DelFileName(string fileName)
        {
            try
            {
                if (System.IO.Directory.Exists(fileName))
                {
                    System.IO.Directory.Delete(fileName, true);

                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 修改名称
        /// </summary>
        /// <param name="filename">新名称</param>
        /// <param name="oldname">旧名称</param>
        /// <param name="LX">类型</param>
        void changeFileName(string filename, string oldname, string LX)
        {
            string rootDirectory = Application.StartupPath + "proc\\" + LX + "\\";
            string path = rootDirectory + oldname;
            if (Directory.Exists(path))
                Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(path, filename);

        }
        /// <summary>
        /// 
        /// </summary>
        void MoveStepPara(string LXname, string xhname)
        {
            string rootDirectory = Application.StartupPath + "\\proc\\" + LXname;
            string path = rootDirectory + "\\" + xhname;
            var a = System.IO.Directory.GetFiles(rootDirectory);
            foreach (var item in a)
            {
                string fileName = Path.GetFileName(item);
                string targetPath = Path.Combine(path, fileName);
                FileInfo file = new FileInfo(item);
                if (file.Exists)
                {
                    file.CopyTo(targetPath, true);
                }

            }

        }
        public string SpecificSymbol(string gg)
        {
            while (true)
            {
                if (gg.IndexOf("%") > -1)
                {
                    int i = gg.IndexOf("%");
                    string a = gg.Substring(0, i);
                    string b = gg.Substring(i + 1, gg.Length - i - 1);
                    gg = a + b;
                }
                else if (gg.IndexOf(":") > -1)
                {
                    int i = gg.IndexOf(":");
                    string a = gg.Substring(0, i);
                    string b = gg.Substring(i + 1, gg.Length - i - 1);
                    gg = a + b;
                }
                else if (gg.IndexOf("/") > -1)
                {
                    int i = gg.IndexOf("/");
                    string a = gg.Substring(0, i);
                    string b = gg.Substring(i + 1, gg.Length - i - 1);
                    gg = a + b;
                }
                else
                {
                    break;
                }
            }
            return gg;
        }
    }
}
