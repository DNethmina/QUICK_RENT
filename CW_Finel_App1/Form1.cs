using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_Finel_App1
{
    public partial class FormFirst : Form
    {
        public FormFirst()
        {
            InitializeComponent();
        }

       

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin A = new AdminLogin();
            A.ShowDialog();
            
           
        }

        private void yourFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback();
            feedback.ShowDialog();
            
        }

        private void registerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SingUp singUp = new SingUp();
            singUp.ShowDialog();
        }

        private void weddingCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Bookitem bookitem = new Bookitem();
           bookitem.ShowDialog();
           
        }
    }
}
