using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TabHeaderDemo
{
    public partial class UserControl系统设置 : UserControl
    {
        public UserControlMethod musercontrolmethod;

        string[] ms;

      
        public void Init(int sel)
        {

            tabControl1.SelectedIndex = sel;

            if (GlobeVal.mysys.AppUserLevel == 0)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;

            }
            cbokind.Items.Clear();

            for (int i = 0; i < GlobeVal.mysys.ControllerCount; i++)
            {
                cbokind.Items.Add(GlobeVal.mysys.ControllerName[i]);

            }

#if Demo 
            cbokind.SelectedIndex = 2;
            cbokind.Enabled = false;
#else
            cbokind.Enabled = true;
            cbokind.SelectedIndex = GlobeVal.mysys.controllerkind;
#endif
            cbomachine.Items.Clear();
            for (int i = 0; i < GlobeVal.mysys.MachineCount; i++)
            {
                cbomachine.Items.Add(GlobeVal.mysys.MachineName[i]);

            }
#if Demo
            cbomachine.SelectedIndex = 0;
            cbomachine.Enabled = false;
#else
            cbomachine.Enabled = true;
            cbomachine.SelectedIndex = GlobeVal.mysys.machinekind;
#endif

            numnumber.Value = GlobeVal.mysys.ControllerCount;


            cbonum.Items.Clear();
            for (int i = 0; i < GlobeVal.mysys.ControllerCount; i++)
            {
                cbonum.Items.Add((i + 1).ToString());
            }
            cbonum.SelectedIndex = 0;

        }

        public void InitGrid()
        {







        }
        public UserControl系统设置()
        {
            InitializeComponent();
            tabControl1.ItemSize = new Size(1, 1);
            ms = new string[2];
            ms[0] = "使用";
            ms[1] = "不使用";
           

            grid1.RowsCount = 0;
            grid1.AutoStretchColumnsToFitWidth = true;

            grid1.BorderStyle = BorderStyle.FixedSingle;

            grid1.ColumnsCount = 7;
            grid1.Columns[0].Width = grid1.Width / 7;

            grid1.Columns[1].Width = grid1.Width / 7;
            grid1.Columns[2].Width = grid1.Width / 7;
            grid1.Columns[3].Width = grid1.Width / 7;
            grid1.Columns[4].Width = grid1.Width / 7;
            grid1.Columns[5].Width = grid1.Width / 7;
        
            grid1.Columns[6].Width = grid1.Width / 7;

            grid1.Columns[6].AutoSizeMode = SourceGrid2.AutoSizeMode.EnableStretch;
            grid1.FixedRows = 1;

            grid1.RowsCount = 0;

            grid1.Rows.Insert(0);

            SourceGrid2.Cells.Real.ColumnHeader head = new SourceGrid2.Cells.Real.ColumnHeader("[硬件通道名称]");
            head.EnableSort = false;
            head.EnableEdit = false;

            grid1[0, 0] = head;

            head = new SourceGrid2.Cells.Real.ColumnHeader("[硬件通道量纲]");
            head.EnableSort = false;
            head.EnableEdit = false;
            grid1[0, 1] = head;


            head = new SourceGrid2.Cells.Real.ColumnHeader("[硬件通道单位]");
            head.EnableSort = false;
            head.EnableEdit = false;
            grid1[0, 2] = head;

            head = new SourceGrid2.Cells.Real.ColumnHeader("[硬件通道内部名称]");
            head.EnableSort = false;
            head.EnableEdit = false;
            grid1[0, 3] = head;

            head = new SourceGrid2.Cells.Real.ColumnHeader("硬件通道量程");
            head.EnableSort = false;
            grid1[0, 4] = head;

            head = new SourceGrid2.Cells.Real.ColumnHeader("硬件通道闭环控制");
            head.EnableSort = false;
            grid1[0, 5] = head;

            head = new SourceGrid2.Cells.Real.ColumnHeader("硬件通道采集方式");
            head.EnableSort = false;
            grid1[0, 6] = head;

           


            //判断如果没有控制通道，则设置一个控制通道，防止系统出错
            bool mb = false;
            for (int i = 1; i <= ClsStaticStation.m_Global.mycls.chsignals.Count; i++)
            {

                if (GlobeVal.mysys.ChannelControl[i - 1] == true)
                {
                    mb = true;
                }
            }

            if (mb == false)
            {
                GlobeVal.mysys.ChannelControl[0] = true;

            }


            for (int i = 1; i <= ClsStaticStation.m_Global.mycls.chsignals.Count; i++)
            {
                grid1.Rows.Insert(i);
                grid1[i, 0] = new SourceGrid2.Cells.Real.Cell(
                    ClsStaticStation.m_Global.mycls.chsignals[i - 1].cName, typeof(string));


                grid1[i, 1] = new SourceGrid2.Cells.Real.ComboBox(

               ClsStaticStation.m_Global.mycls.SignalsNames[ClsStaticStation.m_Global.mycls.chsignals[i - 1].cUnitKind], typeof(string),
              ClsStaticStation.m_Global.mycls.SignalsNames, false);

                grid1[i, 2] = new SourceGrid2.Cells.Real.ComboBox(
                  ClsStaticStation.m_Global.mycls.chsignals[i - 1].cUnits[
                  ClsStaticStation.m_Global.mycls.chsignals[i - 1].cUnitsel], typeof(string),
                  ClsStaticStation.m_Global.mycls.chsignals[i - 1].cUnits, false);

                grid1[i, 3] = new SourceGrid2.Cells.Real.Cell(
                 ClsStaticStation.m_Global.mycls.chsignals[i - 1].SignName, typeof(string));


                grid1[i, 4] = new SourceGrid2.Cells.Real.Cell(
                   GlobeVal.mysys.ChannelRange[i - 1], typeof(double));




                grid1[i, 5] = new SourceGrid2.Cells.Real.Cell(
                 GlobeVal.mysys.ChannelControl[i - 1], typeof(bool));



                grid1[i, 6] = new SourceGrid2.Cells.Real.ComboBox(

               ms[GlobeVal.mysys.ChannelSamplemode[i - 1]], typeof(string),
              ms, false);

               


            }



        }

        private void cbokind_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GlobeVal.mysys.controllerkind = cbokind.SelectedIndex;
            GlobeVal.MainStatusStrip.Items["tslbldevice"].Text = GlobeVal.mysys.ControllerName[GlobeVal.mysys.controllerkind];

            GlobeVal.mysys.SerializeNow(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\sys\\setup.ini");
        }

        private void cbomachine_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GlobeVal.mysys.machinekind = cbomachine.SelectedIndex;
            GlobeVal.MainStatusStrip.Items["tslblmachine"].Text = GlobeVal.mysys.ControllerName[GlobeVal.mysys.machinekind];

            GlobeVal.mysys.SerializeNow(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\sys\\setup.ini");
        }

        private void cbomachine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grid1_CellLostFocus(object sender, SourceGrid2.PositionCancelEventArgs e)
        {
            int k = 0;
            if (e.Position.Column == 4)
            {
                GlobeVal.mysys.ChannelRange[e.Position.Row - 1] = Convert.ToDouble(e.Cell.GetValue(new SourceGrid2.Position(e.Position.Row, e.Position.Column)));
            }

            if (e.Position.Column == 5)
            {
                GlobeVal.mysys.ChannelControl[e.Position.Row - 1] = Convert.ToBoolean(e.Cell.GetValue(new SourceGrid2.Position(e.Position.Row, e.Position.Column)));
            }

            if (e.Position.Column == 6)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (Convert.ToString(e.Cell.GetValue(new SourceGrid2.Position(e.Position.Row, e.Position.Column))) == ms[i])
                    {
                        k = i;
                    }


                    GlobeVal.mysys.ChannelSamplemode[e.Position.Row - 1] = k;


                }
            }
        }

        private void grid1_CellGotFocus(object sender, SourceGrid2.PositionCancelEventArgs e)
        {
            if (e.Position.Column == 0)
            {
                e.Cancel = true;
            }
            if (e.Position.Column == 1)
            {
                e.Cancel = true;
            }
            if (e.Position.Column == 2)
            {
                e.Cancel = true;
            }

            if (e.Position.Column == 3)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobeVal.mysys.SerializeNow(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\sys\\setup.ini");
            Application.Exit();
        }

        private void numnumber_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            GlobeVal.mysys.ControllerCount = Convert.ToInt32(numnumber.Value);


            cbonum.Items.Clear();
            for (int i = 0; i < GlobeVal.mysys.ControllerCount; i++)
            {
                cbonum.Items.Add((i + 1).ToString());
            }
            cbonum.SelectedIndex = 0;

        }

        private void cbonum_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = cbonum.SelectedIndex + 1;
            string f = System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + a.ToString().Trim() + "\\sys\\setup.ini";

            if (System.IO.Directory.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device") == false)
            {
                System.IO.Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device");
            }

            if (System.IO.Directory.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + a.ToString().Trim()) == false)
            {
                System.IO.Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + a.ToString().Trim());
            }

            if (System.IO.Directory.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + a.ToString().Trim() + "\\sys") == false)
            {
                System.IO.Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + a.ToString().Trim() + "\\sys");
            }


            if (System.IO.File.Exists(f) == true)
            {

            }

            else
            {
                System.IO.File.Copy(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\sys\\setup.ini", f);
            }


            GlobeVal.mysys = GlobeVal.mysys.DeSerializeNow(f);


            grid1.RowsCount = 1;

            for (int i = 1; i <= ClsStaticStation.m_Global.mycls.chsignals.Count; i++)
            {
                grid1.Rows.Insert(i);
                grid1[i, 0] = new SourceGrid2.Cells.Real.Cell(
                    ClsStaticStation.m_Global.mycls.chsignals[i - 1].cName, typeof(string));


                grid1[i, 1] = new SourceGrid2.Cells.Real.ComboBox(

               ClsStaticStation.m_Global.mycls.SignalsNames[ClsStaticStation.m_Global.mycls.chsignals[i - 1].cUnitKind], typeof(string),
              ClsStaticStation.m_Global.mycls.SignalsNames, false);

                grid1[i, 2] = new SourceGrid2.Cells.Real.ComboBox(
                  ClsStaticStation.m_Global.mycls.chsignals[i - 1].cUnits[
                  ClsStaticStation.m_Global.mycls.chsignals[i - 1].cUnitsel], typeof(string),
                  ClsStaticStation.m_Global.mycls.chsignals[i - 1].cUnits, false);

                grid1[i, 3] = new SourceGrid2.Cells.Real.Cell(
                 ClsStaticStation.m_Global.mycls.chsignals[i - 1].SignName, typeof(string));


                grid1[i, 4] = new SourceGrid2.Cells.Real.Cell(
                   GlobeVal.mysys.ChannelRange[i - 1], typeof(double));




                grid1[i, 5] = new SourceGrid2.Cells.Real.Cell(
                 GlobeVal.mysys.ChannelControl[i - 1], typeof(bool));



                grid1[i, 6] = new SourceGrid2.Cells.Real.ComboBox(

               ms[GlobeVal.mysys.ChannelSamplemode[i - 1]], typeof(string),
              ms, false);

             


            }

            cboEdc.Items.Clear();
            cboEdc.Items.Add("Edc");
            cboEdc.Items.Add("IEdc");
            cboEdc.SelectedIndex = GlobeVal.mysys.ChannelControllerType;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = cbonum.SelectedIndex + 1;
            string f = System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + a.ToString().Trim() + "\\sys\\setup.ini";

            if (System.IO.Directory.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device") == false)
            {
                System.IO.Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device");
            }

            if (System.IO.Directory.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + a.ToString().Trim()) == false)
            {
                System.IO.Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + a.ToString().Trim());
            }

            if (System.IO.Directory.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + a.ToString().Trim() + "\\sys") == false)
            {
                System.IO.Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\device\\" + a.ToString().Trim() + "\\sys");
            }
            GlobeVal.mysys.SerializeNow(f);

        }

        private void cboEdc_SelectedValueChanged(object sender, EventArgs e)
        {
            GlobeVal.mysys.ChannelControllerType = cboEdc.SelectedIndex;
        }
    }
}
