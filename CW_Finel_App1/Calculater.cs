using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CW_Finel_App1
{
    public partial class Calculater : Form
    {
        public Calculater()
        {
            InitializeComponent();
        }

        string cal;
        int num1;
        int num2;
        string opt;
        int result;

        

        private void buttonCfi_Click(object sender, EventArgs e)
        {
           textBoxCal.Text = textBoxCal.Text + buttonCfi.Text;
        }

        private void buttonCt_Click(object sender, EventArgs e)
        {
            textBoxCal.Text = textBoxCal.Text + buttonCt.Text;
        }

        private void buttonCth_Click(object sender, EventArgs e)
        {
            textBoxCal.Text = textBoxCal.Text + buttonCth.Text;
        }

        private void buttonCf_Click(object sender, EventArgs e)
        {
            textBoxCal.Text = textBoxCal.Text + buttonCf.Text;
        }

        private void buttonCFive_Click(object sender, EventArgs e)
        {
            textBoxCal.Text = textBoxCal.Text + buttonCFive.Text;
        }

        private void buttonCsix_Click(object sender, EventArgs e)
        {
            textBoxCal.Text = textBoxCal.Text + buttonCsix.Text;
        }

        private void buttonCseven_Click(object sender, EventArgs e)
        {
            textBoxCal.Text = textBoxCal.Text + buttonCseven.Text;
        }

        private void buttonCei_Click(object sender, EventArgs e)
        {
            textBoxCal.Text = textBoxCal.Text + buttonCei.Text;
        }

        private void buttonCnine_Click(object sender, EventArgs e)
        {
            textBoxCal.Text = textBoxCal.Text + buttonCnine.Text;
        }

        private void buttonCzero_Click(object sender, EventArgs e)
        {
            textBoxCal.Text = textBoxCal.Text + buttonCzero.Text;
        }

        private void buttondevide_Click(object sender, EventArgs e)
        {
            opt = "/";
            num1 = int.Parse(textBoxCal.Text);

            textBoxCal.Clear();
        }

        private void buttonmulity_Click(object sender, EventArgs e)
        {
            opt = "*";
            num1 = int.Parse(textBoxCal.Text);

            textBoxCal.Clear();
        }

        private void buttonpluse_Click(object sender, EventArgs e)
        {
            opt = "+";
            num1 = int.Parse(textBoxCal.Text);

            textBoxCal.Clear();
        }

        private void buttonminuse_Click(object sender, EventArgs e)
        {
            opt = "-";
            num1 = int.Parse(textBoxCal.Text);

            textBoxCal.Clear();
        }

        private void buttonCcal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBoxCal.Text);

            if(opt.Equals("/"))
            {
                result = num1 / num2;
            }

            if (opt.Equals("*"))
            {
                result = num1 * num2;
            }


            if (opt.Equals("+"))
            {
                result = num1 + num2;
            }


            if (opt.Equals("-"))
            {
                result = num1 - num2;
            }

            textBoxCal.Text = result + "";

           
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBoxCal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        
    }
}
