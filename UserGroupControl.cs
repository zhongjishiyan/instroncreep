using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
namespace TabHeaderDemo
{


    public partial class UserGroupControl : UserControl
    {

        private IP.Components.Toolbox lstspe = new IP.Components.Toolbox(false);

        private void drawFigure(PaintEventArgs e, PointF[] points)
        {
            GraphicsPath path = new GraphicsPath();


            Corners r = new Corners(points, 5);
            r.Execute(path);
            path.CloseFigure();
            Matrix matrix = new Matrix();
            matrix.Translate(3, 3);
            path.Transform(matrix);



            Color c = (this.imageList3.Images[0] as Bitmap).GetPixel(this.imageList3.Images[0].Width - 5, this.imageList3.Images[0].Height / 2);



            drawPath(e, path, c);

            path.Reset();
            r = new Corners(points, 5);
            r.Execute(path);
            path.CloseFigure();
            matrix = new Matrix();
            matrix.Translate(0, 0);
            path.Transform(matrix);

            c = (this.imageList3.Images[0] as Bitmap).GetPixel(this.imageList3.Images[0].Width / 2, this.imageList3.Images[0].Height / 2);



            drawPath(e, path, c);

            path.Dispose();
        }
        public void Init()
        {

            listView1.Columns.Clear();
            listView1.Columns.Add("主机");
            listView1.Columns[0].Width = 40;

            listView1.Columns.Add("类型");
            listView1.Columns[1].Width = 100;
            listView1.Columns.Add("状态");

            listView1.Columns[2].Width = 100;

            listView1.Columns.Add("控制值");
            listView1.Columns[3].Width = 60;

            listView1.Columns.Add("力[kN]");
            listView1.Columns[4].Width = 60;

            listView1.Columns.Add("位移[mm]");
            listView1.Columns[5].Width = 60;

            listView1.Columns.Add("变形1[mm]");
            listView1.Columns[6].Width = 70;

            listView1.Columns.Add("变形2[mm]");
            listView1.Columns[7].Width = 70;


            listView1.Columns.Add("平均变形[mm]");

            listView1.Columns[8].Width = 90;


            listView1.Columns.Add("不平衡度[%]");
            listView1.Columns[9].Width = 80;

            listView1.Columns.Add("控温[℃]");
            listView1.Columns[10].Width = 60;

            listView1.Columns.Add("上段温度");
            listView1.Columns[11].Width = 60;

            listView1.Columns.Add("中段温度");
            listView1.Columns[12].Width = 60;

            listView1.Columns.Add("下段温度");
            listView1.Columns[13].Width = 60;

            listView1.Columns.Add("温度梯度");
            listView1.Columns[14].Width = 60;

            listView1.Columns.Add("试验时间[h]");
            listView1.Columns[15].Width = 90;

            listView1.Columns.Add("波形个数");
            listView1.Columns[16].Width = 60;

            listView1.Columns.Add("循环次数");


            listView1.Items.Clear();
            lstspe.Items.Clear();

            IP.Components.Toolbox.Item m;

            this.cbomachine.Items.Clear();

            for (int i = 0; i < GlobeVal.myglobefile.ControllerCount; i++)
            {
                this.cbomachine.Items.Add((i + 1).ToString());
            }
            if ((GlobeVal.selcontroller >= 1) && (GlobeVal.selcontroller <= GlobeVal.myglobefile.ControllerCount))
            {
                this.cbomachine.SelectedIndex = GlobeVal.selcontroller - 1;
            }
            else
            {
                this.cbomachine.SelectedIndex = 0;
            }

            for (int i = 0; i < GlobeVal.myglobefile.ControllerCount; i++)
            {
                m = new IP.Components.Toolbox.Item();
                m.Text = "主机" + (i + 1).ToString();

                m.Image = imageList4.Images[_Status_Testing.Selector_Status_Ready_For_Test.GetHashCode()];
                lstspe.Items.Add(m);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = (i + 1).ToString();

                for (int j = 0; j < 17; j++)
                {
                    lvi.SubItems.Add("");
                }


                listView1.Items.Add(lvi);

            }

            cboy.Items.Clear();
            for (int i = 0; i < GlobeVal.myglobefile.ControllerCount; i++)
            {
                cbohy.Items.Add("主机" + (i + 1).ToString());
                cbohy1.Items.Add("主机" + (i + 1).ToString());
            }
            cbohy.SelectedIndex = 0;
            cbohy1.SelectedIndex = 0;
            for (int j = 0; j < ClsStaticStation.m_Global.mycls.chsignals.Count; j++)
            {
                cboy.Items.Add(ClsStaticStation.m_Global.mycls.chsignals[j].cName);
                cboy1.Items.Add(ClsStaticStation.m_Global.mycls.chsignals[j].cName);
            }

            

            cboy.SelectedIndex = 0;
            cboy1.SelectedIndex = 0;

            timer1.Enabled = true;

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
        public UserGroupControl()
        {
            InitializeComponent();


            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲


            this.tableLayoutPanel1.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel1, true, null);
            // this.tableLayoutPanel2.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel2, true, null);
            this.tableLayoutPanel3.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel3, true, null);

