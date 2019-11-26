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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            User.Text = "";
            Pass.Text = "";
            First.Text = "";
            Last.Text = "";
            eadd.Text = "";

        }

        private void su_Click(object sender, EventArgs e)
        {
            if(Pass.Text == "" || User.Text == ""|| First.Text == "" || Last.Text == "" || eadd.Text == "")
            {
                MessageBox.Show("Fill in all the textbox", "ERROR");
                goto tt;
            }
            int userinfoID = 0;
            string connectionstring = ConfigurationManager.ConnectionStrings["Invent"]?.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand("userid", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userinfoID = reader.GetInt32(0) + 1;
                    }
                }
                
                connection.Close();
            }
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand("Signup", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("userID", SqlDbType.Int).Value = userinfoID;
                command.Parameters.Add("User", SqlDbType.VarChar).Value = User.Text;
                command.Parameters.Add("Pass", SqlDbType.VarChar).Value = Pass.Text;
                command.Parameters.Add("First", SqlDbType.VarChar).Value = First.Text;
                command.Parameters.Add("Last", SqlDbType.VarChar).Value = Last.Text;
                command.Parameters.Add("Email", SqlDbType.VarChar).Value = eadd.Text;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            MessageBox.Show("Sign up successful!", "Success");
        
            this.Close();
        tt:;
        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void First_TextChanged(object sender, EventArgs e)
        {

        }

        private void Last_TextChanged(object sender, EventArgs e)
        {

        }

        private void eadd_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
