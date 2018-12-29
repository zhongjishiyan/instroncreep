using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System.Drawing.Imaging;

using System.IO;
using org.in2bits.MyXls;
using System.Runtime.InteropServices;
using CustomControls.OS;
using CustomControls.Controls;


namespace TabHeaderDemo
{
    public partial class UserControlAnalysis : UserControl
    {
        public UserControlSpe UserControlSpe1 = new UserControlSpe();

        class btnstep
        {
            public int novalid = 0;
            public int valid = 0;
            public int current = 0;


            public ButtonExNew btn;

            public btnstep()
            {

            }
        }







        public void ExportToExcel(DataTable dtSource, string strFileName)
        {
            XlsDocument xls = new XlsDocument();
            Worksheet sheet = xls.Workbook.Worksheets.Add("sheet1");
            int i = 0;

            //write data from datatable in Excel file 
            foreach (DataColumn column in dtSource.Columns)
            {
                sheet.Cells.Add(1, i + 1, column.ColumnName);
                i++;
            }
            for (int j = 0; j < dtSource.Rows.Count; j++)
            {
                for (int k = 0; k < dtSource.Columns.Count; k++)
                {
                    sheet.Cells.Add(j + 2, k + 1, dtSource.Rows[j][k].ToString());
                }
            }
            // save
            xls.FileName = strFileName;
            if (File.Exists(strFileName))
            {
                File.Delete(strFileName);
            }
            xls.Save();
        }


        public UserControlAnalysis()
        {
            InitializeComponent();

            lstspe.ItemMenu = contextMenuStrip1;

            lstspe.ContextMenuStrip = contextMenuStrip1;
            lstspe.TabMenu = null;




            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲

            this.tableLayoutPanel2.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel2, true, null);


            tableLayoutPanel8.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(tableLayoutPanel8, true, null);

            tableLayoutPanel9.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(tableLayoutPanel9, true, null);


            this.tableLayoutPanelback.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanelback, true, null);

