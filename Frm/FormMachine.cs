using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TabHeaderDemo.Frm
{
    public partial class FormMachine : Form
    {
        public FormMachine()
        {
            InitializeComponent();
        }

        private void FormMachine_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            for (int i = 0; i < GlobeVal.myglobefile.ControllerCount; i++)
            {
                comboBox1.Items.Add((i+1).ToString());
            }
            if ((GlobeVal.selcontroller >= 1) && (GlobeVal.selcontroller <= GlobeVal.myglobefile.ControllerCount))
            {
                comboBox1.SelectedIndex = GlobeVal.selcontroller-1;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobeVal.selcontroller = comboBox1.SelectedIndex + 1;
            ClsStaticStation.m_Global.currentmachineId  = GlobeVal.selcontroller - 1;

            Close();

        }
    }
}
