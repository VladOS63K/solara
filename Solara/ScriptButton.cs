using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solara
{
    public class ScriptButton
    {
        public ScriptButton(string btnName, string btnScript, int btnOrder, Size btnSize)
        {
            BtnName = btnName;
            BtnScript = btnScript;
            BtnOrder = btnOrder;
            BtnSize = btnSize;
        }

        public string BtnName { get; set; }
        public string BtnScript { get; set; }
        public int BtnOrder { get; set; }
        public Size BtnSize { get; set; }
    }
}
