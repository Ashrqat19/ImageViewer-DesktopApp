namespace Desktop_App
{
   
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.modeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.openFileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.loadImgtimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMulti = new System.Windows.Forms.Panel();
            this.nameStatusStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.slideBtn = new System.Windows.Forms.Button();
            this.multiBtn = new System.Windows.Forms.Button();
            this.singleBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.clearCheck = new System.Windows.Forms.CheckBox();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.clearPanelCheck = new System.Windows.Forms.CheckBox();
            this.imgList = new System.Windows.Forms.ListBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.modeContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.nameStatusStrip.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // modeContextMenuStrip
            // 
            this.modeContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.modeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.modeContextMenuStrip.Name = "modeContextMenuStrip";
            this.modeContextMenuStrip.Size = new System.Drawing.Size(118, 52);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleToolStripMenuItem,
            this.slideShowToolStripMenuItem,
            this.multipleShowToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // singleToolStripMenuItem
            // 
            this.singleToolStripMenuItem.Name = "singleToolStripMenuItem";
            this.singleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.singleToolStripMenuItem.Text = "Single";
            this.singleToolStripMenuItem.Click += new System.EventHandler(this.singleToolStripMenuItem_Click);
            // 
            // slideShowToolStripMenuItem
            // 
            this.slideShowToolStripMenuItem.Name = "slideShowToolStripMenuItem";
            this.slideShowToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.slideShowToolStripMenuItem.Text = "SlideShow";
            this.slideShowToolStripMenuItem.Click += new System.EventHandler(this.slideShowToolStripMenuItem_Click);
            // 
            // multipleShowToolStripMenuItem
            // 
            this.multipleShowToolStripMenuItem.Name = "multipleShowToolStripMenuItem";
            this.multipleShowToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.multipleShowToolStripMenuItem.Text = "MultipleShow";
            this.multipleShowToolStripMenuItem.Click += new System.EventHandler(this.multipleShowToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.uploadBtn.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.Location = new System.Drawing.Point(33, 772);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(270, 51);
            this.uploadBtn.TabIndex = 1;
            this.uploadBtn.Text = "Upload Image";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // openFileBrowser
            // 
            this.openFileBrowser.FileName = "openFileDialog1";
            this.openFileBrowser.Filter = "\"Image Files(*.jpg; *.jpeg; *.gif;)|*.jpg; *.jpeg; *.gif; \";";
            this.openFileBrowser.Multiselect = true;
            this.openFileBrowser.Title = "Choose Images";
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(332, 199);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(848, 623);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBox.TabIndex = 2;
            this.imgBox.TabStop = false;
            // 
            // loadImgtimer
            // 
            this.loadImgtimer.Interval = 800;
            this.loadImgtimer.Tick += new System.EventHandler(this.loadImgtimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.stopBtn);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Controls.Add(this.next);
            this.panel1.Controls.Add(this.prev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 844);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 50);
            this.panel1.TabIndex = 5;
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.ForeColor = System.Drawing.Color.White;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(33, 172);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(82, 21);
            this.checkBoxSelectAll.TabIndex = 6;
            this.checkBoxSelectAll.Text = "Select All";
            this.checkBoxSelectAll.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 138);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "C# Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ashrqat Maher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 28F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(23, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "Image Viewer";
            // 
            // panelMulti
            // 
            this.panelMulti.AutoScroll = true;
            this.panelMulti.Location = new System.Drawing.Point(332, 199);
            this.panelMulti.Name = "panelMulti";
            this.panelMulti.Size = new System.Drawing.Size(848, 623);
            this.panelMulti.TabIndex = 7;
            // 
            // nameStatusStrip
            // 
            this.nameStatusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.nameStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.nameStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.nameStatusStrip.Location = new System.Drawing.Point(355, 172);
            this.nameStatusStrip.Name = "nameStatusStrip";
            this.nameStatusStrip.Size = new System.Drawing.Size(123, 25);
            this.nameStatusStrip.TabIndex = 0;
            this.nameStatusStrip.Text = ".";
            this.nameStatusStrip.Visible = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripLabel1.Font = new System.Drawing.Font("Roboto", 9F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.slideBtn);
            this.panel3.Controls.Add(this.multiBtn);
            this.panel3.Controls.Add(this.singleBtn);
            this.panel3.Location = new System.Drawing.Point(1211, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 624);
            this.panel3.TabIndex = 8;
            // 
            // slideBtn
            // 
            this.slideBtn.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slideBtn.Location = new System.Drawing.Point(1, 220);
            this.slideBtn.Name = "slideBtn";
            this.slideBtn.Size = new System.Drawing.Size(67, 183);
            this.slideBtn.TabIndex = 0;
            this.slideBtn.Text = "Slide Show";
            this.slideBtn.UseVisualStyleBackColor = true;
            this.slideBtn.Click += new System.EventHandler(this.slideShowToolStripMenuItem_Click);
            // 
            // multiBtn
            // 
            this.multiBtn.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiBtn.Location = new System.Drawing.Point(1, 406);
            this.multiBtn.Name = "multiBtn";
            this.multiBtn.Size = new System.Drawing.Size(67, 85);
            this.multiBtn.TabIndex = 0;
            this.multiBtn.Text = "Multi";
            this.multiBtn.UseVisualStyleBackColor = true;
            this.multiBtn.Click += new System.EventHandler(this.multipleShowToolStripMenuItem_Click);
            // 
            // singleBtn
            // 
            this.singleBtn.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleBtn.Location = new System.Drawing.Point(1, 126);
            this.singleBtn.Name = "singleBtn";
            this.singleBtn.Size = new System.Drawing.Size(67, 91);
            this.singleBtn.TabIndex = 0;
            this.singleBtn.Text = "Single";
            this.singleBtn.UseVisualStyleBackColor = true;
            this.singleBtn.Click += new System.EventHandler(this.singleToolStripMenuItem_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(816, -1);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(267, 54);
            this.stopBtn.TabIndex = 0;
            this.stopBtn.Text = "Stop Show";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.onOffSlider_Click);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(413, -1);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(267, 54);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start Show";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.onOffSlider_Click);
            // 
            // clearCheck
            // 
            this.clearCheck.AutoSize = true;
            this.clearCheck.ForeColor = System.Drawing.Color.White;
            this.clearCheck.Location = new System.Drawing.Point(34, 740);
            this.clearCheck.Name = "clearCheck";
            this.clearCheck.Size = new System.Drawing.Size(84, 21);
            this.clearCheck.TabIndex = 6;
            this.clearCheck.Text = "Clear List";
            this.clearCheck.UseVisualStyleBackColor = true;
            this.clearCheck.CheckedChanged += new System.EventHandler(this.clearCheck_CheckedChanged);
            // 
            // prev
            // 
            this.prev.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev.Location = new System.Drawing.Point(680, -1);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(68, 55);
            this.prev.TabIndex = 9;
            this.prev.Text = "<<";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.next_Click);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(748, -1);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(68, 55);
            this.next.TabIndex = 9;
            this.next.Text = ">>";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // clearPanelCheck
            // 
            this.clearPanelCheck.AutoSize = true;
            this.clearPanelCheck.ForeColor = System.Drawing.Color.White;
            this.clearPanelCheck.Location = new System.Drawing.Point(149, 740);
            this.clearPanelCheck.Name = "clearPanelCheck";
            this.clearPanelCheck.Size = new System.Drawing.Size(96, 21);
            this.clearPanelCheck.TabIndex = 6;
            this.clearPanelCheck.Text = "Clear Panel";
            this.clearPanelCheck.UseVisualStyleBackColor = true;
            this.clearPanelCheck.CheckedChanged += new System.EventHandler(this.ClearPanelCheck_CheckedChanged);
            // 
            // imgList
            // 
            this.imgList.ContextMenuStrip = this.modeContextMenuStrip;
            this.imgList.FormattingEnabled = true;
            this.imgList.ItemHeight = 16;
            this.imgList.Location = new System.Drawing.Point(34, 199);
            this.imgList.Name = "imgList";
            this.imgList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.imgList.Size = new System.Drawing.Size(269, 532);
            this.imgList.TabIndex = 9;
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(1192, 843);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(87, 50);
            this.exitbtn.TabIndex = 10;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 894);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.imgList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.clearPanelCheck);
            this.Controls.Add(this.clearCheck);
            this.Controls.Add(this.checkBoxSelectAll);
            this.Controls.Add(this.panelMulti);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.nameStatusStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.modeContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.nameStatusStrip.ResumeLayout(false);
            this.nameStatusStrip.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.OpenFileDialog openFileBrowser;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.ContextMenuStrip modeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slideShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multipleShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer loadImgtimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMulti;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip nameStatusStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.CheckBox clearCheck;
        private System.Windows.Forms.CheckBox clearPanelCheck;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button slideBtn;
        private System.Windows.Forms.Button singleBtn;
        private System.Windows.Forms.Button multiBtn;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.ListBox imgList;
        private System.Windows.Forms.Button exitbtn;
    }
}


