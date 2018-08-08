﻿namespace TabHeaderDemo
{
    partial class FormMainLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainLab));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsluser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblmachine = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbldevice = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblkind = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblsample = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblmethod = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblreport = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolstatustest = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblEmergencyStop = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbllimit = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblstate = new System.Windows.Forms.ToolStripStatusLabel();
            this.paneltop = new System.Windows.Forms.Panel();
            this.tlprecord = new System.Windows.Forms.TableLayoutPanel();
            this.recordStopButton = new System.Windows.Forms.Button();
            this.playBackMacroButton = new System.Windows.Forms.Button();
            this.recordStartButton = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnkey3 = new System.Windows.Forms.Button();
            this.btnkey2 = new System.Windows.Forms.Button();
            this.btnkey1 = new System.Windows.Forms.Button();
            this.btnkey4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnhand = new System.Windows.Forms.Button();
            this.btntool = new System.Windows.Forms.Button();
            this.btnpos = new System.Windows.Forms.Button();
            this.btnext2 = new System.Windows.Forms.Button();
            this.tlbmeterback = new System.Windows.Forms.TableLayoutPanel();
            this.tlbmeter = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblcontroller = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnmethod = new System.Windows.Forms.Button();
            this.btnon = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tlpsel = new System.Windows.Forms.TableLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnkeyimageList = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timermain = new System.Windows.Forms.Timer(this.components);
            this.timerRecord = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageListState = new System.Windows.Forms.ImageList(this.components);
            this.jMeter1 = new TabHeaderDemo.JMeter();
            this.jMeter2 = new TabHeaderDemo.JMeter();
            this.jMeter3 = new TabHeaderDemo.JMeter();
            this.jMeter4 = new TabHeaderDemo.JMeter();
            this.statusStrip1.SuspendLayout();
            this.paneltop.SuspendLayout();
            this.tlprecord.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tlbmeterback.SuspendLayout();
            this.tlbmeter.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsluser,
            this.tslblmachine,
            this.tslbldevice,
            this.tslblkind,
            this.tslblsample,
            this.tslblmethod,
            this.tslblreport,
            this.toolstatustest,
            this.tslblEmergencyStop,
            this.tslbllimit,
            this.tslblstate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 700);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1350, 29);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsluser
            // 
            this.tsluser.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsluser.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsluser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsluser.Name = "tsluser";
            this.tsluser.Size = new System.Drawing.Size(60, 24);
            this.tsluser.Text = "安全关闭";
            // 
            // tslblmachine
            // 
            this.tslblmachine.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslblmachine.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tslblmachine.Name = "tslblmachine";
            this.tslblmachine.Size = new System.Drawing.Size(96, 24);
            this.tslblmachine.Text = "电子万能试验机";
            // 
            // tslbldevice
            // 
            this.tslbldevice.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslbldevice.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tslbldevice.Name = "tslbldevice";
            this.tslbldevice.Size = new System.Drawing.Size(72, 24);
            this.tslbldevice.Text = "无可用设备";
            // 
            // tslblkind
            // 
            this.tslblkind.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslblkind.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tslblkind.Name = "tslblkind";
            this.tslblkind.Size = new System.Drawing.Size(76, 24);
            this.tslblkind.Text = "试验类型 空";
            // 
            // tslblsample
            // 
            this.tslblsample.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslblsample.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tslblsample.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslblsample.Name = "tslblsample";
            this.tslblsample.Size = new System.Drawing.Size(72, 24);
            this.tslblsample.Text = "样品：关闭";
            // 
            // tslblmethod
            // 
            this.tslblmethod.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslblmethod.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tslblmethod.Name = "tslblmethod";
            this.tslblmethod.Size = new System.Drawing.Size(72, 24);
            this.tslblmethod.Text = "方法：关闭";
            // 
            // tslblreport
            // 
            this.tslblreport.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslblreport.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tslblreport.Name = "tslblreport";
            this.tslblreport.Size = new System.Drawing.Size(72, 24);
            this.tslblreport.Text = "报告：关闭";
            // 
            // toolstatustest
            // 
            this.toolstatustest.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolstatustest.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolstatustest.Name = "toolstatustest";
            this.toolstatustest.Size = new System.Drawing.Size(103, 24);
            this.toolstatustest.Text = "高级测试：步骤1";
            this.toolstatustest.Visible = false;
            // 
            // tslblEmergencyStop
            // 
            this.tslblEmergencyStop.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslblEmergencyStop.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tslblEmergencyStop.Image = ((System.Drawing.Image)(resources.GetObject("tslblEmergencyStop.Image")));
            this.tslblEmergencyStop.ImageTransparentColor = System.Drawing.Color.Silver;
            this.tslblEmergencyStop.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.tslblEmergencyStop.Name = "tslblEmergencyStop";
            this.tslblEmergencyStop.Size = new System.Drawing.Size(92, 24);
            this.tslblEmergencyStop.Text = "急停：关闭";
            this.tslblEmergencyStop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tslbllimit
            // 
            this.tslbllimit.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslbllimit.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tslbllimit.Image = ((System.Drawing.Image)(resources.GetObject("tslbllimit.Image")));
            this.tslbllimit.ImageTransparentColor = System.Drawing.Color.Silver;
            this.tslbllimit.Name = "tslbllimit";
            this.tslbllimit.Size = new System.Drawing.Size(92, 24);
            this.tslbllimit.Text = "限位：正常";
            this.tslbllimit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tslblstate
            // 
            this.tslblstate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslblstate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tslblstate.Image = ((System.Drawing.Image)(resources.GetObject("tslblstate.Image")));
            this.tslblstate.ImageTransparentColor = System.Drawing.Color.Silver;
            this.tslblstate.Name = "tslblstate";
            this.tslblstate.Size = new System.Drawing.Size(92, 24);
            this.tslblstate.Text = "状态：停止";
            this.tslblstate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.Transparent;
            this.paneltop.Controls.Add(this.tlprecord);
            this.paneltop.Controls.Add(this.tableLayoutPanel4);
            this.paneltop.Controls.Add(this.tableLayoutPanel3);
            this.paneltop.Controls.Add(this.tlbmeterback);
            this.paneltop.Controls.Add(this.btnmethod);
            this.paneltop.Controls.Add(this.btnon);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1350, 126);
            this.paneltop.TabIndex = 31;
            this.paneltop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // tlprecord
            // 
            this.tlprecord.ColumnCount = 5;
            this.tlprecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlprecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlprecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlprecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tlprecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tlprecord.Controls.Add(this.recordStopButton, 0, 0);
            this.tlprecord.Controls.Add(this.playBackMacroButton, 0, 0);
            this.tlprecord.Controls.Add(this.recordStartButton, 0, 0);
            this.tlprecord.Controls.Add(this.btnread, 3, 0);
            this.tlprecord.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlprecord.Location = new System.Drawing.Point(837, 0);
            this.tlprecord.Name = "tlprecord";
            this.tlprecord.RowCount = 1;
            this.tlprecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlprecord.Size = new System.Drawing.Size(243, 42);
            this.tlprecord.TabIndex = 48;
            // 
            // recordStopButton
            // 
            this.recordStopButton.BackColor = System.Drawing.Color.Transparent;
            this.recordStopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recordStopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordStopButton.FlatAppearance.BorderSize = 0;
            this.recordStopButton.Image = ((System.Drawing.Image)(resources.GetObject("recordStopButton.Image")));
            this.recordStopButton.Location = new System.Drawing.Point(92, 3);
            this.recordStopButton.Name = "recordStopButton";
            this.recordStopButton.Size = new System.Drawing.Size(37, 36);
            this.recordStopButton.TabIndex = 54;
            this.recordStopButton.Tag = "停止录制";
            this.recordStopButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.recordStopButton.UseVisualStyleBackColor = false;
            this.recordStopButton.Click += new System.EventHandler(this.recordStopButton_Click);
            this.recordStopButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.recordStopButton_MouseDown);
            this.recordStopButton.MouseEnter += new System.EventHandler(this.recordStopButton_MouseEnter);
            this.recordStopButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.recordStopButton_MouseUp);
            // 
            // playBackMacroButton
            // 
            this.playBackMacroButton.AutoSize = true;
            this.playBackMacroButton.BackColor = System.Drawing.Color.Transparent;
            this.playBackMacroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playBackMacroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playBackMacroButton.FlatAppearance.BorderSize = 0;
            this.playBackMacroButton.Image = ((System.Drawing.Image)(resources.GetObject("playBackMacroButton.Image")));
            this.playBackMacroButton.Location = new System.Drawing.Point(45, 3);
            this.playBackMacroButton.Name = "playBackMacroButton";
            this.playBackMacroButton.Size = new System.Drawing.Size(41, 36);
            this.playBackMacroButton.TabIndex = 53;
            this.playBackMacroButton.Tag = "操作回放";
            this.playBackMacroButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.playBackMacroButton.UseVisualStyleBackColor = false;
            this.playBackMacroButton.Click += new System.EventHandler(this.playBackMacroButton_Click);
            this.playBackMacroButton.MouseEnter += new System.EventHandler(this.playBackMacroButton_MouseEnter);
            // 
            // recordStartButton
            // 
            this.recordStartButton.BackColor = System.Drawing.Color.Transparent;
            this.recordStartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recordStartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordStartButton.FlatAppearance.BorderSize = 0;
            this.recordStartButton.Image = ((System.Drawing.Image)(resources.GetObject("recordStartButton.Image")));
            this.recordStartButton.Location = new System.Drawing.Point(3, 3);
            this.recordStartButton.Name = "recordStartButton";
            this.recordStartButton.Size = new System.Drawing.Size(36, 36);
            this.recordStartButton.TabIndex = 52;
            this.recordStartButton.Tag = "开始录制";
            this.recordStartButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.recordStartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.recordStartButton.UseVisualStyleBackColor = false;
            this.recordStartButton.Click += new System.EventHandler(this.recordStartButton_Click);
            this.recordStartButton.MouseEnter += new System.EventHandler(this.recordStartButton_MouseEnter);
            // 
            // btnread
            // 
            this.btnread.Image = ((System.Drawing.Image)(resources.GetObject("btnread.Image")));
            this.btnread.Location = new System.Drawing.Point(135, 3);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(35, 36);
            this.btnread.TabIndex = 55;
            this.toolTip1.SetToolTip(this.btnread, "读取演示文件");
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.btnkey3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnkey2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnkey1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnkey4, 3, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(88, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(711, 40);
            this.tableLayoutPanel4.TabIndex = 45;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // btnkey3
            // 
            this.btnkey3.BackColor = System.Drawing.Color.Transparent;
            this.btnkey3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkey3.BackgroundImage")));
            this.btnkey3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkey3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnkey3.FlatAppearance.BorderSize = 0;
            this.btnkey3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnkey3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnkey3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkey3.Location = new System.Drawing.Point(357, 3);
            this.btnkey3.Name = "btnkey3";
            this.btnkey3.Size = new System.Drawing.Size(171, 34);
            this.btnkey3.TabIndex = 39;
            this.btnkey3.Text = "键3";
            this.btnkey3.UseVisualStyleBackColor = false;
            this.btnkey3.Click += new System.EventHandler(this.btnkey3_Click);
            this.btnkey3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnkey3_MouseDown);
            this.btnkey3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnkey3_MouseUp);
            // 
            // btnkey2
            // 
            this.btnkey2.BackColor = System.Drawing.Color.Transparent;
            this.btnkey2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkey2.BackgroundImage")));
            this.btnkey2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkey2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnkey2.FlatAppearance.BorderSize = 0;
            this.btnkey2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnkey2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnkey2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkey2.Location = new System.Drawing.Point(180, 3);
            this.btnkey2.Name = "btnkey2";
            this.btnkey2.Size = new System.Drawing.Size(171, 34);
            this.btnkey2.TabIndex = 37;
            this.btnkey2.Text = "键2";
            this.btnkey2.UseVisualStyleBackColor = false;
            this.btnkey2.Click += new System.EventHandler(this.btnkey2_Click_1);
            this.btnkey2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnkey2_MouseDown);
            this.btnkey2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnkey2_MouseUp);
            // 
            // btnkey1
            // 
            this.btnkey1.BackColor = System.Drawing.Color.Transparent;
            this.btnkey1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkey1.BackgroundImage")));
            this.btnkey1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkey1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnkey1.FlatAppearance.BorderSize = 0;
            this.btnkey1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnkey1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnkey1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkey1.Location = new System.Drawing.Point(3, 3);
            this.btnkey1.Name = "btnkey1";
            this.btnkey1.Size = new System.Drawing.Size(171, 34);
            this.btnkey1.TabIndex = 36;
            this.btnkey1.Text = "键1";
            this.btnkey1.UseVisualStyleBackColor = false;
            this.btnkey1.Click += new System.EventHandler(this.btnkey1_Click);
            this.btnkey1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnkey1_MouseDown);
            this.btnkey1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnkey1_MouseUp);
            // 
            // btnkey4
            // 
            this.btnkey4.BackColor = System.Drawing.Color.Transparent;
            this.btnkey4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkey4.BackgroundImage")));
            this.btnkey4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkey4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnkey4.FlatAppearance.BorderSize = 0;
            this.btnkey4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnkey4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnkey4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkey4.Location = new System.Drawing.Point(534, 3);
            this.btnkey4.Name = "btnkey4";
            this.btnkey4.Size = new System.Drawing.Size(174, 34);
            this.btnkey4.TabIndex = 38;
            this.btnkey4.Text = "键4";
            this.btnkey4.UseVisualStyleBackColor = false;
            this.btnkey4.Click += new System.EventHandler(this.btnkey4_Click);
            this.btnkey4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnkey4_MouseDown);
            this.btnkey4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnkey4_MouseUp);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.Controls.Add(this.btnhand, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btntool, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnpos, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnext2, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1080, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(270, 42);
            this.tableLayoutPanel3.TabIndex = 44;
            // 
            // btnhand
            // 
            this.btnhand.BackColor = System.Drawing.Color.Transparent;
            this.btnhand.FlatAppearance.BorderSize = 0;
            this.btnhand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhand.Image = ((System.Drawing.Image)(resources.GetObject("btnhand.Image")));
            this.btnhand.Location = new System.Drawing.Point(46, 3);
            this.btnhand.Name = "btnhand";
            this.btnhand.Size = new System.Drawing.Size(30, 33);
            this.btnhand.TabIndex = 46;
            this.btnhand.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnhand.UseVisualStyleBackColor = false;
            this.btnhand.Visible = false;
            this.btnhand.Click += new System.EventHandler(this.btnhand_Click);
            // 
            // btntool
            // 
            this.btntool.BackColor = System.Drawing.Color.Transparent;
            this.btntool.FlatAppearance.BorderSize = 0;
            this.btntool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntool.Image = ((System.Drawing.Image)(resources.GetObject("btntool.Image")));
            this.btntool.Location = new System.Drawing.Point(3, 3);
            this.btntool.Name = "btntool";
            this.btntool.Size = new System.Drawing.Size(36, 33);
            this.btntool.TabIndex = 35;
            this.btntool.Tag = "";
            this.btntool.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btntool, "数据处理");
            this.btntool.UseVisualStyleBackColor = false;
            this.btntool.Visible = false;
            this.btntool.Click += new System.EventHandler(this.btntool_Click);
            // 
            // btnpos
            // 
            this.btnpos.BackColor = System.Drawing.Color.Transparent;
            this.btnpos.FlatAppearance.BorderSize = 0;
            this.btnpos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpos.Image = ((System.Drawing.Image)(resources.GetObject("btnpos.Image")));
            this.btnpos.Location = new System.Drawing.Point(230, 3);
            this.btnpos.Name = "btnpos";
            this.btnpos.Size = new System.Drawing.Size(37, 33);
            this.btnpos.TabIndex = 47;
            this.btnpos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnpos, "位移设置");
            this.btnpos.UseVisualStyleBackColor = false;
            this.btnpos.Click += new System.EventHandler(this.btnpos_Click);
            // 
            // btnext2
            // 
            this.btnext2.BackColor = System.Drawing.Color.Transparent;
            this.btnext2.FlatAppearance.BorderSize = 0;
            this.btnext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnext2.Image = ((System.Drawing.Image)(resources.GetObject("btnext2.Image")));
            this.btnext2.Location = new System.Drawing.Point(105, 3);
            this.btnext2.Name = "btnext2";
            this.btnext2.Size = new System.Drawing.Size(1, 33);
            this.btnext2.TabIndex = 44;
            this.btnext2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnext2, "引伸计2设置");
            this.btnext2.UseVisualStyleBackColor = false;
            this.btnext2.Visible = false;
            this.btnext2.Click += new System.EventHandler(this.btnext2_Click);
            // 
            // tlbmeterback
            // 
            this.tlbmeterback.BackColor = System.Drawing.Color.Transparent;
            this.tlbmeterback.ColumnCount = 2;
            this.tlbmeterback.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbmeterback.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tlbmeterback.Controls.Add(this.tlbmeter, 0, 0);
            this.tlbmeterback.Controls.Add(this.panel4, 1, 0);
            this.tlbmeterback.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlbmeterback.Location = new System.Drawing.Point(0, 42);
            this.tlbmeterback.Name = "tlbmeterback";
            this.tlbmeterback.RowCount = 1;
            this.tlbmeterback.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbmeterback.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlbmeterback.Size = new System.Drawing.Size(1350, 84);
            this.tlbmeterback.TabIndex = 41;
            // 
            // tlbmeter
            // 
            this.tlbmeter.BackColor = System.Drawing.Color.Transparent;
            this.tlbmeter.ColumnCount = 4;
            this.tlbmeter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlbmeter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlbmeter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlbmeter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlbmeter.Controls.Add(this.jMeter1, 0, 0);
            this.tlbmeter.Controls.Add(this.jMeter2, 1, 0);
            this.tlbmeter.Controls.Add(this.jMeter3, 2, 0);
            this.tlbmeter.Controls.Add(this.jMeter4, 3, 0);
            this.tlbmeter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbmeter.Location = new System.Drawing.Point(3, 3);
            this.tlbmeter.Name = "tlbmeter";
            this.tlbmeter.RowCount = 1;
            this.tlbmeter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbmeter.Size = new System.Drawing.Size(1197, 78);
            this.tlbmeter.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblcontroller);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1206, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(141, 78);
            this.panel4.TabIndex = 41;
            // 
            // lblcontroller
            // 
            this.lblcontroller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblcontroller.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcontroller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblcontroller.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblcontroller.Location = new System.Drawing.Point(56, 0);
            this.lblcontroller.Name = "lblcontroller";
            this.lblcontroller.Size = new System.Drawing.Size(85, 78);
            this.lblcontroller.TabIndex = 43;
            this.lblcontroller.Text = "1";
            this.lblcontroller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 78);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnmethod
            // 
            this.btnmethod.BackColor = System.Drawing.Color.Transparent;
            this.btnmethod.FlatAppearance.BorderSize = 0;
            this.btnmethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmethod.Image = ((System.Drawing.Image)(resources.GetObject("btnmethod.Image")));
            this.btnmethod.Location = new System.Drawing.Point(6, 6);
            this.btnmethod.Name = "btnmethod";
            this.btnmethod.Size = new System.Drawing.Size(38, 33);
            this.btnmethod.TabIndex = 33;
            this.btnmethod.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnmethod, "标准编辑器");
            this.btnmethod.UseVisualStyleBackColor = false;
            this.btnmethod.Click += new System.EventHandler(this.btnmethod_Click);
            // 
            // btnon
            // 
            this.btnon.BackColor = System.Drawing.Color.Transparent;
            this.btnon.FlatAppearance.BorderSize = 0;
            this.btnon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnon.Image = ((System.Drawing.Image)(resources.GetObject("btnon.Image")));
            this.btnon.Location = new System.Drawing.Point(44, 5);
            this.btnon.Name = "btnon";
            this.btnon.Size = new System.Drawing.Size(38, 33);
            this.btnon.TabIndex = 32;
            this.btnon.Tag = "0";
            this.btnon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnon, "全部清零");
            this.btnon.UseVisualStyleBackColor = false;
            this.btnon.Click += new System.EventHandler(this.btnon_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(20, 20);
            this.tabControl1.Location = new System.Drawing.Point(0, 126);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1350, 574);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Location = new System.Drawing.Point(24, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1322, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1316, 560);
            this.panel5.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(24, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1322, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2MinSize = 1;
            this.splitContainer1.Size = new System.Drawing.Size(1316, 560);
            this.splitContainer1.SplitterDistance = 1293;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoving += new System.Windows.Forms.SplitterCancelEventHandler(this.splitContainer1_SplitterMoving);
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            this.splitContainer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseDown);
            this.splitContainer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 560);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(19, 560);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 516);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tlpsel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 32);
            this.panel3.TabIndex = 1;
            // 
            // tlpsel
            // 
            this.tlpsel.ColumnCount = 2;
            this.tlpsel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpsel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpsel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpsel.Location = new System.Drawing.Point(0, 0);
            this.tlpsel.Name = "tlpsel";
            this.tlpsel.RowCount = 1;
            this.tlpsel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpsel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpsel.Size = new System.Drawing.Size(13, 32);
            this.tlpsel.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.bmp");
            this.imageList1.Images.SetKeyName(1, "b.ico");
            // 
            // btnkeyimageList
            // 
            this.btnkeyimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btnkeyimageList.ImageStream")));
            this.btnkeyimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.btnkeyimageList.Images.SetKeyName(0, "29.ico");
            this.btnkeyimageList.Images.SetKeyName(1, "29press.ico");
            this.btnkeyimageList.Images.SetKeyName(2, "27.ico");
            this.btnkeyimageList.Images.SetKeyName(3, "27press.ico");
            this.btnkeyimageList.Images.SetKeyName(4, "3key.ico");
            this.btnkeyimageList.Images.SetKeyName(5, "3key_press.ico");
            this.btnkeyimageList.Images.SetKeyName(6, "4key.ico");
            this.btnkeyimageList.Images.SetKeyName(7, "4key_press.ico");
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timermain
            // 
            this.timermain.Tick += new System.EventHandler(this.timermain_Tick);
            // 
            // timerRecord
            // 
            this.timerRecord.Tick += new System.EventHandler(this.timerRecord_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "24.bmp");
            this.imageList2.Images.SetKeyName(1, "24红.bmp");
            // 
            // imageListState
            // 
            this.imageListState.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListState.ImageStream")));
            this.imageListState.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListState.Images.SetKeyName(0, "1.bmp");
            this.imageListState.Images.SetKeyName(1, "3.bmp");
            // 
            // jMeter1
            // 
            this.jMeter1.BackColor = System.Drawing.Color.Transparent;
            this.jMeter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jMeter1.Location = new System.Drawing.Point(4, 4);
            this.jMeter1.Margin = new System.Windows.Forms.Padding(4);
            this.jMeter1.MinimumSize = new System.Drawing.Size(10, 10);
            this.jMeter1.Name = "jMeter1";
            this.jMeter1.Size = new System.Drawing.Size(291, 70);
            this.jMeter1.TabIndex = 0;
            // 
            // jMeter2
            // 
            this.jMeter2.BackColor = System.Drawing.Color.Transparent;
            this.jMeter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jMeter2.Location = new System.Drawing.Point(303, 4);
            this.jMeter2.Margin = new System.Windows.Forms.Padding(4);
            this.jMeter2.MinimumSize = new System.Drawing.Size(10, 10);
            this.jMeter2.Name = "jMeter2";
            this.jMeter2.Size = new System.Drawing.Size(291, 70);
            this.jMeter2.TabIndex = 1;
            // 
            // jMeter3
            // 
            this.jMeter3.BackColor = System.Drawing.Color.Transparent;
            this.jMeter3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jMeter3.Location = new System.Drawing.Point(602, 4);
            this.jMeter3.Margin = new System.Windows.Forms.Padding(4);
            this.jMeter3.MinimumSize = new System.Drawing.Size(10, 10);
            this.jMeter3.Name = "jMeter3";
            this.jMeter3.Size = new System.Drawing.Size(291, 70);
            this.jMeter3.TabIndex = 2;
            // 
            // jMeter4
            // 
            this.jMeter4.BackColor = System.Drawing.Color.Transparent;
            this.jMeter4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jMeter4.Location = new System.Drawing.Point(901, 4);
            this.jMeter4.Margin = new System.Windows.Forms.Padding(4);
            this.jMeter4.MinimumSize = new System.Drawing.Size(10, 10);
            this.jMeter4.Name = "jMeter4";
            this.jMeter4.Size = new System.Drawing.Size(292, 70);
            this.jMeter4.TabIndex = 3;
            // 
            // FormMainLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMainLab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AppleLab 微机控制岩石静试验机";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainLab_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMainLab_FormClosed);
            this.Load += new System.EventHandler(this.FormMainLab_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.paneltop.ResumeLayout(false);
            this.tlprecord.ResumeLayout(false);
            this.tlprecord.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tlbmeterback.ResumeLayout(false);
            this.tlbmeter.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsluser;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Button btnmethod;
        private System.Windows.Forms.Button btnon;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tlbmeterback;
        private System.Windows.Forms.TableLayoutPanel tlbmeter;
        private JMeter jMeter1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripStatusLabel tslbldevice;
        private System.Windows.Forms.ToolStripStatusLabel tslblkind;
        private System.Windows.Forms.ToolStripStatusLabel tslblsample;
        private System.Windows.Forms.ToolStripStatusLabel tslblmethod;
        private System.Windows.Forms.ToolStripStatusLabel tslblreport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnpos;
        private System.Windows.Forms.Button btnhand;
        private System.Windows.Forms.Button btnext2;
        private System.Windows.Forms.Button btntool;
        private System.Windows.Forms.ImageList btnkeyimageList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private JMeter jMeter2;
        private JMeter jMeter3;
        private JMeter jMeter4;
        public System.Windows.Forms.Button btnkey1;
        public System.Windows.Forms.Button btnkey2;
        public System.Windows.Forms.Button btnkey3;
        public System.Windows.Forms.Button btnkey4;
        private System.Windows.Forms.ToolStripStatusLabel tslblEmergencyStop;
        private System.Windows.Forms.ToolStripStatusLabel tslbllimit;
        private System.Windows.Forms.ToolStripStatusLabel toolstatustest;
        private System.Windows.Forms.Timer timermain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tlpsel;
        public System.Windows.Forms.ToolStripStatusLabel tslblmachine;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tlprecord;
        private System.Windows.Forms.Timer timerRecord;
        private System.Windows.Forms.Button recordStopButton;
        private System.Windows.Forms.Button playBackMacroButton;
        private System.Windows.Forms.Button recordStartButton;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel tslblstate;
        public System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ImageList imageList2;
        public System.Windows.Forms.ImageList imageListState;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblcontroller;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}