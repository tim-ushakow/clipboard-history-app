using ClipboardHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardHistory
{
    public class ClipboardList
    {
        public List<ClipboardData> list;
        int pinedCount = 0;

        public ClipboardList()
        {
            list = new List<ClipboardData>();
            this.loadData();
        }

        public void Add(string data, bool pined)
        {
            if (pined)
            {
                list.Add(new ClipboardData(data, pined));
                pinedCount++;
            } else
            {
                list.Insert(pinedCount, new ClipboardData(data, pined));
            }
            
        }

        public void copyToClipboard(int index)
        {
            Clipboard.SetText(list[index].data);
        }

        public void saveDataToFile(int index)
        {
            string directoryPath = ".\\data";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            System.IO.File.WriteAllText(directoryPath + "\\" + index.ToString() + ".txt", list[index].data);
        }

        public void loadDataFromFile(string filename)
        {

        }

        public void loadData()
        {
            string directoryPath = ".\\data";
            string[] files = Directory.GetFiles(directoryPath);
            foreach (string file in files)
            {
                string data = System.IO.File.ReadAllText(file);
                this.Add(data, true);
            }
        }
    }
}
