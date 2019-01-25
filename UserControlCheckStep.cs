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
    public partial class UserControlCheckStep : UserControl
    {
        public UserControlCheckStep()
        {
            InitializeComponent();
            //  tabControl1.ItemSize = new Size(1, 1);

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲


            this.tlpback.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance
                | System.Reflection.BindingFlags.NonPublic).SetValue(this.tlpback, true, null);
            this.tlp.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance
               | System.Reflection.BindingFlags.NonPublic).SetValue(this.tlp, true, null);

        }

        public int Id = 0;

        public event EventHandler CheckChanged;

        private int mUnCheckHeight=24;


      

        public int UnCheckHeight

        {

            get

            {
                return mUnCheckHeight; 
             

            }

          

        }


        private void OnCheckChanged(object sender, EventArgs eventArgs)
        {
            if (this.CheckChanged  != null)
            //判断事件是否有处理函数 
            {

                this.CheckChanged(sender, eventArgs);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkline_CheckedChanged(object sender, EventArgs e)
        {
            this.OnCheckChanged(this, new EventArgs());
            if (chkline.Checked ==true)
            {
                this.Height = tlpback.Height ;
                Init();
                cbocontrol.SelectedIndex = CComLibrary.GlobeVal.filesave.msegtest[Id].controlmode;
                cbowave.SelectedIndex = CComLibrary.GlobeVal.filesave.msegtest[Id].cmd;

                setwave();

            }
            else
            {
                this.Height = mUnCheckHeight;
               
            }
           
        }

        public void setwave()
        {

          
            UserControlStepInput mUserControlStepInput;
            Label mlabel;
           
            tlp.Visible = false;
            if ((cbowave.SelectedIndex == 0) && (chkline.Checked == true))
            {
                tlp.Controls.Clear();
                mlabel = new Label();
                mlabel.Text = "速度：";
                mlabel.Dock = DockStyle.Fill;
                mlabel.TextAlign = ContentAlignment.MiddleLeft;
                tlp.Controls.Add(mlabel);

                mUserControlStepInput = new UserControlStepInput();
                mUserControlStepInput.Dock = DockStyle.Fill;
                tlp.Controls.Add(mUserControlStepInput);

               

                mUserControlStepInput.numvalue.Value = CComLibrary.GlobeVal.filesave.msegtest[Id].speed;
                mUserControlStepInput.cbounit.Items.Clear();
                mUserControlStepInput.cbounit.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[CComLibrary.GlobeVal.filesave.msegtest[Id].controlmode].speedSignal.cUnits[0]);


                mUserControlStepInput.cbounit.SelectedIndex = 0;
                mUserControlStepInput.Tag = "速度";
                mUserControlStepInput.ValueChanged += MUserControlStepInput_ValueChanged;


                if(ClsStaticStation.m_Global.mycls.hardsignals[CComLibrary.GlobeVal.filesave.msegtest[Id].controlmode].SignName =="Ch Load")
                {
                    mlabel = new Label();
                    mlabel.Text = "     约等于应力：";
                    mlabel.Dock = DockStyle.Fill;
                    mlabel.TextAlign = ContentAlignment.MiddleLeft;
                    tlp.Controls.Add(mlabel);

                    mUserControlStepInput = new UserControlStepInput();
                    mUserControlStepInput.Dock = DockStyle.Fill;
                    tlp.Controls.Add(mUserControlStepInput);



                    mUserControlStepInput.numvalue.Value =  CComLibrary.GlobeVal.filesave.LoadToStrain( CComLibrary.GlobeVal.filesave.msegtest[Id].speed);
                    mUserControlStepInput.cbounit.Items.Clear();
                    mUserControlStepInput.cbounit.Items.Add("MPa/S");


                    mUserControlStepInput.cbounit.SelectedIndex = 0;


                    mUserControlStepInput.Tag = "速度≈";
                    mUserControlStepInput.ValueChanged += MUserControlStepInput_ValueChanged;
                }

                mlabel = new Label();
                mlabel.Text = "目标值：";
                mlabel.Dock = DockStyle.Fill;
                mlabel.TextAlign = ContentAlignment.MiddleLeft;
                tlp.Controls.Add(mlabel);

                mUserControlStepInput = new UserControlStepInput();
                mUserControlStepInput.Dock = DockStyle.Fill;
                tlp.Controls.Add(mUserControlStepInput);

                mUserControlStepInput.numvalue.Value = CComLibrary.GlobeVal.filesave.msegtest[Id].dest;
                
                mUserControlStepInput.Tag = "目标值";
                mUserControlStepInput.cbounit.Items.Clear();
                mUserControlStepInput.cbounit.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[CComLibrary.GlobeVal.filesave.msegtest[Id].controlmode].cUnits[0]);
                mUserControlStepInput.cbounit.SelectedIndex = 0;
                mUserControlStepInput.ValueChanged += MUserControlStepInput_ValueChanged;


                if (ClsStaticStation.m_Global.mycls.hardsignals[CComLibrary.GlobeVal.filesave.msegtest[Id].controlmode].SignName == "Ch Load")
                {
                    mlabel = new Label();
                    mlabel.Text = "     约等于应力：";
                    mlabel.Dock = DockStyle.Fill;
                    mlabel.TextAlign = ContentAlignment.MiddleLeft;
                    tlp.Controls.Add(mlabel);

                    mUserControlStepInput = new UserControlStepInput();
                    mUserControlStepInput.Dock = DockStyle.Fill;
                    tlp.Controls.Add(mUserControlStepInput);



                    mUserControlStepInput.numvalue.Value = CComLibrary.GlobeVal.filesave.LoadToStrain(CComLibrary.GlobeVal.filesave.msegtest[Id].dest);
                    mUserControlStepInput.cbounit.Items.Clear();
                    mUserControlStepInput.cbounit.Items.Add("MPa");


                    mUserControlStepInput.cbounit.SelectedIndex = 0;


                    mUserControlStepInput.Tag = "目标≈";
                    mUserControlStepInput.ValueChanged += MUserControlStepInput_ValueChanged;

                }

                mlabel = new Label();
                mlabel.Text = "保持时间：";
                mlabel.Dock = DockStyle.Fill;
                mlabel.TextAlign = ContentAlignment.MiddleLeft;
                tlp.Controls.Add(mlabel);

                mUserControlStepInput = new UserControlStepInput();
                mUserControlStepInput.Dock = DockStyle.Fill;
                tlp.Controls.Add(mUserControlStepInput);

                mUserControlStepInput.numvalue.Value = CComLibrary.GlobeVal.filesave.msegtest[Id].keeptime;
                mUserControlStepInput.Tag = "保持时间";
                mUserControlStepInput.cbounit.Items.Clear();
                mUserControlStepInput.cbounit.Items.Add(ClsStaticStation.m_Global.mycls.timesignal.cUnits[0]);
                mUserControlStepInput.cbounit.SelectedIndex = 0;
                mUserControlStepInput.ValueChanged += MUserControlStepInput_ValueChanged;


            }
            if ((cbowave.SelectedIndex == 1) && (chkline.Checked == true))
            {
                tlp.Controls.Clear();
                mlabel = new Label();
                mlabel.Text = "保持时间：";
                mlabel.Dock = DockStyle.Fill;
                mlabel.TextAlign = ContentAlignment.MiddleLeft;
                tlp.Controls.Add(mlabel);

                mUserControlStepInput = new UserControlStepInput();
                mUserControlStepInput.Dock = DockStyle.Fill;
                tlp.Controls.Add(mUserControlStepInput);

                mUserControlStepInput.numvalue.Value = CComLibrary.GlobeVal.filesave.msegtest[Id].keeptime;
                mUserControlStepInput.Tag = "保持时间";
                mUserControlStepInput.cbounit.Items.Clear();
                mUserControlStepInput.cbounit.Items.Add(ClsStaticStation.m_Global.mycls.timesignal.cUnits[0]);
                mUserControlStepInput.cbounit.SelectedIndex = 0;
                mUserControlStepInput.ValueChanged += MUserControlStepInput_ValueChanged;


            }

            if ((cbowave.SelectedIndex > 1) && (chkline.Checked == true))
            {
                tlp.Controls.Clear();
                mlabel = new Label();
                mlabel.Text = "频率：";
                mlabel.Dock = DockStyle.Fill;
                mlabel.TextAlign = ContentAlignment.MiddleLeft;
                tlp.Controls.Add(mlabel);

                mUserControlStepInput = new UserControlStepInput();
                mUserControlStepInput.Dock = DockStyle.Fill;
                tlp.Controls.Add(mUserControlStepInput);

                mUserControlStepInput.numvalue.Value = CComLibrary.GlobeVal.filesave.msegtest[Id].freq;
                mUserControlStepInput.Tag = "频率";
                mUserControlStepInput.cbounit.Items.Clear();
                mUserControlStepInput.cbounit.Items.Add(ClsStaticStation.m_Global.mycls.freqsignal.cUnits[0]);
                mUserControlStepInput.cbounit.SelectedIndex = 0;
                mUserControlStepInput.ValueChanged += MUserControlStepInput_ValueChanged;



                mlabel = new Label();
                mlabel.Text = "幅值：";
                mlabel.Dock = DockStyle.Fill;
                mlabel.TextAlign = ContentAlignment.MiddleLeft;
                tlp.Controls.Add(mlabel);

                mUserControlStepInput = new UserControlStepInput();
                mUserControlStepInput.Dock = DockStyle.Fill;
                tlp.Controls.Add(mUserControlStepInput);

                mUserControlStepInput.numvalue.Value = CComLibrary.GlobeVal.filesave.msegtest[Id].range ;
                mUserControlStepInput.Tag = "幅值";
                mUserControlStepInput.cbounit.Items.Clear();
                mUserControlStepInput.cbounit.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[CComLibrary.GlobeVal.filesave.msegtest[Id].controlmode].cUnits[0]);
                mUserControlStepInput.cbounit.SelectedIndex = 0;
                mUserControlStepInput.ValueChanged += MUserControlStepInput_ValueChanged;



                mlabel = new Label();
                mlabel.Text = "均值：";
                mlabel.Dock = DockStyle.Fill;
                mlabel.TextAlign = ContentAlignment.MiddleLeft;
                tlp.Controls.Add(mlabel);

                mUserControlStepInput = new UserControlStepInput();
                mUserControlStepInput.Dock = DockStyle.Fill;
                tlp.Controls.Add(mUserControlStepInput);

                mUserControlStepInput.numvalue.Value = CComLibrary.GlobeVal.filesave.msegtest[Id].ave;
                mUserControlStepInput.Tag = "均值";
                mUserControlStepInput.cbounit.Items.Clear();
                mUserControlStepInput.cbounit.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[CComLibrary.GlobeVal.filesave.msegtest[Id].controlmode].cUnits[0]);
                mUserControlStepInput.cbounit.SelectedIndex = 0;
                mUserControlStepInput.ValueChanged += MUserControlStepInput_ValueChanged;

                mlabel = new Label();
                mlabel.Text = "次数：";
                mlabel.Dock = DockStyle.Fill;
                mlabel.TextAlign = ContentAlignment.MiddleLeft;
                tlp.Controls.Add(mlabel);

                mUserControlStepInput = new UserControlStepInput();
                mUserControlStepInput.Dock = DockStyle.Fill;
                tlp.Controls.Add(mUserControlStepInput);

                mUserControlStepInput.numvalue.Value = CComLibrary.GlobeVal.filesave.msegtest[Id].count;
                mUserControlStepInput.Tag = "次数";
                mUserControlStepInput.cbounit.Items.Clear();
                mUserControlStepInput.cbounit.Items.Add(ClsStaticStation.m_Global.mycls.countsignal.cUnits[0]);
                mUserControlStepInput.cbounit.SelectedIndex = 0;
                mUserControlStepInput.ValueChanged += MUserControlStepInput_ValueChanged;


            }
            tlp.Visible = true;
        }

        private void MUserControlStepInput_ValueChanged(object sender)
        {
            if (  Convert.ToString( (sender as UserControlStepInput).Tag) =="速度")
            {
                

                CComLibrary.GlobeVal.filesave.msegtest[Id].speed= (sender as UserControlStepInput).numvalue.Value ;
            }

            if (Convert.ToString((sender as UserControlStepInput).Tag) == "速度≈")
            {


                CComLibrary.GlobeVal.filesave.msegtest[Id].speed = CComLibrary.GlobeVal.filesave.StrainToLoad( (sender as UserControlStepInput).numvalue.Value);

                for(int i=0;i<this.tlp.Controls.Count;i++)
                {
                    if(tlp.Controls[i] is UserControlStepInput )
                    {
                        if(  Convert.ToString((tlp.Controls[i] as UserControlStepInput).Tag)=="速度")
                        {
                            (tlp.Controls[i] as UserControlStepInput).numvalue.Value = CComLibrary.GlobeVal.filesave.msegtest[Id].speed;
                        }
                    }
                }
            }

            if (Convert.ToString((sender as UserControlStepInput).Tag) == "目标值")
            {

                if ((sender as UserControlStepInput).numvalue.Value >= ClsStaticStation.m_Global.mycls.hardsignals[CComLibrary.GlobeVal.filesave.msegtest[Id].controlmode].fullmaxbase)
                {

                    MessageBox.Show("错误，目标值输入超量程，请重新输入");
                    return;

                }
                CComLibrary.GlobeVal.filesave.msegtest[Id].dest = (sender as UserControlStepInput).numvalue.Value;
            }

            if (Convert.ToString((sender as UserControlStepInput).Tag) == "目标≈")
            {


                CComLibrary.GlobeVal.filesave.msegtest[Id].dest  = CComLibrary.GlobeVal.filesave.StrainToLoad((sender as UserControlStepInput).numvalue.Value);

                for (int i = 0; i < this.tlp.Controls.Count; i++)
                {
                    if (tlp.Controls[i] is UserControlStepInput)
                    {
                        if (Convert.ToString((tlp.Controls[i] as UserControlStepInput).Tag) == "目标值")
                        {
                            (tlp.Controls[i] as UserControlStepInput).numvalue.Value = CComLibrary.GlobeVal.filesave.msegtest[Id].dest;
                        }
                    }
                }
            }
            if (Convert.ToString((sender as UserControlStepInput).Tag) == "保持时间")
            {
                CComLibrary.GlobeVal.filesave.msegtest[Id].keeptime = (sender as UserControlStepInput).numvalue.Value;
            }
            if (Convert.ToString((sender as UserControlStepInput).Tag) == "频率")
            {

                CComLibrary.GlobeVal.filesave.msegtest[Id].freq = (sender as UserControlStepInput).numvalue.Value;
            }
            if (Convert.ToString((sender as UserControlStepInput).Tag) == "幅值")
            {
                if((sender as UserControlStepInput).numvalue.Value>=   ClsStaticStation.m_Global.mycls.hardsignals[CComLibrary.GlobeVal.filesave.msegtest[Id].controlmode].fullmaxbase)
                {
                    MessageBox.Show("错误，幅值输入超量程，请重新输入");
                    return;
                }
                CComLibrary.GlobeVal.filesave.msegtest[Id].range = (sender as UserControlStepInput).numvalue.Value;
            }

            if (Convert.ToString((sender as UserControlStepInput).Tag) == "均值")
            {

               if((sender as UserControlStepInput).numvalue.Value>= ClsStaticStation.m_Global.mycls.hardsignals[CComLibrary.GlobeVal.filesave.msegtest[Id].controlmode].fullmaxbase)
                {
                    MessageBox.Show("错误，均值输入超量程，请重新输入");
                    return;
                }
                CComLibrary.GlobeVal.filesave.msegtest[Id].ave = (sender as UserControlStepInput).numvalue.Value;
            }

            if (Convert.ToString((sender as UserControlStepInput).Tag) == "次数")
            {
                CComLibrary.GlobeVal.filesave.msegtest[Id].count = Convert.ToInt32( (sender as UserControlStepInput).numvalue.Value);
            }

            return;
        }

        public void Init()
        {
            cbocontrol.Items.Clear();
            for (int i = 0; i < ClsStaticStation.m_Global.mycls.hardsignals.Count; i++)
            {
                cbocontrol.Items.Add(ClsStaticStation.m_Global.mycls.hardsignals[i].cName);


            }
         
            cbowave.Items.Clear();
            cbowave.Items.Add("斜波");
            cbowave.Items.Add("保持");
            cbowave.Items.Add("正弦");
            cbowave.Items.Add("三角");
            cbowave.Items.Add("方波");
           
        }
        private void UserControlCheckStep_Load(object sender, EventArgs e)
        {

            chkline_CheckedChanged(null, null);
           
           


        }

        private void tlpback_Resize(object sender, EventArgs e)
        {
            this.Height = tlpback.Height;
        }

        public void cbowave_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbocontrol_SelectedValueChanged(object sender, EventArgs e)
        {
           
           
        }

        private void cbowave_SelectedValueChanged(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.msegtest[Id].cmd = cbowave.SelectedIndex;
            setwave();
        }

        private void cbocontrol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.msegtest[Id].controlmode = cbocontrol.SelectedIndex;
            setwave();
        }
    }
}
