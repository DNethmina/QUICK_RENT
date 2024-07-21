using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_Finel_App1
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        //clear button
        private void button2_Click(object sender, EventArgs e)
        {
            textAdminUser.Clear();
            textAdminpassword.Clear();
        }
        //cheak Username and Password
        private void button1_Click(object sender, EventArgs e)
        {
            bool ok = true;
            if (textAdminUser.Text == "D001" && textAdminpassword.Text == "111")
            {
                Admin admin = new Admin();
                admin.ShowDialog();
                this.Hide();

            }
            if(String.IsNullOrEmpty(textAdminUser.Text) && String.IsNullOrEmpty(textAdminpassword.Text))
            {
                textAdminUser.Text = string.Empty;
                textAdminpassword.Text = string.Empty;
                errorProviderUser.SetError(textAdminUser, "Check Your Username!!");
                ok = false;
                textAdminUser.BackColor = Color.MistyRose;
                errorProviderPass.SetError(textAdminpassword, "Check Your Password!!");
                ok = false;
                textAdminpassword.BackColor = Color.MistyRose;
            }
            if(textAdminUser.Text != "D001")
            {
                errorProviderUser.SetError(textAdminUser, "Your Username is worrng!!!");
                ok = false;
                textAdminUser.BackColor = Color.MistyRose;
            }
            if(textAdminpassword.Text != "111")
            {
                errorProviderUser.SetError(textAdminpassword, "Your Password is worrng!!!");
                ok = false;
                textAdminpassword.BackColor = Color.MistyRose;
            }

           
           



        }

        
    }
}
