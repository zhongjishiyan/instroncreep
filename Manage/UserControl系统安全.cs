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
    public partial class UserControl系统安全 : UserControl
    {
        public UserControlMethod musercontrolmethod;
        public  void Init(int sel)
        {

            tabControl1.SelectedIndex = sel;

            grpuser.Visible = false;
            listBox1.Items.Clear();
           
            for (int i = 0; i < GlobeVal.myglobefile.UserCount; i++)
            {
                listBox1.Items.Add(GlobeVal.myglobefile.UserName[i]);

            }

            chksafe.Checked = GlobeVal.myglobefile.safe  ;


        }
        public UserControl系统安全()
        {
            InitializeComponent();
            tabControl1.ItemSize = new Size(1, 1);
            chksystem.Checked = false;
           

        }

        private void chksystem_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FormUser f = new FormUser();
            GlobeVal.suc = false;
            GlobeVal.username = "";
            GlobeVal.userpassword = "";
            GlobeVal.userkind = GlobeVal.myglobefile.UserLevels[GlobeVal.myglobefile.UserCount];
            f.ShowDialog();

            if (GlobeVal.suc  == true)
            {

                GlobeVal.myglobefile.UserName[GlobeVal.myglobefile.UserCount] = GlobeVal.username;
                GlobeVal.myglobefile.UserPassword[GlobeVal.myglobefile.UserCount] = GlobeVal.userpassword;
                GlobeVal.myglobefile.UserLevels[GlobeVal.myglobefile.UserCount] = GlobeVal.userkind;
                listBox1.Items.Add(GlobeVal.myglobefile.UserName[GlobeVal.myglobefile.UserCount]);
                GlobeVal.myglobefile.UserCount = GlobeVal.myglobefile.UserCount + 1;
                GlobeVal.mysys.SerializeNow(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\sys\\setup.ini");
               
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                GlobeVal.suc = false;
                GlobeVal.username = GlobeVal.myglobefile.UserName[listBox1.SelectedIndex];
                GlobeVal.userpassword = GlobeVal.myglobefile.UserPassword[listBox1.SelectedIndex];
                GlobeVal.userkind = GlobeVal.myglobefile.UserLevels[listBox1.SelectedIndex];
                FormUser f = new FormUser();
                f.ShowDialog();

                if (GlobeVal.suc == true)
                {

                    GlobeVal.myglobefile.UserName[listBox1.SelectedIndex] = GlobeVal.username;
                    GlobeVal.myglobefile.UserPassword[listBox1.SelectedIndex] = GlobeVal.userpassword;
                    GlobeVal.myglobefile.UserLevels[listBox1.SelectedIndex] = GlobeVal.userkind;

                    listBox1.Items[listBox1.SelectedIndex] = GlobeVal.username;
                    GlobeVal.mysys.SerializeNow(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\sys\\setup.ini");

                }

               
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a;
            if (listBox1.SelectedIndex >0)
            {

                a = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);


            for (int i = a; i < GlobeVal.myglobefile.UserCount-1; i++)
            {
                GlobeVal.myglobefile.UserName[i] = GlobeVal.myglobefile.UserName[i + 1];
                GlobeVal.myglobefile.UserPassword[i] = GlobeVal.myglobefile.UserPassword[i + 1];
                GlobeVal.myglobefile.UserLevels[i] = GlobeVal.myglobefile.UserLevels[i + 1];


            }

            GlobeVal.myglobefile.UserCount = GlobeVal.myglobefile.UserCount - 1;
            GlobeVal.mysys.SerializeNow(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ" + "\\sys\\setup.ini");

            }


        }

        private void chksafe_CheckedChanged(object sender, EventArgs e)
        {
           
           
        }

        private void chksafe_Click(object sender, EventArgs e)
        {
            if (chksafe.Checked == true)
            {
                FormMima f = new FormMima();
                f.ShowDialog();

                if (f.suc == true)
                {

                    GlobeVal.myglobefile.safe = chksafe.Checked;

                }
                else
                {
                    chksafe.Checked = false;
                }
            }
            else
            {
                GlobeVal.myglobefile.safe = chksafe.Checked;
            }

        }

        private void chksystem_Click(object sender, EventArgs e)
        {
            if (chksystem.Checked == true)
            {

                FormMima f = new FormMima();
                f.ShowDialog();

                if (f.suc == true)
                {
                    chksystem.Checked = true;
                    grpuser.Visible = true;
                }
                else
                {
                    chksystem.Checked = false;
                    grpuser.Visible = false;
                }

            }
        }
    }
}
