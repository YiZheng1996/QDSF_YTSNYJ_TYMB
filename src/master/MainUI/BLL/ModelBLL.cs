using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RW.Data;
using System.Data;
using RW.Components.Core.BLL;
using System.Windows.Forms;

namespace MainUI.BLL
{
    public class ModelBLL : DriverDeviceBaseBLL
    {
        protected override void Init()
        {
            this.TableName = "Model";
            base.Init();
        }

        public DataTable GetAllModelType()
        {

            string sql = "";
            sql = "select ID, ModelType,mark from Model order by ID ";
            return this.GetDataTable(sql);
        }
        public bool IsExist(string mc)
        {
            string sql = string.Format("select ModelType from Model where ModelType='{0}'", mc);
            DataTable ds = this.GetDataTable(sql);
            if (ds.Rows.Count > 0)
            {

                return true;
            }
            else
                return false;
        }
        public bool IsExist(string mc,string bz)
        {
            string sql = string.Format("select ModelType from Model where ModelType='{0}',mark='{1}'", mc,bz);
            DataTable ds = this.GetDataTable(sql);
            if (ds.Rows.Count > 0)
            {

                return true;
            }
            else
                return false;
        }

        public bool Add(string name,string bz)
        {
            NewFile(SpecificSymbol(name));
            string sql = string.Format(@"insert into Model (ModelType,mark) values ('{0}','{1}')", name,bz);
            return this.Connection.ExecuteNonQuery(sql) >= 1 ? true : false;
        }
        public bool Delete(string name,int id)
        {
            deleteFile(SpecificSymbol(name));
            string sql = string.Format(@"delete from Model where ID={0}", id);
            return this.Connection.ExecuteNonQuery(sql) >= 1 ? true : false;
        }
        public bool Updata(int id,string name, string bz,string OldName)
        {
            changeFileName(SpecificSymbol(name), SpecificSymbol(OldName));
            string sql = string.Format(@"update Model set ModelType='{0}',mark='{1}' where ID={2}", name, bz,id);
            return this.Connection.ExecuteNonQuery(sql) >= 1 ? true : false;

        }
        void NewFile(string newName)
        {
            string rootDirectory = Application.StartupPath + "\\proc\\";
            bool s = AddFileName(rootDirectory + newName, false);
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
        void deleteFile(string filename)
        {
            string rootDirectory = Application.StartupPath + "\\proc\\";
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
        void changeFileName(string filename, string oldname)
        {

            string rootDirectory = Application.StartupPath + "\\proc\\";
            string path = rootDirectory + oldname;
            if (!System.IO.Directory.Exists(path))
                Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(path, filename);

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
