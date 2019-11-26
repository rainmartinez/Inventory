using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class Additem : Form
    {
        public Additem()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addthing_Click(object sender, EventArgs e)
        {
            if( Itemname.Text == "" || Quant.Text == ""|| Price.Text == "")
            {
                MessageBox.Show("Missing information", "ERROR");
            }
            string connectionstring = ConfigurationManager.ConnectionStrings["Invent"]?.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand("View", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("search", SqlDbType.VarChar).Value = "";
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (Convert.ToInt32(ID.Text) == reader.GetInt32(0))
                        {
                            MessageBox.Show("Item already exists!", "ERROR");
                            goto end;
                        }
                        else if (Itemname.Text == reader.GetString(1))
                        {
                            MessageBox.Show("Item already exists!", "ERROR");
                            goto end;
                        }
                    }
                    connection.Close();
                }
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand("Add", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("Id", SqlDbType.Int).Value = ID.Text;
                    command.Parameters.Add("Itemname", SqlDbType.VarChar).Value = Itemname.Text;
                    command.Parameters.Add("Quant", SqlDbType.Int).Value = Quant.Text;
                    command.Parameters.Add("Price", SqlDbType.Int).Value = Price.Text;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("Successfully added item to inventory!", "Success");
            }
            catch
            {
                MessageBox.Show("Item already exists!", "ERROR");
            }
        end:;
        }

        private void update_Click(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["Invent"]?.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand("Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("Id", SqlDbType.Int).Value = ID.Text;
                command.Parameters.Add("Itemname", SqlDbType.VarChar).Value = Itemname.Text;
                command.Parameters.Add("Quant", SqlDbType.Int).Value = Quant.Text;
                command.Parameters.Add("Price", SqlDbType.Int).Value = Price.Text;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            MessageBox.Show("Successfully updated item from inventory!", "Success");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["Invent"]?.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand("Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("Id", SqlDbType.Int).Value = ID.Text;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            MessageBox.Show("Successfully Deleted item to inventory!", "Success");
        }

        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Quant_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Itemname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