            lstspe.ItemMenu = contextMenuStrip1;

            lstspe.ContextMenuStrip = contextMenuStrip1;
            lstspe.TabMenu = null;

        }





        public void methodon(String t, String parent)
        {


        }


        private void buttonEx1_Click(object sender, EventArgs e)
        {

        }

        private void UserManage_Paint(object sender, PaintEventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            GraphicsContainer containerState = e.Graphics.BeginContainer();
            tableLayoutPanel1.BackColor = Color.Transparent;

            e.Graphics.PageUnit = System.Drawing.GraphicsUnit.Pixel;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.Clear(Color.White);



            PointF[] roundedRectangle = new PointF[5];
            roundedRectangle[0].X = 6;
            roundedRectangle[0].Y = 0;
            roundedRectangle[1].X = this.Width - 2 - 3;
            roundedRectangle[1].Y = 0;
            roundedRectangle[2].X = this.Width - 2 - 3;
            roundedRectangle[2].Y = this.Height - 2 - 3;
            roundedRectangle[3].X = 1;
            roundedRectangle[3].Y = this.Height - 2 - 3;
            roundedRectangle[4].X = 1;
            roundedRectangle[4].Y = 6;
            drawFigure(e, roundedRectangle);



            e.Graphics.EndContainer(containerState);
        }
        private static void drawFigure1(PaintEventArgs e, PointF[] points)
        {
            GraphicsPath path = new GraphicsPath();


            Corners r = new Corners(points, 5);
            r.Execute(path);
            path.CloseFigure();
            Matrix matrix = new Matrix();
            matrix.Translate(0, 0);
            path.Transform(matrix);
            drawPath1(e, path, System.Drawing.Color.White);
            path.Dispose();

        }

