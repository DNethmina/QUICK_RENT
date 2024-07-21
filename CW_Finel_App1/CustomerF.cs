using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_Finel_App1
{
    public partial class CustomerF : Form
    {
        public CustomerF()
        {
            InitializeComponent();
        }
        //Read Feedback
        private void buttonR_Click(object sender, EventArgs e)
        {
            string parth = @"C:\\Users\\deshan\\Desktop\\GUI\\MyfristConsoleApp1\\my GUI\\CW_Finel_App1\\CW_final.txt";
            var str = File.ReadAllText(parth);
            textBoxCF.Text = str;
        }
        //wirte feedback
        private void buttonW_Click(object sender, EventArgs e)
        {
            string parth = @"C:\\Users\\deshan\\Desktop\\GUI\\MyfristConsoleApp1\\my GUI\\CW_Finel_App1\\CW_final.txt";
            File.WriteAllText(parth, textBoxCF.Text);
            MessageBox.Show("Your Submited Is Save");
        }
        //clear Button
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxCF.Clear();
        }
    }
}
