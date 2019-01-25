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
    public partial class UserControl系统选项 : UserControl
    {
        public UserControlMethod musercontrolmethod;
        public  void Init(int sel)
        {

            tabControl1.SelectedIndex = sel;

            if (GlobeVal.myglobefile.safe == true)
            {

                if (GlobeVal.myglobefile.AppUserLevel == 0)
                {
                    tabControl1.Enabled = false;
                }
                else
                {
                    tabControl1.Enabled = true;
                }
            }
            else
            {
                tabControl1.Enabled = true;
            }
            cbostartup.Items.Clear();
            cbostartup.Items.Add("在主屏幕");
            cbostartup.Items.Add("按照上次使用过的试验方法准备试验");
            cbostartup.Items.Add("按照指定的试验方法准备试验");
            cbostartup.SelectedIndex = GlobeVal.myglobefile.startupscreen;


            chktitle.Checked=GlobeVal.myglobefile.showapptitle;
            txtAppTitle.Text = GlobeVal.myglobefile.apptitle;
            txtshort.Text= GlobeVal.myglobefile.shorttitle;
            chkshort.Checked = GlobeVal.myglobefile.showshorttitle;

            txtlogo.Text = GlobeVal.myglobefile.bmplogo;
        
            chklogo.Checked = GlobeVal.myglobefile.showlogo;

        }
        public  UserControl系统选项()
        {
            InitializeComponent();
            tabControl1.ItemSize = new Size(1, 1);
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbostartup_SelectionChangeCommitted(object sender, EventArgs e)
        {
             GlobeVal.myglobefile.startupscreen=cbostartup.SelectedIndex;
             GlobeVal.myglobefile.SerializeNow(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\sys\\globe.ini");
        }

        private void chkdemo_CheckedChanged(object sender, EventArgs e)
        {
          

          
              
        }

        private void txtAppTitle_TextChanged(object sender, EventArgs e)
        {
            GlobeVal.myglobefile.apptitle = txtAppTitle.Text;
        }

        private void chktitle_CheckedChanged(object sender, EventArgs e)
        {
            GlobeVal.myglobefile.showapptitle = chktitle.Checked; 
        }

        private void txtshort_TextChanged(object sender, EventArgs e)
        {
            GlobeVal.myglobefile.shorttitle = txtshort.Text;
        }

        private void chkshort_CheckedChanged(object sender, EventArgs e)
        {
            GlobeVal.myglobefile.showshorttitle = chkshort.Checked;
        }

        private void btnlogo_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "(*.bmp" + ")|*.bmp";

            string s;
            s = System.Windows.Forms.Application.StartupPath;

            openFileDialog1.InitialDirectory = System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\bmp\\";


            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == "")
            {

            }

            else
            {

               
                 txtlogo.Text = System.IO.Path.GetFileName(openFileDialog1.FileName);

                GlobeVal.myglobefile.bmplogo = txtlogo.Text;

            }

        }

        private void chklogo_CheckedChanged(object sender, EventArgs e)
        {
            GlobeVal.myglobefile.showlogo = chklogo.Checked;
        }

        private void btndemotxt_Click(object sender, EventArgs e)
        {
            
        }
    }
}
