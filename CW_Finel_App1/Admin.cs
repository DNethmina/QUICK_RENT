using CW_Finel_App1.CW_Final2DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CW_Finel_App1
{
    public partial class Admin : Form
    {
        private SqlConnection connection;
        public Admin()
        {
            InitializeComponent();
            DBconnection DB = new DBconnection();
            this.connection = new SqlConnection(DB.cont);
            addDataToTable();
            
        }
        
       /* private void setDaylyIncome()
        {
            String date=DateTime.Now.ToLongDateString();
            DateTime dateTime = DateTime.Now;
            SqlCommand cmd = new SqlCommand("select sum(Price) from Booking where Date = '" + dateTime + "'", connection);
            MessageBox.Show("Your value input success");
            string sum = Convert.ToString(cmd.ExecuteScalar()) ;
            sum = lblIncome.Text;
           
        }*/

        // Customer tabale Viwe
       private void addDataToTable()
        {
            DBconnection DB = new DBconnection();
            SqlConnection con = new SqlConnection(DB.cont);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Customer", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            con.Close();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewC.DataSource = dt;
        }



        // Go To sign up sheet
        private void buttonvehicladetails_Click(object sender, EventArgs e)
        {
            SingUp singUp = new SingUp();
            singUp.ShowDialog();
        }
        //Go To Customer Feedback viwe
        private void buttonCfeedback_Click(object sender, EventArgs e)
        {
            CustomerF C = new CustomerF();
            C.ShowDialog();
        }

        
        //Go to Vehical Tabale
        private void buttonaddvehicle_Click(object sender, EventArgs e)
        {
            Vehicale vehicale_Detaile = new Vehicale();
            vehicale_Detaile.ShowDialog();
        }
        //Go to Booking Tabale
        private void buttonBooking_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.ShowDialog();
            
        }


        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'final_DBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.final_DBDataSet.Customer);

        }
        //Go to Sing up sheet
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SingUp singUp = new SingUp();
            singUp.ShowDialog();
        }

        
        // Delete Query
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxACID.Text != "")
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Delete Customer where Customer_ID = '" + textBoxACID.Text + "'", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Successfully delete");
                addDataToTable();


            }
            else
            {
                MessageBox.Show("Select your choice");
            }


        }
        // Select Data
        private void dataGridViewC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewC.CurrentRow.Selected = true;
                    textBoxACID.Text = dataGridViewC.Rows[e.RowIndex].Cells["Customer_ID"].FormattedValue.ToString();
                    textBoxAName.Text = dataGridViewC.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                    textANIC.Text = dataGridViewC.Rows[e.RowIndex].Cells["NIC_or_Passport_No"].FormattedValue.ToString();

                }
            }
        }
        // Go to Home
        private void buttonAH_Click(object sender, EventArgs e)
        {
            FormFirst formFirst = new FormFirst();
            formFirst.ShowDialog();
        }
        //Searching
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from Customer where Customer_ID = '" + textBoxACID.Text + "'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewC.DataSource = dt;
        }
    }
    
}
