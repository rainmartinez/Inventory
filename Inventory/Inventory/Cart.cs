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
using System.IO;

namespace Inventory
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["Invent"]?.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand("View", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("search", SqlDbType.VarChar).Value = search.Text;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item1 = new ListViewItem(new[] { Convert.ToString(reader.GetInt32(0)), reader.GetString(1), Convert.ToString(reader.GetInt32(2)), Convert.ToString(reader.GetInt32(3)) });
                        listView1.Items.Add(item1);
                    }

                }
            }
            listView1.ListViewItemSorter = new Sorter();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\Reciept.txt";
                string connectionstring = ConfigurationManager.ConnectionStrings["Invent"]?.ConnectionString;
                DialogResult B = MessageBox.Show("Are you sure you want to check out?", "Confirm", MessageBoxButtons.YesNo);
                if (B == DialogResult.Yes)
                {
                    

                    File.Create(path).Close();
                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    using (SqlCommand command = new SqlCommand("NewArchieve", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    using (SqlCommand command = new SqlCommand("ViewCart", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                using (var tw = new StreamWriter(path, true))
                                {
                                    tw.WriteLine("------------------");
                                    tw.WriteLine(reader.GetString(1) + "     x" + Convert.ToString(reader.GetInt32(2)) + "     P" + Convert.ToString(reader.GetInt32(3)));
                                }
                            }

                        }
                        connection.Close();
                    }
                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    using (SqlCommand command = new SqlCommand("Select sum(TotalPrice)\n" + "From Cart", connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                using (var tw = new StreamWriter(path, true))
                                {
                                    tw.WriteLine("------------------");
                                    tw.WriteLine("Total Price: P" + reader.GetInt32(0));
                                }
                            }
                            connection.Close();
                        }
                    }
                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    using (SqlCommand command = new SqlCommand("NewInvent", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show("Receipt generated at " + path);
                    this.Close();

                }
                else if (B == DialogResult.No)
                {

                }
               
            }
            catch(Exception)
            {
                MessageBox.Show("Cart has no content!", "ERROR");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //clear all cart contents then add to invent
            string connectionstring = ConfigurationManager.ConnectionStrings["Invent"]?.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand("TestRestore", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            DialogResult b = MessageBox.Show("Exit without checking out?", "Choice", MessageBoxButtons.YesNo);
            if (b == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand("TestRestore", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                this.Close();
            }
            else if(b == DialogResult.No)
            {

            }

        }

        private void Buy_Click(object sender, EventArgs e)
        {
            try
            {
                //remove from inventory here
                string connectionstring = ConfigurationManager.ConnectionStrings["Invent"]?.ConnectionString;
                if (Convert.ToInt32(Amount.Text) > Convert.ToInt32(listView1.SelectedItems[0].SubItems[2].Text))
                {
                    MessageBox.Show("Enter valid amount", "ERROR");
                    goto gg;
                }
                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand("AddToCart", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("ItemID", SqlDbType.Int).Value = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                    command.Parameters.Add("Quant", SqlDbType.Int).Value = Convert.ToInt32(Amount.Text);
                    command.Parameters.Add("Price", SqlDbType.Int).Value = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand("Test", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("Quant", SqlDbType.Int).Value = Convert.ToInt32(Amount.Text);
                    command.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                listView1.Items.Clear();
                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand("View", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("search", SqlDbType.VarChar).Value = search.Text;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item1 = new ListViewItem(new[] { Convert.ToString(reader.GetInt32(0)), reader.GetString(1), Convert.ToString(reader.GetInt32(2)), Convert.ToString(reader.GetInt32(3)) });
                            listView1.Items.Add(item1);
                        }

                    }
                }
                MessageBox.Show("Added to cart", "Success");
            }
            catch (Exception c)
            {
                MessageBox.Show("Select an item from the list", "ERROR");
            }
        
 gg:;
        }
        private void Amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string connectionstring = ConfigurationManager.ConnectionStrings["Invent"]?.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand("View", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("search", SqlDbType.VarChar).Value = search.Text;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item1 = new ListViewItem(new[] { Convert.ToString(reader.GetInt32(0)), reader.GetString(1), Convert.ToString(reader.GetInt32(2)), Convert.ToString(reader.GetInt32(3)) });
                        listView1.Items.Add(item1);
                     
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Viewcart viewcart = new Viewcart();
            viewcart.ShowDialog();
            this.Show();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Sorter s = (Sorter)listView1.ListViewItemSorter;
            s.Column = e.Column;

            if (s.Order == System.Windows.Forms.SortOrder.Ascending)
            {
                s.Order = System.Windows.Forms.SortOrder.Descending;
            }
            else
            {
                s.Order = System.Windows.Forms.SortOrder.Ascending;
            }
            listView1.Sort();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Howmany_Click(object sender, EventArgs e)
        {

        }
    }
}