            this.userControlGraph1.SetGraphStyle(1);        }


        private void button4_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("是否要使用相同的试样参数开始另外一个新样品？", "开始另外一个新样品？", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {

            }
            else
            {

            }
        }

        private void drawFigure(PaintEventArgs e, PointF[] points)
        {



            GraphicsPath path = new GraphicsPath();


            Corners r = new Corners(points, 5);
            r.Execute(path);
            path.CloseFigure();
            Matrix matrix = new Matrix();
            matrix.Translate(3, 3);
            path.Transform(matrix);



            System.Drawing.Color c = (imageList3.Images[0] as Bitmap).GetPixel(imageList3.Images[0].Width - 5, imageList3.Images[0].Height / 2);



            drawPath(e, path, c);

            path.Reset();
            r = new Corners(points, 5);
            r.Execute(path);
            path.CloseFigure();
            matrix = new Matrix();
            matrix.Translate(0, 0);
            path.Transform(matrix);

            c = (imageList3.Images[0] as Bitmap).GetPixel(imageList3.Images[0].Width / 2, imageList3.Images[0].Height / 2);


            drawPath(e, path, c);
            btnfinish.BackColor = c;


            btnfinish.FlatAppearance.MouseOverBackColor = c;
            btnfinish.FlatAppearance.MouseDownBackColor = c;
            btnfinish.FlatAppearance.CheckedBackColor = c;



            path.Dispose();
        }

        private static void drawPath(PaintEventArgs e, GraphicsPath path, System.Drawing.Color color)
        {
            LinearGradientBrush brush = new LinearGradientBrush(path.GetBounds(),
                color, color, LinearGradientMode.Horizontal);
            e.Graphics.FillPath(brush, path);
            Pen pen = new Pen(color, 1);
            e.Graphics.DrawPath(pen, path);

            brush.Dispose();
            pen.Dispose();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            if (this.DesignMode)
            {
                return;
            }

            GraphicsContainer containerState = e.Graphics.BeginContainer();
            tableLayoutPanelback.BackColor = System.Drawing.Color.Transparent;

            e.Graphics.PageUnit = System.Drawing.GraphicsUnit.Pixel;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.Clear(System.Drawing.Color.White);



            PointF[] roundedRectangle = new PointF[5];
            roundedRectangle[0].X = 8;
            roundedRectangle[0].Y = 3;
            roundedRectangle[1].X = this.pictureBox1.Width - 2 - 3;
            roundedRectangle[1].Y = 3;
            roundedRectangle[2].X = this.pictureBox1.Width - 2 - 3;
            roundedRectangle[2].Y = this.pictureBox1.Height - 2 - 3;
            roundedRectangle[3].X = 1;
            roundedRectangle[3].Y = this.pictureBox1.Height - 2 - 3;
            roundedRectangle[4].X = 1;
            roundedRectangle[4].Y = 8;
            drawFigure(e, roundedRectangle);

            //e.Graphics.EndContainer(containerState);

            //containerState = e.Graphics.BeginContainer();
            //e.Graphics.PageUnit = System.Drawing.GraphicsUnit.Pixel;
            //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //e.Graphics.Clear(Color.White);



            roundedRectangle = new PointF[5];
            roundedRectangle[0].X = 50 + splitContainer1.Left - 15;
            roundedRectangle[0].Y = 6 + splitContainer1.Top;
            roundedRectangle[1].X = 60 + splitContainer1.Right;
            roundedRectangle[1].Y = 6 + splitContainer1.Top;
            roundedRectangle[2].X = 60 + splitContainer1.Right;
            roundedRectangle[2].Y = roundedRectangle[0].Y + (panel8.Bottom - splitContainer1.Top - 6);
            roundedRectangle[3].X = splitContainer1.Left + 50 - 15;
            roundedRectangle[3].Y = roundedRectangle[0].Y + (panel8.Bottom - splitContainer1.Top - 6);
            roundedRectangle[4].X = splitContainer1.Left + 50 - 15;
            roundedRectangle[4].Y = splitContainer1.Top + 6;
            drawFigure1(e, roundedRectangle);

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







       

      

        public void lstspeRefresh()

        {
            lstspe.Items.Clear();

            for (int i = 0; i < CComLibrary.GlobeVal.filesave.testedcount + 1; i++)
            {
                IP.Components.Toolbox.Item m = new IP.Components.Toolbox.Item();
                m.Text = (i + 1).ToString();
                lstspe.Items.Add(m);



                if (CComLibrary.GlobeVal.filesave.dt.Rows[i]["试样状态"] is System.DBNull)
                {
                    CComLibrary.GlobeVal.filesave.dt.Rows[i]["试样状态"] = CComLibrary.TestStatus.Untested;
                }

                m.Image = imageList2.Images[Convert.ToInt16(CComLibrary.GlobeVal.filesave.dt.Rows[i]["试样状态"])];
            }
        }







        private void btnsave_Click(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.SerializeNow(GlobeVal.spefilename);


        }

        private void lstspe_Click(object sender, EventArgs e)
        {

        }



    



        private void btnfinish_Click(object sender, EventArgs e)
        {
            ((TabControl)Application.OpenForms["FormMainLab"].Controls["tabcontrol1"]).SelectedIndex = 0;

            GlobeVal.MainStatusStrip.Items["tslblkind"].Text = "试验类型：空";
            GlobeVal.MainStatusStrip.Items["tslblsample"].Text = "样品：关闭";

            GlobeVal.MainStatusStrip.Items["tslblmethod"].Text = "方法:关闭";
        }



        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timermain_Tick(object sender, EventArgs e)
        {

        }

        private void UserControlTest_Load(object sender, EventArgs e)
        {
            if (Screen.PrimaryScreen.Bounds.Width == 1366)
            {
                splitContainer1.SplitterDistance = 40;
                tableLayoutPanelback.ColumnStyles[0].Width = 30;
            }
            else
            {
                splitContainer1.SplitterDistance = 100;
                tableLayoutPanelback.ColumnStyles[0].Width = 50;
            }

            imageList4.Images.Clear();
            imageList4.Images.Add(TabHeaderDemo.Properties.Resources._50);
            imageList4.Images.Add(TabHeaderDemo.Properties.Resources._50_1);
            imageList4.Images.Add(TabHeaderDemo.Properties.Resources.r2_2);
            imageList4.Images.Add(TabHeaderDemo.Properties.Resources.r2);


            UserControlSpe1.Dock = DockStyle.Fill;
            splitContainer3.Panel2.Controls.Add(UserControlSpe1);

            timermain.Enabled = true;


        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (CComLibrary.GlobeVal.filesave.ReportPrint == true)
            {

                GlobeVal.UserControlMain1.userreport1.printreport();


            }

            else
            {
                MessageBox.Show("方法中没设置报告打印");
                return;
            }
            
        }

        private void tableLayoutPanelback_Resize(object sender, EventArgs e)
        {
            splitContainer1.Dock = DockStyle.None;
            splitContainer1.Dock = DockStyle.Fill;
        }

        private void paneltestright_SizeChanged_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void lstspe_Click_1(object sender, EventArgs e)
        {

        }

        private void lstspe_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }

        private void 重新计算当前试样ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mspefiledat = "";


            int num = 0;

            if (lstspe.SelectedItem == null)
            {
                return;
            }


            num = Convert.ToInt16(lstspe.SelectedItem.Text);

            if (CComLibrary.GlobeVal.filesave.dt.Rows[num - 1]["试样状态"] is DBNull)
            {
                MessageBox.Show("试验后才能计算");
                return;
            }
            else
            {
                if (Convert.ToInt16(CComLibrary.GlobeVal.filesave.dt.Rows[num - 1]["试样状态"]) == Convert.ToInt16(CComLibrary.TestStatus.Untested))
                {
                    MessageBox.Show("试验后才能计算");
                    return;
                }
            }



            mspefiledat = GlobeVal.mysys.SamplePath + "\\" + GlobeVal.mysys.SampleFile + "-" +
          (num).ToString().Trim() + ".txt";



            CComLibrary.GlobeVal.mscattergraph =userControlGraph1.userGraph1.scatterGraph1;

            //清除曲线上的箭头文本

            CComLibrary.GlobeVal.m_listline.Clear();

            userControlGraph1.userGraph1.scatterGraph1.Annotations.Clear();
            
            

            CComLibrary.GlobeVal.filesave.calc(mspefiledat);//计算数据
            if (CComLibrary.GlobeVal.filesave.UseDatabase == true)
            {
                if (System.IO.Directory.Exists(Application.StartupPath + "\\mdb\\") == true)
                {
                    System.IO.Directory.CreateDirectory(Application.StartupPath + "\\mdb\\");
                }
                CComLibrary.GlobeVal.filesave.samplename = System.IO.Path.GetFileNameWithoutExtension(GlobeVal.spefilename);
                CComLibrary.GlobeVal.filesave.Init_databaselist(true, num - 1);

                if (System.IO.File.Exists(Application.StartupPath + "\\mdb\\" + CComLibrary.GlobeVal.filesave.methodname + ".mdb") == false)
                {
                    GlobeVal.NewDatabase();

                }

                GlobeVal.SaveDatabase();
            }


            if (userControlResult1 != null)
            {
                userControlResult1.ReCalcGrid(1, true, false, CComLibrary.GlobeVal.filesave.mtablecol1, CComLibrary.GlobeVal.filesave.mtable1para,
                CComLibrary.GlobeVal.filesave.mtable1statistics, num - 1);
            }

         


         
          

            // FreeFormRefresh(true, false);



            CComLibrary.GlobeVal.filesave.SerializeNow(GlobeVal.spefilename);

            if (CComLibrary.GlobeVal.m_test == false)
            {
                userControlGraph1.userGraph1.scatterGraph1.Annotations.Clear();
                for (int i = 0; i < CComLibrary.GlobeVal.m_listline.Count; i++)
                {
                    if (CComLibrary.GlobeVal.m_listline[i].kind == 0)
                    {

                       // userControlGraph1.userGraph1.scatterGraph1.drawsign(CComLibrary.GlobeVal.m_listline[i].xstart, CComLibrary.GlobeVal.m_listline[i].ystart, CComLibrary.GlobeVal.m_listline[i]);



                    }
                    else if (CComLibrary.GlobeVal.m_listline[i].kind == 1)
                    {
                       // GlobeVal.UserControlGraph1.userGraph1.drawline(CComLibrary.GlobeVal.m_listline[i].xstart, CComLibrary.GlobeVal.m_listline[i].ystart,
                         //    CComLibrary.GlobeVal.m_listline[i].xend, CComLibrary.GlobeVal.m_listline[i].yend, CComLibrary.GlobeVal.m_listline[i]);


                    }

                }

            }

        }

        private void 试验数据导出为ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mspefiledat = "";
            string firstline = "";
            string secondline = "";

            int i = 0;

            int num = 0;

            if (lstspe.SelectedItem == null)
            {
                return;
            }


            num = Convert.ToInt16(lstspe.SelectedItem.Text);

            if (CComLibrary.GlobeVal.filesave.dt.Rows[num - 1]["试样状态"] is DBNull)
            {
                MessageBox.Show("试验后数据才能导出Excel");
                return;
            }
            else
            {
                if (Convert.ToInt16(CComLibrary.GlobeVal.filesave.dt.Rows[num - 1]["试样状态"]) == Convert.ToInt16(CComLibrary.TestStatus.Untested))
                {
                    MessageBox.Show("试验后数据才能导出Excel");
                    return;
                }
            }

            mspefiledat = GlobeVal.mysys.SamplePath + "\\" + GlobeVal.mysys.SampleFile + "-" +
       (num).ToString().Trim() + ".txt";

            StreamReader m_streamReader = new StreamReader(mspefiledat, System.Text.Encoding.Default);

            XlsDocument xls = new XlsDocument();
            Worksheet sheet = xls.Workbook.Worksheets.Add("sheet1");

            try
            {
                //使用StreamReader类来读取文件
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                // 从数据流中读取每一行，直到文件的最后一行，并在richTextBox1中显示出内容


                string strLine = "";

                char[] sp;
                char[] sp1;
                string[] ww;
                bool r = true;

                sp = new char[2];
                sp1 = new char[2];

                sp[0] = Convert.ToChar(" ");




                i = 0;
                while (r == true)
                {

                    strLine = m_streamReader.ReadLine();



                    if (strLine == null)
                    {
                        r = false;

                    }
                    else
                    {

                        ww = strLine.Split(sp);

                        for (int j = 0; j < ww.Length; j++)
                        {
                            sheet.Cells.Add(i + 1, j + 1, ww[j].ToString());
                        }
                        i = i + 1;
                    }

                }
                //关闭此StreamReader对象
                m_streamReader.Close();


                // legend.Items[curvescount - 1].Text = fileName;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            xls.FileName = Application.StartupPath + "\\ExcelData\\" + "导出数据.xls";
            if (File.Exists(xls.FileName))
            {
                File.Delete(xls.FileName);
            }
            xls.Save();


            MessageBox.Show("数据已经导出到" + xls.FileName);


        }

        public void Init()
        {
            lstspe.Items.Clear();

            for (int i = 0; i < CComLibrary.GlobeVal.filesave.testedcount + 1; i++)
            {
                IP.Components.Toolbox.Item m = new IP.Components.Toolbox.Item();
                m.Text = (i + 1).ToString();
                lstspe.Items.Add(m);

                if (CComLibrary.GlobeVal.filesave.dt.Rows[i]["试样状态"] == null)
                {
                    CComLibrary.GlobeVal.filesave.dt.Rows[i]["试样状态"] = CComLibrary.TestStatus.Untested;
                }

                if (CComLibrary.GlobeVal.filesave.dt.Rows[i]["试样状态"] is System.DBNull)
                {
                    CComLibrary.GlobeVal.filesave.dt.Rows[i]["试样状态"] = CComLibrary.TestStatus.Untested;
                }

                m.Image = imageList2.Images[Convert.ToInt16(CComLibrary.GlobeVal.filesave.dt.Rows[i]["试样状态"])];
            }
          
         
                    this.userControlResult1.InitGrid(1, true, true, CComLibrary.GlobeVal.filesave.mtablecol1, CComLibrary.GlobeVal.filesave.mtable1para,
                        CComLibrary.GlobeVal.filesave.mtable1statistics);
                
           
                  
                

               
            


            
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            CustomControls.MethodOpenFileDialog controlex = new CustomControls.MethodOpenFileDialog();
            controlex.StartLocation = AddonWindowLocation.Right;
            controlex.DefaultViewMode = FolderViewMode.Details;
            controlex.OpenDialog.InitialDirectory = "c:\\data\\";
            controlex.OpenDialog.AddExtension = true;
            controlex.OpenDialog.Filter = "试验方法文件(*.spe)|*.spe";
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

                }

               

                CComLibrary.GlobeVal.filesave = CComLibrary.GlobeVal.filesave.DeSerializeNow(fileName);


                Init();
                
                userControlRawdata1.Init();
                userControlRawdata1.dataGridView1.Rows.Clear();

                fileName = Path.GetFileNameWithoutExtension(fileName) + "-1.txt";

                userControlGraph1.userGraph1.scatterGraph1.YAxes[0].Mode = NationalInstruments.UI.AxisMode.AutoScaleLoose;
                userControlGraph1.userGraph1.scatterGraph1.XAxes[0].Mode = NationalInstruments.UI.AxisMode.AutoScaleLoose;
                bool firstread = false;
                string firstline = "";
                string secondline = "";
                int i = 0;
                bool r = true;
                char[] sp;
                char[] sp1;
                string[] ww;
                string[] ww1;
                int xchsel = 0;
                int ychsel = 0;

                double x = 0;
                double y = 0;

                sp = new char[2];
                sp1 = new char[2];

                sp[0] = Convert.ToChar(" ");


                xchsel = 0 ;
                ychsel = 0 ;



                userControlGraph1.userGraph1.scatterGraph1.Plots[0].ClearData();
                StreamReader m_streamReader = new StreamReader(fileName, System.Text.Encoding.Default);
                try
                {
                    //使用StreamReader类来读取文件
                    m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    // 从数据流中读取每一行，直到文件的最后一行，并在richTextBox1中显示出内容

                    string strLine = m_streamReader.ReadLine();
                    firstline = strLine;
                    strLine = m_streamReader.ReadLine();
                    secondline = strLine;
                    strLine = m_streamReader.ReadLine();


                    ww = firstline.Split(sp);
                    ww1 = secondline.Split(sp);
                    userControlGraph1.userGraph1.scatterGraph1.XAxes[0].Caption = ww[xchsel] + "[" + ww1[xchsel] + "]";
                    userControlGraph1.userGraph1.scatterGraph1.YAxes[0].Caption = ww[ychsel] + "[" + ww1[ychsel] + "]";


                    while (r == true)
                    {


                        ww = strLine.Split(sp);

                        
                        userControlRawdata1.dataGridView1.Rows.Add(ww);


                        x = Convert.ToDouble(ww[xchsel]);
                        y = Convert.ToDouble(ww[ychsel]);

                        userControlGraph1.userGraph1.scatterGraph1.Plots[0].PlotXYAppend(x, y);

                        strLine = m_streamReader.ReadLine();

                        if (strLine == null)
                        {
                            r = false;

                        }

                        i = i + 1;

                    }
                    //关闭此StreamReader对象
                    m_streamReader.Close();

                    
                    // legend.Items[curvescount - 1].Text = fileName;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                firstread = true;

                UserControlSpe1.setspe(1, CComLibrary.TestStatus.tested);
                UserControlSpe1.setinput();
            }
        }

        private void btnsaveas_Click(object sender, EventArgs e)
        {
           
        }
    }
}
