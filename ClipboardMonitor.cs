using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardHistory
{
    public class ClipboardMonitor
    {
        ClipboardApplication application;
        private string previousData;

        public ClipboardMonitor(ClipboardApplication application)
        {
            this.application = application;
        }

        public void onClipboardChange(string data)
        {
            application.Log("clipboard changed");
            application.list.Add(data, false);
            application.updateList();
        }

        public void onMonitor()
        {
            string data = Clipboard.GetText();
            if (data != previousData)
            {
                previousData = data;
                if (!application.list.checkData(data)) {
                    this.onClipboardChange(data);
                }
            }
        }
    }
}
