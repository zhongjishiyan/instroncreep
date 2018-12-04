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
    public partial class UserControlStepInput : UserControl
    {
        public delegate void ValueChangedHandle(object sender);

        public event ValueChangedHandle ValueChanged;


        public UserControlStepInput()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲


            this.tlpback.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance 
                | System.Reflection.BindingFlags.NonPublic).SetValue(this.tlpback, true, null);
            
        }

        private void numspeed1_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            if(ValueChanged!=null)
            {
                this.ValueChanged(this);
            }
        }
    }
}
