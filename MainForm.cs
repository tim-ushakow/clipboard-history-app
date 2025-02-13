namespace ClipboardHistory
{
    public partial class MainForm : Form
    {
        public ClipboardApplication application;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = application.getApplicationTitle();
            this.application.setLoggerListBox(logListBox);

            clipboardTimer.Tick += this.application.onClipboardTimer;
        }

        public void setClipboardApplication(ClipboardApplication application)
        {
            this.application = application;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.application.Log("onClick");
        }

        public void updateClipboardList()
        {
            clipboardListView.Items.Clear();
            foreach (ClipboardData data in application.list.list)
            {
                ListViewItem item = new ListViewItem(data.title);
                item.SubItems.Add(data.time);
                item.ImageIndex = data.pined?0:2;
                clipboardListView.Items.Add(item);
            }
        }

        private void clipboardListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.application.Log("onDoubleClick()");
            if (clipboardListView.SelectedItems.Count > 0)
            {
                ListViewItem item = clipboardListView.SelectedItems[0];
                this.application.list.copyToClipboard(item.Index);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListViewItem item = clipboardListView.SelectedItems[0];
            if (item != null)
            {
                this.application.pinItem(item.Index);
            }
        }
    }
}
