﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using CustomControls.OS;

namespace TabHeaderDemo
{
    public partial class UserControl轴向 : UserControl
    {
        private List<int> mlistbox1 = new List<int>();
        private void drawFigure(PaintEventArgs e, PointF[] points)
        {
            GraphicsPath path = new GraphicsPath();


            Corners r = new Corners(points, 5);
            r.Execute(path);
            path.CloseFigure();
            Matrix matrix = new Matrix();
            matrix.Translate(3, 3);
            path.Transform(matrix);





            Color c = (this.imageList3.Images[0] as Bitmap).GetPixel((this.imageList3.Images[0] as Bitmap).Width - 5, (this.imageList3.Images[0] as Bitmap).Height / 2);



            drawPath(e, path, c);

            path.Reset();
            r = new Corners(points, 5);
            r.Execute(path);
            path.CloseFigure();
            matrix = new Matrix();
            matrix.Translate(0, 0);
            path.Transform(matrix);

            c = (this.imageList3.Images[0] as Bitmap).GetPixel(this.imageList3.Images[0].Width / 2, this.imageList3.Images[0].Height / 2);

            

            panel3.BackColor = c;
            drawPath(e, path, c);

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
        public UserControl轴向()
        {
            InitializeComponent();
            cboctrl.Items.Clear();

            mlistbox1.Clear();
        
          


            for (int i = 0; i < ClsStaticStation.m_Global.mycls.chsignals.Count; i++)
            {
                if ((ClsStaticStation.m_Global.mycls.chsignals[i].SensorId == 0) && (ClsStaticStation.m_Global.mycls.chsignals[i].ClosedControl == true))
                {
                    cboctrl.Items.Add(ClsStaticStation.m_Global.mycls.chsignals[i].cName);
                    mlistbox1.Add(i);
                }
            }

            if (cboctrl.Items.Count > 0)
            {
                cboctrl.SelectedIndex = 0;
            }

            
            //Application.StartupPath

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲



            this.tableLayoutPanel1.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel1, true, null);
            this.tableLayoutPanel4.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel4, true, null);

         
            this.tableLayoutPanel8.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel8, true, null);
          

            this.tableLayoutPanel11.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel11, true, null);

            this.tableLayoutPanel9.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel9, true, null);
            this.tableLayoutPanel10.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel10, true, null);

        
        

        }

     
      
        public void DelayS(double t)
        {
            double m = Environment.TickCount;

            while ((Environment.TickCount - m) / 1000 <= t)
            {
                Application.DoEvents();
            }


        }

        

        private void btnup_Click(object sender, EventArgs e)
        {
            GlobeVal.myarm.CrossUp(mlistbox1[cboctrl.SelectedIndex], numericEdit1.Value);
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            GlobeVal.myarm.CrossDown(mlistbox1[cboctrl.SelectedIndex], numericEdit1.Value);
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            GlobeVal.myarm.CrossStop(mlistbox1[cboctrl.SelectedIndex]);
         }


        
        private void btnstart_Click(object sender, EventArgs e)
        {

            GlobeVal.myarm.DestStart(mlistbox1[cboctrl.SelectedIndex], numericEdit2.Value, numericEdit1.Value);
        }

        private void btnend_Click(object sender, EventArgs e)
        {

            GlobeVal.myarm.DestStop(mlistbox1[cboctrl.SelectedIndex]);
        }

     

        private void UserControl轴向_Paint(object sender, PaintEventArgs e)
        {
            return;

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
            roundedRectangle[0].X = 1;
            roundedRectangle[0].Y = 0;
            roundedRectangle[1].X = this.Width - 2 - 3;
            roundedRectangle[1].Y = 0;
            roundedRectangle[2].X = this.Width - 2 - 3;
            roundedRectangle[2].Y = this.Height - 2 - 3;
            roundedRectangle[3].X = 1;
            roundedRectangle[3].Y = this.Height - 2 - 3;
            roundedRectangle[4].X = 1;
            roundedRectangle[4].Y = 0;
            drawFigure(e, roundedRectangle);



            e.Graphics.EndContainer(containerState);
        }

    
        private void UserControl轴向_Load(object sender, EventArgs e)
        {
           

           

            btnup.Text = GlobeVal.mysys.lbl_up;
            btnstop.Text = GlobeVal.mysys.lbl_stop;
            btndown.Text = GlobeVal.mysys.lbl_down;
            btnstart.Text = GlobeVal.mysys.lbl_start;
            btnend.Text = GlobeVal.mysys.lbl_end;

        }

        private void cboctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboctrl.SelectedIndex >= 0)
            {

                lblunit.Text = ClsStaticStation.m_Global.mycls.chsignals[mlistbox1[cboctrl.SelectedIndex]].cUnits[0] + "/min";
                lblmunit.Text = ClsStaticStation.m_Global.mycls.chsignals[mlistbox1[cboctrl.SelectedIndex]].cUnits[0];
               
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Frm.FormPanelSet f = new Frm.FormPanelSet();
            f.ShowDialog();
        }


        private void btnfindzero_Click(object sender, EventArgs e)
        {
            GlobeVal.myarm.findzero(1);
        }

    }
}
