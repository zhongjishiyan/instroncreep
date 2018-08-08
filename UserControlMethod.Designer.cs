﻿namespace TabHeaderDemo
{
    partial class UserControlMethod
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("方法");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("样品");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("基本布局");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("高级布局");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("常规", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("尺寸");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("数字输入");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("文本输入");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("选项输入");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("试样", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("试验选项");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("应变");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("测试");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("控制", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("实时显示");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("按键");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("主机");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("控制台", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("类型");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("X轴数据");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Y轴数据");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("高级");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("曲线图1", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("类型");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("X轴数据");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Y轴数据");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("高级");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("曲线图2", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("电表设置");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("操作输入");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("摄像");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("其它显示", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("文档设置");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("原始数据输出");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("数据库设置");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("峰值趋势数据输出");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("报告", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMethod));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new TabHeaderDemo.TreeListEx(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelbutton = new System.Windows.Forms.Panel();
            this.btnexsave1 = new TabHeaderDemo.ButtonExNew(this.components);
            this.btnexprint = new TabHeaderDemo.ButtonExNew(this.components);
            this.btnexsave = new TabHeaderDemo.ButtonExNew(this.components);
            this.btnexsaveclose = new TabHeaderDemo.ButtonExNew(this.components);
            this.btnexread = new TabHeaderDemo.ButtonExNew(this.components);
            this.btnsaveas = new TabHeaderDemo.ButtonExNew(this.components);
            this.btnexnew = new TabHeaderDemo.ButtonExNew(this.components);
            this.btnexopen = new TabHeaderDemo.ButtonExNew(this.components);
            this.buttonExNext = new TabHeaderDemo.ButtonExNew(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelback1 = new System.Windows.Forms.Panel();
            this.panelback = new System.Windows.Forms.Panel();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelbutton.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelback1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelbutton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1066, 592);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.treeView1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 586F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(217, 586);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.CausesValidation = false;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.treeView1.FullRowSelect = true;
            this.treeView1.ItemHeight = 32;
            this.treeView1.Location = new System.Drawing.Point(23, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点5";
            treeNode1.StateImageIndex = 0;
            treeNode1.Text = "方法";
            treeNode2.Name = "节点6";
            treeNode2.StateImageIndex = 0;
            treeNode2.Text = "样品";
            treeNode3.Name = "节点7";
            treeNode3.StateImageIndex = 0;
            treeNode3.Text = "基本布局";
            treeNode4.Name = "节点8";
            treeNode4.StateImageIndex = 0;
            treeNode4.Text = "高级布局";
            treeNode5.Name = "节点0";
            treeNode5.StateImageIndex = 0;
            treeNode5.Text = "常规";
            treeNode6.Name = "节点9";
            treeNode6.StateImageIndex = 0;
            treeNode6.Text = "尺寸";
            treeNode7.Name = "节点10";
            treeNode7.StateImageIndex = 0;
            treeNode7.Text = "数字输入";
            treeNode8.Name = "节点11";
            treeNode8.StateImageIndex = 0;
            treeNode8.Text = "文本输入";
            treeNode9.Name = "节点0";
            treeNode9.StateImageIndex = 0;
            treeNode9.Text = "选项输入";
            treeNode10.Name = "节点1";
            treeNode10.StateImageIndex = 1;
            treeNode10.Text = "试样";
            treeNode11.Name = "节点4";
            treeNode11.StateImageIndex = 0;
            treeNode11.Text = "试验选项";
            treeNode12.Name = "节点0";
            treeNode12.StateImageIndex = 0;
            treeNode12.Text = "应变";
            treeNode13.Name = "节点9";
            treeNode13.StateImageIndex = 0;
            treeNode13.Text = "测试";
            treeNode14.Name = "控制";
            treeNode14.StateImageIndex = 2;
            treeNode14.Text = "控制";
            treeNode15.Name = "节点0";
            treeNode15.StateImageIndex = 0;
            treeNode15.Text = "实时显示";
            treeNode16.Name = "节点1";
            treeNode16.StateImageIndex = 0;
            treeNode16.Text = "按键";
            treeNode17.Name = "节点2";
            treeNode17.StateImageIndex = 0;
            treeNode17.Text = "主机";
            treeNode18.Name = "节点0";
            treeNode18.StateImageIndex = 13;
            treeNode18.Text = "控制台";
            treeNode19.Name = "节点21";
            treeNode19.StateImageIndex = 0;
            treeNode19.Text = "类型";
            treeNode20.Name = "节点22";
            treeNode20.StateImageIndex = 0;
            treeNode20.Text = "X轴数据";
            treeNode21.Name = "节点23";
            treeNode21.StateImageIndex = 0;
            treeNode21.Text = "Y轴数据";
            treeNode22.Name = "节点24";
            treeNode22.StateImageIndex = 0;
            treeNode22.Text = "高级";
            treeNode23.Name = "节点2";
            treeNode23.StateImageIndex = 6;
            treeNode23.Text = "曲线图1";
            treeNode24.Name = "节点25";
            treeNode24.StateImageIndex = 0;
            treeNode24.Text = "类型";
            treeNode25.Name = "节点26";
            treeNode25.StateImageIndex = 0;
            treeNode25.Text = "X轴数据";
            treeNode26.Name = "节点27";
            treeNode26.StateImageIndex = 0;
            treeNode26.Text = "Y轴数据";
            treeNode27.Name = "节点28";
            treeNode27.StateImageIndex = 0;
            treeNode27.Text = "高级";
            treeNode28.Name = "节点3";
            treeNode28.StateImageIndex = 7;
            treeNode28.Text = "曲线图2";
            treeNode29.Name = "节点1";
            treeNode29.StateImageIndex = 0;
            treeNode29.Text = "电表设置";
            treeNode30.Name = "节点0";
            treeNode30.SelectedImageIndex = -2;
            treeNode30.StateImageIndex = 0;
            treeNode30.Text = "操作输入";
            treeNode31.Name = "节点0";
            treeNode31.StateImageIndex = 0;
            treeNode31.Text = "摄像";
            treeNode32.Name = "节点0";
            treeNode32.StateImageIndex = 14;
            treeNode32.Text = "其它显示";
            treeNode33.Name = "节点29";
            treeNode33.StateImageIndex = 0;
            treeNode33.Text = "文档设置";
            treeNode34.Name = "节点0";
            treeNode34.StateImageIndex = 0;
            treeNode34.Text = "原始数据输出";
            treeNode35.Name = "节点0";
            treeNode35.StateImageIndex = 0;
            treeNode35.Text = "数据库设置";
            treeNode36.Name = "节点0";
            treeNode36.StateImageIndex = 0;
            treeNode36.Text = "峰值趋势数据输出";
            treeNode37.Name = "节点5";
            treeNode37.StateImageIndex = 9;
            treeNode37.Text = "报告";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10,
            treeNode14,
            treeNode18,
            treeNode23,
            treeNode28,
            treeNode32,
            treeNode37});
            this.treeView1.Scrollable = false;
            this.treeView1.ShowLines = false;
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(191, 580);
            this.treeView1.StateImageList = this.imageList1;
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.EnabledChanged += new System.EventHandler(this.treeView1_EnabledChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Red;
            this.imageList1.Images.SetKeyName(0, "mt1.png");
            this.imageList1.Images.SetKeyName(1, "mt2.png");
            this.imageList1.Images.SetKeyName(2, "mt3.png");
            this.imageList1.Images.SetKeyName(3, "mt4.png");
            this.imageList1.Images.SetKeyName(4, "mt5.png");
            this.imageList1.Images.SetKeyName(5, "mt5.png");
            this.imageList1.Images.SetKeyName(6, "mt6.png");
            this.imageList1.Images.SetKeyName(7, "mt7.png");
            this.imageList1.Images.SetKeyName(8, "mt8.png");
            this.imageList1.Images.SetKeyName(9, "mt9.png");
            this.imageList1.Images.SetKeyName(10, "mt10.png");
            this.imageList1.Images.SetKeyName(11, "mt11.ico");
            this.imageList1.Images.SetKeyName(12, "mt12.ico");
            this.imageList1.Images.SetKeyName(13, "控制台图标.png");
            this.imageList1.Images.SetKeyName(14, "额外显示图标.png");
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 380);
            this.panel1.TabIndex = 3;
            // 
            // panelbutton
            // 
            this.panelbutton.BackColor = System.Drawing.Color.Silver;
            this.panelbutton.Controls.Add(this.btnexsave1);
            this.panelbutton.Controls.Add(this.btnexprint);
            this.panelbutton.Controls.Add(this.btnexsave);
            this.panelbutton.Controls.Add(this.btnexsaveclose);
            this.panelbutton.Controls.Add(this.btnexread);
            this.panelbutton.Controls.Add(this.btnsaveas);
            this.panelbutton.Controls.Add(this.btnexnew);
            this.panelbutton.Controls.Add(this.btnexopen);
            this.panelbutton.Controls.Add(this.buttonExNext);
            this.panelbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbutton.Location = new System.Drawing.Point(981, 3);
            this.panelbutton.Name = "panelbutton";
            this.panelbutton.Size = new System.Drawing.Size(82, 586);
            this.panelbutton.TabIndex = 2;
            // 
            // btnexsave1
            // 
            this.btnexsave1.BackColor = System.Drawing.Color.Transparent;
            this.btnexsave1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexsave1.BackgroundImage")));
            this.btnexsave1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexsave1.FlatAppearance.BorderSize = 0;
            this.btnexsave1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnexsave1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnexsave1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexsave1.ForeColor = System.Drawing.Color.White;
            this.btnexsave1.Image = ((System.Drawing.Image)(resources.GetObject("btnexsave1.Image")));
            this.btnexsave1.Location = new System.Drawing.Point(-4, 76);
            this.btnexsave1.Name = "btnexsave1";
            this.btnexsave1.Size = new System.Drawing.Size(89, 67);
            this.btnexsave1.TabIndex = 78;
            this.btnexsave1.Text = "保存";
            this.btnexsave1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexsave1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnexsave1.UseMnemonic = false;
            this.btnexsave1.UseVisualStyleBackColor = false;
            this.btnexsave1.Click += new System.EventHandler(this.btnexsave1_Click);
            // 
            // btnexprint
            // 
            this.btnexprint.BackColor = System.Drawing.Color.Transparent;
            this.btnexprint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexprint.BackgroundImage")));
            this.btnexprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexprint.FlatAppearance.BorderSize = 0;
            this.btnexprint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnexprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnexprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexprint.ForeColor = System.Drawing.Color.White;
            this.btnexprint.Image = ((System.Drawing.Image)(resources.GetObject("btnexprint.Image")));
            this.btnexprint.Location = new System.Drawing.Point(-4, 380);
            this.btnexprint.Name = "btnexprint";
            this.btnexprint.Size = new System.Drawing.Size(89, 67);
            this.btnexprint.TabIndex = 77;
            this.btnexprint.Text = "打印";
            this.btnexprint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnexprint.UseMnemonic = false;
            this.btnexprint.UseVisualStyleBackColor = false;
            this.btnexprint.Click += new System.EventHandler(this.btnexprint_Click);
            // 
            // btnexsave
            // 
            this.btnexsave.BackColor = System.Drawing.Color.Transparent;
            this.btnexsave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexsave.BackgroundImage")));
            this.btnexsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexsave.FlatAppearance.BorderSize = 0;
            this.btnexsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnexsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnexsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexsave.ForeColor = System.Drawing.Color.White;
            this.btnexsave.Image = ((System.Drawing.Image)(resources.GetObject("btnexsave.Image")));
            this.btnexsave.Location = new System.Drawing.Point(-4, 228);
            this.btnexsave.Name = "btnexsave";
            this.btnexsave.Size = new System.Drawing.Size(89, 67);
            this.btnexsave.TabIndex = 76;
            this.btnexsave.Text = "保存";
            this.btnexsave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnexsave.UseMnemonic = false;
            this.btnexsave.UseVisualStyleBackColor = false;
            this.btnexsave.Click += new System.EventHandler(this.btnexsave_Click);
            // 
            // btnexsaveclose
            // 
            this.btnexsaveclose.BackColor = System.Drawing.Color.Transparent;
            this.btnexsaveclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexsaveclose.BackgroundImage")));
            this.btnexsaveclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexsaveclose.FlatAppearance.BorderSize = 0;
            this.btnexsaveclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnexsaveclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnexsaveclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexsaveclose.ForeColor = System.Drawing.Color.White;
            this.btnexsaveclose.Image = ((System.Drawing.Image)(resources.GetObject("btnexsaveclose.Image")));
            this.btnexsaveclose.Location = new System.Drawing.Point(-4, 152);
            this.btnexsaveclose.Name = "btnexsaveclose";
            this.btnexsaveclose.Size = new System.Drawing.Size(89, 67);
            this.btnexsaveclose.TabIndex = 75;
            this.btnexsaveclose.Text = "保存后关闭";
            this.btnexsaveclose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexsaveclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnexsaveclose.UseMnemonic = false;
            this.btnexsaveclose.UseVisualStyleBackColor = false;
            this.btnexsaveclose.Click += new System.EventHandler(this.btnexsaveclose_Click);
            // 
            // btnexread
            // 
            this.btnexread.BackColor = System.Drawing.Color.Transparent;
            this.btnexread.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexread.BackgroundImage")));
            this.btnexread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexread.FlatAppearance.BorderSize = 0;
            this.btnexread.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnexread.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnexread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexread.ForeColor = System.Drawing.Color.White;
            this.btnexread.Image = ((System.Drawing.Image)(resources.GetObject("btnexread.Image")));
            this.btnexread.Location = new System.Drawing.Point(0, 516);
            this.btnexread.Name = "btnexread";
            this.btnexread.Size = new System.Drawing.Size(89, 67);
            this.btnexread.TabIndex = 74;
            this.btnexread.Text = "浏览";
            this.btnexread.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexread.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnexread.UseMnemonic = false;
            this.btnexread.UseVisualStyleBackColor = false;
            this.btnexread.Visible = false;
            // 
            // btnsaveas
            // 
            this.btnsaveas.BackColor = System.Drawing.Color.Transparent;
            this.btnsaveas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsaveas.BackgroundImage")));
            this.btnsaveas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsaveas.FlatAppearance.BorderSize = 0;
            this.btnsaveas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsaveas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsaveas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaveas.ForeColor = System.Drawing.Color.White;
            this.btnsaveas.Image = ((System.Drawing.Image)(resources.GetObject("btnsaveas.Image")));
            this.btnsaveas.Location = new System.Drawing.Point(-4, 304);
            this.btnsaveas.Name = "btnsaveas";
            this.btnsaveas.Size = new System.Drawing.Size(89, 67);
            this.btnsaveas.TabIndex = 72;
            this.btnsaveas.Text = "另存为";
            this.btnsaveas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsaveas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsaveas.UseMnemonic = false;
            this.btnsaveas.UseVisualStyleBackColor = false;
            this.btnsaveas.Click += new System.EventHandler(this.btnsaveas_Click);
            // 
            // btnexnew
            // 
            this.btnexnew.BackColor = System.Drawing.Color.Transparent;
            this.btnexnew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexnew.BackgroundImage")));
            this.btnexnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexnew.FlatAppearance.BorderSize = 0;
            this.btnexnew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnexnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnexnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexnew.ForeColor = System.Drawing.Color.White;
            this.btnexnew.Image = ((System.Drawing.Image)(resources.GetObject("btnexnew.Image")));
            this.btnexnew.Location = new System.Drawing.Point(9, 592);
            this.btnexnew.Name = "btnexnew";
            this.btnexnew.Size = new System.Drawing.Size(89, 67);
            this.btnexnew.TabIndex = 69;
            this.btnexnew.Text = "新建";
            this.btnexnew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexnew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnexnew.UseMnemonic = false;
            this.btnexnew.UseVisualStyleBackColor = false;
            this.btnexnew.Visible = false;
            // 
            // btnexopen
            // 
            this.btnexopen.BackColor = System.Drawing.Color.Transparent;
            this.btnexopen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexopen.FlatAppearance.BorderSize = 0;
            this.btnexopen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnexopen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnexopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexopen.ForeColor = System.Drawing.Color.White;
            this.btnexopen.Image = ((System.Drawing.Image)(resources.GetObject("btnexopen.Image")));
            this.btnexopen.Location = new System.Drawing.Point(-4, -3);
            this.btnexopen.Name = "btnexopen";
            this.btnexopen.Size = new System.Drawing.Size(89, 67);
            this.btnexopen.TabIndex = 73;
            this.btnexopen.Text = "打开";
            this.btnexopen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexopen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnexopen.UseMnemonic = false;
            this.btnexopen.UseVisualStyleBackColor = false;
            this.btnexopen.Click += new System.EventHandler(this.btnexopen_Click);
            // 
            // buttonExNext
            // 
            this.buttonExNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonExNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExNext.BackgroundImage")));
            this.buttonExNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExNext.FlatAppearance.BorderSize = 0;
            this.buttonExNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonExNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonExNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExNext.ForeColor = System.Drawing.Color.White;
            this.buttonExNext.Image = ((System.Drawing.Image)(resources.GetObject("buttonExNext.Image")));
            this.buttonExNext.Location = new System.Drawing.Point(-3, 0);
            this.buttonExNext.Name = "buttonExNext";
            this.buttonExNext.Size = new System.Drawing.Size(89, 67);
            this.buttonExNext.TabIndex = 83;
            this.buttonExNext.Text = "下一步";
            this.buttonExNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonExNext.UseMnemonic = false;
            this.buttonExNext.UseVisualStyleBackColor = false;
            this.buttonExNext.Visible = false;
            this.buttonExNext.Click += new System.EventHandler(this.buttonExNext_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panelback1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(226, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(749, 586);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // panelback1
            // 
            this.panelback1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelback1.Controls.Add(this.panelback);
            this.panelback1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelback1.Location = new System.Drawing.Point(3, 8);
            this.panelback1.Name = "panelback1";
            this.panelback1.Size = new System.Drawing.Size(743, 570);
            this.panelback1.TabIndex = 0;
            // 
            // panelback
            // 
            this.panelback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelback.Location = new System.Drawing.Point(0, 0);
            this.panelback.Name = "panelback";
            this.panelback.Size = new System.Drawing.Size(743, 570);
            this.panelback.TabIndex = 0;
            this.panelback.Paint += new System.Windows.Forms.PaintEventHandler(this.panelback_Paint);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Black;
            this.imageList2.Images.SetKeyName(0, "mt11.ico");
            this.imageList2.Images.SetKeyName(1, "mt12.ico");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "12.ico");
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // UserControlMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControlMethod";
            this.Size = new System.Drawing.Size(1066, 592);
            this.Load += new System.EventHandler(this.UserControlMethod_Load);
            this.TabIndexChanged += new System.EventHandler(this.UserControlMethod_TabIndexChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControl5_Paint);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelbutton.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelback1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        public ButtonExNew btnexnew;
        public ButtonExNew btnexprint;
        public ButtonExNew btnexsave;
        public ButtonExNew btnexsaveclose;
        public ButtonExNew btnexread;
        public ButtonExNew btnexopen;
        public ButtonExNew btnsaveas;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panelback1;
        public System.Windows.Forms.Panel panelback;
        private System.Windows.Forms.ImageList imageList3;
        public System.Windows.Forms.Panel panelbutton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public TreeListEx treeView1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        public ButtonExNew btnexsave1;
        public ButtonExNew buttonExNext;
    }
}
