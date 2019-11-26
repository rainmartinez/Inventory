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
    public partial class Viewcart : Form
    {
        public int total;
        public Viewcart()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Viewcart_Load(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["Invent"]?.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand("ViewCart", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item1 = new ListViewItem(new[] { Convert.ToString(reader.GetInt32(0)), reader.GetString(1), Convert.ToString(reader.GetInt32(2)), Convert.ToString(reader.GetInt32(3)) });
                        listView1.Items.Add(item1);
                        total = total + reader.GetInt32(3);
                        label3.Text = Convert.ToString(total);
                    }

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["Invent"]?.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand("ViewCart", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (Convert.ToInt32 (textBox1.Text) == reader.GetInt32(0))
                        {
                            goto cont;
                        }
                    }
                    connection.Close();
                    MessageBox.Show("Invalid itemID", "ERROR");
                    goto end;
                }
            }
        cont:;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand("DeleteCart", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("Id", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                command.Parameters.Add("Quant", SqlDbType.Int).Value = Convert.ToInt32(textBox2.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            MessageBox.Show("Successfully Deleted item from cart!", "Success");
            listView1.Items.Clear();
            total = 0;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand("ViewCart", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item1 = new ListViewItem(new[] { Convert.ToString(reader.GetInt32(0)), reader.GetString(1), Convert.ToString(reader.GetInt32(2)), Convert.ToString(reader.GetInt32(3)) });
                        listView1.Items.Add(item1);
                        total = total + reader.GetInt32(3);
                        label3.Text = Convert.ToString(total);
                    }
                }
            }
        end:;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    
}
