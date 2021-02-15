using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class Login : Form
    {
        public string StaffName;
        public Login()
        {
            InitializeComponent();
            DbConnection db = new DbConnection();//
            string conString = db.GetConnectionString();//
            SqlConnection sq = new SqlConnection(conString);//
            SqlCommand command = new SqlCommand();//
            command.Connection = sq;
            string sql = "select FirstName + ' ' +  LastName from Staff";
            command.CommandText = sql;

            sq.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetValue(0).ToString());
            }
            comboBox1.SelectedIndex = 0;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id2;

            id2 = 1;
            bool isStaff = true;
            bool isManager = true;
            /*
            
            DbConnection db = new DbConnection();//
            string conString = db.GetConnectionString();//
            SqlConnection sq = new SqlConnection(conString);//
            SqlCommand command = new SqlCommand();//
            command.Connection = sq;
            //string sql = "Select ;
            //command.CommandText = sql;
            sq.Open();
            SqlDataReader reader = command.ExecuteReader();
            */
            // we will put a check after connecting forms to database
            //on click we will check whether the login id and password exists in databse

            StaffName = comboBox1.SelectedItem.ToString();
            DbConnection db = new DbConnection();//
            string conString = db.GetConnectionString();//
            SqlConnection sq = new SqlConnection(conString);//
            SqlCommand command = new SqlCommand();//
            command.Connection = sq;
            string sql = "select Jobs_idJob from Staff where FirstName + ' ' +  LastName = '" + StaffName + "'";
            command.CommandText = sql;
            
            sq.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id2 = int.Parse(reader.GetValue(0).ToString());
            }
            if (isStaff == true & textbox_Password.Text.ToString() == "iamstaff" )
            {
                MessageBox.Show("Successful login by " + StaffName);
                StaffUnPriv Form = new StaffUnPriv(StaffName);
                this.Hide();
                Form.Show();

            }
            else if (id2 == 1 && isManager == true && textbox_Password.Text.ToString() == "iammanager")
            {
                MessageBox.Show("Successful login by " + StaffName);
                Menu Form = new Menu(StaffName);
                this.Hide();
                Form.Show();
            }
            else
            {
                MessageBox.Show("Access Denied. Use your correct password to login.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textbox_Password.UseSystemPasswordChar= false;
            }
            else
            {

                textbox_Password.UseSystemPasswordChar = true;

            }
        }

        private void Textbox_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
