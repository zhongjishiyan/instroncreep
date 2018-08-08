using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TabHeaderDemo
{
    public partial class UserGroupControl: UserControl
    {
        
        
 
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
            listView1.Columns[1].Width = 40;
            listView1.Columns.Add("状态");

            listView1.Columns[2].Width = 40;

            listView1.Columns.Add("控制值");
            listView1.Columns[3].Width = 60;

            listView1.Columns.Add("负荷[kN]");
            listView1.Columns[4].Width = 60;

            listView1.Columns.Add("位移[mm]");
            listView1.Columns[5].Width = 60;

            listView1.Columns.Add("变形A[mm]");
            listView1.Columns[6].Width = 70;

            listView1.Columns.Add("变形B[mm]");
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
            for (int i = 0; i < GlobeVal.mysys.ControllerCount; i++)
            {
                m = new IP.Components.Toolbox.Item();
                m.Text = "主机"+(i+1).ToString();

                m.Image = imageList4.Images[0];
                lstspe.Items.Add(m);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = (i+1).ToString();

                for (int j = 0; j < 17; j++)
                {
                    lvi.SubItems.Add("");
                }
                

                listView1.Items.Add(lvi);

             }

            
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

           
        }

      

       

        public void methodon(String t, String parent)
        {
          

        }

       
        private void UserManage_Load(object sender, EventArgs e)
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
            roundedRectangle[0].Y = 3;
            roundedRectangle[1].X = this.Width - 2 - 3;
            roundedRectangle[1].Y = 3;
            roundedRectangle[2].X = this.Width - 2 - 3;
            roundedRectangle[2].Y = this.Height - 2 - 3;
            roundedRectangle[3].X = 1;
            roundedRectangle[3].Y = this.Height - 2 - 3;
            roundedRectangle[4].X = 1;
            roundedRectangle[4].Y = 8;
            drawFigure(e, roundedRectangle);

            //e.Graphics.EndContainer(containerState);

            //containerState = e.Graphics.BeginContainer();
            //e.Graphics.PageUnit = System.Drawing.GraphicsUnit.Pixel;
            //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //e.Graphics.Clear(Color.White);



            roundedRectangle = new PointF[5];
            roundedRectangle[0].X = lstspe .Left - 15;
            roundedRectangle[0].Y = lstspe.Top+10;
            roundedRectangle[1].X = lstspe.Right;
            roundedRectangle[1].Y = lstspe.Top+10;
            roundedRectangle[2].X = lstspe.Right;
            roundedRectangle[2].Y = roundedRectangle[0].Y + (lstspe.Bottom - lstspe .Top);
            roundedRectangle[3].X = lstspe.Left - 15;
            roundedRectangle[3].Y = roundedRectangle[0].Y + (lstspe .Bottom - lstspe.Top);
            roundedRectangle[4].X = lstspe.Left - 15;
            roundedRectangle[4].Y = lstspe.Top+10;
            drawFigure1(e, roundedRectangle);

            e.Graphics.EndContainer(containerState);

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (GlobeVal.myarm.connected ==true)
            {

               
                for (int i=0;i<listView1.Items.Count;i++)
                {
                    listView1.Items[i].SubItems[1].Text = GlobeVal.myarm.MyTransferData.Id[i].ToString();
                    listView1.Items[i].SubItems[2].Text = GlobeVal.myarm.MyTransferData.State[i].ToString();
                    listView1.Items[i].SubItems[3].Text = GlobeVal.myarm.MyTransferData.ControlValue[i].ToString();
                    listView1.Items[i].SubItems[4].Text = GlobeVal.myarm.MyTransferData.load[i].ToString();
                    listView1.Items[i].SubItems[5].Text = GlobeVal.myarm.MyTransferData.pos[i].ToString();
                    listView1.Items[i].SubItems[6].Text = GlobeVal.myarm.MyTransferData.extA[i].ToString();
                    listView1.Items[i].SubItems[7].Text = GlobeVal.myarm.MyTransferData.extB[i].ToString();
                    listView1.Items[i].SubItems[8].Text = GlobeVal.myarm.MyTransferData.extAve[i].ToString();
                    listView1.Items[i].SubItems[9].Text = GlobeVal.myarm.MyTransferData.unbalancedness[i].ToString();
                    listView1.Items[i].SubItems[10].Text = GlobeVal.myarm.MyTransferData.Temperaturecontrol[i].ToString();
                    listView1.Items[i].SubItems[11].Text = GlobeVal.myarm.MyTransferData.Temperature1[i].ToString();
                    listView1.Items[i].SubItems[12].Text = GlobeVal.myarm.MyTransferData.Temperature2[i].ToString();
                    listView1.Items[i].SubItems[13].Text = GlobeVal.myarm.MyTransferData.Temperature3[i].ToString();
                    listView1.Items[i].SubItems[14].Text = GlobeVal.myarm.MyTransferData.temperaturegradient[i].ToString();
                    listView1.Items[i].SubItems[15].Text = GlobeVal.myarm.MyTransferData.testtime[i].ToString();
                    listView1.Items[i].SubItems[16].Text = GlobeVal.myarm.MyTransferData.wavecount[i].ToString();
                    listView1.Items[i].SubItems[17].Text = GlobeVal.myarm.MyTransferData.cycliccount[i].ToString();

                }
            }
        }
    }
}
