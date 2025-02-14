namespace ClipboardHistory
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "test", "test" }, 0);
            ListViewItem listViewItem2 = new ListViewItem("test", 1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            clipboardListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            contextMenu = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            button1 = new Button();
            button2 = new Button();
            logListBox = new ListBox();
            clipboardTimer = new System.Windows.Forms.Timer(components);
            contextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // clipboardListView
            // 
            clipboardListView.BackgroundImageTiled = true;
            clipboardListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            clipboardListView.ContextMenuStrip = contextMenu;
            clipboardListView.FullRowSelect = true;
            clipboardListView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            clipboardListView.LargeImageList = imageList1;
            clipboardListView.Location = new Point(12, 47);
            clipboardListView.Name = "clipboardListView";
            clipboardListView.Size = new Size(497, 636);
            clipboardListView.TabIndex = 0;
            clipboardListView.TileSize = new Size(470, 54);
            clipboardListView.UseCompatibleStateImageBehavior = false;
            clipboardListView.View = View.Tile;
            clipboardListView.MouseDoubleClick += clipboardListView_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 400;
            // 
            // contextMenu
            // 
            contextMenu.ImageScalingSize = new Size(20, 20);
            contextMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            contextMenu.Name = "contextMenu";
            contextMenu.Size = new Size(211, 104);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(210, 24);
            toolStripMenuItem1.Text = "Pin";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(210, 24);
            toolStripMenuItem2.Text = "Copy";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(210, 24);
            toolStripMenuItem3.Text = "Delete";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "clipboard.png");
            imageList1.Images.SetKeyName(1, "clipboard-transp.png");
            imageList1.Images.SetKeyName(2, "clipboard-gs.png");
            // 
            // button1
            // 
            button1.Location = new Point(480, 12);
            button1.Name = "button1";
            button1.Size = new Size(29, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(445, 12);
            button2.Name = "button2";
            button2.Size = new Size(29, 29);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // logListBox
            // 
            logListBox.Font = new Font("Lucida Console", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logListBox.FormattingEnabled = true;
            logListBox.ItemHeight = 13;
            logListBox.Location = new Point(12, 689);
            logListBox.Name = "logListBox";
            logListBox.Size = new Size(497, 147);
            logListBox.TabIndex = 3;
            // 
            // clipboardTimer
            // 
            clipboardTimer.Enabled = true;
            clipboardTimer.Interval = 1000;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 858);
            Controls.Add(logListBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(clipboardListView);
            Name = "MainForm";
            Text = "Clipboard";
            TopMost = true;
            Load += MainForm_Load;
            contextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView clipboardListView;
        private ColumnHeader columnHeader1;
        private Button button1;
        private Button button2;
        private ListBox logListBox;
        private System.Windows.Forms.Timer clipboardTimer;
        private ImageList imageList1;
        private ColumnHeader columnHeader2;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}
