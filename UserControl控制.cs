using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ClsStaticStation;
namespace TabHeaderDemo
{
    public partial class UserControl控制 : UserControl
    {
        public UserControlMethod musercontrolmethod;
        private CComLibrary.SegFile sf;

        private CComLibrary.SequenceFile sqf = new CComLibrary.SequenceFile();

        private bool mloaded = false;

        private int curcol = 0;
        private int currow = 0;



        public void Init_测试结束()
        {

            cbostopchannel1.Items.Clear();



            for (int i = 0; i < ClsStaticStation.m_Global.mycls.allsignals.Count; i++)
            {
                cbostopchannel1.Items.Add(ClsStaticStation.m_Global.mycls.allsignals[i].cName);
            }


            cbostopchannel1.SelectedIndex = CComLibrary.GlobeVal.filesave.endoftest1usechannel;

            cbostopchannel1_SelectionChangeCommitted(null, null);



            chktestend1.Checked = CComLibrary.GlobeVal.filesave.endoftest1;
            cbotestendCriteria1.Items.Clear();
            cbotestendCriteria1.Items.Add("下降百分率");
            cbotestendCriteria1.Items.Add("下降门槛值");
            cbotestendCriteria1.Items.Add("峰值");

            cbotestendCriteria1.SelectedIndex = CComLibrary.GlobeVal.filesave.endoftest1criteria;





            numtestendvalue1.Value = CComLibrary.GlobeVal.filesave.endoftest1value;


            if (cbotestendCriteria1.SelectedIndex == 0)
            {
                lbltestend1.Text = "灵敏度 (%)：";


            }
            else if (cbotestendCriteria1.SelectedIndex == 1)
            {
                lbltestend1.Text = "下降到：";

            }
            else if (cbotestendCriteria1.SelectedIndex == 2)
            {
                lbltestend1.Text = "超过峰值：";
            }

            chktestend1_CheckedChanged (null, null);

            //----------------------------------------------

            cbostopchannel2.Items.Clear();



            for (int i = 0; i < ClsStaticStation.m_Global.mycls.allsignals.Count; i++)
            {
                cbostopchannel2.Items.Add(ClsStaticStation.m_Global.mycls.allsignals[i].cName);
            }


            cbostopchannel2.SelectedIndex = CComLibrary.GlobeVal.filesave.endoftest2usechannel;
            cbostopchannel2_SelectionChangeCommitted(null, null);

            chktestend2.Checked = CComLibrary.GlobeVal.filesave.endoftest2;
            cbotestendCriteria2.Items.Clear();
            cbotestendCriteria2.Items.Add("下降百分率");
            cbotestendCriteria2.Items.Add("下降门槛值");
            cbotestendCriteria2.Items.Add("峰值");

            cbotestendCriteria2.SelectedIndex = CComLibrary.GlobeVal.filesave.endoftest2criteria;



            if (cbotestendCriteria2.SelectedIndex == 0)
            {
                lbltestend2.Text = "灵敏度 (%)：";


            }
            else if (cbotestendCriteria2.SelectedIndex == 1)
            {
                lbltestend2.Text = "载荷下降到： ";

            }
            else if (cbotestendCriteria2.SelectedIndex == 2)
            {
                lbltestend2.Text = "超过峰值：";
            }

            numtestendvalue2.Value = CComLibrary.GlobeVal.filesave.endoftest2value;

            chktestend2_CheckedChanged(null, null);

            //-----------------------------------

            chkBidirectionalProtected.Checked = CComLibrary.GlobeVal.filesave.mBidirectionalProtected;

            cboBidirectionalProtected.Items.Clear();
            for (int i=0;i<ClsStaticStation.m_Global.mycls.hardsignals.Count;i++)
            {
                cboBidirectionalProtected.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[i].cName);
            }

            cboBidirectionalProtected.SelectedIndex = CComLibrary.GlobeVal.filesave.mBidirectionalProtectedSensor;

            numBidirectionalProtectedUp.Value = CComLibrary.GlobeVal.filesave.mBidirectionalProtectedUpLimit;
            numBidirectionalProtectedDown.Value = CComLibrary.GlobeVal.filesave.mBidirectionalProtectedLowLimit;
            chkBidirectionalProtected_CheckedChanged(null, null);


            //------------------------------

            chkUnidirectionalProtection.Checked = CComLibrary.GlobeVal.filesave.mUnidirectionalProtection;
            cboUnidirectionalProtection.Items.Clear();
            for (int i=0;i<ClsStaticStation.m_Global.mycls.hardsignals.Count;i++)
            {
                cboUnidirectionalProtection.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[i].cName);
            }
            cboUnidirectionalProtection.SelectedIndex = CComLibrary.GlobeVal.filesave.mUnidirectionalProtectionSensor;


            cboUnidirectionalProtectionMode.Items.Clear();
            cboUnidirectionalProtectionMode.Items.Add("高于");
            cboUnidirectionalProtectionMode.Items.Add("低于");
            cboUnidirectionalProtectionMode.SelectedIndex = CComLibrary.GlobeVal.filesave.mUnidirectionalProtectionMode;

            numUnidirectionalProtection.Value = CComLibrary.GlobeVal.filesave.mUnidirectionalProtectionValue;
            chkUnidirectionalProtection_CheckedChanged(null, null);

            //---------------------
            chkTemperatureProtection.Checked = CComLibrary.GlobeVal.filesave.mTemperatureProtection;
            numTemperatureProtectionUp.Value = CComLibrary.GlobeVal.filesave.mTemperatureProtectionUpLimit;
            numTemperatureProtectionDown.Value = CComLibrary.GlobeVal.filesave.mTemperatureProtectionLowLimit;

            chkTemperatureProtection_CheckedChanged(null, null);

            //----------------------
            chkFatigueProtection.Checked = CComLibrary.GlobeVal.filesave.mFatigueProtection;

            numFatigueProtection.Value = CComLibrary.GlobeVal.filesave.mFatigueProtectionCount;
            numFatigueProtectionstop.Value = CComLibrary.GlobeVal.filesave.mFatigueProtectionStopValue;
            chkFatigueProtection_CheckedChanged(null, null);

            //----------------------------

            cbotestaction1.Items.Clear();
            cbotestaction1.Items.Add("停于位置");
            cbotestaction1.Items.Add("返回初始状态");
            cbotestaction1.Items.Add("返回预负荷");
            cbotestaction1.Items.Add("停于负荷");
            cbotestaction1.Items.Add("停于变形");
            cbotestaction1.Items.Add("关断驱动");

            cbotestaction1.SelectedIndex = CComLibrary.GlobeVal.filesave.mtestaction[0];
            numtestactionspeed1.Value = CComLibrary.GlobeVal.filesave.mtestactionreturnspeed[0];


            cbotestaction2.Items.Clear();
            cbotestaction2.Items.Add("停于位置");
            cbotestaction2.Items.Add("返回初始状态");
            cbotestaction2.Items.Add("返回预负荷");
            cbotestaction2.Items.Add("停于负荷");
            cbotestaction2.Items.Add("停于变形");
            cbotestaction2.Items.Add("关断驱动");

            cbotestaction2.SelectedIndex = CComLibrary.GlobeVal.filesave.mtestaction[1];
            numtestactionspeed2.Value = CComLibrary.GlobeVal.filesave.mtestactionreturnspeed[1];


            cbotestaction3.Items.Clear();
            cbotestaction3.Items.Add("停于位置");
            cbotestaction3.Items.Add("返回初始状态");
            cbotestaction3.Items.Add("返回预负荷");
            cbotestaction3.Items.Add("停于负荷");
            cbotestaction3.Items.Add("停于变形");
            cbotestaction3.Items.Add("关断驱动");

            cbotestaction3.SelectedIndex = CComLibrary.GlobeVal.filesave.mtestaction[2];
            numtestactionspeed3.Value = CComLibrary.GlobeVal.filesave.mtestactionreturnspeed[2];


            cbotestaction4.Items.Clear();
            cbotestaction4.Items.Add("停于位置");
            cbotestaction4.Items.Add("返回初始状态");
            cbotestaction4.Items.Add("返回预负荷");
            cbotestaction4.Items.Add("停于负荷");
            cbotestaction4.Items.Add("停于变形");
            cbotestaction4.Items.Add("关断驱动");

            cbotestaction4.SelectedIndex = CComLibrary.GlobeVal.filesave.mtestaction[3];
            numtestactionspeed4.Value = CComLibrary.GlobeVal.filesave.mtestactionreturnspeed[3];

            NumTestTimeForEnd.Value = CComLibrary.GlobeVal.filesave.mtesttimeforend ;

            cbotestaction5.Items.Clear();
            cbotestaction5.Items.Add("停于位置");
            cbotestaction5.Items.Add("返回初始状态");
            cbotestaction5.Items.Add("返回预负荷");
            cbotestaction5.Items.Add("停于负荷");
            cbotestaction5.Items.Add("停于变形");
            cbotestaction5.Items.Add("关断驱动");

