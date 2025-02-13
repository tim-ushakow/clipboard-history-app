using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardHistory
{
    public class ClipboardApplication
    {
        public string title = "Clipboard History";
        public string version = "0.1 *DEV*";
        public Logger logger = new Logger();
        public ClipboardMonitor monitor;
        public ClipboardList list;
        public MainForm form;
        public ClipboardApplication(MainForm form)
        {
            this.monitor = new ClipboardMonitor(this);
            this.list = new ClipboardList();
            this.form = form;
        }

        public string getApplicationTitle()
        {
            return this.title + " " + this.version;
        }

        public void setLoggerListBox(ListBox listBox)
        {
            this.logger.setListBox(listBox);
            this.logger.Log(getApplicationTitle());
        }

        public void onClipboardTimer(object sender, System.EventArgs args)
        {
            this.monitor.onMonitor();
        }

        public void Log(string message)
        {
            this.logger.Log(message);
        }
        public void updateList()
        {
            this.form.updateClipboardList();
        }

        public void pinItem(int index)
        {
            this.list.list[index].pined = !this.list.list[index].pined;
            this.list.saveDataToFile(index);
            this.updateList();
        }
    }
}
