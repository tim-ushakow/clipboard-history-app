using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardHistory
{
    public class Logger
    {
        public ListBox listBox = null;
        public void Log(string message)
        {
            if (this.listBox != null)
            {
                this.listBox.SelectedIndex = this.listBox.Items.Add(Utils.GetCurrentTime() + "\t" + message);
            }
                
        }

        public void setListBox(ListBox listBox)
        {
            this.listBox = listBox;
        }
    }
}