        private static void drawPath1(PaintEventArgs e, GraphicsPath path, System.Drawing.Color color)
        {
            
            LinearGradientBrush brush = new LinearGradientBrush(path.GetBounds(),
                color, color, LinearGradientMode.Horizontal);
            e.Graphics.FillPath(brush, path);
            Pen pen = new Pen(color, 1);
            e.Graphics.DrawPath(pen, path);

            brush.Dispose();
            pen.Dispose();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            GraphicsContainer containerState = e.Graphics.BeginContainer();
            tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;

            e.Graphics.PageUnit = System.Drawing.GraphicsUnit.Pixel;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.Clear(System.Drawing.Color.White);



            PointF[] roundedRectangle = new PointF[5];
            roundedRectangle[0].X = 8;
            roundedRectangle[0].Y = 0;
            roundedRectangle[1].X = this.Width - 2 - 3;
            roundedRectangle[1].Y = 0;
            roundedRectangle[2].X = this.Width - 2 - 3;
            roundedRectangle[2].Y = this.Height - 2;
            roundedRectangle[3].X = 1;
            roundedRectangle[3].Y = this.Height - 2;
            roundedRectangle[4].X = 1;
            roundedRectangle[4].Y = 5;
            drawFigure(e, roundedRectangle);

            //e.Graphics.EndContainer(containerState);

            //containerState = e.Graphics.BeginContainer();
            //e.Graphics.PageUnit = System.Drawing.GraphicsUnit.Pixel;
            //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //e.Graphics.Clear(Color.White);



            roundedRectangle = new PointF[5];
            roundedRectangle[0].X = panel4.Left - 10;
            roundedRectangle[0].Y = panel4.Top + 4;
            roundedRectangle[1].X = panel4.Right;
            roundedRectangle[1].Y = panel4.Top + 4;
            roundedRectangle[2].X = panel4.Right;
            roundedRectangle[2].Y = roundedRectangle[0].Y + (panel4.Bottom - panel4.Top);
            roundedRectangle[3].X = panel4.Left - 10;
            roundedRectangle[3].Y = roundedRectangle[0].Y + (panel4 .Bottom - panel4.Top);
            roundedRectangle[4].X = panel4.Left - 10;
            roundedRectangle[4].Y = panel4.Top + 4;
            drawFigure1(e, roundedRectangle);

            e.Graphics.EndContainer(containerState);

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (GlobeVal.myarm.connected == true)
            {


                for (int i = 0; i < listView1.Items.Count; i++)


                {

                    
                    listView1.Items[i].SubItems[1].Text = GlobeVal.myarm.MyTransferData.FuncID[i].ToString();

                    listView1.Items[i].SubItems[1].Text = GlobeVal.myarm.machinekind[i];

                    if (GlobeVal.myarm.MyTransferData.EDC_STATE[i] == Convert.ToInt16(ClsStaticStation.modMain.EDC_State.EDC_STATE_NOT_READY))
                    {
                        listView1.Items[i].SubItems[2].Text = "未联机";
                    }
                    if (GlobeVal.myarm.MyTransferData.EDC_STATE[i] == Convert.ToInt16(ClsStaticStation.modMain.EDC_State.EDC_STATE_OFF))
                    {
                        listView1.Items[i].SubItems[2].Text = "联机";
                    }
                    if (GlobeVal.myarm.MyTransferData.EDC_STATE[i] == Convert.ToInt16(ClsStaticStation.modMain.EDC_State.EDC_STATE_ON))
                    {
                        listView1.Items[i].SubItems[2].Text = "启动";
                    }
                    if (GlobeVal.myarm.MyTransferData.EDC_STATE[i] == Convert.ToInt16(ClsStaticStation.modMain.EDC_State.EDC_STATE_TEST))
                    {
                        listView1.Items[i].SubItems[2].Text = "试验中";
                    }
                    if (GlobeVal.myarm.MyTransferData.EDC_STATE[i] != Convert.ToInt16( ClsStaticStation.modMain.EDC_State.EDC_STATE_NOT_READY))
                    {
                        listView1.Items[i].SubItems[3].Text = GlobeVal.myarm.MyTransferData.ControlValue[i].ToString("F3");
                        listView1.Items[i].SubItems[4].Text = GlobeVal.myarm.MyTransferData.CHANNEL_F[i].ToString("F3");
                        listView1.Items[i].SubItems[5].Text = GlobeVal.myarm.MyTransferData.CHANNEL_S[i].ToString("F3");
                        listView1.Items[i].SubItems[6].Text = GlobeVal.myarm.MyTransferData.CHANNEL_4[i].ToString("F3");
                        listView1.Items[i].SubItems[7].Text = GlobeVal.myarm.MyTransferData.CHANNEL_5[i].ToString("F3");
                        listView1.Items[i].SubItems[8].Text = GlobeVal.myarm.MyTransferData.CHANNEL_E[i].ToString("F3");
                        listView1.Items[i].SubItems[9].Text = GlobeVal.myarm.MyTransferData.Unbalancedness[i].ToString("F3");
                        listView1.Items[i].SubItems[10].Text = GlobeVal.myarm.MyTransferData.TemperatureControl[i].ToString("F3");//试验温度设定值
                        listView1.Items[i].SubItems[11].Text = GlobeVal.myarm.MyTransferData.CHANNEL_7[i].ToString("F3");//温度上
                        listView1.Items[i].SubItems[12].Text = GlobeVal.myarm.MyTransferData.CHANNEL_8[i].ToString("F3");//温度中
                        listView1.Items[i].SubItems[13].Text = GlobeVal.myarm.MyTransferData.CHANNEL_9[i].ToString("F3");//温度下
                        listView1.Items[i].SubItems[14].Text = GlobeVal.myarm.MyTransferData.TemperatureGradient[i].ToString("F3");//温度梯度
                        listView1.Items[i].SubItems[15].Text = GlobeVal.myarm.MyTransferData.TEST_TIME[i].ToString("F3");
                        listView1.Items[i].SubItems[16].Text = GlobeVal.myarm.MyTransferData.LOOP_COUNT[i].ToString();//循环个数
                        listView1.Items[i].SubItems[17].Text = GlobeVal.myarm.MyTransferData.CYCLE_COUNT[i].ToString();//波形次数
                    }
                    else
                    {
                        listView1.Items[i].SubItems[3].Text = "";
                        listView1.Items[i].SubItems[4].Text = "";
                        listView1.Items[i].SubItems[5].Text = "";
                        listView1.Items[i].SubItems[6].Text = "";
                        listView1.Items[i].SubItems[7].Text = "";
                        listView1.Items[i].SubItems[8].Text = "";
                        listView1.Items[i].SubItems[9].Text = "";
                        listView1.Items[i].SubItems[10].Text = "";//试验温度设定值
                        listView1.Items[i].SubItems[11].Text = "";//温度上
                        listView1.Items[i].SubItems[12].Text = "";//温度中
                        listView1.Items[i].SubItems[13].Text = "";//温度下
                        listView1.Items[i].SubItems[14].Text = "";//温度梯度
                        listView1.Items[i].SubItems[15].Text = "";
                        listView1.Items[i].SubItems[16].Text = "";//循环个数
                        listView1.Items[i].SubItems[17].Text = "";//波形次数
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmachine_Click(object sender, EventArgs e)
        {
            GlobeVal.selcontroller = cbomachine.SelectedIndex + 1;
            ClsStaticStation.m_Global.currentmachineId = GlobeVal.selcontroller - 1;





            (Application.OpenForms["FormMainLab"] as FormMainLab).lblcontroller.Text = GlobeVal.selcontroller.ToString().Trim();

            if (Directory.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + GlobeVal.selcontroller.ToString().Trim() + "\\") == false)
            {
                Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + GlobeVal.selcontroller.ToString().Trim() + "\\");
            }

            if (Directory.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + GlobeVal.selcontroller.ToString().Trim() + "\\sys\\") == false)
            {
                Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + GlobeVal.selcontroller.ToString().Trim() + "\\sys\\");
            }
            if (Directory.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + GlobeVal.selcontroller.ToString().Trim() + "\\para\\") == false)
            {
                Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + GlobeVal.selcontroller.ToString().Trim() + "\\para\\");
            }



            string f1 = System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + GlobeVal.selcontroller.ToString().Trim() + "\\sys\\setup.ini";

            if (File.Exists(f1) == false)
            {
                GlobeVal.mysys.SerializeNow(f1);

            }

            GlobeVal.mysys = GlobeVal.mysys.DeSerializeNow(f1);



            string f2 = System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + GlobeVal.selcontroller.ToString().Trim() + "\\para\\方法.dat";






            if (File.Exists(f2) == false)
            {
                CComLibrary.GlobeVal.filesave.SerializeNow(f2);
            }

            CComLibrary.GlobeVal.filesave = CComLibrary.GlobeVal.filesave.DeSerializeNow(f2);



            GlobeVal.userControlmethod1.OpenTheMethodSilently(f2);

            GlobeVal.userControltest1.changeUI();
            GlobeVal.userControltest1.InitButtons();

            ((FormMainLab)Application.OpenForms["FormMainLab"]).InitKey();
            ((FormMainLab)Application.OpenForms["FormMainLab"]).InitMeter();


            GlobeVal.myarm.sendfilename(f2);

           GlobeVal.myarm.machinekind[GlobeVal.selcontroller-1]= ClsStaticStation.m_Global.mycls.TestkindList[CComLibrary.GlobeVal.filesave.methodkind];

            

        }

        private void UserGroupControl_Load(object sender, EventArgs e)
        {
            lstspe.Dock = DockStyle.Fill;
            lstspe.ShowPointer = false;
            lstspe.ShowAll = false;
            lstspe.Text = "";
            lstspe.CreateGeneralCategory = false;
            lstspe.DrawTabLevel = false;
            lstspe.AllowNestedTabs = true;
            lstspe.AllowToolboxItems = true ;
            panel4.Controls.Add(lstspe);
            
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            GlobeVal.selcontroller = cbomachine.SelectedIndex + 1;
            ClsStaticStation.m_Global.currentmachineId = GlobeVal.selcontroller - 1;
            (Application.OpenForms["FormMainLab"] as FormMainLab).lblcontroller.Text = GlobeVal.selcontroller.ToString().Trim();


            if (GlobeVal.myarm.MyTransferData.EDC_STATE[GlobeVal.selcontroller - 1] == Convert.ToInt16(ClsStaticStation.modMain.EDC_State.EDC_STATE_TEST))

            {
                MessageBox.Show("试验进行中,请先结束试验");
                return;
            }

                UserControlMain c = GlobeVal.FormmainLab.umain;


            c.OpenTest();

            (Application.OpenForms["FormMainLab"] as FormMainLab).tabControl1.SelectedIndex = 1;

          
        }
    }


}
