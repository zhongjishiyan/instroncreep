﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using CustomControls.OS;
using CustomControls.Controls;
namespace TabHeaderDemo
{
    public partial class UserControlMethod : UserControl
    {
        private int linesPrinted;
        private string[] lines;

        private UserControl试样 UserControl试样1;
        private UserControl常规 UserControl常规1;
        private UserControl控制 UserControl控制1;
        private UserControl计算 UserControl计算1;
        private UserControl结果 UserControl结果1;
        
        private UserControl控制台 UserControl控制台1;
        private UserControl额外显示 UserControl额外显示1;
        private UserControl曲线 UserControl曲线1;
        private UserControl曲线 UserControl曲线2;
        private UserControl原始数据 UserControl原始数据1;
        private UserControl文件设置 UserControl文件设置1;
        private UserControl缺省表格 UserControl缺省表格1;
        private UserControl数据库 UserControl数据库1;
        private UserControl摄像 UserControl摄像1;
        private UserControl长时数据 UserControl长时数据1;



        private string mmethodfilename;
        private void drawFigure(PaintEventArgs e, PointF[] points)
        {
            GraphicsPath path = new GraphicsPath();


            Corners r = new Corners(points, 5);
            r.Execute(path);
            path.CloseFigure();
            Matrix matrix = new Matrix();
            matrix.Translate(3, 3);
            path.Transform(matrix);



            Color c = (imageList3.Images[0] as Bitmap).GetPixel(imageList3.Images[0].Width - 5, imageList3.Images[0].Height / 2);
            

           
            drawPath(e, path, c);

            path.Reset();
            r = new Corners(points, 5);
            r.Execute(path);
            path.CloseFigure();
            matrix = new Matrix();
            matrix.Translate(0, 0);
            path.Transform(matrix);

            c = (imageList3.Images[0] as Bitmap) .GetPixel(imageList3.Images[0].Width / 2, imageList3.Images[0].Height / 2);

            if (treeView1 == null)
            {
            }
            else
            {
                if (c.Name == "0")
                {
                }
                else
                {
                    treeView1.BackColor = c;
                }
            }

            panelbutton.BackColor = c;

          

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
        public UserControlMethod()
        {
            InitializeComponent();
            treeView1.mimagelist = imageList2;

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲

            this.tableLayoutPanel1.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel1, true, null);
            this.tableLayoutPanel2.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel2, true, null);
            this.tableLayoutPanel3.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel3, true, null);


            UserControl试样1 = new UserControl试样();
            UserControl常规1 = new UserControl常规();
            UserControl控制1 = new UserControl控制();
            UserControl计算1 = new UserControl计算();
            UserControl结果1 = new UserControl结果();
           
            UserControl控制台1 = new UserControl控制台();
            UserControl额外显示1 = new UserControl额外显示();
            UserControl曲线1 = new UserControl曲线();
            UserControl曲线2 = new UserControl曲线();
            UserControl原始数据1 = new UserControl原始数据();
            UserControl文件设置1 = new UserControl文件设置();
            UserControl缺省表格1 = new UserControl缺省表格();
            UserControl数据库1 = new UserControl数据库();
            UserControl摄像1 = new UserControl摄像();
            UserControl长时数据1 = new UserControl长时数据();

            UserControl试样1.musercontrolmethod = this;
            UserControl常规1.musercontrolmethod = this;
            UserControl控制1.musercontrolmethod = this;
            UserControl计算1.musercontrolmethod = this;
            UserControl结果1.musercontrolmethod = this;
        
            UserControl控制台1.musercontrolmethod = this;
            UserControl额外显示1.musercontrolmethod = this;
            UserControl曲线1.musercontrolmethod = this;
            UserControl曲线2.musercontrolmethod = this;
            UserControl原始数据1.musercontrolmethod = this;
            UserControl文件设置1.musercontrolmethod = this;
            UserControl缺省表格1.musercontrolmethod = this;
            UserControl数据库1.musercontrolmethod = this;
            UserControl摄像1.musercontrolmethod = this;
            UserControl长时数据1.musercontrolmethod = this;