            cbotestaction5.SelectedIndex = CComLibrary.GlobeVal.filesave.mtestactionfortesttime ;
            numtestactionspeed5.Value = CComLibrary.GlobeVal.filesave.mtestactionreturnspeedfortesttime;


        }

        public void Add(int i, ref CComLibrary.SegFile sf)
        {


            grid2.Rows.Insert(i);



            grid2[i, 0] = new SourceGrid2.Cells.Real.Cell(
                   i.ToString(), typeof(string));


            grid2[i, 1] = new SourceGrid2.Cells.Real.ComboBox(sf.cmdstring[sf.mseglist[i - 1].cmd]
                 , typeof(string),
                sf.cmdstring, false);




            SourceGrid2.BehaviorModels.CustomEvents cmdclick = new SourceGrid2.BehaviorModels.CustomEvents();
            cmdclick.ValueChanged += new SourceGrid2.PositionEventHandler(cmdclick_ValueChanged);

            grid2[i, 1].Behaviors.Add(cmdclick);




            grid2[i, 2] = new SourceGrid2.Cells.Real.Button(
                    typeof(string));

            if (grid2[i, 1].Value.ToString() == "停止")
            {
                grid2[i, 2].Value = "";
            }
            else
            {
                grid2[i, 2].Value = sf.mseglist[i - 1].speedconvert() + " " + sf.mseglist[i - 1].dirconvert();
            }

            SourceGrid2.BehaviorModels.CustomEvents textclick = new SourceGrid2.BehaviorModels.CustomEvents();
            textclick.DoubleClick += new SourceGrid2.PositionEventHandler(textclick_DoubleClick);

            grid2[i, 2].Behaviors.Add(textclick);

            grid2[i, 3] = new SourceGrid2.Cells.Real.Button(
                                     typeof(string));

            if (grid2[i, 1].Value.ToString() == "停止")
            {
                grid2[i, 3].Value = "";
            }
            else
            {
                grid2[i, 3].Value = sf.mseglist[i - 1].destconvert();
            }


            grid2[i, 3].Behaviors.Add(textclick);

            grid2[i, 4] = new SourceGrid2.Cells.Real.ComboBox(sf.actionstring[sf.mseglist[i - 1].action]
                     , typeof(string),
                 sf.actionstring, false);

            SourceGrid2.BehaviorModels.CustomEvents actionclick = new SourceGrid2.BehaviorModels.CustomEvents();
            actionclick.ValueChanged += new SourceGrid2.PositionEventHandler(actionclick_ValueChanged);



            grid2[i, 4].Behaviors.Add(actionclick);

            grid2[i, 5] = new SourceGrid2.Cells.Real.Button(
                    typeof(string));
            if (grid2[i, 1].Value.ToString() == "停止")
            {
                grid2[i, 5].Value = "";
            }
            else
            {
                (grid2[i, 5] as SourceGrid2.Cells.Real.Button).Value = sf.mseglist[i - 1].cyclicconvert();

            }

            grid2[i, 5].Behaviors.Add(textclick);
            grid2[i, 6] = new SourceGrid2.Cells.Real.Cell(
                                sf.mseglist[i - 1].explain, typeof(string));
        }

        void textclick_DoubleClick(object sender, SourceGrid2.PositionEventArgs e)
        {
            if (e.Position.Column == 2)
            {

                if (GlobeVal.myglobefile.machinekind == 2)
                {
                    if (sf.mseglist[e.Position.Row - 1].cmd == 2)
                    {
                        Frm.Frm围压控制参数 f = new TabHeaderDemo.Frm.Frm围压控制参数();
                        f.result = false;

                        f.lblspeed.Text = "速度(MPa/s):";
                        f.numericEdit1.Value = sf.mseglist[e.Position.Row - 1].speed;
                        f.Text = "控制参数步骤" + e.Position.Row.ToString().Trim();
                        f.ShowDialog();
                        if (f.result == true)
                        {
                            sf.mseglist[e.Position.Row - 1].speed = f.numericEdit1.Value;


                            grid2[e.Position.Row, e.Position.Column].Value = sf.mseglist[e.Position.Row - 1].speedconvert();



                        }
                    }

                    else
                    {

                        Frm.Form控制参数 f = new TabHeaderDemo.Frm.Form控制参数();

                        f.result = false;


                        if (sf.mseglist[e.Position.Row - 1].controlmode == 0)
                        {
                            f.radioButton1.Text = "位移速度";
                            f.lblUnit.Text = "mm/s";
                            f.radioButton2.Visible = false;
                            f.panel1.Visible = false;

                        }
                        else
                        {
                            f.radioButton1.Text = "力速度";
                            f.lblUnit.Text = "kN/s";
                            f.radioButton2.Visible = true;
                            f.panel1.Visible = true;

                        }


                        f.numericEdit1.Value = sf.mseglist[e.Position.Row - 1].speed;
                        f.Text = "控制参数步骤" + e.Position.Row.ToString().Trim();
                        f.ShowDialog();
                        if (f.result == true)
                        {
                            sf.mseglist[e.Position.Row - 1].speed = f.numericEdit1.Value;


                            grid2[e.Position.Row, e.Position.Column].Value = sf.mseglist[e.Position.Row - 1].speedconvert();


                        }
                    }
                }
                else


                {
                    Frm.Form标准控制参数 f = new TabHeaderDemo.Frm.Form标准控制参数();

                    f.result = false;



                    f.lblname.Text = ClsStaticStation.m_Global.mycls.hardsignals[sf.mseglist[e.Position.Row - 1].controlmode].cName + "速度";
                    f.lblUnit.Text = ClsStaticStation.m_Global.mycls.hardsignals[sf.mseglist[e.Position.Row - 1].controlmode].speedSignal.cUnits[0];



                    if (ClsStaticStation.m_Global.mycls.hardsignals[sf.mseglist[e.Position.Row - 1].controlmode].cUnitKind == 1)
                    {
                        f.panel1.Visible = true;

                    }
                    else
                    {
                        f.panel1.Visible = false;
                    }

                    f.numericEdit1.Value = sf.mseglist[e.Position.Row - 1].speed;
                    f.Text = "控制参数步骤" + e.Position.Row.ToString().Trim();
                    f.ShowDialog();
                    if (f.result == true)
                    {
                        sf.mseglist[e.Position.Row - 1].speed = f.numericEdit1.Value;


                        grid2[e.Position.Row, e.Position.Column].Value = sf.mseglist[e.Position.Row - 1].speedconvert();


                    }

                }


            }
            if (e.Position.Column == 3)
            {
                if (GlobeVal.myglobefile.machinekind == 2)
                {


                    if (sf.mseglist[e.Position.Row - 1].cmd == 2)  //围压设置
                    {
                        Frm.Form围压跳转条件 f = new TabHeaderDemo.Frm.Form围压跳转条件();

                        f.Text = "跳转条件步骤" + e.Position.Row.ToString().Trim();
                        f.result = false;
                        f.rbtnload.Checked = true;

                        sf.mseglist[e.Position.Row - 1].destcontrolmode = 1;

                        f.numericEdit2.Value = sf.mseglist[e.Position.Row - 1].dest;
                        f.ShowDialog();

                        if (f.result == true)
                        {
                            sf.mseglist[e.Position.Row - 1].destcontrolmode = 1;
                            sf.mseglist[e.Position.Row - 1].dest = f.numericEdit2.Value;
                            sf.mseglist[e.Position.Row - 1].keeptime = 0;
                        }

                        grid2[e.Position.Row, e.Position.Column].Value = sf.mseglist[e.Position.Row - 1].destconvert();

                    }
                    else
                    {

                        Frm.Form跳转条件 f = new TabHeaderDemo.Frm.Form跳转条件();
                        f.Text = "跳转条件步骤" + e.Position.Row.ToString().Trim();
                        f.result = false;


                        if (sf.mseglist[e.Position.Row - 1].destcontrolmode == 0)
                        {
                            f.rbtnpos.Checked = true;
                        }
                        else
                        {
                            f.rbtnload.Checked = true;
                        }
                        f.numericEdit1.Value = sf.mseglist[e.Position.Row - 1].dest;
                        f.numericEdit2.Value = sf.mseglist[e.Position.Row - 1].dest;
                        f.numericEdit3.Value = sf.mseglist[e.Position.Row - 1].keeptime;

                        f.ShowDialog();

                        if (f.result == true)
                        {
                            if (f.rbtnpos.Checked == true)
                            {
                                sf.mseglist[e.Position.Row - 1].destcontrolmode = 0;
                                sf.mseglist[e.Position.Row - 1].dest = f.numericEdit1.Value;
                                sf.mseglist[e.Position.Row - 1].keeptime = f.numericEdit3.Value;

                            }
                            else
                            {
                                sf.mseglist[e.Position.Row - 1].destcontrolmode = 1;
                                sf.mseglist[e.Position.Row - 1].dest = f.numericEdit2.Value;
                                sf.mseglist[e.Position.Row - 1].keeptime = f.numericEdit3.Value;
                            }



                            grid2[e.Position.Row, e.Position.Column].Value = sf.mseglist[e.Position.Row - 1].destconvert();
                        }
                    }
                }
                else

                {

                    Frm.Form标准跳转条件 f = new TabHeaderDemo.Frm.Form标准跳转条件();

                    f.Text = "跳转条件步骤" + e.Position.Row.ToString().Trim();
                    f.result = false;

                    f.comboBox1.Items.Clear();

                    for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals.Count; i++)
                    {
                        f.comboBox1.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[i].cName);
                    }



                    if ((sf.mseglist[e.Position.Row - 1].destcontrolmode >= 0) && (sf.mseglist[e.Position.Row - 1].destcontrolmode < f.comboBox1.Items.Count))
                    {

                    }
                    else
                    {
                        sf.mseglist[e.Position.Row - 1].destcontrolmode = 0;
                    }

                    f.comboBox1.SelectedIndex = sf.mseglist[e.Position.Row - 1].destcontrolmode;


                    f.cbomode.Items.Clear();
                    f.cbomode.Items.Add("切换");
                    f.cbomode.Items.Add("不切换");
                    f.cbomode.Items.Add("跟随");
                    f.cbomode.SelectedIndex = sf.mseglist[e.Position.Row - 1].destmod;


                    f.lblunit.Text = ClsStaticStation.m_Global.mycls.hardsignals[sf.mseglist[e.Position.Row - 1].destcontrolmode].cUnits[0];

                    if (ClsStaticStation.m_Global.mycls.hardsignals[sf.mseglist[e.Position.Row - 1].destcontrolmode].cUnitKind == 1)
                    {
                        f.panel1.Visible = true;

                    }
                    else
                    {
                        f.panel1.Visible = false;
                    }


                    f.numericEdit2.Value = sf.mseglist[e.Position.Row - 1].dest;
                    f.numericEdit3.Value = sf.mseglist[e.Position.Row - 1].keeptime;
                    f.ShowDialog();

                    if (f.result == true)
                    {
                        sf.mseglist[e.Position.Row - 1].destcontrolmode = f.comboBox1.SelectedIndex;
                        sf.mseglist[e.Position.Row - 1].dest = f.numericEdit2.Value;
                        sf.mseglist[e.Position.Row - 1].keeptime = f.numericEdit3.Value;
                        sf.mseglist[e.Position.Row - 1].destmod = f.cbomode.SelectedIndex;
                    }

                    grid2[e.Position.Row, e.Position.Column].Value = sf.mseglist[e.Position.Row - 1].destconvert();
                }
            }

            if (e.Position.Column == 5)
            {
                if (sf.mseglist[e.Position.Row - 1].cmd == 3)
                {
                    grid2[e.Position.Row, e.Position.Column].Value = "";
                    return;
                }
                Frm.Form循环执行 f = new TabHeaderDemo.Frm.Form循环执行();
                f.Text = "循环执行步骤" + e.Position.Row.ToString().Trim();
                f.result = false;

                f.chkcyclic.Checked = sf.mseglist[e.Position.Row - 1].cyclicrun;
                f.numericEdit1.Value = sf.mseglist[e.Position.Row - 1].cycliccount;
                f.numericEdit2.Value = sf.mseglist[e.Position.Row - 1].returnstep;
                f.numericEdit3.Value = sf.mseglist[e.Position.Row - 1].havedcount;
                f.ShowDialog();
                if (f.result == true)
                {
                    sf.mseglist[e.Position.Row - 1].cyclicrun = f.chkcyclic.Checked;
                    sf.mseglist[e.Position.Row - 1].cycliccount = Convert.ToInt32(f.numericEdit1.Value);
                    sf.mseglist[e.Position.Row - 1].returnstep = Convert.ToInt32(f.numericEdit2.Value);
                    grid2[e.Position.Row, e.Position.Column].Value = sf.mseglist[e.Position.Row - 1].cyclicconvert();
                }
            }

            return;
        }

        void actionclick_ValueChanged(object sender, SourceGrid2.PositionEventArgs e)
        {
            int c = 0;
            for (int i = 0; i < sf.actionstring.Length; i++)
            {
                if (sf.actionstring[i] == e.Cell.GetValue(e.Position).ToString())
                {
                    c = i;
                }
            }
            sf.mseglist[e.Position.Row - 1].action = c;

        }

        void cmdclick_ValueChanged(object sender, SourceGrid2.PositionEventArgs e)
        {
            int c = 0;
            for (int i = 0; i < sf.cmdstring.Length; i++)
            {
                if (sf.cmdstring[i] == e.Cell.GetValue(e.Position).ToString())
                {
                    c = i;
                }
            }

            sf.mseglist[e.Position.Row - 1].cmd = c;

            sf.mseglist[e.Position.Row - 1].controlmode = c;




            SourceGrid2.PositionEventArgs m;

            m = new SourceGrid2.PositionEventArgs(new SourceGrid2.Position(e.Position.Row, 2), null);
            this.textclick_DoubleClick(sender, m);

            m = new SourceGrid2.PositionEventArgs(new SourceGrid2.Position(e.Position.Row, 3), null);
            this.textclick_DoubleClick(sender, m);
        }

        void behaviorClick_Click(object sender, SourceGrid2.PositionEventArgs e)
        {

        }

        public void Init_简单()
        {

        }



        public void Init_中级1()
        {
            if(CComLibrary.GlobeVal.filesave.mPARA_LOOPS<1)
            {
                CComLibrary.GlobeVal.filesave.mPARA_LOOPS = 1;
            }
            numLoopCount.Value = CComLibrary.GlobeVal.filesave.mPARA_LOOPS;

            UserControlCheckStep m1;

            tlpstep.Controls.Clear();

            tlpstep.RowStyles.Clear();

            for (int i = 0; i < CComLibrary.GlobeVal.filesave.msegtestcount; i++)
            {
                m1 = new UserControlCheckStep();
                m1.Dock = DockStyle.Fill;
               
                m1.chkline.Text = "段" + (i + 1).ToString().Trim();
                
                m1.CheckChanged += M1_CheckChanged;
              
                m1.Id = i;
                tlpstep.Controls.Add(m1);
                m1.chkline.Checked = true;

              




            }

            if (CComLibrary.GlobeVal.filesave.msegtestcount <= 11)
            {
                m1 = new UserControlCheckStep();
                m1.Dock = DockStyle.Fill;
                
                m1.chkline.Text = "段" + (CComLibrary.GlobeVal.filesave.msegtestcount + 1).ToString().Trim();
                m1.Id = CComLibrary.GlobeVal.filesave.msegtestcount;
                m1.CheckChanged += M1_CheckChanged;
                m1.chkline.Checked = false;
                tlpstep.Controls.Add(m1);
                m1.Height = m1.UnCheckHeight;
            }
        }

        private void M1_CheckChanged(object sender, EventArgs e)
        {
            UserControlCheckStep m1;
            if ((sender as UserControlCheckStep).Id == 0)
            {
                (sender as UserControlCheckStep).chkline.Checked = true;
            }
            else
            {
                if ((sender as UserControlCheckStep).Id < CComLibrary.GlobeVal.filesave.msegtestcount - 1)
                {
                    (sender as UserControlCheckStep).chkline.Checked = true;
                }

                else if ((sender as UserControlCheckStep).Id == CComLibrary.GlobeVal.filesave.msegtestcount - 1)
                {
                    if ((sender as UserControlCheckStep).chkline.Checked == false)
                    {
                        tlpstep.Controls.RemoveAt(CComLibrary.GlobeVal.filesave.msegtestcount);
                        CComLibrary.GlobeVal.filesave.msegtestcount = CComLibrary.GlobeVal.filesave.msegtestcount - 1;
                    }
                }
                else if((sender as UserControlCheckStep).Id == CComLibrary.GlobeVal.filesave.msegtestcount)
                {
                    if ((sender as UserControlCheckStep).chkline.Checked == true)
                    {
                        CComLibrary.GlobeVal.filesave.msegtestcount = CComLibrary.GlobeVal.filesave.msegtestcount + 1;
                        m1 = new UserControlCheckStep();
                        m1.Dock = DockStyle.Fill;
                        
                        m1.chkline.Text = "段" + (CComLibrary.GlobeVal.filesave.msegtestcount + 1).ToString().Trim();
                        m1.Id = CComLibrary.GlobeVal.filesave.msegtestcount;
                        m1.CheckChanged += M1_CheckChanged;
                        
                        tlpstep.Controls.Add(m1);
                        m1.Height = m1.UnCheckHeight;
                       

                    }
                }

            }
            return;
        }

        public void Init_中级()
        {

            int i = 0;
            toolStrip1.Visible = true;

            mloaded = true;

            grid2.RowsCount = 0;
            grid2.AutoStretchColumnsToFitWidth = true;

            grid2.BorderStyle = BorderStyle.FixedSingle;

            grid2.ColumnsCount = 7;
            grid2.Columns[0].Width = 50;
            grid2.Columns[1].Width = grid2.Width / 7;
            grid2.Columns[2].Width = grid2.Width / 7;
            grid2.Columns[3].Width = grid2.Width / 7;
            grid2.Columns[4].Width = grid2.Width / 7;
            grid2.Columns[5].Width = grid2.Width / 7;
            grid2.Columns[6].Width = grid2.Width / 7;
            grid2.CustomSort = false;
            grid2.Columns[1].AutoSizeMode = SourceGrid2.AutoSizeMode.EnableStretch;
            grid2.FixedRows = 1;
            grid2.Rows.Insert(0);
            grid2.Rows[0].Height = 25;

            SourceGrid2.Cells.Real.ColumnHeader head;
            head = new SourceGrid2.Cells.Real.ColumnHeader("步骤");
            head.EnableSort = false;
            grid2[0, 0] = head;



            head = new SourceGrid2.Cells.Real.ColumnHeader("控制对象");

            head.EnableSort = false;
            grid2[0, 1] = head;

            head = new SourceGrid2.Cells.Real.ColumnHeader("控制参数");
            head.EnableSort = false;
            grid2[0, 2] = head;

            head = new SourceGrid2.Cells.Real.ColumnHeader("控制目标和保持时间");
            head.EnableSort = false;
            grid2[0, 3] = head;

            head = new SourceGrid2.Cells.Real.ColumnHeader("控制模式");
            head.EnableSort = false;
            grid2[0, 4] = head;

            head = new SourceGrid2.Cells.Real.ColumnHeader("周期波参数");
            head.EnableSort = false;
            grid2[0, 5] = head;

            head = new SourceGrid2.Cells.Real.ColumnHeader("说明");
            head.EnableSort = false;
            grid2[0, 6] = head;

            sf = new CComLibrary.SegFile();


            for (i = 1; i <= sf.mseglist.Count; i++)
            {
                Add(i, ref sf);
            }
            tscbo.Items.Clear();
            DirectoryInfo info = new DirectoryInfo(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\seg");
            FileInfo[] files = info.GetFiles("*.seg");
            foreach (FileInfo file in files)
            {
                tscbo.Items.Add(file.Name);

                if (CComLibrary.GlobeVal.filesave.SegName == file.Name)
                {
                    tscbo.Text = file.Name;
                }
            }

            mloaded = false;


            if (tscbo.Text == "")
            {
                // tscbo_SelectedIndexChanged(null, null);
            }
            else
            {
                tscbo_SelectedIndexChanged(null, null);


            }



        }
        public void Init_数据()
        {
            cbosamplemode.Items.Clear();
            cbosamplemode.Items.Add("静态采集方式");
            cbosamplemode.Items.Add("动态采集方式");
            //cbosamplemode.Items.Add("高级控制采集方式");

            cbosamplemode.SelectedIndex = CComLibrary.GlobeVal.filesave.Samplingmode;





            cbosamplemode_SelectionChangeCommitted(null, null);

            CComLibrary.GlobeVal.filesave.chkcriteria[0] = true;
            chkcriteria1.Checked = CComLibrary.GlobeVal.filesave.chkcriteria[0];
            CComLibrary.GlobeVal.filesave.chkcriteria[1] = true;

            chkcriteria2.Checked = CComLibrary.GlobeVal.filesave.chkcriteria[1];
            CComLibrary.GlobeVal.filesave.chkcriteria[2] = true;
            chkcriteria3.Checked = CComLibrary.GlobeVal.filesave.chkcriteria[2];
            CComLibrary.GlobeVal.filesave.chkcriteria[3] = true;
            chkcriteria4.Checked = CComLibrary.GlobeVal.filesave.chkcriteria[3];


            cbomeasurement1.Items.Clear();


            for (int i = 0; i < ClsStaticStation.m_Global.mycls.allsignals.Count; i++)
            {
                cbomeasurement1.Items.Add(ClsStaticStation.m_Global.mycls.allsignals[i].cName);

                if(ClsStaticStation.m_Global.mycls.allsignals[i].cName=="时间")
                {
                    CComLibrary.GlobeVal.filesave.cbomeasurement[0] = i;
                }
            }
            cbomeasurement1.SelectedIndex = CComLibrary.GlobeVal.filesave.cbomeasurement[0];



            cbomeasurement2.Items.Clear();


            for (int i = 0; i < ClsStaticStation.m_Global.mycls.allsignals.Count; i++)
            {
                cbomeasurement2.Items.Add(ClsStaticStation.m_Global.mycls.allsignals[i].cName);
                if (ClsStaticStation.m_Global.mycls.allsignals[i].cName == "位移")
                {
                    CComLibrary.GlobeVal.filesave.cbomeasurement[1] = i;
                }
            }
            cbomeasurement2.SelectedIndex = CComLibrary.GlobeVal.filesave.cbomeasurement[1];



            cbomeasurement3.Items.Clear();


            for (int i = 0; i < ClsStaticStation.m_Global.mycls.allsignals.Count; i++)
            {
                cbomeasurement3.Items.Add(ClsStaticStation.m_Global.mycls.allsignals[i].cName);
                if (ClsStaticStation.m_Global.mycls.allsignals[i].cName == "力")
                {
                    CComLibrary.GlobeVal.filesave.cbomeasurement[2] = i;
                }
            }
            cbomeasurement3.SelectedIndex = CComLibrary.GlobeVal.filesave.cbomeasurement[2];

            cbomeasurement4.Items.Clear();


            for (int i = 0; i < ClsStaticStation.m_Global.mycls.allsignals.Count; i++)
            {
                cbomeasurement4.Items.Add(ClsStaticStation.m_Global.mycls.allsignals[i].cName);
                if (ClsStaticStation.m_Global.mycls.allsignals[i].cName == "平均变形")
                {
                    CComLibrary.GlobeVal.filesave.cbomeasurement[3] = i;
                }
            }
            cbomeasurement4.SelectedIndex = CComLibrary.GlobeVal.filesave.cbomeasurement[3];


            lblinterval1.Text = ClsStaticStation.m_Global.mycls.allsignals[cbomeasurement1.SelectedIndex].cUnits[0];
            lblinterval2.Text = ClsStaticStation.m_Global.mycls.allsignals[cbomeasurement2.SelectedIndex].cUnits[0];
            lblinterval3.Text = ClsStaticStation.m_Global.mycls.allsignals[cbomeasurement3.SelectedIndex].cUnits[0];
            lblinterval4.Text = ClsStaticStation.m_Global.mycls.allsignals[cbomeasurement4.SelectedIndex].cUnits[0];



            numinterval1.Value = CComLibrary.GlobeVal.filesave.numinterval[0];
            numinterval2.Value = CComLibrary.GlobeVal.filesave.numinterval[1];
            numinterval3.Value = CComLibrary.GlobeVal.filesave.numinterval[2];
            numinterval4.Value = CComLibrary.GlobeVal.filesave.numinterval[3];

            chkcriteria1_CheckedChanged(null, null);
            chkcriteria2_CheckedChanged(null, null);
            chkcriteria3_CheckedChanged(null, null);
            chkcriteria4_CheckedChanged(null, null);

            //-------------------

            CComLibrary.GlobeVal.filesave.mSaveCriteria = true;
            chkSaveCriteria.Checked = CComLibrary.GlobeVal.filesave.mSaveCriteria;

            cboSaveCriteria.Items.Clear();
            cboSaveCriteria.Items.Add("按照时间存盘");
            cboSaveCriteria.Items.Add("按照控制器采集间隔保存");
            cboSaveCriteria.Items.Add("按照波形间隔");
            cboSaveCriteria.Items.Add("按照循环间隔");
            
            cboSaveCriteria.SelectedIndex = CComLibrary.GlobeVal.filesave.mSaveCriteriaMode;

            if(CComLibrary.GlobeVal.filesave.mSaveCountSeg<2)
            {
                CComLibrary.GlobeVal.filesave.mSaveCountSeg = 2;
            }
            numSaveCountSeg.Value = CComLibrary.GlobeVal.filesave.mSaveCountSeg;
            numSaveCyclcCount.Value = CComLibrary.GlobeVal.filesave.mSaveCyclcCount;
            numSaveWaveCount.Value = CComLibrary.GlobeVal.filesave.mSaveWaveCount;

            chkSaveCriteria_CheckedChanged(null, null);


            
         

            for (int i=0;i<6;i++)
            {
                dgridsave.Columns[i].Width = dgridsave.Width / 6;
            }


            numSaveCountSeg_ValueChanged(null, null);

            if (CComLibrary.GlobeVal.filesave.mKeepTest ==1)
            {
                chkKeepTime.Checked = true;
            }
            else
            {
                chkKeepTime.Checked = false;
            }
          

        }

        public void Init_应变()
        {
            chkremoveext.Checked = CComLibrary.GlobeVal.filesave.chkextremove;
            CComLibrary.GlobeVal.filesave.Extensometer_removal = 0;
            cboextruler.SelectedIndex = 0;
            cboextchannel.Items.Clear();

            for (int i = 0; i < m_Global.mycls.hardsignals.Count; i++)
            {
                cboextchannel.Items.Add(m_Global.mycls.hardsignals[i].cName);

            }
            if ((CComLibrary.GlobeVal.filesave.Extensometer_DataChannel >= 0) && (CComLibrary.GlobeVal.filesave.Extensometer_DataChannel < cboextchannel.Items.Count))
            {
                cboextchannel.SelectedIndex = CComLibrary.GlobeVal.filesave.Extensometer_DataChannel;
            }
            else
            {
                CComLibrary.GlobeVal.filesave.Extensometer_DataChannel = 0;
                cboextchannel.SelectedIndex = 0;
            }



            numext.Value = CComLibrary.GlobeVal.filesave.Extensometer_DataValue;
            cboextunit.Items.Clear();
            for (int i = 0; i < m_Global.mycls.hardsignals[CComLibrary.GlobeVal.filesave.Extensometer_DataChannel].cUnitCount; i++)
            {
                cboextunit.Items.Add(m_Global.mycls.hardsignals[CComLibrary.GlobeVal.filesave.Extensometer_DataChannel].cUnits[i]);

            }


            if ((CComLibrary.GlobeVal.filesave.Extensometer_DataValueUnit >= 0) && (CComLibrary.GlobeVal.filesave.Extensometer_DataValueUnit <
            m_Global.mycls.hardsignals[CComLibrary.GlobeVal.filesave.Extensometer_DataChannel].cUnitCount))
            {

                cboextunit.SelectedIndex = CComLibrary.GlobeVal.filesave.Extensometer_DataValueUnit;
            }

            else
            {
                CComLibrary.GlobeVal.filesave.Extensometer_DataValueUnit = 0;
                cboextunit.SelectedIndex = 0;
            }
            cboextact.SelectedIndex = CComLibrary.GlobeVal.filesave.Extensometer_Action;
            chkfrozen.Checked = CComLibrary.GlobeVal.filesave.Extensometer_DataFrozen;
            numgauge.Value = CComLibrary.GlobeVal.filesave.Extensometer_gauge;
            numgauge1.Value = CComLibrary.GlobeVal.filesave.Extensometer1_gauge;

        }
        public void Init_设置控制()
        {

            CComLibrary.GlobeVal.filesave.mcontrolprocess = 1;
            
            chkAlarm.Checked = CComLibrary.GlobeVal.filesave.malarm;
            chkAlarm_CheckStateChanged(null, null);
            numAlarm1.Value = CComLibrary.GlobeVal.filesave.malarmvalue1;
            numAlarm2.Value = CComLibrary.GlobeVal.filesave.malarmvalue2;
            numAlarm3.Value = CComLibrary.GlobeVal.filesave.malarmvalue3;
            numAlarm4.Value = CComLibrary.GlobeVal.filesave.malarmvalue4;

            num_CREEP_REF_TIME.Value = CComLibrary.GlobeVal.filesave.mCREEP_REF_TIME;
            num_CREEP_EXTENSION_LIMIT.Value= CComLibrary.GlobeVal.filesave.mCREEP_EXTENSION_LIMIT;

        }
        private void list_autozerosetvalue()
        {
            int i;
            CComLibrary.GlobeVal.filesave.mautozero.Clear();
            for (i = 0; i < this.lstinclude.Items.Count; i++)
            {
                CComLibrary.GlobeVal.filesave.mautozero.Add(this.lstinclude.list[i]);
            }
        }
        public void Init_测试()
        {
            cbomode1.Items.Clear();
            cbomode1.Items.Add("轴向");
            cbomode1.SelectedIndex = 0;

            cbomode2.Items.Clear();
            cbomode2.Items.Add("轴向");
            cbomode2.SelectedIndex = 0;

            cbomode3.Items.Clear();
            cbomode3.Items.Add("轴向");
            cbomode3.SelectedIndex = 0;


            cbomode4.Items.Clear();
            cbomode4.Items.Add("轴向");
            cbomode4.SelectedIndex = 0;


            chkline1.Checked = CComLibrary.GlobeVal.filesave.testcmdstep[0].check;
            chkline2.Checked = CComLibrary.GlobeVal.filesave.testcmdstep[1].check;
            chkline3.Checked = CComLibrary.GlobeVal.filesave.testcmdstep[2].check;
            chkline4.Checked = CComLibrary.GlobeVal.filesave.testcmdstep[3].check;

            cbocontrol1.Items.Clear();
            cbocontrol2.Items.Clear();
            cbocontrol3.Items.Clear();
            cbocontrol4.Items.Clear();

            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals.Count; i++)
            {
                cbocontrol1.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[i].cName);
                cbocontrol2.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[i].cName);
                cbocontrol3.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[i].cName);
                cbocontrol4.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[i].cName);
            }

            if ((CComLibrary.GlobeVal.filesave.testcmdstep[0].controlmode >= 0) && (CComLibrary.GlobeVal.filesave.testcmdstep[0].controlmode < cbocontrol1.Items.Count))
            {
                cbocontrol1.SelectedIndex = CComLibrary.GlobeVal.filesave.testcmdstep[0].controlmode;
            }
            else
            {
                CComLibrary.GlobeVal.filesave.testcmdstep[0].controlmode = 0;
                cbocontrol1.SelectedIndex = 0;
            }

            if ((CComLibrary.GlobeVal.filesave.testcmdstep[1].controlmode >= 0) && (CComLibrary.GlobeVal.filesave.testcmdstep[1].controlmode < cbocontrol2.Items.Count))
            {
                cbocontrol2.SelectedIndex = CComLibrary.GlobeVal.filesave.testcmdstep[1].controlmode;
            }
            else
            {
                CComLibrary.GlobeVal.filesave.testcmdstep[1].controlmode = 0;
                cbocontrol2.SelectedIndex = 0;
            }

            if ((CComLibrary.GlobeVal.filesave.testcmdstep[2].controlmode >= 0) && (CComLibrary.GlobeVal.filesave.testcmdstep[2].controlmode < cbocontrol3.Items.Count))
            {
                cbocontrol3.SelectedIndex = CComLibrary.GlobeVal.filesave.testcmdstep[2].controlmode;
            }
            else
            {
                CComLibrary.GlobeVal.filesave.testcmdstep[2].controlmode = 0;
                cbocontrol3.SelectedIndex = 0;
            }


            if ((CComLibrary.GlobeVal.filesave.testcmdstep[3].controlmode >= 0) && (CComLibrary.GlobeVal.filesave.testcmdstep[3].controlmode < cbocontrol4.Items.Count))
            {
                cbocontrol4.SelectedIndex = CComLibrary.GlobeVal.filesave.testcmdstep[3].controlmode;
            }
            else
            {
                CComLibrary.GlobeVal.filesave.testcmdstep[3].controlmode = 0;
                cbocontrol4.SelectedIndex = 0;
            }
            cbospeedunit1.Items.Clear();
            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbocontrol1.SelectedIndex].speedSignal.cUnitCount; i++)
            {
                cbospeedunit1.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbocontrol1.SelectedIndex].speedSignal.cUnits[i]);

            }

            if ((CComLibrary.GlobeVal.filesave.testcmdstep[0].speedunit > 0) && (CComLibrary.GlobeVal.filesave.testcmdstep[0].speedunit < cbospeedunit1.Items.Count))

            {
                cbospeedunit1.SelectedIndex = CComLibrary.GlobeVal.filesave.testcmdstep[0].speedunit;
            }
            else
            {
                CComLibrary.GlobeVal.filesave.testcmdstep[0].speedunit = 0;
                cbospeedunit1.SelectedIndex = 0;
            }
            cbospeedunit2.Items.Clear();
            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbocontrol2.SelectedIndex].speedSignal.cUnitCount; i++)
            {
                cbospeedunit2.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbocontrol2.SelectedIndex].speedSignal.cUnits[i]);

            }
            if ((CComLibrary.GlobeVal.filesave.testcmdstep[1].speedunit > 0) && (CComLibrary.GlobeVal.filesave.testcmdstep[1].speedunit < cbospeedunit2.Items.Count))

            {
                cbospeedunit2.SelectedIndex = CComLibrary.GlobeVal.filesave.testcmdstep[1].speedunit;
            }
            else
            {
                CComLibrary.GlobeVal.filesave.testcmdstep[1].speedunit = 0;
                cbospeedunit2.SelectedIndex = 0;
            }

            cbospeedunit3.Items.Clear();
            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbocontrol3.SelectedIndex].speedSignal.cUnitCount; i++)
            {
                cbospeedunit3.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbocontrol3.SelectedIndex].speedSignal.cUnits[i]);

            }

            if ((CComLibrary.GlobeVal.filesave.testcmdstep[2].speedunit > 0) && (CComLibrary.GlobeVal.filesave.testcmdstep[2].speedunit < cbospeedunit3.Items.Count))

            {
                cbospeedunit3.SelectedIndex = CComLibrary.GlobeVal.filesave.testcmdstep[2].speedunit;
            }
            else
            {
                CComLibrary.GlobeVal.filesave.testcmdstep[2].speedunit = 0;
                cbospeedunit3.SelectedIndex = 0;
            }




            cbospeedunit4.Items.Clear();
            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbocontrol4.SelectedIndex].speedSignal.cUnitCount; i++)
            {
                cbospeedunit4.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbocontrol4.SelectedIndex].speedSignal.cUnits[i]);

            }
            if ((CComLibrary.GlobeVal.filesave.testcmdstep[3].speedunit > 0) && (CComLibrary.GlobeVal.filesave.testcmdstep[3].speedunit < cbospeedunit4.Items.Count))

            {
                cbospeedunit4.SelectedIndex = CComLibrary.GlobeVal.filesave.testcmdstep[3].speedunit;
            }
            else
            {
                CComLibrary.GlobeVal.filesave.testcmdstep[3].speedunit = 0;
                cbospeedunit4.SelectedIndex = 0;
            }



            cbodestcontrol1.Items.Clear();
            cbodestcontrol2.Items.Clear();
            cbodestcontrol3.Items.Clear();
            cbodestcontrol4.Items.Clear();

            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals.Count; i++)
            {
                cbodestcontrol1.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[i].cName);
                cbodestcontrol2.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[i].cName);
                cbodestcontrol3.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[i].cName);
                cbodestcontrol4.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[i].cName);

            }
            if ((CComLibrary.GlobeVal.filesave.testcmdstep[0].destcontrolmode >= 0) && (CComLibrary.GlobeVal.filesave.testcmdstep[0].destcontrolmode < cbodestcontrol1.Items.Count))
            {
                cbodestcontrol1.SelectedIndex = CComLibrary.GlobeVal.filesave.testcmdstep[0].destcontrolmode;
            }
            else
            {
                CComLibrary.GlobeVal.filesave.testcmdstep[0].destcontrolmode = 0;
                cbodestcontrol1.SelectedIndex = 0;
            }
            if ((CComLibrary.GlobeVal.filesave.testcmdstep[1].destcontrolmode >= 0) && (CComLibrary.GlobeVal.filesave.testcmdstep[1].destcontrolmode < cbodestcontrol2.Items.Count))
            {
                cbodestcontrol2.SelectedIndex = CComLibrary.GlobeVal.filesave.testcmdstep[1].destcontrolmode;
            }
            else
            {
                CComLibrary.GlobeVal.filesave.testcmdstep[1].destcontrolmode = 0;
                cbodestcontrol2.SelectedIndex = 0;
            }

            if ((CComLibrary.GlobeVal.filesave.testcmdstep[2].destcontrolmode >= 0) && (CComLibrary.GlobeVal.filesave.testcmdstep[2].destcontrolmode < cbodestcontrol3.Items.Count))
            {
                cbodestcontrol3.SelectedIndex = CComLibrary.GlobeVal.filesave.testcmdstep[2].destcontrolmode;
            }
            else
            {
                CComLibrary.GlobeVal.filesave.testcmdstep[2].destcontrolmode = 0;
                cbodestcontrol3.SelectedIndex = 0;
            }

            if ((CComLibrary.GlobeVal.filesave.testcmdstep[3].destcontrolmode >= 0) && (CComLibrary.GlobeVal.filesave.testcmdstep[3].destcontrolmode < cbodestcontrol4.Items.Count))
            {
                cbodestcontrol4.SelectedIndex = CComLibrary.GlobeVal.filesave.testcmdstep[3].destcontrolmode;
            }
            else
            {
                CComLibrary.GlobeVal.filesave.testcmdstep[3].destcontrolmode = 0;
                cbodestcontrol4.SelectedIndex = 0;
            }
            cbovalueunit1.Items.Clear();

            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbodestcontrol1.SelectedIndex].cUnitCount; i++)
            {

                cbovalueunit1.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbodestcontrol1.SelectedIndex].cUnits[i]);
            }

            if ((CComLibrary.GlobeVal.filesave.testcmdstep[0].destunit >= 0) && (CComLibrary.GlobeVal.filesave.testcmdstep[0].destunit < cbovalueunit1.Items.Count))

            {
                cbovalueunit1.SelectedIndex = CComLibrary.GlobeVal.filesave.testcmdstep[0].destunit;

            }
            else
            {
                CComLibrary.GlobeVal.filesave.testcmdstep[0].destunit = 0;
                cbovalueunit1.SelectedIndex = 0;
            }

            cbovalueunit2.Items.Clear();

            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbodestcontrol2.SelectedIndex].cUnitCount; i++)
            {

                cbovalueunit2.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbodestcontrol2.SelectedIndex].cUnits[i]);
            }


            if ((CComLibrary.GlobeVal.filesave.testcmdstep[1].destunit >= 0) && (CComLibrary.GlobeVal.filesave.testcmdstep[1].destunit < cbovalueunit2.Items.Count))

            {
                cbovalueunit2.SelectedIndex = CComLibrary.GlobeVal.filesave.testcmdstep[1].destunit;

            }
            else
            {
                CComLibrary.GlobeVal.filesave.testcmdstep[1].destunit = 0;
                cbovalueunit2.SelectedIndex = 0;
            }



            cbovalueunit3.Items.Clear();

            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbodestcontrol3.SelectedIndex].cUnitCount; i++)
            {

                cbovalueunit3.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbodestcontrol3.SelectedIndex].cUnits[i]);
            }

            if ((CComLibrary.GlobeVal.filesave.testcmdstep[2].destunit >= 0) && (CComLibrary.GlobeVal.filesave.testcmdstep[2].destunit < cbovalueunit3.Items.Count))

            {
                cbovalueunit3.SelectedIndex = CComLibrary.GlobeVal.filesave.testcmdstep[2].destunit;

            }
            else
            {
                CComLibrary.GlobeVal.filesave.testcmdstep[2].destunit = 0;
                cbovalueunit3.SelectedIndex = 0;
            }


            cbovalueunit4.Items.Clear();

            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbodestcontrol4.SelectedIndex].cUnitCount; i++)
            {

                cbovalueunit4.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbodestcontrol4.SelectedIndex].cUnits[i]);
            }

            if ((CComLibrary.GlobeVal.filesave.testcmdstep[3].destunit >= 0) && (CComLibrary.GlobeVal.filesave.testcmdstep[3].destunit < cbovalueunit4.Items.Count))

            {
                cbovalueunit4.SelectedIndex = CComLibrary.GlobeVal.filesave.testcmdstep[3].destunit;

            }
            else
            {
                CComLibrary.GlobeVal.filesave.testcmdstep[3].destunit = 0;
                cbovalueunit4.SelectedIndex = 0;
            }



            numspeed1.Value = CComLibrary.GlobeVal.filesave.testcmdstep[0].speed;

            numvalue1.Value = CComLibrary.GlobeVal.filesave.testcmdstep[0].dest;

            numspeed2.Value = CComLibrary.GlobeVal.filesave.testcmdstep[1].speed;

            numvalue2.Value = CComLibrary.GlobeVal.filesave.testcmdstep[1].dest;

            numspeed3.Value = CComLibrary.GlobeVal.filesave.testcmdstep[2].speed;

            numvalue3.Value = CComLibrary.GlobeVal.filesave.testcmdstep[2].dest;

            numspeed4.Value = CComLibrary.GlobeVal.filesave.testcmdstep[3].speed;

            numvalue4.Value = CComLibrary.GlobeVal.filesave.testcmdstep[3].dest;




        }
        public void Init_测试前()
        {
            chkpreload.Checked = CComLibrary.GlobeVal.filesave.pretest_cmd.check;

            chkpreload_CheckStateChanged(null, null);

            cbopreload_controlmode.Enabled = false;
            cbopreload_controlmode.Items.Clear();
            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals.Count; i++)
            {
                cbopreload_controlmode.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[i].cName);
            }
            CComLibrary.GlobeVal.filesave.pretest_cmd.controlmode = 0;
            cbopreload_controlmode.SelectedIndex = CComLibrary.GlobeVal.filesave.pretest_cmd.controlmode;


            cbopreload_speedunit.Enabled = false;
            cbopreload_speedunit.Items.Clear();
            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbopreload_controlmode.SelectedIndex].speedSignal.cUnitCount; i++)
            {
                cbopreload_speedunit.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbopreload_controlmode.SelectedIndex].speedSignal.cUnits[i]);

            }
            if ((CComLibrary.GlobeVal.filesave.pretest_cmd.speedunit >= 0) && (CComLibrary.GlobeVal.filesave.pretest_cmd.speedunit < cbopreload_speedunit.Items.Count))

            {
                cbopreload_speedunit.SelectedIndex = CComLibrary.GlobeVal.filesave.pretest_cmd.speedunit;
            }
            else
            {
                CComLibrary.GlobeVal.filesave.pretest_cmd.speedunit = 0;
                cbopreload_speedunit.SelectedIndex = 0;
            }

            cbopreload_channel.Enabled = false;
            cbopreload_channel.Items.Clear();

            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals.Count; i++)
            {
                cbopreload_channel.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[i].cName);
            }

            CComLibrary.GlobeVal.filesave.pretest_cmd.destcontrolmode = 1;
            cbopreload_channel.SelectedIndex = CComLibrary.GlobeVal.filesave.pretest_cmd.destcontrolmode;


            cboprelaod_valueunit.Enabled = false;
            cboprelaod_valueunit.Items.Clear();

            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbopreload_channel.SelectedIndex].cUnitCount; i++)
            {

                cboprelaod_valueunit.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbopreload_channel.SelectedIndex].cUnits[i]);
            }

            if ((CComLibrary.GlobeVal.filesave.pretest_cmd.destunit >= 0) && (CComLibrary.GlobeVal.filesave.pretest_cmd.destunit < cboprelaod_valueunit.Items.Count))

            {
                cboprelaod_valueunit.SelectedIndex = CComLibrary.GlobeVal.filesave.pretest_cmd.destunit;
            }
            else
            {
                CComLibrary.GlobeVal.filesave.pretest_cmd.destunit = 0;
                cboprelaod_valueunit.SelectedIndex = 0;
            }

            editpreload_speed.Value = CComLibrary.GlobeVal.filesave.pretest_cmd.speed;

            editpreload_value.Value = CComLibrary.GlobeVal.filesave.pretest_cmd.dest;


            editkeeptime.Value = CComLibrary.GlobeVal.filesave.pretest_cmd.keeptime;

            this.cbopreoload_keeptime.Items.Clear();
            this.cbopreoload_keeptime.Items.Add("秒");
            this.cbopreoload_keeptime.Items.Add("分");

            cbopreoload_keeptime.SelectedIndex = CComLibrary.GlobeVal.filesave.pretest_cmd.keeptimeunit;




            lstavail.ClearItem();
            for (int j = 0; j < ClsStaticStation.m_Global.mycls.chsignals.Count; j++)
            {

                if (CComLibrary.GlobeVal.filesave.mautozero == null)
                {
                    lstavail.Items.Add(ClsStaticStation.m_Global.mycls.chsignals[j]);
                }
                else
                {
                    if (this.lstinclude.MatchItem(CComLibrary.GlobeVal.filesave.mautozero,
                        ClsStaticStation.m_Global.mycls.chsignals[j]) == true)
                    {

                    }
                    else
                    {
                        lstavail.AddItem(ClsStaticStation.m_Global.mycls.chsignals[j]);
                    }


                }

            }

            lstinclude.ClearItem();
            for (int j = 0; j < CComLibrary.GlobeVal.filesave.mautozero.Count; j++)
            {


                lstinclude.AddItem(CComLibrary.GlobeVal.filesave.mautozero[j]);


            }

            chkTemperature.Checked = CComLibrary.GlobeVal.filesave.mTemperatureBool;
            NumTestTemperature.Value = CComLibrary.GlobeVal.filesave.MTemperatureTest;
            NumTemperatureTime.Value = CComLibrary.GlobeVal.filesave.mTemperatureTime;
            numTemperatureShift.Value = CComLibrary.GlobeVal.filesave.mTemperatureShift;
            numTemperatureEnd.Value = CComLibrary.GlobeVal.filesave.mTemperatureEnd;

            CboTestTemperature.Items.Clear();
            CboTestTemperature.Items.Add("℃");
            CboTestTemperature.SelectedIndex = 0;

            cboTemperatureTime.Items.Clear();
            cboTemperatureTime.Items.Add("Min");
            cboTemperatureTime.SelectedIndex = 0;

            cboTemperatureShift.Items.Clear();
            cboTemperatureShift.Items.Add("℃");
            cboTemperatureShift.SelectedIndex = 0;

            cboTemperatureEnd.Items.Clear();
            cboTemperatureEnd.Items.Add("℃");
            cboTemperatureEnd.SelectedIndex = 0;
            chkTemperature_CheckStateChanged(null, null);

           



        }
        public void Init(int sel)
        {


            tabControl1.SelectedIndex = sel;
            tlpline1.RowStyles[1].Height = 2;

            if (GlobeVal.UserControlMain1.btnmtest.Visible == true)
            {
                if (CComLibrary.GlobeVal.filesave.mcontrolprocess != 2)
                {

                    tabControl1.Enabled = true;
                }
                else
                {
                    tabControl1.Enabled = false;
                }
            }
            else
            {
                tabControl1.Enabled = true;
            }

            if (sel == 0)
            {
                Init_设置控制();
            }
            if (sel == 1)
            {
                Init_应变();
            }
            if (sel == 2)
            {
                Init_测试前();
            }

            if (sel == 3)
            {
                Init_测试();
            }

            if (sel == 4)
            {
                Init_测试结束();
            }
            if (sel == 5)
            {
                Init_数据();
            }
            /*
            if (sel == 6)
            {
                Init_中级();
                if (GlobeVal.UserControlMain1.btnmtest.Visible == true)
                {
                    tscbo.Enabled = false ;
                    tsbtnnew.Enabled = false;
                    tsbtnkill.Enabled = false;
                    tsbtnrename.Enabled = false;
                    tsbtnadd.Enabled = false;
                    tsbtninsert.Enabled = false;
                    tsbtndel.Enabled = false;
                }
                else
                {
                    tscbo.Enabled = true ;
                    tsbtnnew.Enabled = true ;
                    tsbtnkill.Enabled = true ;
                    tsbtnrename.Enabled = true ;
                    tsbtnadd.Enabled = true ;
                    tsbtninsert.Enabled = true ;
                    tsbtndel.Enabled = true ;
                
                }
            }

           */

            if (sel == 8)
            {
                Init_中级1();
            }


            if (sel == 7)
            {
                Init_简单();
            }



        }
        public UserControl控制()
        {
            InitializeComponent();
            tabControl1.ItemSize = new Size(1, 1);

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲



            this.tableLayoutPanel1.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel1, true, null);

            this.tableLayoutPanel2.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel2, true, null);

            this.tableLayoutPanel3.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel3, true, null);
            this.tableLayoutPanel4.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel4, true, null);

            this.tableLayoutPanel5.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel5, true, null);

            this.tableLayoutPanel6.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel6, true, null);
            this.tlppreload.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tlppreload, true, null);
            this.tableLayoutPanel8.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel8, true, null);

            this.tableLayoutPanel9.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel9, true, null);
            this.tableLayoutPanel10.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel10, true, null);
            this.tableLayoutPanel11.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel11, true, null);

            this.tableLayoutPanel12.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel12, true, null);
            this.tableLayoutPanel13.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel13, true, null);

            this.tableLayoutPanel14.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel14, true, null);

            this.tableLayoutPanel15.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel15, true, null);

            this.tableLayoutPanel16.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel16, true, null);

            this.tlpline4.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tlpline4, true, null);

            this.tableLayoutPanel18.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel18, true, null);

            this.tableLayoutPanel19.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel19, true, null);

            this.tlpline2.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tlpline2, true, null);

            this.tlpline1.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tlpline1, true, null);
            this.tlpline3.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tlpline3, true, null);

            this.tableLayoutPanel23.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel23, true, null);
            this.tableLayoutPanel30.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel30, true, null);
            this.tableLayoutPanel36.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel36, true, null);
            this.tableLayoutPanel38.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tableLayoutPanel38, true, null);

            this.tlpcriteria1.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tlpcriteria1, true, null);
            this.tlpcriteria2.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tlpcriteria2, true, null);
            this.tlpcriteria3.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tlpcriteria3, true, null);
            this.tlpcriteria4.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tlpcriteria4, true, null);

            this.tlpdata.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.tlpdata, true, null);


         

        }

        private void cbocontrolprocess_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            if (this.lstavail.SelectedItem != null)
            {
                this.lstinclude.AddItem(this.lstavail.list[this.lstavail.SelectedIndex]);

                this.lstavail.RemoveItem(this.lstavail.SelectedIndex);

                list_autozerosetvalue();

            }

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (this.lstinclude.SelectedItem != null)
            {
                this.lstavail.AddItem(this.lstinclude.list[this.lstinclude.SelectedIndex]);
                this.lstinclude.RemoveItem(this.lstinclude.SelectedIndex);

                list_autozerosetvalue();
            }
        }

        private void cbotestendCriteria1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbotestendCriteria1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.endoftest1criteria = cbotestendCriteria1.SelectedIndex;


            numtestendvalue1.Value = 0;


            if (cbotestendCriteria1.SelectedIndex == 0)
            {
                lbltestend1.Text = "灵敏度 (%)";


            }
            else if (cbotestendCriteria1.SelectedIndex == 1)
            {
                lbltestend1.Text = "载荷下降到 ";

            }
            else if (cbotestendCriteria1.SelectedIndex == 2)
            {
                lbltestend1.Text = "超过载荷门槛值";
            }
        }

        private void cbotestendCriteria2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.endoftest2criteria = cbotestendCriteria2.SelectedIndex;

            if (cbotestendCriteria2.SelectedIndex == 0)
            {
                lbltestend2.Text = "灵敏度 (%)";


            }
            else if (cbotestendCriteria2.SelectedIndex == 1)
            {
                lbltestend2.Text = "载荷下降到 ";

            }
            else if (cbotestendCriteria2.SelectedIndex == 2)
            {
                lbltestend2.Text = "超过载荷门槛值";
            }

            numtestendvalue2.Value = 0;
        }


        private void num1_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {

        }

        private void grid1_CellLostFocus(object sender, SourceGrid2.PositionCancelEventArgs e)
        {

            if (e.Position.Column == 2)
            {
                for (int i = 1; i <= CComLibrary.GlobeVal.filesave.mchsignals.Count; i++)
                {
                    if (i == e.Position.Row)
                    {

                        CComLibrary.GlobeVal.filesave.mchsignals[i - 1].uplimit = Convert.ToDouble(e.Cell.GetDisplayText(new SourceGrid2.Position(e.Position.Row, e.Position.Column)));
                    }
                }
            }

            if (e.Position.Column == 3)
            {
                for (int i = 1; i <= CComLibrary.GlobeVal.filesave.mchsignals.Count; i++)
                {
                    if (i == e.Position.Row)
                    {
                        CComLibrary.GlobeVal.filesave.mchsignals[i - 1].donwlimit = Convert.ToDouble(e.Cell.GetDisplayText(new SourceGrid2.Position(e.Position.Row, e.Position.Column)));
                    }
                }
            }
            if (e.Position.Column == 5)
            {
                for (int i = 1; i <= CComLibrary.GlobeVal.filesave.mchsignals.Count; i++)
                {
                    if (i == e.Position.Row)
                    {
                        CComLibrary.GlobeVal.filesave.mchsignals[i - 1].limitselect = Convert.ToBoolean(e.Cell.GetDisplayText(new SourceGrid2.Position(e.Position.Row, e.Position.Column)));
                    }
                }
            }

        }

        private void cbopreload_controlmode_SelectionChangeCommitted(object sender, EventArgs e)
        {

            CComLibrary.GlobeVal.filesave.pretest_cmd.controlmode = cbopreload_controlmode.SelectedIndex;
            cbopreload_speedunit.Items.Clear();
            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbopreload_controlmode.SelectedIndex].speedSignal.cUnitCount; i++)
            {
                cbopreload_speedunit.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbopreload_controlmode.SelectedIndex].speedSignal.cUnits[i]);

            }

            cbopreload_speedunit.SelectedIndex = 0;

        }

        private void chkpreload_CheckStateChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.pretest_cmd.check = chkpreload.Checked;

            if (chkpreload.Checked ==true)
            {
                tlppreload.Height = 147;
            }
            else
            {
                tlppreload.Height = Convert.ToInt16( tlppreload.RowStyles[0].Height); 
            }
        }

        private void editpreload_speed_ValueChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.pretest_cmd.speed = editpreload_speed.Value;
        }

        private void cbopreload_channel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.pretest_cmd.destcontrolmode = cbopreload_channel.SelectedIndex;
            cboprelaod_valueunit.Items.Clear();

            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbopreload_channel.SelectedIndex].cUnitCount; i++)
            {

                cboprelaod_valueunit.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbopreload_channel.SelectedIndex].cUnits[i]);
            }

            cboprelaod_valueunit.SelectedIndex = 0;
        }

        private void editpreload_value_ValueChanged(object sender, EventArgs e)
        {


            if (editpreload_value.Value > ClsStaticStation.m_Global.mycls.hardsignals[cbopreload_channel.SelectedIndex].fullmaxbase)
            {

                MessageBox.Show("预负荷超量程,不能超过"+ ClsStaticStation.m_Global.mycls.hardsignals[cbopreload_channel.SelectedIndex].fullmaxbase.ToString());
                editpreload_value.Value = 0;
                return;
            }
            CComLibrary.GlobeVal.filesave.pretest_cmd.dest = editpreload_value.Value;
        }

        private void chkline1_CheckStateChanged(object sender, EventArgs e)
        {

            CComLibrary.GlobeVal.filesave.testcmdstep[0].check = chkline1.Checked;
        }

        private void chkline2_CheckStateChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[1].check = chkline2.Checked;
        }

        private void chkline3_CheckStateChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[2].check = chkline3.Checked;
        }

        private void chkline4_CheckStateChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[3].check = chkline4.Checked;
        }


        private void cbocontrol1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[0].controlmode = cbocontrol1.SelectedIndex;

            cbospeedunit1.Items.Clear();
            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbocontrol1.SelectedIndex].speedSignal.cUnitCount; i++)
            {
                cbospeedunit1.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbocontrol1.SelectedIndex].speedSignal.cUnits[i]);

            }

            cbospeedunit1.SelectedIndex = 0;
        }

        private void cbocontrol2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[1].controlmode = cbocontrol2.SelectedIndex;

            cbospeedunit2.Items.Clear();
            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbocontrol2.SelectedIndex].speedSignal.cUnitCount; i++)
            {
                cbospeedunit2.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbocontrol2.SelectedIndex].speedSignal.cUnits[i]);

            }

            cbospeedunit2.SelectedIndex = 0;
        }

        private void cbocontrol3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[2].controlmode = cbocontrol3.SelectedIndex;

            cbospeedunit3.Items.Clear();
            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbocontrol3.SelectedIndex].speedSignal.cUnitCount; i++)
            {
                cbospeedunit3.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbocontrol3.SelectedIndex].speedSignal.cUnits[i]);

            }

            cbospeedunit3.SelectedIndex = 0;
        }

        private void cbocontrol4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[3].controlmode = cbocontrol4.SelectedIndex;

            cbospeedunit4.Items.Clear();
            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbocontrol4.SelectedIndex].speedSignal.cUnitCount; i++)
            {
                cbospeedunit4.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbocontrol4.SelectedIndex].speedSignal.cUnits[i]);

            }

            cbospeedunit4.SelectedIndex = 0;
        }

        private void cbodestcontrol1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[0].destcontrolmode = cbodestcontrol1.SelectedIndex;

            cbovalueunit1.Items.Clear();

            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbodestcontrol1.SelectedIndex].cUnitCount; i++)
            {

                cbovalueunit1.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbodestcontrol1.SelectedIndex].cUnits[i]);
            }

            cbovalueunit1.SelectedIndex = 0;
        }

        private void cbodestcontrol2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[1].destcontrolmode = cbodestcontrol2.SelectedIndex;

            cbovalueunit2.Items.Clear();

            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbodestcontrol2.SelectedIndex].cUnitCount; i++)
            {

                cbovalueunit2.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbodestcontrol2.SelectedIndex].cUnits[i]);
            }

            cbovalueunit2.SelectedIndex = 0;
        }

        private void cbodestcontrol3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[2].destcontrolmode = cbodestcontrol3.SelectedIndex;

            cbovalueunit3.Items.Clear();

            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbodestcontrol3.SelectedIndex].cUnitCount; i++)
            {

                cbovalueunit3.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbodestcontrol3.SelectedIndex].cUnits[i]);
            }

            cbovalueunit3.SelectedIndex = 0;
        }

        private void cbodestcontrol4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[3].destcontrolmode = cbodestcontrol4.SelectedIndex;

            cbovalueunit4.Items.Clear();

            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals[cbodestcontrol4.SelectedIndex].cUnitCount; i++)
            {

                cbovalueunit4.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[cbodestcontrol4.SelectedIndex].cUnits[i]);
            }

            cbovalueunit4.SelectedIndex = 0;
        }



        private void numspeed1_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[0].speed = numspeed1.Value;
        }

        private void numspeed2_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[1].speed = numspeed2.Value;
        }

        private void numspeed3_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[2].speed = numspeed3.Value;
        }

        private void numspeed4_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[3].speed = numspeed4.Value;
        }

        private void numvalue1_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[0].dest = numvalue1.Value;
        }

        private void numvalue2_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            numvalue2.Value = CComLibrary.GlobeVal.filesave.testcmdstep[1].dest;
        }

        private void numvalue3_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            numvalue3.Value = CComLibrary.GlobeVal.filesave.testcmdstep[2].dest;
        }

        private void numvalue4_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            numvalue4.Value = CComLibrary.GlobeVal.filesave.testcmdstep[3].dest;
        }

        private void tsbtnadd_Click(object sender, EventArgs e)
        {
            sf.add();
            Add(grid2.RowsCount, ref sf);
        }

        private void tsbtnnew_Click(object sender, EventArgs e)
        {
            String s;
            Frm.Form新建程序文件 f = new TabHeaderDemo.Frm.Form新建程序文件();
            f.result = false;
            f.ShowDialog();

            if (f.result == true)
            {
                s = f.txtname.Text;

                sf = new CComLibrary.SegFile();
                grid2.RowsCount = 1;
                sf.mseglist.Clear();
                sf.add();
                Add(1, ref sf);

                sf.SerializeNow(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\seg\\" + s + ".seg");

                tscbo.Items.Clear();
                tscbo.Text = s + ".seg";
                DirectoryInfo info = new DirectoryInfo(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\seg");
                FileInfo[] files = info.GetFiles("*.seg");
                foreach (FileInfo file in files)
                {
                    tscbo.Items.Add(file.Name);
                }

                tscbo.Text = s + ".seg";
            }


        }

        private void tsbtnsave_Click(object sender, EventArgs e)
        {

            bool fb = false;

            for (int i = 0; i < sf.mseglist.Count; i++)
            {
                if (sf.mseglist[i].cyclicrun == true)
                {
                    for (int j = sf.mseglist[i].returnstep; j < i; j++)
                    {
                        if (sf.mseglist[j].cyclicrun == true)
                        {
                            fb = true;
                        }
                    }

                }
            }

            if (fb == true)
            {
                MessageBox.Show("错误，循环中包括子循环");
                return;
            }

            if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\seg\\" + tscbo.Text) == true)
            {
                System.IO.File.Delete(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\seg\\" + tscbo.Text);
            }

            if (tscbo.Text.Trim() != "")
            {
                sf.SerializeNow(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\seg\\" + tscbo.Text);
            }
            else
            {


            }

        }

        private void tsbtnkill_Click(object sender, EventArgs e)
        {


            if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\seg\\" + tscbo.Text) == true)
            {
                DialogResult b = MessageBox.Show("是否删除文件[" + tscbo.Text + "]?", "提示", MessageBoxButtons.YesNo);

                if (b == DialogResult.Yes)
                {

                    System.IO.File.Delete(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\seg\\" + tscbo.Text);
                }
                else
                {
                    return;
                }
            }
            grid2.RowsCount = 1;

            sf.clear();

            DirectoryInfo info = new DirectoryInfo(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\seg");
            FileInfo[] files = info.GetFiles("*.seg");
            foreach (FileInfo file in files)
            {
                tscbo.Items.Add(file.Name);
            }


        }

        private void tscbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mloaded == false)
            {
                sf.mseglist.Clear();


                sf = sf.DeSerializeNow(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\seg\\" + tscbo.Text);

                int i = 0;

                grid2.RowsCount = 1;


                int c = sf.mseglist.Count;

                for (i = 1; i <= c; i++)
                {
                    Add(i, ref sf);
                }
                CComLibrary.GlobeVal.filesave.SegName = tscbo.Text;

            }
        }


        private void grid2_CellGotFocus(object sender, SourceGrid2.PositionCancelEventArgs e)
        {
            if (grid2.Rows.Count > 0)
            {
                curcol = e.Position.Column;
                currow = e.Position.Row;
            }

        }

        private void grid2_SettingCell(object sender, SourceGrid2.PositionEventArgs e)
        {

        }

        private void tsbtnrename_Click(object sender, EventArgs e)
        {
            String s;
            string s1;
            Frm.Form新建程序文件 f = new TabHeaderDemo.Frm.Form新建程序文件();
            f.result = false;
            f.Text = "重命名";
            f.ShowDialog();
            if (f.result == true)
            {
                s = f.txtname.Text;
                if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\seg\\" + tscbo.Text) == true)
                {
                    s1 = System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\seg\\" + tscbo.Text;
                    System.IO.File.Move(s1,
                        System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\seg\\" + s + ".seg");

                }
                tscbo.Items.Clear();
                DirectoryInfo info = new DirectoryInfo(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\seg");
                FileInfo[] files = info.GetFiles("*.seg");
                foreach (FileInfo file in files)
                {
                    tscbo.Items.Add(file.Name);
                }

                tscbo.Text = s + ".seg";
            }
        }

        private void tsbtninsert_Click(object sender, EventArgs e)
        {
            if (currow <= 1)
            {
                MessageBox.Show("不能在第一行插入");
                return;
            }

            DialogResult a = MessageBox.Show("是否在当前位置之前插入？", "提示", MessageBoxButtons.YesNo);


            if (a == DialogResult.Yes)
            {
                CComLibrary.SegTest m = new CComLibrary.SegTest();
                sf.mseglist.Insert(currow - 1, m);
                Add(currow - 1, ref sf);

            }




        }

        private void tsbtndel_Click(object sender, EventArgs e)
        {
            int w = 0;
            DialogResult a = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                w = currow - 1;
                sf.mseglist.RemoveAt(w);
                grid2.Rows.Remove(w + 1);
            }

        }

        private void tscbo_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void numericEdit1_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {

        }

        private void chkcrack_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkstep1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }









        private void listViewBlock1_btnleftevent(object sender, int index)
        {
            return;
        }

        private void listViewBlock1_btncutevent(object sender, int index)
        {
            return;
        }

        private void listViewBlock1_btncopyevent(object sender, int index)
        {

            return;
        }


        private void numcount_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {

        }


        private void cbopreload_speedunit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.pretest_cmd.speedunit = cbopreload_speedunit.SelectedIndex;
        }

        private void cboprelaod_valueunit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.pretest_cmd.destunit = cboprelaod_valueunit.SelectedIndex;
        }

        private void cbospeedunit1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[0].speedunit = cbospeedunit1.SelectedIndex;
        }

        private void cbospeedunit2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[1].speedunit = cbospeedunit2.SelectedIndex;
        }

        private void cbospeedunit3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[2].speedunit = cbospeedunit3.SelectedIndex;
        }

        private void cbospeedunit4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[3].speedunit = cbospeedunit4.SelectedIndex;
        }

        private void cbovalueunit2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[1].destunit = cbovalueunit2.SelectedIndex;
        }

        private void cbovalueunit1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[0].destunit = cbovalueunit1.SelectedIndex;
        }

        private void cbovalueunit3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[2].destunit = cbovalueunit3.SelectedIndex;
        }

        private void cbovalueunit4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.testcmdstep[3].destunit = cbovalueunit4.SelectedIndex;
        }

        private void numgauge_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.Extensometer_gauge = numgauge.Value;
        }

        private void numgauge1_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.Extensometer1_gauge = numgauge1.Value;
        }

        private void chkfrozen_CheckedChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.Extensometer_DataFrozen = chkfrozen.Checked;
        }

        private void cboextact_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.Extensometer_Action = cboextact.SelectedIndex;
        }

        private void numext_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.Extensometer_DataValue = numext.Value;
        }

        private void cboextunit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.Extensometer_DataValueUnit = cboextunit.SelectedIndex;
        }

        private void cboextchannel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.Extensometer_DataChannel = cboextchannel.SelectedIndex;

            cboextunit.Items.Clear();
            for (int i = 0; i < m_Global.mycls.hardsignals[CComLibrary.GlobeVal.filesave.Extensometer_DataChannel].cUnitCount; i++)
            {
                cboextunit.Items.Add(m_Global.mycls.hardsignals[CComLibrary.GlobeVal.filesave.Extensometer_DataChannel].cUnits[i]);

            }

            cboextunit.SelectedIndex = 0;


        }

        private void cboextruler_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.Extensometer_removal = cboextruler.SelectedIndex;
        }

        private void chkremoveext_CheckedChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.chkextremove = chkremoveext.Checked;
        }



        private void cbosamplemode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.Samplingmode = cbosamplemode.SelectedIndex;

           
        }






        private void cbomeasurement2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.cbomeasurement[1] = cbomeasurement2.SelectedIndex;

            lblinterval2.Text = ClsStaticStation.m_Global.mycls.allsignals[cbomeasurement2.SelectedIndex].cUnits[0];
        }

        private void cbomeasurement1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.cbomeasurement[0] = cbomeasurement1.SelectedIndex;

            lblinterval1.Text = ClsStaticStation.m_Global.mycls.allsignals[cbomeasurement1.SelectedIndex].cUnits[0];


        }

        private void cbomeasurement3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.cbomeasurement[2] = cbomeasurement3.SelectedIndex;

            lblinterval3.Text = ClsStaticStation.m_Global.mycls.allsignals[cbomeasurement3.SelectedIndex].cUnits[0];
        }

        private void chkcriteria1_CheckedChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.chkcriteria[0] = chkcriteria1.Checked;

            if (chkcriteria1.Checked == false)
            {
                tlpcriteria1.Height = 24;
            }
            else
            {

                tlpcriteria1.Height = 74;

               
            }

        }

        private void chkcriteria2_CheckedChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.chkcriteria[1] = chkcriteria2.Checked;

            if (chkcriteria2.Checked == false)
            {
                tlpcriteria2.Height = 24;
            }
            else
            {

                tlpcriteria2.Height = 74;


            }
        }

        private void chkcriteria3_CheckedChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.chkcriteria[2] = chkcriteria3.Checked;
            if (chkcriteria3.Checked == false)
            {
                tlpcriteria3.Height = 24;
            }
            else
            {

                tlpcriteria3.Height = 74;


            }
        }

        private void numinterval1_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.numinterval[0] = numinterval1.Value;
        }

        private void numinterval2_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.numinterval[1] = numinterval2.Value;
        }

        private void numinterval3_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.numinterval[2] = numinterval3.Value;
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
            if (e.Position.Column == 4)
            {
                e.Cancel = true;
            }


        }

        private void chktestend1_CheckedChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.endoftest1 = chktestend1.Checked;

            if(chktestend1.Checked ==true)
            {
                grptestend1.Height = 118;
            }
            else
            {
                grptestend1.Height = 40;
            }
        }

        private void chktestend2_CheckedChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.endoftest2 = chktestend2.Checked;

            if (chktestend2.Checked == true)
            {
                grptestend2.Height = 118;
            }
            else
            {
                grptestend2.Height = 40;
            }
        }

        private void numtestendvalue1_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.endoftest1value = numtestendvalue1.Value;
        }

        private void numtestendvalue2_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.endoftest2value = numtestendvalue2.Value;


        }


        private void cbostopchannel1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.endoftest1usechannel = cbostopchannel1.SelectedIndex;
            lbltestendCriteria1.Text = ClsStaticStation.m_Global.mycls.allsignals[cbostopchannel1.SelectedIndex].cUnits[0];
        }

        private void cbostopchannel2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.endoftest2usechannel = cbostopchannel2.SelectedIndex;

            lbltestendCriteria2.Text = ClsStaticStation.m_Global.mycls.allsignals[cbostopchannel2.SelectedIndex].cUnits[0];
        }

        private void userControlCheckStep1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void tlpstep_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkTemperature_CheckStateChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mTemperatureBool = chkTemperature.Checked;

            if(chkTemperature.Checked ==true)
            {
                tlpTemperature.Height = 132;
            }
            else
            {
                tlpTemperature.Height = Convert.ToInt16( tlpTemperature.RowStyles[0].Height);
            }
        }

        private void chkTemperature_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NumTestTemperature_ValueChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.MTemperatureTest = NumTestTemperature.Value;

        }

        private void NumTemperatureTime_ValueChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mTemperatureTime = NumTemperatureTime.Value;
        }

        private void numTemperatureShift_ValueChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mTemperatureShift = numTemperatureShift.Value;
        }

        private void numTemperatureEnd_ValueChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mTemperatureEnd = numTemperatureEnd.Value;
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void chkcriteria4_CheckedChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.chkcriteria[3] = chkcriteria4.Checked;

            if (chkcriteria4.Checked == false)
            {
                tlpcriteria4.Height = 24;
            }
            else
            {

                tlpcriteria4.Height = 81;


            }
        }

        private void cbomeasurement4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.cbomeasurement[3] = cbomeasurement4.SelectedIndex;

            lblinterval4.Text = ClsStaticStation.m_Global.mycls.allsignals[cbomeasurement4.SelectedIndex].cUnits[0];
        }

        private void numinterval4_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.numinterval[3] = numinterval4.Value;
        }

        private void tlpdata_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboSaveCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {

            CComLibrary.GlobeVal.filesave.mSaveCriteriaMode = cboSaveCriteria.SelectedIndex;

            if (cboSaveCriteria.SelectedIndex == 0)
            {
                tlpSaveCriteria.RowStyles[1].Height = tlpSaveCriteria.RowStyles[0].Height;
                tlpSaveCriteria.RowStyles[2].Height = 0;
                tlpSaveCriteria.RowStyles[3].Height = 0;
                numSaveCount_AfterChangeValue(null, null);

            }

            if (cboSaveCriteria.SelectedIndex ==1)
            {
                tlpSaveCriteria.RowStyles[1].Height = 0;
                tlpSaveCriteria.RowStyles[2].Height = 0;
               
                tlpSaveCriteria.RowStyles[3].Height = 0;
                dgridsave.Height = 0;
            }
            if (cboSaveCriteria.SelectedIndex == 2)
            {
                tlpSaveCriteria.RowStyles[1].Height = 0;
                tlpSaveCriteria.RowStyles[2].Height = tlpSaveCriteria.RowStyles[0].Height ;
                tlpSaveCriteria.RowStyles[3].Height = 0;
               
                dgridsave.Height = 0;
            }
            if (cboSaveCriteria.SelectedIndex == 3)
            {
                tlpSaveCriteria.RowStyles[1].Height = 0;
                tlpSaveCriteria.RowStyles[2].Height = 0;
                tlpSaveCriteria.RowStyles[3].Height = tlpSaveCriteria.RowStyles[0].Height;
                dgridsave.Height = 0;
            }
           
           

        }

        private void numSaveCount_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
           
        }

        private void dgridsave_Resize(object sender, EventArgs e)
        {
            dgridsave.Parent.Height = dgridsave.Height;
           
        }

       
      

        private void chkAlarm_CheckStateChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.malarm = chkAlarm.Checked;
            if(chkAlarm.Checked ==false)
            {
                grpAlarm.Height = 45;

            }
            else
            {
                grpAlarm.Height = 150;
            }
        }

        private void chkAlarm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numAlarm1_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.malarmvalue1 = numAlarm1.Value;

        }

        private void numAlarm2_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.malarmvalue2 = numAlarm2.Value;
        }

        private void numAlarm3_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.malarmvalue3 = numAlarm3.Value;
        }

        private void numAlarm4_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.malarmvalue4 = numAlarm4.Value;
        }

        private void chkBidirectionalProtected_CheckedChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mBidirectionalProtected = this.chkBidirectionalProtected.Checked;

            if (this.chkBidirectionalProtected.Checked == true)
            {
                grpBidirectionalProtected.Height = 170;
            }
            else
            {
                grpBidirectionalProtected.Height = 40;
            }


        }

        private void cboBidirectionalProtected_SelectedIndexChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mBidirectionalProtectedSensor = cboBidirectionalProtected.SelectedIndex;
            this.lblBidirectionalProtectedUp.Text = ClsStaticStation.m_Global.mycls.chsignals[cboBidirectionalProtected.SelectedIndex].cUnits[0];
            this.lblBidirectionalProtectedDown.Text = ClsStaticStation.m_Global.mycls.chsignals[cboBidirectionalProtected.SelectedIndex].cUnits[0];
        }

        private void chkUnidirectionalProtection_CheckedChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mUnidirectionalProtection = chkUnidirectionalProtection.Checked;

            if(this.chkUnidirectionalProtection.Checked ==true )
            {
                grpUnidirectionalProtection.Height = 170;
            }
            else
            {
                grpUnidirectionalProtection.Height = 40;
            }
        }

        private void chkTemperatureProtection_CheckedChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mTemperatureProtection = chkTemperatureProtection.Checked;

            if(this.chkTemperatureProtection.Checked ==true)
            {
                grpTemperatureProtection.Height = 140;
            }
            else
            {
                grpTemperatureProtection.Height = 40;
            }
        }

        private void chkFatigueProtection_CheckedChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mFatigueProtection = chkFatigueProtection.Checked;

            if (chkFatigueProtection.Checked ==true)
            {
               grpFatigueProtection.Height = 140;
            }
            else
            {
               grpFatigueProtection.Height = 40;
            }
        }

        private void cbotestaction_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cboBidirectionalProtected_SelectedValueChanged(object sender, EventArgs e)
        {
           


        }

        private void numBidirectionalProtectedUp_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mBidirectionalProtectedUpLimit = numBidirectionalProtectedUp.Value; 
        }

        private void numBidirectionalProtectedDown_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mBidirectionalProtectedLowLimit = numBidirectionalProtectedDown.Value;
        }

        private void cboUnidirectionalProtection_SelectedValueChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mUnidirectionalProtectionSensor = cboUnidirectionalProtection.SelectedIndex;
            this.lblUnidirectionalProtection.Text = ClsStaticStation.m_Global.mycls.chsignals[cboUnidirectionalProtection.SelectedIndex].cUnits[0];
        }

        private void cboUnidirectionalProtectionMode_SelectedValueChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mUnidirectionalProtectionMode = cboUnidirectionalProtectionMode.SelectedIndex;
        }

        private void numUnidirectionalProtection_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mUnidirectionalProtectionValue = numUnidirectionalProtection.Value;
        }

        private void numTemperatureProtectionUp_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mTemperatureProtectionUpLimit = numTemperatureProtectionUp.Value; 
        }

        private void numTemperatureProtectionDown_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mTemperatureProtectionLowLimit = numTemperatureProtectionDown.Value;
        }

        private void numFatigueProtection_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mFatigueProtectionCount = Convert.ToInt64( numFatigueProtection.Value);
        }

        private void numFatigueProtectionstop_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mFatigueProtectionStopValue = numFatigueProtectionstop.Value;
        }

        private void chkSaveCriteria_CheckedChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mSaveCriteria = chkSaveCriteria.Checked;

            if (chkSaveCriteria.Checked ==true)
            {
                tlpSaveCriteriaTop.Height = 244;

            }
            else
            {
                tlpSaveCriteriaTop.Height = 25;
            }
        }

        private void numSaveWaveCount_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mSaveWaveCount = Convert.ToInt32(numSaveWaveCount.Value); 
        }

        private void numSaveCyclcCount_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mSaveCyclcCount = Convert.ToInt32(numSaveCyclcCount.Value);
        }

        private void dgridsave_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgridsave_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 )
            {
                CComLibrary.GlobeVal.filesave.mSaveCriteraiRow2[e.RowIndex] = Convert.ToDouble( dgridsave.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

            }

            if (e.ColumnIndex == 2)
            {
                CComLibrary.GlobeVal.filesave.mSaveCriteraiRow3[e.RowIndex] = Convert.ToDouble(dgridsave.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

            }

            if (e.ColumnIndex == 4)
            {
                CComLibrary.GlobeVal.filesave.mSaveCriteraiRow5[e.RowIndex] = Convert.ToDouble(dgridsave.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

            }
        }

        private void cbotestaction4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mtestaction[3] = cbotestaction4.SelectedIndex;
        }

        private void cbotestaction3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mtestaction[2] = cbotestaction3.SelectedIndex;
        }

        private void cbotestaction2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mtestaction[1] = cbotestaction2.SelectedIndex;
        }

        private void cbotestaction1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mtestaction[0] = cbotestaction1.SelectedIndex;
        }

        private void numtestactionspeed1_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mtestactionreturnspeed[0] = numtestactionspeed1.Value;
        }

        private void numtestactionspeed2_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mtestactionreturnspeed[1] = numtestactionspeed2.Value;
        }

        private void numtestactionspeed3_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mtestactionreturnspeed[2] = numtestactionspeed3.Value;
        }

        private void numtestactionspeed4_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mtestactionreturnspeed[3] = numtestactionspeed4.Value;
        }

     
        private void panel4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CComLibrary.GlobeVal.filesave.pretest_cmd.destorigin().ToString());
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editkeeptime_ValueChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.pretest_cmd.keeptime = editkeeptime.Value;
        }

        private void editkeeptime_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {

        }

        private void cbopreoload_keeptime_SelectedValueChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.pretest_cmd.keeptimeunit = cbopreoload_keeptime.SelectedIndex;
        }

        

        private void NumTestTimeForEnd_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mtesttimeforend = NumTestTimeForEnd.Value;
        }

        private void chkKeepTime_CheckedChanged(object sender, EventArgs e)
        {
            if(chkKeepTime.Checked==true)
            {
                CComLibrary.GlobeVal.filesave.mKeepTest = 1;
            }
            else
            {
                CComLibrary.GlobeVal.filesave.mKeepTest = 0;
            }
            
        }

        private void num_CREEP_EXTENSION_LIMIT_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            

        }

        private void num_CREEP_REF_TIME_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
           
        }

        private void numLoopCount_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mPARA_LOOPS = Convert.ToInt64(numLoopCount.Value);
        }

        private void cbotestaction5_SelectedValueChanged(object sender, EventArgs e)
        {
             CComLibrary.GlobeVal.filesave.mtestactionfortesttime= cbotestaction5.SelectedIndex;
           
        }

        private void numtestactionspeed5_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mtestactionreturnspeedfortesttime = numtestactionspeed5.Value;
        }

        private void num_CREEP_EXTENSION_LIMIT_ValueChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mCREEP_EXTENSION_LIMIT = num_CREEP_EXTENSION_LIMIT.Value;
        }

        private void num_CREEP_REF_TIME_ValueChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.mCREEP_REF_TIME = num_CREEP_REF_TIME.Value;
        }

        private void numSaveCountSeg_ValueChanged(object sender, EventArgs e)
        {
            if (CComLibrary.GlobeVal.filesave == null)
            {
                return;
            }
            CComLibrary.GlobeVal.filesave.mSaveCountSeg = Convert.ToInt32(numSaveCountSeg.Value);
            dgridsave.Rows.Clear();

            dgridsave.Height = dgridsave.ColumnHeadersHeight;

            for (int i = 0; i < Convert.ToInt16(numSaveCountSeg.Value); i++)
            {
                dgridsave.Rows.Add();
                dgridsave.Height = dgridsave.Height + Convert.ToInt16(dgridsave.Rows[i].Height);
                dgridsave.Rows[i].Cells[0].Value = (i + 1).ToString();
                dgridsave.Rows[i].Cells[1].Value = CComLibrary.GlobeVal.filesave.mSaveCriteraiRow2[i].ToString("F3");
                dgridsave.Rows[i].Cells[2].Value = CComLibrary.GlobeVal.filesave.mSaveCriteraiRow3[i].ToString("F3");
                dgridsave.Rows[i].Cells[3].Value = "小时";
                dgridsave.Rows[i].Cells[4].Value = CComLibrary.GlobeVal.filesave.mSaveCriteraiRow5[i].ToString("F3");
                dgridsave.Rows[i].Cells[5].Value = "分钟";


            }
            if (dgridsave.Rows.Count > 0)
            {
                dgridsave.Height = dgridsave.Height + 5;
            }
        }
    }
}
