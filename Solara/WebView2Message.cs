using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VladOSLauncher
{
    public class WebView2Message
    {
        public WebView2Message(string Key, object Value)
        {
            this.Key = Key;
            this.Value = Value;
        }

        public string Key { get; }
        public object Value { get; }
    }
}
