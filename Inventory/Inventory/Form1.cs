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
using System.Configuration;

namespace Inventory
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void Buttonsi_Click(object sender, EventArgs e)
        {
            string user, pass;

            string connectionstring = ConfigurationManager.ConnectionStrings["Invent"]?.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand("delete from Latestaccess", connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
                using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand("CheckUserPass", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user = reader.GetString(0); pass = reader.GetString(1);
                        if (usernamesi.Text == user)
                        {
                            if(Passwordsi.Text == pass)
                            {
                                connection.Close();
                                connection.Open();
                                using (SqlCommand mand = new SqlCommand("Editlogin", connection))
                                {
                                    mand.CommandType = CommandType.StoredProcedure;
                                    mand.Parameters.Add("time", SqlDbType.SmallDateTime).Value = DateTime.Now;
                                    mand.Parameters.Add("user", SqlDbType.VarChar).Value = usernamesi.Text;
                                    mand.Parameters.Add("pass", SqlDbType.VarChar).Value = Passwordsi.Text;
                                    mand.ExecuteNonQuery();
                                    
                                }
                                    goto zz;
                            }
                            else
                            {

                            }
                        }
                    }
                }
                MessageBox.Show("Wrong Username and/or Password", "ERROR");
                goto xx;
zz:
                usernamesi.Clear();
                Passwordsi.Clear();
                Main main = new Main();
                this.Hide();
                main.ShowDialog();
                this.Show();
xx:             connection.Close();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //usernamesi
        }

        private void Passwordsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buttonsu_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            this.Hide();
            signup.ShowDialog();
            this.Show();
        }
    }
}
