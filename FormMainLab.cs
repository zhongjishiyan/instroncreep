﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ClsStaticStation;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using AppleLabApplication;
using Microsoft.Win32;
using PipesServerTest;
namespace TabHeaderDemo
{

    public partial class FormMainLab : Form
    {
        private UserControl操作面板 UserControl操作面板1;
        private UserControl轴向 UserControl轴向1;

        public int l = 0;
        public UserControlTop UTop;


        int lastTimeRecorded = 0;




        private Color topbackcolor = new Color();

        private ClsStaticStation.CDsp myarm;




        public delegate void NewMessageDelegate(string NewMessage);
        private PipeServer _pipeServer;




        private List<JMeter> mlistmeter;
        private List<Button> mlistkey;

        public UserControlMain umain;

        private MainForm fdata;


        // public DriverDll.CDriver cdriverdll;

        private int msel = 0;
        [STAThread]
        static void Main()
        {


            if (IsWindowsVistaOrNewer)
            {



                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Process instance = RunningInstance();
                if (instance == null)
                {
                    //1.1 没有实例在运行
                    //try

                    GlobeVal.mainlab = new FormMainLab();
                    {
                        Application.Run(GlobeVal.mainlab);
                    }

                    // catch (Exception ex)
                    {
                        //throw;
                    }

                }
                else
                {
                    //1.2 已经有一个实例在运行
                    HandleRunningInstance(instance);
                }

            }
            else
            {
                MessageBox.Show("请在windows7以上版本运行");
            }

        }


