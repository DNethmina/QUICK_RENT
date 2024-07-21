using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CW_Finel_App1
{
    public partial class Booking : Form
    {
        private SqlConnection connection ;
        
        public Booking()
        {
            InitializeComponent();
            DBconnection DB = new DBconnection();
            this.connection = new SqlConnection(DB.cont);
            addDataToTable();
        }
        // Clear Button
        private void buttonBC_Click(object sender, EventArgs e)
        {
            textBoxBCID.Clear();
            textBoxVID .Clear();
            textBoxBCID.Clear ();
            textBoxDestination.Clear();
            textBoxPrice.Clear();
            textBoxKm.Clear();
        }
        //Tabale Showing
        private void addDataToTable()
        {
            DBconnection DB = new DBconnection();
            SqlConnection con = new SqlConnection(DB.cont);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Booking",con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            con.Close();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewB.DataSource = dt;
        }
        private void buttoncal_Click(object sender, EventArgs e)
        {
            Calculater calculater = new Calculater();
            calculater.ShowDialog();
        }
     
        // Insert Query
        private void buttonBVS_Click(object sender, EventArgs e)
        {
            bool yes = true;

            

            try
            { 
                DBconnection DB = new DBconnection();
                if (textBoxBCID.Text != string.Empty && textBoxVID.Text != string.Empty)
                {
                    string sql = "insert into Booking(Customer_ID,Vehical_ID,Price,Destination,No_of_KM,Date)values('" +textBoxBCID.Text + "','" + textBoxVID.Text + "','"+int.Parse(textBoxPrice.Text)+"','" +textBoxDestination.Text + "','" +int.Parse(textBoxKm.Text) + "',GETDATE())";
                    SqlConnection con = new SqlConnection(DB.cont);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Succussfully input");
                    addDataToTable();


                }

                else if(String.IsNullOrEmpty(textBoxBCID.Text) && String.IsNullOrEmpty(textBoxVID.Text) && String.IsNullOrEmpty(textBoxDestination.Text) && String.IsNullOrEmpty(textBoxKm.Text) && String.IsNullOrEmpty(textBoxPrice.Text) )
                {
                    
                    errorProviderBCID.SetError(textBoxBCID, "Please Enter User ID !!!");
                    yes = false;
                    textBoxBCID.BackColor = Color.MistyRose;
                    errorProviderBVID.SetError(textBoxVID, "Please Enter Vehical ID !!!");
                    yes = false;
                    textBoxVID.BackColor = Color.MistyRose;
                    errorProviderDes.SetError(textBoxDestination, "Please Enter Destinatin !!!");
                    yes = false;
                    textBoxDestination.BackColor = Color.MistyRose;
                    errorProviderkm.SetError(textBoxKm, "Please Enter Number Of Km!!!");
                    yes = false;
                    textBoxKm.BackColor = Color.MistyRose;
                    errorProviderPrice.SetError(textBoxPrice, "Please Enter Price");
                    yes = false;
                    textBoxPrice.BackColor = Color.MistyRose;

                }
                
        
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

            
            
        }
        private void Booking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'final_DBDataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter1.Fill(this.final_DBDataSet.Booking);

        }
        // For selection
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewB.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewB.CurrentRow.Selected = true;
                    textBoxBCID.Text = dataGridViewB.Rows[e.RowIndex].Cells["Customer_ID"].FormattedValue.ToString();
                    textBoxVID.Text = dataGridViewB.Rows[e.RowIndex].Cells["Vehical_ID"].FormattedValue.ToString();
                    textBoxPrice.Text = dataGridViewB.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                    textBoxDestination.Text = dataGridViewB.Rows[e.RowIndex].Cells["Destination"].FormattedValue.ToString();
                    textBoxKm.Text = dataGridViewB.Rows[e.RowIndex].Cells["No_of_KM"].FormattedValue.ToString();
                }
            }
        }
        // Searching
        private void buttonBS_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from Booking where Customer_ID = '"+textBoxBCID.Text+"'",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewB.DataSource = dt;
        }
        // Delete Button Query
        private void buttonBD_Click(object sender, EventArgs e)
        {
            if(textBoxBCID.Text != "")
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Delete Booking where Customer_ID = '" + textBoxBCID.Text + "'", connection);
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

       
    }
}
