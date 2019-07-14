using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shecan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioBtn_Yes_CheckedChanged(object sender, EventArgs e)//Select Shecan's DNS
        {

            if (radioBtn_Yes.Checked)
            {
                radioBtn_No.Checked = false;
                Program.setDNS(txt_shecan1.Text, txt_shecan2.Text);
            }
        }

        private void radioBtn_No_CheckedChanged(object sender, EventArgs e) //Select another DNS
        {
            if(radioBtn_No.Checked)
            {
                radioBtn_Yes.Checked = false;
                Program.setDNS(txt_globDns1.Text, txt_globDns2.Text);
            }

        }
    }
}
