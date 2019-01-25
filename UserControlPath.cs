using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using CustomControls.OS;
using CustomControls.Controls;
using System.IO;

namespace TabHeaderDemo
{
    public partial class UserControlPath : UserControl
    {
        public string gfilename = ""; //方法单元读取的文件名



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
        public UserControlPath()
        {
            InitializeComponent();
            treeView1.mimagelist = imageList2;
            tabControl1.ItemSize = new Size(1, 1);

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲



            this.tableLayoutPanel1.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel1, true, null);
            this.tableLayoutPanel2.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel2, true, null);
            this.tableLayoutPanel8.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel8, true, null);

            this.tableLayoutPanel9.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel9, true, null);

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
            roundedRectangle[0].X = 8;
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

        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {




        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {

            }
            else
            {
                treeView1.SelectedNode = e.Node.Nodes[0];

                methodon(e.Node.Nodes[0].Text, e.Node.Text);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                methodon(e.Node.Text, "");
            }
            else
            {
                methodon(e.Node.Text, e.Node.Parent.Text);
            }
        }

        public void methodon(String t, String parent)
        {
            if (t == "选择路径")
            {
                btnenext.Visible = true;
                btneopen.Visible = true;
                btneback.Visible = false;
                lblpath.Text = GlobeVal.myglobefile.SamplePath;
                txtsamplename.Text = GlobeVal.myglobefile.SampleFile;
                tabControl1.SelectedIndex = 1;

            }

            if (t == "选择样品")
            {
                btnenext.Visible = true;
                btneopen.Visible = true;
                btneback.Visible = false;
                tabControl1.SelectedIndex = 2;
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        public void SampleNextStep1(bool newfile)
        {

        }

        public void SampleNextStep(bool newfile)
        {
            string s;


            if (newfile == true)
            {
                CComLibrary.GlobeVal.continuetest = false;
            }
            else
            {
                CComLibrary.GlobeVal.continuetest = true;
            }



            if (newfile == true)
            {
                CComLibrary.GlobeVal.filesave.InitTable();
                CComLibrary.GlobeVal.filesave.SerializeNow(GlobeVal.spefilename);





            }
            else

            {
                if (File.Exists(GlobeVal.spefilename) == false)
                {
                    CComLibrary.GlobeVal.filesave.InitTable();
                    CComLibrary.GlobeVal.filesave.SerializeNow(GlobeVal.spefilename);
                }
                else
                {
                    CComLibrary.GlobeVal.filesave = CComLibrary.GlobeVal.filesave.DeSerializeNow(GlobeVal.spefilename);
                }
            }



            if (CComLibrary.GlobeVal.filesave.mwizard == true)
            {

                GlobeVal.UserControlMain1.tabControl1.SelectedIndex = 3;

                GlobeVal.userControltest1.paneltestright.Controls.Clear();

                GlobeVal.userControltest1.splitContainer1.SplitterDistance = 100;
                if (GlobeVal.wizard == null)
                {
                    GlobeVal.wizard = new UserControlWizard();
                    GlobeVal.wizard.Dock = DockStyle.Fill;
                    GlobeVal.wizard.BackColor = Color.Cyan;
                }


                GlobeVal.userControltest1.lstspe.Visible = false;
                GlobeVal.userControltest1.paneltestright.Controls.Add(GlobeVal.wizard);

                GlobeVal.userControltest1.tableLayoutPanelback.RowStyles[1].Height = 84;
                GlobeVal.userControltest1.tableLayoutPanelTop.Visible = true;


                GlobeVal.wizard.Init(CComLibrary.GlobeVal.filesave.mstep[0].Id);



                GlobeVal.userControltest1.Init_btnstep();








            }
            else
            {


                GlobeVal.userControltest1.Visible = false;


                GlobeVal.UserControlMain1.tabControl1.SelectedIndex = 3;

                GlobeVal.userControltest1.tableLayoutPanelback.RowStyles[1].Height = 0;

                GlobeVal.userControltest1.tableLayoutPanelTop.Visible = false;




                GlobeVal.userControltest1.splitContainer1.SplitterDistance = 100;

                GlobeVal.userControltest1.paneltestright.Visible = false;



                GlobeVal.userControltest1.lstspe.Visible = true;


                if (GlobeVal.dynset == null)
                {

                    GlobeVal.dynset = new UserControlDynSet();

                }


                GlobeVal.dynset.Dock = DockStyle.Fill;
                GlobeVal.dynset.BackColor = Color.Cyan;
                GlobeVal.dynset.tlbetest.Controls.Clear();
                GlobeVal.dynset.tlbetest.RowCount = 0;
                GlobeVal.dynset.tlbetest.ColumnCount = 0;
                GlobeVal.dynset.Dock = DockStyle.None;

                if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\layout\\" + CComLibrary.GlobeVal.filesave.layfilename + ".lay"))
                {
                    GlobeVal.userControltest1.OpenDefaultlayout(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\layout\\" + CComLibrary.GlobeVal.filesave.layfilename + ".lay");

                }
                else
                {
                    GlobeVal.userControltest1.OpenDefaultlayout(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\layout\\模板1.lay");
                }

                GlobeVal.dynset.Dock = DockStyle.Fill;
                GlobeVal.userControltest1.paneltestright.Controls.Clear();

                GlobeVal.userControltest1.paneltestright.Controls.Add(GlobeVal.dynset);

                GlobeVal.dynset.tlbetest.Dock = DockStyle.Fill;


                GlobeVal.dynset.tlbetest.ResetSizeAndSizeTypes();

                GlobeVal.userControltest1.paneltestright.Visible = true;










                if (newfile == true)
                {
                    GlobeVal.userControltest1.FreeFormRefresh(false, false);
                }
                else
                {
                    GlobeVal.userControltest1.FreeFormRefresh(true, true);
                }


                GlobeVal.userControltest1.Visible = true;
                GlobeVal.userControltest1.Visible = false;
                GlobeVal.dynset.tlbetest.ResetSizeAndSizeTypes();
                /*
                double t = Environment.TickCount;
                while((Environment.TickCount -t)<500)
                        {
                    Application.DoEvents();
                }
                */
                GlobeVal.userControltest1.Visible = true;
            }

            GlobeVal.UserControlMain1.btnmmethod.Visible = true;
            GlobeVal.UserControlMain1.btnmreport.Visible = true;
            GlobeVal.UserControlMain1.btnmmanage.Visible = true;
            GlobeVal.UserControlMain1.btngroupcontrol.Visible = true;


            if (GlobeVal.userControlpretest1.gfilename.Trim() == "")
            {

            }
            else
            {
                GlobeVal.userControlmethod1.OpenTheMethodSilently(GlobeVal.userControlpretest1.gfilename);

            }

            if (newfile == true)
            {
                if (CComLibrary.GlobeVal.filesave.mwizard == true)
                {

                }
                CComLibrary.GlobeVal.filesave.InitTable();
            }


            GlobeVal.MainStatusStrip.Items["tslblkind"].Text = "试验类型：" + ClsStaticStation.m_Global.mycls.TestkindList[CComLibrary.GlobeVal.filesave.methodkind];

            GlobeVal.MainStatusStrip.Items["tslblsample"].Text = "样品：" + Path.GetFileNameWithoutExtension(GlobeVal.spefilename);

            GlobeVal.MainStatusStrip.Items["tslblmethod"].Text = "方法:" + CComLibrary.GlobeVal.filesave.methodname;





        }

        private void btnenext_Click(object sender, EventArgs e)
        {
            string s;

            if (tabControl1.SelectedIndex == 2)
            {
                if (GlobeVal.myglobefile.SamplePath == "")
                {
                    MessageBox.Show("请设置数据保存路径");

                    return;
                }
                if (System.IO.Directory.Exists(GlobeVal.myglobefile.SamplePath))
                {
                }
                else
                {
                    MessageBox.Show("数据保存路径不存在,请点击浏览选择试验路径");
                    return;
                }

                if (txtsample.Text.Trim() == "")
                {
                    MessageBox.Show("请先读取样品文件");
                    return;
                }



                GlobeVal.spefilename = txtsamplepath.Text + "\\" + txtsample.Text + ".spe";


                SampleNextStep(false);





            }
            else if (tabControl1.SelectedIndex == 0)
            {

                tabControl1.SelectedIndex = 1;
                btneback.Visible = true;
                btneopen.Visible = false;



            }
            else if (tabControl1.SelectedIndex == 1)
            {

                if (txtsamplename.Text.Trim() == "")
                {

                    MessageBox.Show("样品文件名不能为空");
                    return;
                }
                if (GlobeVal.myglobefile.SamplePath == "")
                {
                    MessageBox.Show("请设置数据保存路径");

                    return;
                }
                if (System.IO.Directory.Exists(GlobeVal.myglobefile.SamplePath))
                {
                }
                else
                {
                    MessageBox.Show("数据保存路径不存在,请点击浏览选择试验路径");
                    return;
                }




                GlobeVal.spefilename = lblpath.Text + "\\" + txtsamplename.Text + ".spe";


                if (File.Exists(GlobeVal.spefilename) == true)
                {
                    DialogResult r = MessageBox.Show("相同文件名数据已经存在，是否覆盖？", "提示", MessageBoxButtons.YesNo);

                    if (r == DialogResult.Yes)
                    {

                    }
                    else
                    {
                        return;
                    }
                }

                SampleNextStep(true);

                CComLibrary.GlobeVal.filesave.currentspenumber = 0;


            }




        }



        private void btnelook_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                CustomControls.MethodOpenFileDialog controlex = new CustomControls.MethodOpenFileDialog();
                controlex.StartLocation = AddonWindowLocation.Right;
                controlex.DefaultViewMode = FolderViewMode.Details;
                controlex.OpenDialog.InitialDirectory = lblpath.Text;
                controlex.OpenDialog.AddExtension = true;
                controlex.OpenDialog.Filter = "样品文件(*.spe)|*.spe";
                controlex.ShowDialog(this);

                if (controlex.OpenDialog.FileName == null)
                {

                    return;
                }
                else
                {
                    string fileName = controlex.OpenDialog.FileName;
                    gfilename = fileName;
                    if (fileName == "")
                    {
                        return;
                    }
                    else
                    {

                        this.txtsample.Text = Path.GetFileNameWithoutExtension(fileName);
                        this.txtsamplepath.Text = Path.GetDirectoryName(fileName);

                        if (CComLibrary.GlobeVal.filesave == null)
                        {
                            CComLibrary.GlobeVal.filesave = new CComLibrary.FileStruct();
                        }
                        CComLibrary.GlobeVal.filesave = CComLibrary.GlobeVal.filesave.DeSerializeNow(fileName);

                        CComLibrary.GlobeVal.currentfilesavename = fileName;


                        GlobeVal.putlistboxitem(listBox2);


                        ListViewItem lv = new ListViewItem();
                        lv.Text = this.txtsample.Text;


                        lv.SubItems.Add(ClsStaticStation.m_Global.mycls.TestkindList[CComLibrary.GlobeVal.filesave.methodkind]);
                        lv.SubItems.Add(System.IO.File.GetLastWriteTime(fileName).ToLongDateString() + " " + System.IO.File.GetLastWriteTime(fileName).ToLongTimeString());
                        lv.SubItems.Add(Path.GetDirectoryName(fileName));

                        if (listView2.Items.Count > 0)
                        {
                            if (this.txtsample.Text == listView2.Items[0].Text)
                            {
                                listView2.Items.RemoveAt(0);
                            }

                            if (listView2.Items.Count >= 20)
                            {
                                listView2.Items.RemoveAt(19);
                            }
                        }
                        listView2.Items.Insert(0, lv);



                        for (int i = 0; i < listView2.Items.Count; i++)
                        {

                            GlobeVal.myglobefile.RecentSampleFilename[i] = listView2.Items[i].Text;
                            GlobeVal.myglobefile.RecentSampleFilenameKind[i] = listView2.Items[i].SubItems[1].Text;
                            GlobeVal.myglobefile.RecentSampleFilePath[i] = listView2.Items[i].SubItems[3].Text;

                        }

                        for (int i = listView2.Items.Count; i < 20; i++)
                        {
                            GlobeVal.myglobefile.RecentSampleFilename[i] = "";
                            GlobeVal.myglobefile.RecentSampleFilenameKind[i] = "";
                            GlobeVal.myglobefile.RecentSampleFilePath[i] = "";
                        }

                        ClsStaticStation.m_Global.mycls.initchannel();
                        ((FormMainLab)Application.OpenForms["FormMainLab"]).InitKey();
                        ((FormMainLab)Application.OpenForms["FormMainLab"]).InitMeter();

                        //lblmethodkind.Text = ClsStaticStation.m_Global.mycls.TestkindList[CComLibrary.GlobeVal.filesave.methodkind];
                        //lblmethod.Text = this.txtmethod.Text;



                    }
                }

                controlex.Dispose();

            }
            if (tabControl1.SelectedIndex == 1)
            {
                this.folderBrowserDialog1.SelectedPath = lblpath.Text;
                this.folderBrowserDialog1.ShowDialog();

                lblpath.Text = this.folderBrowserDialog1.SelectedPath;

                GlobeVal.myglobefile.SamplePath = lblpath.Text;


            }

        }

        private void btneopen_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                if (listView2.SelectedIndices.Count > 0)
                {

                    string fileName = listView2.Items[listView2.SelectedIndices[0]].SubItems[3].Text + "\\"
                    + listView2.Items[listView2.SelectedIndices[0]].Text + ".spe";
                    gfilename = fileName;

                    if (System.IO.File.Exists(fileName) == true)
                    {

                    }
                    else
                    {
                        MessageBox.Show("样品文件不存在");
                        return;
                    }

                    if (fileName == "")
                    {
                        return;
                    }
                    else
                    {

                        this.txtsample.Text = Path.GetFileNameWithoutExtension(fileName);
                        this.txtsamplepath.Text = Path.GetDirectoryName(fileName);

                        if (CComLibrary.GlobeVal.filesave == null)
                        {
                            CComLibrary.GlobeVal.filesave = new CComLibrary.FileStruct();
                        }
                        CComLibrary.GlobeVal.filesave = CComLibrary.GlobeVal.filesave.DeSerializeNow(fileName);

                        CComLibrary.GlobeVal.currentfilesavename = fileName;

                        GlobeVal.putlistboxitem(listBox2);


                        ListViewItem lv = new ListViewItem();
                        lv.Text = this.txtsample.Text;


                        lv.SubItems.Add(ClsStaticStation.m_Global.mycls.TestkindList[CComLibrary.GlobeVal.filesave.methodkind]);
                        lv.SubItems.Add(System.IO.File.GetLastWriteTime(fileName).ToLongDateString() + " " + System.IO.File.GetLastWriteTime(fileName).ToLongTimeString());
                        lv.SubItems.Add(Path.GetDirectoryName(fileName));

                        if (this.txtsample.Text == listView2.Items[0].Text)
                        {
                            listView2.Items.RemoveAt(0);
                        }


                        if (listView2.Items.Count >= 20)
                        {
                            listView2.Items.RemoveAt(19);
                        }
                        listView2.Items.Insert(0, lv);



                        for (int i = 0; i < listView2.Items.Count; i++)
                        {

                            GlobeVal.myglobefile.RecentSampleFilename[i] = listView2.Items[i].Text;
                            GlobeVal.myglobefile.RecentSampleFilenameKind[i] = listView2.Items[i].SubItems[1].Text;
                            GlobeVal.myglobefile.RecentSampleFilePath[i] = listView2.Items[i].SubItems[3].Text;

                        }

                        for (int i = listView2.Items.Count; i < 20; i++)
                        {
                            GlobeVal.myglobefile.RecentSampleFilename[i] = "";
                            GlobeVal.myglobefile.RecentSampleFilenameKind[i] = "";
                            GlobeVal.myglobefile.RecentSampleFilePath[i] = "";
                        }

                        ClsStaticStation.m_Global.mycls.initchannel();
                        ((FormMainLab)Application.OpenForms["FormMainLab"]).InitKey();
                        ((FormMainLab)Application.OpenForms["FormMainLab"]).InitMeter();

                        //lblmethodkind.Text = ClsStaticStation.m_Global.mycls.TestkindList[CComLibrary.GlobeVal.filesave.methodkind];
                        //lblmethod.Text = this.txtmethod.Text;

                    }


                }
                else
                {
                    MessageBox.Show("请选择最近使用的样本");
                }
            }
        }

    }



       
    
}
