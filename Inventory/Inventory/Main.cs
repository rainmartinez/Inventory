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
    public partial class Main : Form
    {
        public string test;
        public Main()
        {
            InitializeComponent();


        }

        private void Logout_Click(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["invent"]?.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand("Editlogout", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("time", SqlDbType.SmallDateTime).Value = DateTime.Now;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Additem additem = new Additem();
            additem.ShowDialog();
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
            this.Show();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Buy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart cart = new Cart();
            cart.ShowDialog();
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
            this.Show();
        }

        private void Main_Load(object sender, EventArgs e)
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
    }
}
