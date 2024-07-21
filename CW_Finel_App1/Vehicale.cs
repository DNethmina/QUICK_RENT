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
    public partial class Vehicale : Form
    {
        private SqlConnection connection;
        public Vehicale()
        {
            InitializeComponent();
            DBconnection DB = new DBconnection();
            this.connection = new SqlConnection(DB.cont);
            addDataToTable();
        }
        //Tabale viwe
        private void addDataToTable()
        {
            DBconnection DB = new DBconnection();
            SqlConnection con = new SqlConnection(DB.cont);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Vehical", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            con.Close();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewvehical.DataSource = dt;
        }
        //Clear Button
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxB.Clear();
            textBoxT.Clear();
            textBoxNo.Clear();
            textBoxVno.Clear();
        }

        private void Vehicale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'final_DBDataSet.Vehical' table. You can move, or remove it, as needed.
            this.vehicalTableAdapter.Fill(this.final_DBDataSet.Vehical);

        }
        //Data Insert
        private void buttonVS_Click(object sender, EventArgs e)
        {
            bool yes = true;
            try
            {
                DBconnection DB = new DBconnection();
                if (textBoxID.Text != string.Empty && textBoxNo.Text != string.Empty)
                {
                    string sql = "insert into Vehical(Vehical_ID,Brand,Type,Engine_No,Vehical_No,Vehical_date)values('" + textBoxID.Text + "','" + textBoxB.Text + "','" + textBoxT.Text + "','" + textBoxNo.Text + "','" + textBoxVno.Text + "',GETDATE())";
                    SqlConnection con = new SqlConnection(DB.cont);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Succussfully input");
                    
                    addDataToTable();
                }

                else if(String.IsNullOrEmpty(textBoxID.Text) && String.IsNullOrEmpty(textBoxB.Text) && String.IsNullOrEmpty(textBoxT.Text) && String.IsNullOrEmpty(textBoxNo.Text) && String.IsNullOrEmpty(textBoxVno.Text))
                {
                    
                    errorProviderVid.SetError(textBoxID, "Please Enter Vehical ID !!!");
                    yes = false;
                    textBoxID.BackColor = Color.MistyRose;
                    errorProviderVB.SetError(textBoxB, "Please Enter Vehical Brand !!!");
                    yes = false;
                    textBoxB.BackColor = Color.MistyRose;
                    errorProviderVT.SetError(textBoxT, "Please Enter Vehical Type !!!");
                    yes = false;
                    textBoxT.BackColor = Color.MistyRose;
                    errorProviderEn.SetError(textBoxNo, "Please Enter Vehical Engine Number !!!");
                    yes = false;
                    textBoxNo.BackColor = Color.MistyRose;
                    errorProviderVn.SetError(textBoxVno, "Please Enter Vehical Number !!!");
                    yes = false;
                    textBoxVno.BackColor = Color.MistyRose;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        //Selection
        private void dataGridViewvehical_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dataGridViewvehical.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dataGridViewvehical.CurrentRow.Selected = true;
                        textBoxID.Text = dataGridViewvehical.Rows[e.RowIndex].Cells["Vehical_ID"].FormattedValue.ToString();
                        textBoxB.Text = dataGridViewvehical.Rows[e.RowIndex].Cells["Brand"].FormattedValue.ToString();
                        textBoxT.Text = dataGridViewvehical.Rows[e.RowIndex].Cells["Type"].FormattedValue.ToString();
                        textBoxNo.Text = dataGridViewvehical.Rows[e.RowIndex].Cells["Engine_No"].FormattedValue.ToString();
                        textBoxVno.Text = dataGridViewvehical.Rows[e.RowIndex].Cells["Vehical_No"].FormattedValue.ToString();
                    }
                }
            
        }
        //Search Button
        private void buttonS_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from Vehical where Vehical_ID = '" + textBoxID.Text + "'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewvehical.DataSource = dt;
        }
        //Delete Query
        private void buttonD_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "")
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Delete Vehical where Vehical_ID = '" + textBoxID.Text + "'", connection);
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