        /// <summary>
        /// Gets a value indicating if the operating system is a Windows 2000 or a newer one.
        /// </summary>
        /// 
        private static Process RunningInstance()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            //遍历与当前进程名称相同的进程列表 
            foreach (Process process in processes)
            {
                //如果实例已经存在则忽略当前进程 
                if (process.Id != current.Id)
                {
                    //保证要打开的进程同已经存在的进程来自同一文件路径
                    if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == current.MainModule.FileName)
                    {
                        //返回已经存在的进程
                        return process;
                    }
                }
            }
            return null;
        }
        //3.已经有了就把它激活，并将其窗口放置最前端
        private static void HandleRunningInstance(Process instance)
        {
            ShowWindowAsync(instance.MainWindowHandle, 1); //调用api函数，正常显示窗口
            SetForegroundWindow(instance.MainWindowHandle); //将窗口放置最前端
        }
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(System.IntPtr hWnd, int cmdShow);
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(System.IntPtr hWnd);

        public static bool IsWindows2000OrNewer
        {
            get { return (Environment.OSVersion.Platform == PlatformID.Win32NT) && (Environment.OSVersion.Version.Major >= 5); }
        }

        /// <summary>
        /// Gets a value indicating if the operating system is a Windows XP or a newer one.
        /// </summary>
        public static bool IsWindowsXpOrNewer
        {
            get
            {
                return
                    (Environment.OSVersion.Platform == PlatformID.Win32NT) &&
                    (
                        (Environment.OSVersion.Version.Major >= 6) ||
                        (
                            (Environment.OSVersion.Version.Major == 5) &&
                            (Environment.OSVersion.Version.Minor >= 1)
                        )
                    );
            }
        }

        /// <summary>
        /// Gets a value indicating if the operating system is a Windows Vista or a newer one.
        /// </summary>
        public static bool IsWindowsVistaOrNewer
        {
            get { return (Environment.OSVersion.Platform == PlatformID.Win32NT) && (Environment.OSVersion.Version.Major >= 6); }
        }

        public FormMainLab()
        {
            InitializeComponent();
            // _pipeServer = new PipeServer();
            // _pipeServer.PipeMessage += new DelegateMessage(PipesMessageHandler);

            GlobeVal.myglobefile = new ClassGlobeFile();
            GlobeVal.mysys = new ClassSys();


            //MessageBox.Show(System.Windows.Forms.Application.StartupPath.ToString());


            if (Directory.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ") == false)
            {
                Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ");
            }

            if (File.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\sys\\globe.ini") == true)
            {

                GlobeVal.myglobefile = GlobeVal.myglobefile.DeSerializeNow(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\sys\\globe.ini");

            }

            if (File.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\sys\\setup.ini") == true)
            {

                GlobeVal.mysys = GlobeVal.mysys.DeSerializeNow(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\sys\\setup.ini");

            }


            m_Global.mycls = new ItemSignalStation(Convert.ToInt32(GlobeVal.mysys.machinekind));



            m_Global.mycls.ChannelCount = GlobeVal.mysys.ChannelCount;

            for (int i = 0; i < GlobeVal.mysys.ChannelCount; i++)
            {
                m_Global.mycls.ChannelControl[i] = GlobeVal.mysys.ChannelControl[i];
                m_Global.mycls.ChannelDimension[i] = GlobeVal.mysys.ChannelDimension[i];
                m_Global.mycls.ChannelRange[i] = GlobeVal.mysys.ChannelRange[i];
                m_Global.mycls.ChannelSampling[i] = GlobeVal.mysys.ChannelSamplemode[i];
            }




            if (GlobeVal.mysys.controllerkind == 0)
            {
                myarm = new CDsp();

            }

            if (GlobeVal.mysys.controllerkind == 1)
            {

                myarm = new CDsp();

            }


            fdata = new MainForm();

            topbackcolor = Color.WhiteSmoke;





        }

        private void KeyboardReplayHook_KeyUp(object sender, KeyEventArgs e)
        {
            return;
        }

        private void KeyboardReplayHook_KeyDown(object sender, KeyEventArgs e)
        {


        }












        public void delay(double m)
        {
            double t;
            t = Environment.TickCount;

            while (Environment.TickCount - t < m)
            {
                Application.DoEvents();
            }
        }



        public System.Drawing.Bitmap backimage = new Bitmap(50, 50);

        private void drawFigure(PaintEventArgs e, PointF[] points)
        {
            GraphicsPath path = new GraphicsPath();


            Corners r = new Corners(points, 5);
            r.Execute(path);
            path.CloseFigure();
            Matrix matrix = new Matrix();
            matrix.Translate(3, 3);
            path.Transform(matrix);


            Bitmap map = new Bitmap(backimage);

            // Color c = (this.imageList1.Images[1] as Bitmap).GetPixel(this.imageList1.Images[1].Width - 5, this.imageList1.Images[1].Height / 2);


            // Color c = map.GetPixel(map.Width - 5, map.Height / 2);


            map.Dispose();
            drawPath(e, path, topbackcolor);

            path.Reset();
            r = new Corners(points, 5);
            r.Execute(path);
            path.CloseFigure();
            matrix = new Matrix();
            matrix.Translate(0, 0);
            path.Transform(matrix);
            map = new Bitmap(backimage);
            // c = map.GetPixel(map.Width / 2, map.Height / 2);



            map.Dispose();

            drawPath(e, path, topbackcolor);

            path.Dispose();
        }

        private static void drawPath(PaintEventArgs e, GraphicsPath path, Color color)
        {
            LinearGradientBrush brush = new LinearGradientBrush(path.GetBounds(),
                color, color, LinearGradientMode.Horizontal);
            e.Graphics.FillPath(brush, path);
            Pen pen = new Pen(color, 1);
            e.Graphics.DrawPath(pen, path);

            brush.Dispose();
            pen.Dispose();
        }
        //判断键值是否存在
        private bool IsRegeditKeyExit()
        {
            string[] subkeyNames;
            RegistryKey hkml = Registry.LocalMachine;
            RegistryKey software = hkml.OpenSubKey("SOFTWARE\\test");
            //RegistryKey software = hkml.OpenSubKey("SOFTWARE\\test", true);
            subkeyNames = software.GetValueNames();
            //取得该项下所有键值的名称的序列，并传递给预定的数组中
            foreach (string keyName in subkeyNames)
            {
                if (keyName == "test") //判断键值的名称
                {
                    hkml.Close();
                    return true;
                }
            }
            hkml.Close();
            return false;
        }
        //判断注册表是否存在
        private bool IsRegeditExit(string name)
        {

            bool _exit = false;

            try
            {

                string[] subkeyNames;

                RegistryKey hkml = Registry.LocalMachine;

                RegistryKey software = hkml.OpenSubKey("software", true);
                RegistryKey aimdir = software.OpenSubKey("AppleLabJ", true);               /////由此可判断Weather路径是否存在


                subkeyNames = aimdir.GetValueNames();

                foreach (string keyName in subkeyNames)
                {

                    if (keyName == name)
                    {

                        _exit = true;

                        return _exit;

                    }

                }

            }

            catch

            { }

            return _exit;

        }
        public void reg()
        {
            return;
            RegistryKey key = Registry.LocalMachine;
            RegistryKey software = key.CreateSubKey("software\\AppleLabJ");
            //在HKEY_LOCAL_MACHINE\SOFTWARE下新建名为test的注册表项。如果已经存在则不影响！

            software = key.OpenSubKey("software\\AppleLabJ", true);
            software.SetValue("AppleLabJ", "AppleLab 微机控制岩石试验机", RegistryValueKind.String);
            software.SetValue("InstallData", DateTime.Today.ToShortDateString(), RegistryValueKind.String);
            //software.SetValue("test", "0", RegistryValueKind.DWord);
            key.Close();
        }
        public void _直接进入分析界面()
        {

            this.Cursor = Cursors.WaitCursor;



            tabControl1.SelectedIndex = 0;
            GlobeVal.UserControlMain1.btnmtest.Visible = true;
            GlobeVal.UserControlMain1.btnmtest.Text = "分析";
            GlobeVal.UserControlMain1.btnmmanage.Visible = false;
            GlobeVal.UserControlMain1.btnmmethod.Visible = false;
            GlobeVal.UserControlMain1.btnmreport.Visible = false;
            GlobeVal.UserControlMain1.btngroupcontrol.Visible = false;



            GlobeVal.UserControlMain1.tabControl1.SelectedIndex = 7;

            this.Cursor = Cursors.Default;
            tabControl1.SelectedIndex = 1;

        }
        public void _直接进入试验界面()
        {
            GlobeVal.UserControlMain1.btnmtest.Text = "测试";

            this.Cursor = Cursors.WaitCursor;

       

            double t = System.Environment.TickCount;



            /*
            while (System.Environment.TickCount - t <= 500)
            {
                Application.DoEvents();
            }
            */


            umain.OpenTest();

            tabControl1.SelectedIndex = 0;
            /*
            string fileName = System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\Method\\" +
                GlobeVal.userControlpretest1.listView1.Items[0].SubItems[1].Text + "\\"
                  + GlobeVal.userControlpretest1.listView1.Items[0].Text + ".dat";
            */

            string fileName = System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + GlobeVal.selcontroller.ToString().Trim() + "\\para\\方法.dat";



            if (CComLibrary.GlobeVal.filesave == null)
            {
                CComLibrary.GlobeVal.filesave = new CComLibrary.FileStruct();
            }
            CComLibrary.GlobeVal.filesave = CComLibrary.GlobeVal.filesave.DeSerializeNow(fileName);


            if (UserControl操作面板1 == null)
            {

                UserControl操作面板1 = new UserControl操作面板();
                UserControl轴向1 = new UserControl轴向();
                UserControl操作面板1.Controls.Add(UserControl轴向1);
                UserControl轴向1.Dock = DockStyle.Fill;
                UserControl操作面板1.Dock = DockStyle.Fill;

            }
            GlobeVal.userControltest1.panelright.Controls.Clear();

            UserControl操作面板1.Visible = false;
            GlobeVal.userControltest1.panelright.Controls.Add(UserControl操作面板1);


            ClsStaticStation.m_Global.mycls.initchannel();
            ((FormMainLab)Application.OpenForms["FormMainLab"]).InitKey();
            ((FormMainLab)Application.OpenForms["FormMainLab"]).InitMeter();


            GlobeVal.userControlpretest1.gfilename = fileName;
            CComLibrary.GlobeVal.currentfilesavename = fileName;

            if (GlobeVal.mysys.SamplePath == "")
            {
                MessageBox.Show("请设置数据保存路径");

                return;
            }

            if (System.IO.Directory.Exists(GlobeVal.mysys.SamplePath))
            {
            }
            else
            {
                MessageBox.Show("数据保存路径不存在,请点击浏览选择试验路径,将重新设置为c:\\data");
                GlobeVal.mysys.SamplePath = "c:\\data";

                //return;
            }
        




            GlobeVal.spefilename = GlobeVal.mysys.SamplePath + "\\" + "未命名" + ".spe";




            GlobeVal.userControlpretest1.SampleNextStep(true);

            UserControl操作面板1.Visible = true;

            this.Cursor = Cursors.Default;
            tabControl1.SelectedIndex = 1;

            CComLibrary.GlobeVal.filesave.currentspenumber = 0;
        }
        private void FormMainLab_Load(object sender, EventArgs e)
        {
            GlobeVal.MainStatusStrip = this.statusStrip1;

            GlobeVal.FormmainLab = this;

           

            this.Left = 0;
            this.Top = 0;

            jMeter1.BackColor = topbackcolor;
            jMeter2.BackColor = topbackcolor;
            jMeter3.BackColor = topbackcolor;
            jMeter4.BackColor = topbackcolor;


            mlistmeter = new List<JMeter>();
            mlistmeter.Add(jMeter1);

            mlistmeter.Add(jMeter2);
            mlistmeter.Add(jMeter3);
            mlistmeter.Add(jMeter4);
            mlistkey = new List<Button>();
            mlistkey.Add(btnkey1);
            mlistkey.Add(btnkey2);
            mlistkey.Add(btnkey3);
            mlistkey.Add(btnkey4);
            UTop = new TabHeaderDemo.UserControlTop();
            UTop.Dock = DockStyle.Fill;
            panel5.Controls.Add(UTop);
            umain = new UserControlMain();
            umain.Dock = DockStyle.Fill;
           testpage.Controls.Add(umain);

            backimage = new Bitmap(this.imageList1.Images[0], this.imageList1.Images[0].Size);

            this.Width = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width);
            this.Height = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height);


            tabControl1.ItemSize = new Size(1, 1);





            GlobeVal.myarm = myarm;









           


            /*
          
            if (IsRegeditExit("AppleLabJ") == true)
            {
                
            }
            else
            {
                reg();
            }

            string info = "";
            RegistryKey Key;
            Key = Registry.LocalMachine;
            RegistryKey software = Key.OpenSubKey("software\\AppleLabJ");
            // myreg = Key.OpenSubKey("software\\test",true);
            info = software.GetValue("AppleLabJ").ToString();

            GlobeVal.mysys.softwareconfig = info;

            info = software.GetValue("InstallData").ToString();

            GlobeVal.mysys.softwareinstalldate = info;

            

            software.Close();

    */


            if (GlobeVal.mysys.showshorttitle == false)
            {
                UTop.wordArt1.Caption = "AppleLab";

            }
            else
            {
                UTop.wordArt1.Caption = GlobeVal.mysys.shorttitle;
            }

            if (GlobeVal.mysys.showlogo == true)
            {
                if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\bmp\\" + GlobeVal.mysys.bmplogo))
                {
                    UTop.paneldefine.BackgroundImage = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\bmp\\" + GlobeVal.mysys.bmplogo);
                    UTop.panel6.Visible = false;
                    UTop.paneldefine.Visible = true;
                }
                else
                {
                    UTop.panel6.Visible = true;
                    UTop.paneldefine.Visible = false;

                }
            }
            else
            {
                UTop.panel6.Visible = true;
                UTop.paneldefine.Visible = false;

            }

            UTop.Refresh();

            timermain.Enabled = true;

            if (GlobeVal.mysys.safe == true)
            {

                Frm.Form登录 f = new TabHeaderDemo.Frm.Form登录();


                f.result = false;

                f.ShowDialog();

                if (f.result == true)
                {

                }
                else
                {
                    Close();
                }
                f.Close();



            }

            if (GlobeVal.mysys.controllerkind == 0)
            {
                if (GlobeVal.mysys.machinekind == 3)
                {
                }
                else
                {
                    //cdriverdll = new DriverDll.CDriver();
                    // cdriverdll.Start();

                }

            }

            if (Screen.PrimaryScreen.Bounds.Width == 1366)
            {
              
                paneltop.Height = 106;
                tlbmeterback.Height = 64;
            }
            else
            {

            }


            if (GlobeVal.mysys.startupscreen == 1)
            {



                //直接启动试验界面

                _直接进入试验界面();

            }



        }

        void m_toolbox_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {


            GraphicsContainer containerState = e.Graphics.BeginContainer();



            e.Graphics.PageUnit = System.Drawing.GraphicsUnit.Pixel;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.Clear(Color.White);



            PointF[] roundedRectangle = new PointF[5];
            roundedRectangle[0].X = 6;
            roundedRectangle[0].Y = 0;
            roundedRectangle[1].X = paneltop.Width - 2 - 3;
            roundedRectangle[1].Y = 0;
            roundedRectangle[2].X = paneltop.Width - 2 - 3;
            roundedRectangle[2].Y = paneltop.Height - 2 - 3;
            roundedRectangle[3].X = 1;
            roundedRectangle[3].Y = paneltop.Height - 2 - 3;
            roundedRectangle[4].X = 1;
            roundedRectangle[4].Y = 6;
            drawFigure(e, roundedRectangle);



            e.Graphics.EndContainer(containerState);
        }

        private void btnkey2_MouseDown(object sender, MouseEventArgs e)
        {
            btnkey2.BackgroundImage = btnkeyimageList.Images[1];
        }

        private void btnkey2_Click(object sender, EventArgs e)
        {

        }

        private void btnkey2_MouseUp(object sender, MouseEventArgs e)
        {
            btnkey2.BackgroundImage = btnkeyimageList.Images[0];
        }

        private void btnkey1_MouseDown(object sender, MouseEventArgs e)
        {
            btnkey1.BackgroundImage = btnkeyimageList.Images[3];

        }

        private void btnkey1_MouseUp(object sender, MouseEventArgs e)
        {
            btnkey1.BackgroundImage = btnkeyimageList.Images[2];
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnkey3_MouseDown(object sender, MouseEventArgs e)
        {
            btnkey3.BackgroundImage = btnkeyimageList.Images[5];
        }

        private void btnkey3_MouseUp(object sender, MouseEventArgs e)
        {
            btnkey3.BackgroundImage = btnkeyimageList.Images[4];
        }

        private void btnkey4_MouseDown(object sender, MouseEventArgs e)
        {
            btnkey4.BackgroundImage = btnkeyimageList.Images[7];
        }

        private void btnkey4_MouseUp(object sender, MouseEventArgs e)
        {
            btnkey4.BackgroundImage = btnkeyimageList.Images[6];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {




            if ((GlobeVal.myarm.getlimit(0) == true) || (GlobeVal.myarm.getlimit(0) == true))
            {
                GlobeVal.MainStatusStrip.Items["tslbllimit"].Text = "限位：保护";
                //GlobeVal.MainStatusStrip.Items["tslbllimit"].BackColor = Color.Red;
                GlobeVal.MainStatusStrip.Items["tslbllimit"].Image = imageListState.Images[0];

            }
            else
            {
                GlobeVal.MainStatusStrip.Items["tslbllimit"].Text = "限位：正常";
                GlobeVal.MainStatusStrip.Items["tslbllimit"].Image = imageListState.Images[1];
                //GlobeVal.MainStatusStrip.Items["tslbllimit"].BackColor = SystemColors.Control;
            }

            if (GlobeVal.myarm.getEmergencyStop() == true)
            {
                GlobeVal.MainStatusStrip.Items["tslblEmergencyStop"].Text = "急停：保护";

                GlobeVal.MainStatusStrip.Items["tslblEmergencyStop"].Image = imageListState.Images[0];
                // GlobeVal.MainStatusStrip.Items["tslblEmergencyStop"].BackColor = Color.Red;
            }

            else
            {
                GlobeVal.MainStatusStrip.Items["tslblEmergencyStop"].Text = "急停：正常";
                GlobeVal.MainStatusStrip.Items["tslblEmergencyStop"].Image = imageListState.Images[1];
                //  GlobeVal.MainStatusStrip.Items["tslblEmergencyStop"].BackColor = SystemColors.Control;
            }


            if (CComLibrary.GlobeVal.filesave == null)
            {

            }
            else
            {
                for (int i = 0; i < CComLibrary.GlobeVal.filesave.mmeter.Count; i++)
                {
                    for (int j = 0; j < m_Global.mycls.allsignals.Count; j++)
                    {
                        if (CComLibrary.GlobeVal.filesave.mmeter[i].cName == m_Global.mycls.allsignals[j].cName)
                        {
                            mlistmeter[i].lblvalue.Text = m_Global.mycls.allsignals[j].GetValueFromUnit(m_Global.mycls.allsignals[j].cvalue,
                                CComLibrary.GlobeVal.filesave.mmeter[i].cUnitsel);



                        }
                    }
                }
            }

        }
        public void InitKey()
        {
            for (int i = 0; i < CComLibrary.GlobeVal.filesave.mkey.Count; i++)
            {
                mlistkey[i].Text = CComLibrary.GlobeVal.filesave.mkey[i].cName;

                mlistkey[i].Tag = false;
                mlistkey[i].Visible = true;
            }
            for (int i = CComLibrary.GlobeVal.filesave.mkey.Count; i < 4; i++)
            {
                mlistkey[i].Visible = false;
            }
        }
        public void InitMeter()
        {
            tlbmeter.ColumnCount = CComLibrary.GlobeVal.filesave.mmeter.Count;


            for (int i = 0; i < CComLibrary.GlobeVal.filesave.mmeter.Count; i++)
            {

                mlistmeter[i].lblcaption.Text = CComLibrary.GlobeVal.filesave.mmeter[i].cName;
                mlistmeter[i].lblunit.Text = CComLibrary.GlobeVal.filesave.mmeter[i].cUnits[CComLibrary.GlobeVal.filesave.mmeter[i].cUnitsel];
                mlistmeter[i].Visible = true;
                mlistmeter[i].lblvalue.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(
                    CComLibrary.GlobeVal.filesave.mmeter[i].precise);
            }

            for (int i = CComLibrary.GlobeVal.filesave.mmeter.Count; i < 4; i++)
            {
                mlistmeter[i].Visible = false;
            }

            tlbmeter.Refresh();
        }

        private void splitContainer1_SplitterMoving(object sender, SplitterCancelEventArgs e)
        {
            if (msel == 1)
            {
                //e.Cancel = true;
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {


        }

        private void splitContainer1_MouseDown(object sender, MouseEventArgs e)
        {
            msel = 1;
        }

        private void splitContainer1_MouseUp(object sender, MouseEventArgs e)
        {
            msel = 0;
        }



        private void FormMainLab_FormClosed(object sender, FormClosedEventArgs e)
        {


            myarm.Exit();
            myarm.CloseConnection();
            GlobeVal.mysys.SerializeNow(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\sys\\setup.ini");
        }



        private void btnon_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt16(btnon.Tag) == 0)
            {
                btnon.Image = imageList2.Images[1];
                btnon.Tag = 1;
                GlobeVal.myarm.btnzeroall();
            }
            else
            {
                btnon.Image = imageList2.Images[0];
                btnon.Tag = 0;
                GlobeVal.myarm.btnrestoreall();
            }


        }




        private void btnkey1_Click(object sender, EventArgs e)
        {


            GlobeVal.myarm.btnkey(sender as Button);

        }

        private void btnkey2_Click_1(object sender, EventArgs e)
        {
            GlobeVal.myarm.btnkey(sender as Button);
        }

        private void btnkey3_Click(object sender, EventArgs e)
        {
            GlobeVal.myarm.btnkey(sender as Button);
        }

        private void btnkey4_Click(object sender, EventArgs e)
        {
            GlobeVal.myarm.btnkey(sender as Button);
        }



        private void timermain_Tick(object sender, EventArgs e)
        {
            if ((GlobeVal.mysys.CurentUserIndex >= 0) && (GlobeVal.mysys.CurentUserIndex < GlobeVal.mysys.UserCount))
            {
            }
            else
            {
                GlobeVal.mysys.CurentUserIndex = 0;
            }


            tsluser.Text = "用户名:" + GlobeVal.mysys.UserName[GlobeVal.mysys.CurentUserIndex];

            if (GlobeVal.mysys.showapptitle == false)
            {
                tslblmachine.Text = GlobeVal.mysys.MachineName[GlobeVal.mysys.machinekind];
                this.Text = "AppleLab-" + GlobeVal.mysys.MachineName[GlobeVal.mysys.machinekind];
            }
            else
            {
                tslblmachine.Text = GlobeVal.mysys.apptitle;
                this.Text = GlobeVal.mysys.apptitle;
            }

            if (GlobeVal.mysys.showshorttitle == false)
            {
                UTop.wordArt1.Caption = "AppleLab";

            }
            else
            {
                UTop.wordArt1.Caption = GlobeVal.mysys.shorttitle;
            }

        }


        private void btnmethod_Click(object sender, EventArgs e)
        {
            int i;
            bool b = false;
            CComLibrary.FileStruct f = new CComLibrary.FileStruct();
            if (GlobeVal.mysys.AppUserLevel < 1)
            {
                MessageBox.Show("您的当前权限不够，请使用试验经理或管理员权限登录");
                return;
            }
            if (tabControl1.SelectedIndex == 0)
            {
                if (CComLibrary.GlobeVal.filesave == null)
                {
                    b = true;
                }
                else
                {
                    f = CComLibrary.GlobeVal.filesave;

                    string temp = System.Environment.GetEnvironmentVariable("TEMP");
                    DirectoryInfo info = new DirectoryInfo(temp);
                    CComLibrary.GlobeVal.filesave.SerializeNow(info.FullName + "\\temp.tmp");

                }
                try
                {


                    fdata.g_namelist.Clear();
                    fdata.g_signnamelist.Clear();
                    for (int j = 0; j < m_Global.mycls.originsignals.Count; j++)
                    {
                        fdata.g_namelist.Add(m_Global.mycls.originsignals[j].cName);
                        fdata.g_signnamelist.Add(m_Global.mycls.originsignals[j].SignName);
                    }
                    fdata.g_datafilepath = System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\";

                    fdata.gmptpath = System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + @"\method\";
                    fdata.gmptprocedurepath = System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + @"\method\";
                    fdata.tsbeditproject.Visible = true;
                    fdata.Text = "AppleLab-试验标准编辑器";
                    fdata.ShowDialog();
                    fdata.reset();

                    CComLibrary.GlobeVal.InitUserCalcChannel();

                }
                catch (Exception ex)
                {

                }
                if (b == true)
                {
                    string temp = System.Environment.GetEnvironmentVariable("TEMP");
                    DirectoryInfo info = new DirectoryInfo(temp);
                    CComLibrary.GlobeVal.filesave = f.DeSerializeNow(info.FullName + "\\temp.tmp");
                }
            }
            else
            {
                MessageBox.Show("只能在主窗体中编辑");
            }
        }




        private void recordStartButton_MouseEnter(object sender, EventArgs e)
        {

            this.toolTip1.ShowAlways = true;
            this.toolTip1.SetToolTip(sender as Button, (sender as Button).Tag as string);
        }

        private void playBackMacroButton_MouseEnter(object sender, EventArgs e)
        {
            this.toolTip1.ShowAlways = true;
            this.toolTip1.SetToolTip(sender as Button, (sender as Button).Tag as string);
        }

        private void recordStopButton_MouseEnter(object sender, EventArgs e)
        {
            this.toolTip1.ShowAlways = true;
            this.toolTip1.SetToolTip(sender as Button, (sender as Button).Tag as string);
        }




        private void PipesMessageHandler(string message)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new NewMessageDelegate(PipesMessageHandler), message);
                }
                else
                {

                    GlobeVal.myarm.getmsg(message);
                    btnkey1.Text = message;
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void FormMainLab_FormClosing(object sender, FormClosingEventArgs e)
        {
            // _pipeServer.PipeMessage -= new DelegateMessage(PipesMessageHandler);
            // _pipeServer = null;
            if (GlobeVal.myarm.mtestrun == true)
            {
                e.Cancel = true;
            }
        }
    }
}
