using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardHistory
{
    public class ClipboardData
    {
        public string title;
        public string data;
        public string time;
        public bool pined = false;
        public ClipboardData(string data, bool pined)
        {
            this.data = data;
            this.title = data.Trim().Substring(0, Math.Min(data.Length, 40)) + " | " + data.Length.ToString() + " bytes";
            this.time = pined?"Pined":Utils.GetCurrentTime() + " | " + Utils.GetActiveWindowTitle();
            this.pined = pined;
        }
    }
}
