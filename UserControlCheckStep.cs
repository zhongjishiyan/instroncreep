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
              

                mlabel = new Label();
                mlabel.Text = "幅值：";
                mlabel.Dock = DockStyle.Fill;
                mlabel.TextAlign = ContentAlignment.MiddleLeft;
                tlp.Controls.Add(mlabel);

                mUserControlStepInput = new UserControlStepInput();
                mUserControlStepInput.Dock = DockStyle.Fill;
                tlp.Controls.Add(mUserControlStepInput);
               
                mlabel = new Label();
                mlabel.Text = "均值：";
                mlabel.Dock = DockStyle.Fill;
                mlabel.TextAlign = ContentAlignment.MiddleLeft;
                tlp.Controls.Add(mlabel);

                mUserControlStepInput = new UserControlStepInput();
                mUserControlStepInput.Dock = DockStyle.Fill;
                tlp.Controls.Add(mUserControlStepInput);
               

                mlabel = new Label();
                mlabel.Text = "次数：";
                mlabel.Dock = DockStyle.Fill;
                mlabel.TextAlign = ContentAlignment.MiddleLeft;
                tlp.Controls.Add(mlabel);

                mUserControlStepInput = new UserControlStepInput();
                mUserControlStepInput.Dock = DockStyle.Fill;
                tlp.Controls.Add(mUserControlStepInput);
               
            }
            tlp.Visible = true;
        }

        private void MUserControlStepInput_ValueChanged(object sender)
        {
            if (  Convert.ToString( (sender as UserControlStepInput).Tag) =="速度")
            {
                CComLibrary.GlobeVal.filesave.msegtest[Id].speed= (sender as UserControlStepInput).numvalue.Value ;
            }
            if (Convert.ToString((sender as UserControlStepInput).Tag) == "目标值")
            {
                CComLibrary.GlobeVal.filesave.msegtest[Id].dest = (sender as UserControlStepInput).numvalue.Value;
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
            setwave();
        }

        private void cbocontrol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CComLibrary.GlobeVal.filesave.msegtest[Id].controlmode = cbocontrol.SelectedIndex;
            setwave();
        }
    }
}
