using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CW_Finel_App1
{
    public partial class SingUp : Form
    {
        public SingUp()
        {
            InitializeComponent();
        }
        // Clear Button
        private void buttonSClear_Click(object sender, EventArgs e)
        {
            textBoxCID.Clear();
            textBoxName.Clear();
            textBoxAddress.Clear();
            textNIC.Clear();
            textAge.Clear();
            textContact.Clear();
           
           
        }

        //Data Insert To Customer Table
        private void buttonSSave_Click(object sender, EventArgs e)
        {
                bool Yes=false;

                DBconnection DB = new DBconnection();
                String gender = null;
                if (textBoxCID.Text != string.Empty && textNIC.Text != string.Empty)
                { 
                    
                    if (radioButtonMale.Checked)
                    {
                        gender = "male";
                    }
                    if(radioButtonFemale.Checked) 
                    {
                        gender = "female";
                    }
                    string sql = "insert into Customer(Customer_ID,Name,Country,Address,NIC_or_Passport_No,Gender,Age,Contact,Register_date)values('" + textBoxCID.Text + "','" + textBoxName.Text + "','" + comboBoxCountry.SelectedItem + "','" + textBoxAddress.Text + "','" + textNIC.Text + "','" + gender + "','" + int.Parse(textAge.Text) + "','" + int.Parse(textContact.Text) + "',GETDATE())";
                    SqlConnection con = new SqlConnection(DB.cont);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Succussfully input");
                   


            }

                else if(String.IsNullOrEmpty(textBoxCID.Text) && String.IsNullOrEmpty(textBoxName.Text) && String.IsNullOrEmpty(textNIC.Text) && String.IsNullOrEmpty(textBoxAddress.Text) && String.IsNullOrEmpty(textAge.Text) && String.IsNullOrEmpty(textContact.Text))
            {
                // MessageBox.Show("Something is worng");
                errorProviderCID.SetError(textBoxCID, "Please Enter CID!!!");
                Yes = false;
                textBoxCID.BackColor = Color.MistyRose;
                errorProviderName.SetError(textBoxName, "Please Enter Name!!!");
                Yes = false;
                textBoxName.BackColor = Color.MistyRose;
                errorProviderNIC.SetError(textNIC, "Please Enter NIC_No or Passport_No!!!");
                Yes = false;
                textNIC.BackColor = Color.MistyRose;
                errorProviderAddress.SetError(textBoxAddress, "Please Enter Address!!!");
                Yes = false;
                textBoxAddress.BackColor = Color.MistyRose;
                errorProviderAge.SetError(textAge, "Enter Your Age !!!");
                Yes = false;
                textAge.BackColor = Color.MistyRose;
                errorProviderContact.SetError(textContact, "Please Enter Contact!!!");
                Yes = false;
                textContact.BackColor = Color.MistyRose;
            }
            try
            {
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

            
        }

        
    }
    
}
