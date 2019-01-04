namespace TabHeaderDemo
{
    partial class UserControl轴向
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl轴向));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ledalarm = new LBSoft.IndustrialCtrls.Leds.LBLed();
            this.lblalarm = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ledslimit = new LBSoft.IndustrialCtrls.Leds.LBLed();
            this.lblslimit = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ledhlimit = new LBSoft.IndustrialCtrls.Leds.LBLed();
            this.lblhlimit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.numericEdit2 = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.lblmunit = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblunit = new System.Windows.Forms.Label();
            this.numericEdit1 = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.cboctrl = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnend = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btndown = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit2)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit1)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(160, 630);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 105);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.ledalarm, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblalarm, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 68);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(144, 34);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // ledalarm
            // 
            this.ledalarm.BackColor = System.Drawing.Color.Transparent;
            this.ledalarm.BlinkInterval = 500;
            this.ledalarm.Label = "";
            this.ledalarm.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top;
            this.ledalarm.LedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ledalarm.LedSize = new System.Drawing.SizeF(20F, 20F);
            this.ledalarm.Location = new System.Drawing.Point(3, 3);
            this.ledalarm.Name = "ledalarm";
            this.ledalarm.Renderer = null;
            this.ledalarm.Size = new System.Drawing.Size(32, 28);
            this.ledalarm.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On;
            this.ledalarm.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular;
            this.ledalarm.TabIndex = 4;
            // 
            // lblalarm
            // 
            this.lblalarm.AutoSize = true;
            this.lblalarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblalarm.ForeColor = System.Drawing.Color.White;
            this.lblalarm.Location = new System.Drawing.Point(41, 0);
            this.lblalarm.Name = "lblalarm";
            this.lblalarm.Size = new System.Drawing.Size(100, 34);
            this.lblalarm.TabIndex = 1;
            this.lblalarm.Text = "报警";
            this.lblalarm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.ledslimit, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblslimit, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 34);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(144, 34);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // ledslimit
            // 
            this.ledslimit.BackColor = System.Drawing.Color.Transparent;
            this.ledslimit.BlinkInterval = 500;
            this.ledslimit.Label = "";
            this.ledslimit.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top;
            this.ledslimit.LedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ledslimit.LedSize = new System.Drawing.SizeF(20F, 20F);
            this.ledslimit.Location = new System.Drawing.Point(3, 3);
            this.ledslimit.Name = "ledslimit";
            this.ledslimit.Renderer = null;
            this.ledslimit.Size = new System.Drawing.Size(32, 28);
            this.ledslimit.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On;
            this.ledslimit.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular;
            this.ledslimit.TabIndex = 4;
            // 
            // lblslimit
            // 
            this.lblslimit.AutoSize = true;
            this.lblslimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblslimit.ForeColor = System.Drawing.Color.White;
            this.lblslimit.Location = new System.Drawing.Point(41, 0);
            this.lblslimit.Name = "lblslimit";
            this.lblslimit.Size = new System.Drawing.Size(100, 34);
            this.lblslimit.TabIndex = 1;
            this.lblslimit.Text = "软限位保护";
            this.lblslimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ledhlimit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblhlimit, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(144, 34);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // ledhlimit
            // 
            this.ledhlimit.BackColor = System.Drawing.Color.Transparent;
            this.ledhlimit.BlinkInterval = 500;
            this.ledhlimit.Label = "";
            this.ledhlimit.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top;
            this.ledhlimit.LedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ledhlimit.LedSize = new System.Drawing.SizeF(20F, 20F);
            this.ledhlimit.Location = new System.Drawing.Point(3, 3);
            this.ledhlimit.Name = "ledhlimit";
            this.ledhlimit.Renderer = null;
            this.ledhlimit.Size = new System.Drawing.Size(32, 28);
            this.ledhlimit.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On;
            this.ledhlimit.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular;
            this.ledhlimit.TabIndex = 3;
            // 
            // lblhlimit
            // 
            this.lblhlimit.AutoSize = true;
            this.lblhlimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblhlimit.ForeColor = System.Drawing.Color.White;
            this.lblhlimit.Location = new System.Drawing.Point(41, 0);
            this.lblhlimit.Name = "lblhlimit";
            this.lblhlimit.Size = new System.Drawing.Size(100, 34);
            this.lblhlimit.TabIndex = 1;
            this.lblhlimit.Text = "硬限位保护";
            this.lblhlimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel10);
            this.panel2.Controls.Add(this.tableLayoutPanel9);
            this.panel2.Controls.Add(this.tableLayoutPanel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(8, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 159);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 103);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(144, 58);
            this.tableLayoutPanel10.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "目标：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel10.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel4.Controls.Add(this.numericEdit2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblmunit, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(138, 27);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // numericEdit2
            // 
            this.numericEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericEdit2.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Text;
            this.numericEdit2.Location = new System.Drawing.Point(3, 3);
            this.numericEdit2.Name = "numericEdit2";
            this.numericEdit2.Size = new System.Drawing.Size(84, 21);
            this.numericEdit2.TabIndex = 2;
            // 
            // lblmunit
            // 
            this.lblmunit.AutoSize = true;
            this.lblmunit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblmunit.ForeColor = System.Drawing.Color.White;
            this.lblmunit.Location = new System.Drawing.Point(93, 0);
            this.lblmunit.Name = "lblmunit";
            this.lblmunit.Size = new System.Drawing.Size(42, 27);
            this.lblmunit.TabIndex = 3;
            this.lblmunit.Text = "mm";
            this.lblmunit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel9.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.lblunit, 2, 1);
            this.tableLayoutPanel9.Controls.Add(this.numericEdit1, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(144, 54);
            this.tableLayoutPanel9.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "加载速度：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblunit
            // 
            this.lblunit.AutoSize = true;
            this.lblunit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblunit.ForeColor = System.Drawing.Color.White;
            this.lblunit.Location = new System.Drawing.Point(95, 26);
            this.lblunit.Name = "lblunit";
            this.lblunit.Size = new System.Drawing.Size(46, 28);
            this.lblunit.TabIndex = 1;
            this.lblunit.Text = "mm/Min";
            this.lblunit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericEdit1
            // 
            this.tableLayoutPanel9.SetColumnSpan(this.numericEdit1, 2);
            this.numericEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericEdit1.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Text;
            this.numericEdit1.Location = new System.Drawing.Point(3, 29);
            this.numericEdit1.Name = "numericEdit1";
            this.numericEdit1.Size = new System.Drawing.Size(86, 21);
            this.numericEdit1.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.cboctrl, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(144, 49);
            this.tableLayoutPanel8.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "加载方式：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboctrl
            // 
            this.cboctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboctrl.FormattingEnabled = true;
            this.cboctrl.Location = new System.Drawing.Point(3, 23);
            this.cboctrl.Name = "cboctrl";
            this.cboctrl.Size = new System.Drawing.Size(176, 20);
            this.cboctrl.TabIndex = 1;
            this.cboctrl.SelectedIndexChanged += new System.EventHandler(this.cboctrl_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(8, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 195);
            this.panel3.TabIndex = 4;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.btnstart, 0, 3);
            this.tableLayoutPanel11.Controls.Add(this.btnend, 0, 4);
            this.tableLayoutPanel11.Controls.Add(this.btnup, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.btndown, 0, 2);
            this.tableLayoutPanel11.Controls.Add(this.btnstop, 0, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 5;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(144, 195);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.Transparent;
            this.btnstart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnstart.FlatAppearance.BorderSize = 0;
            this.btnstart.Image = ((System.Drawing.Image)(resources.GetObject("btnstart.Image")));
            this.btnstart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstart.Location = new System.Drawing.Point(3, 120);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(138, 33);
            this.btnstart.TabIndex = 47;
            this.btnstart.Text = "目标开始";
            this.btnstart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnend
            // 
            this.btnend.BackColor = System.Drawing.Color.Transparent;
            this.btnend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnend.FlatAppearance.BorderSize = 0;
            this.btnend.Image = ((System.Drawing.Image)(resources.GetObject("btnend.Image")));
            this.btnend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnend.Location = new System.Drawing.Point(3, 159);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(138, 33);
            this.btnend.TabIndex = 44;
            this.btnend.Text = "目标结束";
            this.btnend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnend.UseVisualStyleBackColor = false;
            this.btnend.Click += new System.EventHandler(this.btnend_Click);
            // 
            // btnup
            // 
            this.btnup.BackColor = System.Drawing.Color.Transparent;
            this.btnup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnup.FlatAppearance.BorderSize = 0;
            this.btnup.Image = ((System.Drawing.Image)(resources.GetObject("btnup.Image")));
            this.btnup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnup.Location = new System.Drawing.Point(3, 3);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(138, 33);
            this.btnup.TabIndex = 41;
            this.btnup.Text = "上升";
            this.btnup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnup.UseVisualStyleBackColor = false;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btndown
            // 
            this.btndown.BackColor = System.Drawing.Color.Transparent;
            this.btndown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btndown.FlatAppearance.BorderSize = 0;
            this.btndown.Image = ((System.Drawing.Image)(resources.GetObject("btndown.Image")));
            this.btndown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndown.Location = new System.Drawing.Point(3, 81);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(138, 33);
            this.btndown.TabIndex = 39;
            this.btndown.Text = "下降";
            this.btndown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndown.UseVisualStyleBackColor = false;
            this.btndown.Click += new System.EventHandler(this.btndown_Click);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.Color.Transparent;
            this.btnstop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnstop.FlatAppearance.BorderSize = 0;
            this.btnstop.Image = ((System.Drawing.Image)(resources.GetObject("btnstop.Image")));
            this.btnstop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstop.Location = new System.Drawing.Point(3, 42);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(138, 33);
            this.btnstop.TabIndex = 40;
            this.btnstop.Text = "保持";
            this.btnstop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(8, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "选项";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "3.ico");
            // 
            // UserControl轴向
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl轴向";
            this.Size = new System.Drawing.Size(160, 664);
            this.Load += new System.EventHandler(this.UserControl轴向_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControl轴向_Paint);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit2)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit1)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblslimit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblhlimit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblunit;
        private NationalInstruments.UI.WindowsForms.NumericEdit numericEdit1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboctrl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnend;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btndown;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private NationalInstruments.UI.WindowsForms.NumericEdit numericEdit2;
        private System.Windows.Forms.Label lblmunit;
        private LBSoft.IndustrialCtrls.Leds.LBLed ledslimit;
        private LBSoft.IndustrialCtrls.Leds.LBLed ledhlimit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private LBSoft.IndustrialCtrls.Leds.LBLed ledalarm;
        private System.Windows.Forms.Label lblalarm;
        private System.Windows.Forms.Button button1;
    }
}
