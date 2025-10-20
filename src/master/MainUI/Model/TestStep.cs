using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Model
{
    public class TestStep
    {
        public int ID { get; set; }
        public int ModelID { get; set; }
        public string Model { get; set; }
        public int Sort { get; set; }
        public int Step { get; set; }
        public string ProcessName { get; set; }
        public string ProcessKey { get; set; }
        public int LineNumber { get; set; }

        public override string ToString()
        {
            string str = "";
            str += "ModelID:" + Model.ToString() + "；";
            str += "Model:" + Model.ToString() + "；";
            str += "Step:" + Step.ToString() + "；";
            str += "ProcessName:" + ProcessName.ToString() + "；";
            str += "ProcessKey:" + ProcessKey.ToString() + "；";
            str += "LineNumber:" + LineNumber.ToString() + "；";
            str += "ID:" + ID.ToString() + "；";


            return str;

        }
    }
}
