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
    public partial class Bookitem : Form
    {
        public Bookitem()
        {
            InitializeComponent();
            labelRA.Visible = false;
            labelRB.Visible = false;
            labelRC.Visible = false;
            labelRD.Visible = false;
        }

        private void checkBoxBA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBA.Checked == true)
            {
                labelRA.Visible =true;
                pictureBoxBA.Visible =false;
                panelA.BackColor = Color.PaleTurquoise;
            }
            if (checkBoxBA.Checked == false)
            {
                labelRA.Visible =false;
                pictureBoxBA.Visible =true;
                panelA.BackColor = Color.Honeydew;
            }
        }

        private void checkBoxCB_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxCB.Checked == true)
            {
                labelRB.Visible = true;
                pictureBoxBB.Visible = false;
                panelB.BackColor = Color.PaleTurquoise;
            }
            if (checkBoxCB.Checked == false)
            {
                labelRB.Visible = false;
                pictureBoxBB.Visible = true;
                panelB.BackColor = Color.Honeydew;
            }
        }

        private void checkBoxCC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCC.Checked == true)
            {
                labelRC.Visible = true;
                pictureBoxC.Visible = false;
                panelC.BackColor = Color.PaleTurquoise;
            }
            if (checkBoxCC.Checked == false)
            {
                labelRC.Visible = false;
                pictureBoxC.Visible = true;
                panelC.BackColor = Color.Honeydew;

            }
        }

        private void checkBoxDD_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDD.Checked == true)
            {
                labelRD.Visible = true;
                pictureBoxD.Visible = false;
                panelD.BackColor = Color.PaleTurquoise;
            }
            if (checkBoxDD.Checked == false)
            {
                labelRD.Visible = false;
                pictureBoxD.Visible = true;
                panelD.BackColor= Color.Honeydew;
            }
        }

        private void buttonBA_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.ShowDialog();
        }

       
    }
}
