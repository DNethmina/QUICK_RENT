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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }
        //Submit Data
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string parth = @"C:\\Users\\deshan\\Desktop\\GUI\\MyfristConsoleApp1\\my GUI\\CW_Finel_App1\\CW_final.txt";
            File.WriteAllText(parth,textBoxFeedback.Text);
            MessageBox.Show("Your Submited Is Save");
        }
        //Clear Data
        private void buttonCn_Click(object sender, EventArgs e)
        {
            textBoxFeedback.Clear();
        }
    }
}