            UserControl常规1.Init(0,false);
            panelback.Visible = false;
            panelback.Controls.Clear();
            UserControl常规1.Dock = DockStyle.Fill;
            panelback.Controls.Add(UserControl常规1);
            panelback.Visible = true;
           
            
        }

        private void UserControl5_Paint(object sender, PaintEventArgs e)
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

            if (GlobeVal.UserControlMain1.btnmtest.Visible==true)
            {
                if (CComLibrary.GlobeVal.filesave.mcontrolprocess != 2)
                {
                    panelbutton.Visible = true;

                    btnexopen.Visible = true;

                    btnexsave1.Visible = true;

                    btnexsaveclose.Visible = false;

                    btnexsave.Visible = false;

                    btnsaveas.Visible = false;

                    btnexprint.Visible = false;


                    // InitTree();
                    // treeView1.Visible = false;

                   // treeView1.SelectedNode = treeView1.Nodes["控制"].Nodes["测试"];

                }
                else
                {
                    //InitTree();
                    panelbutton.Visible = true;
                   // treeView1.Visible = true;

                    btnexopen.Visible = false;

                    btnexsave1.Visible = false;

                    btnexsaveclose.Visible = true;

                    btnexsave.Visible = true;

                    btnsaveas.Visible = true;

                    btnexprint.Visible = true;

                }
            }
            else
            {
                panelbutton.Visible = true;
                treeView1.Visible = true;

                btnexopen.Visible = false;

                btnexsave1.Visible = false;

                btnexsaveclose.Visible = true;

                btnexsave.Visible = true ;

                btnsaveas.Visible = true;

                btnexprint.Visible = true;
            }
        }

       

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
               
            }
            else
            {
                treeView1.SelectedNode = e.Node.Nodes[0];
                
                methodon(e.Node.Nodes[0].Text,e.Node.Text);
            }
        }

        public void methodon(String t,String parent)
        {
            if (t == "方法")
            {

                UserControl常规1.Init(0,false);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl常规1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl常规1);
                panelback.Visible = true;
            }

            if (t == "样品")
            {

                UserControl常规1.Init(1,false);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl常规1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl常规1);
                panelback.Visible = true;
            }

            if (t == "基本布局")
            {

                UserControl常规1.Init(2,false);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl常规1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl常规1);
                panelback.Visible = true;
            }
            if (t == "高级布局")
            {

                UserControl常规1.Init(3,false );
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl常规1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl常规1);
                panelback.Visible = true;
            }


            if (t == "尺寸")
            {

                UserControl试样1.Init(0);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl试样1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl试样1);
                panelback.Visible = true;

            }
            if (t == "数字输入")
            {

                UserControl试样1.Init(1);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl试样1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl试样1);
                panelback.Visible = true;

            }

            if (t == "文本输入")
            {

                UserControl试样1.Init(2);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl试样1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl试样1);
                panelback.Visible = true;

            }

            if (t == "选项输入")
            {

                UserControl试样1.Init(3);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl试样1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl试样1);
                panelback.Visible = true;

            }

            if (t == "测试")
            {
                UserControl控制1.Visible = false;
				if (CComLibrary.GlobeVal.filesave.mcontrolprocess == 0)
				{
					UserControl控制1.Init(3);
				}
				else if (CComLibrary.GlobeVal.filesave.mcontrolprocess == 1)
				{
					
                    UserControl控制1.Init(6);
				}

				else if (CComLibrary.GlobeVal.filesave.mcontrolprocess == 2)
				{
					UserControl控制1.Init(7);
				}
                else if (CComLibrary.GlobeVal.filesave.mcontrolprocess == 3)
                {
                    UserControl控制1.Init(8);
                }
                else if(CComLibrary.GlobeVal.filesave.mcontrolprocess ==4 )
                {
                    UserControl控制1.Init(9);
                }

                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl控制1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl控制1);
                panelback.Visible = true;
                UserControl控制1.Visible = true;
            }

            if (t == "测试前")
            {
               
                UserControl控制1.Init(2);
               
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl控制1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl控制1);
                panelback.Visible = true;
            }
            if (t == "测试结束")
            {
                UserControl控制1.Init(4);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl控制1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl控制1);
                panelback.Visible = true;
            }
            if (t == "数据采集")
            {
                UserControl控制1.Init(5);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl控制1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl控制1);
                panelback.Visible = true;
            }
            if (t == "应变")
            {
                UserControl控制1.Init(1);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl控制1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl控制1);
                panelback.Visible = true;
            }
            if (t == "试验选项")
            {
                UserControl控制1.Init(0);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl控制1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl控制1);
                panelback.Visible = true;
            }

            if (t == "设定")
            {
                UserControl计算1.Init();
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl计算1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl计算1);
                panelback.Visible = true;
            }

            if (t == "列")
            {
                if (parent == "结果1")
                {
                    UserControl结果1.resulttab = 0;
                }

                if (parent == "结果2")
                {
                    UserControl结果1.resulttab = 1;
                }
                UserControl结果1.Init(0);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl结果1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl结果1);
                panelback.Visible = true;
            }
            if (t == "统计")
            {
                if (parent == "结果1")
                {
                    UserControl结果1.resulttab = 0;
                }

                if (parent == "结果2")
                {
                    UserControl结果1.resulttab = 1;
                }
                UserControl结果1.Init(1);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl结果1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl结果1);
                panelback.Visible = true;
            }
            if (t == "格式")
            {
                if (parent == "结果1")
                {
                    UserControl结果1.resulttab = 0;
                }

                if (parent == "结果2")
                {
                    UserControl结果1.resulttab = 1;
                }
                UserControl结果1.Init(2);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl结果1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl结果1);
                panelback.Visible = true;
            }


           
           

            if (t == "实时显示")
            {
                UserControl控制台1.Init(0);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl控制台1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl控制台1);
                panelback.Visible = true;
            }
            if (t == "按键")
            {
                UserControl控制台1.Init(1);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl控制台1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl控制台1);
                panelback.Visible = true;
            }
            if (t == "主机")
            {
                UserControl控制台1.Init(2);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl控制台1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl控制台1);
                panelback.Visible = true;
            }

            if (t == "电表设置")
            {

                UserControl额外显示1.Init(0);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl额外显示1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl额外显示1);
                panelback.Visible = true;
            }
            if (t == "操作输入")
            {

                UserControl额外显示1.Init(1);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl额外显示1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl额外显示1);
                panelback.Visible = true;
            }


            if (t == "类型")
            {
                if (parent == "曲线图1")
                {
                    UserControl曲线1.curvetab = 0;
                    UserControl曲线1.Init(0);
                    panelback.Visible = false;
                    panelback.Controls.Clear();
                    UserControl曲线1.Dock = DockStyle.Fill;
                    panelback.Controls.Add(UserControl曲线1);
                    panelback.Visible = true;
                }
                if (parent == "曲线图2")
                {
                    UserControl曲线2.curvetab = 1;
                    UserControl曲线2.Init(0);
                    panelback.Visible = false;
                    panelback.Controls.Clear();
                    UserControl曲线2.Dock = DockStyle.Fill;
                    panelback.Controls.Add(UserControl曲线2);
                    panelback.Visible = true;
                }
            }

            if (t == "X轴数据")
            {
                if (parent == "曲线图1")
                {
                    UserControl曲线1.Init(1);
                    panelback.Visible = false;
                    panelback.Controls.Clear();
                    UserControl曲线1.Dock = DockStyle.Fill;
                    panelback.Controls.Add(UserControl曲线1);
                    panelback.Visible = true;
                }
                if (parent == "曲线图2")
                {
                    UserControl曲线2.Init(1);
                    panelback.Visible = false;
                    panelback.Controls.Clear();
                    UserControl曲线2.Dock = DockStyle.Fill;
                    panelback.Controls.Add(UserControl曲线2);
                    panelback.Visible = true;
                }
            }
            if (t == "Y轴数据")
            {
                if (parent == "曲线图1")
                {
                    UserControl曲线1.Init(2);
                    panelback.Visible = false;
                    panelback.Controls.Clear();
                    UserControl曲线1.Dock = DockStyle.Fill;
                    panelback.Controls.Add(UserControl曲线1);
                    panelback.Visible = true;
                }
                if (parent == "曲线图2")
                {
                    UserControl曲线2.Init(2);
                    panelback.Visible = false;
                    panelback.Controls.Clear();
                    UserControl曲线2.Dock = DockStyle.Fill;
                    panelback.Controls.Add(UserControl曲线2);
                    panelback.Visible = true;
                }
            }

            if (t == "高级")
            {
                if (parent == "曲线图1")
                {
                    UserControl曲线1.Init(3);
                    panelback.Visible = false;
                    panelback.Controls.Clear();
                    UserControl曲线1.Dock = DockStyle.Fill;
                    panelback.Controls.Add(UserControl曲线1);
                    panelback.Visible = true;
                }
                if (parent == "曲线图2")
                {
                    UserControl曲线2.Init(3);
                    panelback.Visible = false;
                    panelback.Controls.Clear();
                    UserControl曲线2.Dock = DockStyle.Fill;
                    panelback.Controls.Add(UserControl曲线2);
                    panelback.Visible = true;
                }
            }
            if (t=="摄像")
            {
                UserControl摄像1.Init(0);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl摄像1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl摄像1);
                panelback.Visible = true;

            }
            if (t == "原始数据输出")
            {
                UserControl原始数据1.Init(0);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl原始数据1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl原始数据1);
                panelback.Visible = true;

            }

            if (t=="数据库设置")
            {
                UserControl数据库1.Init(0);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl数据库1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl数据库1);
                panelback.Visible = true;
            }

            if (t=="峰值趋势数据输出")
            {
                UserControl长时数据1.Init(0);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl长时数据1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl长时数据1);
                panelback.Visible = true;
            }

            if (t == "文档设置")
            {
                
                UserControl文件设置1.Init(0);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl文件设置1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl文件设置1);
                panelback.Visible = true;

            }

            if (t == "缺省表格")
            {
                UserControl缺省表格1.Init(0);
                panelback.Visible = false;
                panelback.Controls.Clear();
                UserControl缺省表格1.Dock = DockStyle.Fill;
                panelback.Controls.Add(UserControl缺省表格1);
                panelback.Visible = true;
            }


        }
        private TreeNode FindNode(TreeNode tnParent, string strValue)
        {
            if (tnParent == null) return null;
            if (tnParent.Text == strValue) return tnParent;

            TreeNode tnRet = null;
            foreach (TreeNode tn in tnParent.Nodes)
            {
                tnRet = FindNode(tn, strValue);
                if (tnRet != null) break;
            }
            return tnRet;
        }

        public TreeNode TreeViewFindNode(string str)
        {
          return   FindNode(treeView1.Nodes[0], str);
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            
            if (e.Node.Parent ==null)
            {
                methodon(e.Node.Text, "");
            }
            else
            {
                methodon(e.Node.Text,e.Node.Parent.Text);
                treeView1.SelectedNode = e.Node;
               
            }


        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }


        private void UserControlMethod_Load(object sender, EventArgs e)
        {
          

        }

        public void OpenTheMethodSilently(string fileName)
        {
            
                mmethodfilename = fileName;
                UserControl常规1.txtmethodname.Text = Path.GetFileNameWithoutExtension(fileName);
                UserControl常规1.txtmethodpath.Text = Path.GetDirectoryName(fileName);

                if (CComLibrary.GlobeVal.filesave == null)
                {
                    CComLibrary.GlobeVal.filesave = new CComLibrary.FileStruct();
                }
                CComLibrary.GlobeVal.filesave = CComLibrary.GlobeVal.filesave.DeSerializeNow(fileName);
                CComLibrary.GlobeVal.currentfilesavename = fileName;
                UserControl常规1.Open_method();
                UserControl试样1.Open_method();
                UserControl计算1.Open_method();
                this.treeView1.CollapseAll();
                this.treeView1.SelectedNode = this.treeView1.Nodes[0].Nodes[0];
                methodon(this.treeView1.Nodes[0].Nodes[0].Text, this.treeView1.Nodes[0].Text);

                CComLibrary.GlobeVal.InitUserCalcChannel();
            
            
        }
        public void InitTree1()
        {
            treeView1.Nodes.Clear();
            

            treeView1.Nodes.Add("试样", "试样");
            treeView1.Nodes["试样"].StateImageIndex = 1;

            treeView1.Nodes["试样"].Nodes.Add("尺寸");
            treeView1.Nodes["试样"].Nodes.Add("数字输入");
            treeView1.Nodes["试样"].Nodes.Add("文本输入");
            treeView1.Nodes["试样"].Nodes.Add("选项输入");
            treeView1.Nodes.Add("控制", "控制");
            treeView1.Nodes["控制"].StateImageIndex = 2;

            treeView1.Nodes["控制"].Nodes.Add("试验选项");
            treeView1.Nodes["控制"].Nodes.Add("应变");
            //  treeView1.Nodes[2].Nodes.Add("测试前");
            treeView1.Nodes["控制"].Nodes.Add("测试");
            treeView1.Nodes["控制"].Nodes.Add("数据采集");
            treeView1.Nodes["控制"].Nodes.Add("测试结束");
            if (CComLibrary.GlobeVal.filesave._flow计算和结果 == true)
            {
                treeView1.Nodes.Add("计算", "计算");
                treeView1.Nodes["计算"].StateImageIndex = 3;

                treeView1.Nodes["计算"].Nodes.Add("设定");
            }

           

            if (CComLibrary.GlobeVal.filesave._flow计算和结果 == true)
            {
                treeView1.Nodes.Add("结果1", "结果1");
                treeView1.Nodes["结果1"].StateImageIndex = 4;
                treeView1.Nodes["结果1"].Nodes.Add("列");
                treeView1.Nodes["结果1"].Nodes.Add("统计");
                treeView1.Nodes["结果1"].Nodes.Add("格式");
            }
            if (CComLibrary.GlobeVal.filesave._flow计算和结果 == true)
            {
                treeView1.Nodes.Add("结果2", "结果2");
                treeView1.Nodes["结果2"].StateImageIndex = 5;
                treeView1.Nodes["结果2"].Nodes.Add("列");
                treeView1.Nodes["结果2"].Nodes.Add("统计");
                treeView1.Nodes["结果2"].Nodes.Add("格式");
            }
            treeView1.Nodes.Add("曲线图1", "曲线图1");
            treeView1.Nodes["曲线图1"].StateImageIndex = 6;

            treeView1.Nodes["曲线图1"].Nodes.Add("类型");
            treeView1.Nodes["曲线图1"].Nodes.Add("X轴数据");
            treeView1.Nodes["曲线图1"].Nodes.Add("Y轴数据");
            treeView1.Nodes["曲线图1"].Nodes.Add("高级");
            treeView1.Nodes.Add("曲线图2", "曲线图2");

            treeView1.Nodes["曲线图2"].StateImageIndex = 7;
            treeView1.Nodes["曲线图2"].Nodes.Add("类型");
            treeView1.Nodes["曲线图2"].Nodes.Add("X轴数据");
            treeView1.Nodes["曲线图2"].Nodes.Add("Y轴数据");
            treeView1.Nodes["曲线图2"].Nodes.Add("高级");
            treeView1.Nodes.Add("其它显示", "其它显示");

            treeView1.Nodes["其它显示"].StateImageIndex = 14;
            treeView1.Nodes["其它显示"].Nodes.Add("电表设置");
            treeView1.Nodes["其它显示"].Nodes.Add("操作输入");
            treeView1.Nodes["其它显示"].Nodes.Add("摄像");
            treeView1.Nodes.Add("报告", "报告");
            treeView1.Nodes["报告"].StateImageIndex = 9;
            treeView1.Nodes["报告"].Nodes.Add("文档设置");
            treeView1.Nodes["报告"].Nodes.Add("原始数据输出");
            treeView1.Nodes["报告"].Nodes.Add("数据库设置");
            treeView1.Nodes["报告"].Nodes.Add("峰值趋势数据输出");
        }
        public void  InitTree()
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add("常规", "常规");
            treeView1.Nodes["常规"].StateImageIndex = 0;



            treeView1.Nodes["常规"].Nodes.Add("方法");
            treeView1.Nodes["常规"].Nodes.Add("样品");
            treeView1.Nodes["常规"].Nodes.Add("基本布局");
            treeView1.Nodes["常规"].Nodes.Add("高级布局");


            treeView1.Nodes.Add("试样", "试样");
            treeView1.Nodes["试样"].StateImageIndex = 1;

            treeView1.Nodes["试样"].Nodes.Add("尺寸");
            treeView1.Nodes["试样"].Nodes.Add("数字输入");
            treeView1.Nodes["试样"].Nodes.Add("文本输入");
            treeView1.Nodes["试样"].Nodes.Add("选项输入");
            treeView1.Nodes.Add("控制", "控制");
            treeView1.Nodes["控制"].StateImageIndex = 2;

            treeView1.Nodes["控制"].Nodes.Add("试验选项", "试验选项");
            treeView1.Nodes["控制"].Nodes.Add("应变", "应变");
            //  treeView1.Nodes[2].Nodes.Add("测试前");
            treeView1.Nodes["控制"].Nodes.Add("测试", "测试");
            treeView1.Nodes["控制"].Nodes.Add("数据采集", "数据采集");
            treeView1.Nodes["控制"].Nodes.Add("测试结束", "测试结束");
            if (CComLibrary.GlobeVal.filesave._flow计算和结果 == true)
            {
                treeView1.Nodes.Add("计算", "计算");
                treeView1.Nodes["计算"].StateImageIndex = 3;

                treeView1.Nodes["计算"].Nodes.Add("设定");
            }

            treeView1.Nodes.Add("控制台", "控制台");
            treeView1.Nodes["控制台"].StateImageIndex = 13;

            treeView1.Nodes["控制台"].Nodes.Add("实时显示");
            treeView1.Nodes["控制台"].Nodes.Add("按键");
            treeView1.Nodes["控制台"].Nodes.Add("主机");

            if (CComLibrary.GlobeVal.filesave._flow计算和结果 == true)
            {
                treeView1.Nodes.Add("结果1", "结果1");
                treeView1.Nodes["结果1"].StateImageIndex = 4;
                treeView1.Nodes["结果1"].Nodes.Add("列");
                treeView1.Nodes["结果1"].Nodes.Add("统计");
                treeView1.Nodes["结果1"].Nodes.Add("格式");
            }
            if (CComLibrary.GlobeVal.filesave._flow计算和结果 == true)
            {
                treeView1.Nodes.Add("结果2", "结果2");
                treeView1.Nodes["结果2"].StateImageIndex = 5;
                treeView1.Nodes["结果2"].Nodes.Add("列");
                treeView1.Nodes["结果2"].Nodes.Add("统计");
                treeView1.Nodes["结果2"].Nodes.Add("格式");
            }
            treeView1.Nodes.Add("曲线图1", "曲线图1");
            treeView1.Nodes["曲线图1"].StateImageIndex = 6;

            treeView1.Nodes["曲线图1"].Nodes.Add("类型");
            treeView1.Nodes["曲线图1"].Nodes.Add("X轴数据");
            treeView1.Nodes["曲线图1"].Nodes.Add("Y轴数据");
            treeView1.Nodes["曲线图1"].Nodes.Add("高级");
            treeView1.Nodes.Add("曲线图2", "曲线图2");

            treeView1.Nodes["曲线图2"].StateImageIndex = 7;
            treeView1.Nodes["曲线图2"].Nodes.Add("类型");
            treeView1.Nodes["曲线图2"].Nodes.Add("X轴数据");
            treeView1.Nodes["曲线图2"].Nodes.Add("Y轴数据");
            treeView1.Nodes["曲线图2"].Nodes.Add("高级");
            treeView1.Nodes.Add("其它显示", "其它显示");

            treeView1.Nodes["其它显示"].StateImageIndex = 14;
            treeView1.Nodes["其它显示"].Nodes.Add("电表设置");
            treeView1.Nodes["其它显示"].Nodes.Add("操作输入");
            treeView1.Nodes["其它显示"].Nodes.Add("摄像");
            treeView1.Nodes.Add("报告", "报告");
            treeView1.Nodes["报告"].StateImageIndex = 9;
            treeView1.Nodes["报告"].Nodes.Add("文档设置");
            treeView1.Nodes["报告"].Nodes.Add("原始数据输出");
            treeView1.Nodes["报告"].Nodes.Add("数据库设置");
            treeView1.Nodes["报告"].Nodes.Add("峰值趋势数据输出");

        }
        public void OpenTheMethod(string fileName)
        {
            mmethodfilename = fileName; 
            UserControl常规1.txtmethodname.Text = Path.GetFileNameWithoutExtension(fileName);
            UserControl常规1.txtmethodpath.Text = Path.GetDirectoryName(fileName);

            GlobeVal.mmethodfilename = fileName;

            if (CComLibrary.GlobeVal.filesave == null)
            {
                CComLibrary.GlobeVal.filesave = new CComLibrary.FileStruct();
            }
            CComLibrary.GlobeVal.filesave = CComLibrary.GlobeVal.filesave.DeSerializeNow(fileName);
            if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\report\\" + CComLibrary.GlobeVal.filesave.ReportTemplate) == true)
            {

                GlobeVal.UserControlMain1.userreport1.mReportApp = GlobeVal.UserControlMain1.userreport1.mReportApp.DeSerializeNow(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\report\\" + CComLibrary.GlobeVal.filesave.ReportTemplate);

            }
            GlobeVal.filesavecmp = CComLibrary.GlobeVal.filesave.DeSerializeNow(fileName);


            InitTree();
      

            CComLibrary.GlobeVal.currentfilesavename = fileName;
            UserControl常规1.Open_method();
            UserControl试样1.Open_method();
            UserControl计算1.Open_method();
            this.treeView1.CollapseAll();
            this.treeView1.SelectedNode = this.treeView1.Nodes[0].Nodes[0];
            methodon(this.treeView1.Nodes[0].Nodes[0].Text, this.treeView1.Nodes[0].Text);
           

            CComLibrary.GlobeVal.InitUserCalcChannel();

            
            treeView1.Nodes["控制"].Nodes.Clear();

            if (CComLibrary.GlobeVal.filesave._flow试验选项 ==  CheckState.Checked)
            {
                treeView1.Nodes["控制"].Nodes.Add("试验选项");

            }

            if (CComLibrary.GlobeVal.filesave._flow应变 == CheckState.Checked)
            {
                treeView1.Nodes["控制"].Nodes.Add("应变");

            }

            if (CComLibrary.GlobeVal.filesave._flow测试前 == CheckState.Checked)
            {
                treeView1.Nodes["控制"].Nodes.Add("测试前");

            }

            if (CComLibrary.GlobeVal.filesave._flow测试 == CheckState.Checked)
            {
                treeView1.Nodes["控制"].Nodes.Add("测试");

            }

            if (CComLibrary.GlobeVal.filesave._flow数据采集 == CheckState.Checked)
            {
                treeView1.Nodes["控制"].Nodes.Add("数据采集");

            }

            if (CComLibrary.GlobeVal.filesave._flow测试结束 == CheckState.Checked)
            {
                treeView1.Nodes["控制"].Nodes.Add("测试结束");

            }

          



        }



        private void btnexopen_Click(object sender, EventArgs e)
        {
            CustomControls.MethodOpenFileDialog controlex = new CustomControls.MethodOpenFileDialog();
            controlex.StartLocation = AddonWindowLocation.Right;
            controlex.DefaultViewMode = FolderViewMode.Details;
            controlex.OpenDialog.InitialDirectory = System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\Method";
            controlex.OpenDialog.AddExtension = true;
            controlex.OpenDialog.Filter = "试验方法文件(*.dat)|*.dat";
            controlex.ShowDialog(this);
            if (controlex.OpenDialog.FileName == null)
            {

                return;
            }
            else
            {
                string fileName = controlex.OpenDialog.FileName;

                if (fileName == "")
                {
                    return;
                }
                else
                {
                    OpenTheMethod(fileName);

                    
                }

                ClsStaticStation.m_Global.mycls.initchannel();
                ((FormMainLab)Application.OpenForms["FormMainLab"]).InitKey();
                ((FormMainLab)Application.OpenForms["FormMainLab"]).InitMeter();

                string f = System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + GlobeVal.selcontroller.ToString().Trim() + "\\para\\方法.dat";

                if (System.IO.Directory.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device") == false)
                {
                    System.IO.Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device");
                }

                if (System.IO.Directory.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + GlobeVal.selcontroller.ToString().Trim()) == false)
                {
                    System.IO.Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + GlobeVal.selcontroller.ToString().Trim());
                }

                if (System.IO.Directory.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + GlobeVal.selcontroller.ToString().Trim() + "\\para") == false)
                {
                    System.IO.Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + GlobeVal.selcontroller.ToString().Trim() + "\\para");
                }
                GlobeVal.mmethodfilename = f;


                CComLibrary.GlobeVal.filesave.SegName = "方法.seg";

                CComLibrary.GlobeVal.filesave.SerializeNow(GlobeVal.mmethodfilename);

                f = System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + GlobeVal.selcontroller.ToString().Trim() + "\\seg\\方法.seg";
                if (System.IO.Directory.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + GlobeVal.selcontroller.ToString().Trim() + "\\seg") == false)
                {
                    System.IO.Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + GlobeVal.selcontroller.ToString().Trim() + "\\seg");
                }

                CComLibrary.SegFile sf=new CComLibrary.SegFile();



                sf = sf.DeSerializeNow(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\seg\\" + CComLibrary.GlobeVal.filesave.SegName);

                sf.SerializeNow(f);
                CComLibrary.GlobeVal.filesave.SegName = "方法.seg";


                // btnexopen.Visible = false;

                // buttonExNext.Visible = true;
            }
            controlex.Dispose();




        }

        private void btnexsave_Click(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.currentspenumber = 0;
            
            CComLibrary.GlobeVal.filesave.SerializeNow(GlobeVal.mmethodfilename);
            GlobeVal.filesavecmp = CComLibrary.GlobeVal.filesave.DeSerializeNow(GlobeVal.mmethodfilename); 
           ((FormMainLab)Application.OpenForms["FormMainLab"]).InitKey() ;
            ((FormMainLab)Application.OpenForms["FormMainLab"]).InitMeter();
        }

        private void panelback_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void btnsaveas_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.InitialDirectory = System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\Method";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "试验方法文件(*.dat)|*.dat";
            saveFileDialog1.ShowDialog(this);
            if ((saveFileDialog1.FileName == "") ||(saveFileDialog1.FileName ==null))
            {

               // CComLibrary.GlobeVal.filesave.SerializeNow(saveFileDialog1.FileName);

                return;
            }
            else
            {
                mmethodfilename = Path.GetFileName(saveFileDialog1.FileName);
                CComLibrary.GlobeVal.filesave.methodname = Path.GetFileNameWithoutExtension(saveFileDialog1.FileName);
                CComLibrary.GlobeVal.filesave.SerializeNow(saveFileDialog1.FileName);
              
                this.UserControl常规1.txtmethodname.Text = mmethodfilename;
            }

           
        }

        private void btnexsaveclose_Click(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.currentspenumber = 0;
          
            CComLibrary.GlobeVal.filesave.SerializeNow(mmethodfilename);
            GlobeVal.filesavecmp = CComLibrary.GlobeVal.filesave.DeSerializeNow(mmethodfilename);
            ((FormMainLab)Application.OpenForms["FormMainLab"]).InitKey();
            ((FormMainLab)Application.OpenForms["FormMainLab"]).InitMeter();
            ((TabControl)Application.OpenForms["FormMainLab"].Controls["tabcontrol1"]).SelectedIndex = 0;
        }

        private void UserControlMethod_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnexprint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            int i = 0;
            char[] param = { '\n' };

            ListBox ml = new ListBox();
            GlobeVal.putlistboxitem(ml);

            lines = new string[ml.Items.Count];

            for ( i=0;i<ml.Items.Count;i++)
            {
                lines[i] = Convert.ToString( ml.Items[i]);
            }
            

          
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            Brush brush = new SolidBrush(Color.Black);

            while (linesPrinted < lines.Length)
            {
                e.Graphics.DrawString(lines[linesPrinted++],
                    this.Font, brush, x, y);
                y += 15;
                if (y >= e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            linesPrinted = 0;
            e.HasMorePages = false;
        }

        private void buttonExNext_Click(object sender, EventArgs e)
        {
            methodon("测试", "控制");
            btnexopen.Visible = true;
            buttonExNext.Visible = false;

        }

        private void btnexsave1_Click(object sender, EventArgs e)
        {

        }
    }
}
