using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Data.SqlClient; //
using System.Diagnostics;

namespace RestaurantManagement//
{
    public partial class AddStaff : Form
    {
        SqlConnection con;

        public AddStaff()
        {
            InitializeComponent();
            DbConnection db = new DbConnection();//
            string conString = db.GetConnectionString();//
            SqlConnection sq = new SqlConnection(conString);//
            SqlCommand command = new SqlCommand();//
            command.Connection = sq;
            string sql = "select JobTitle from Jobs";
            command.CommandText = sql;
            sq.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetValue(0).ToString());
            }
            reader.Close();
            sql = "select idBranch from Branch";
            command.CommandText = sql;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader.GetValue(0).ToString());
            }

        }

        private void button_BackToMenu_Click(object sender, EventArgs e)
        {
            Menu Form = new Menu("A");
            this.Hide();
            Form.Show();
        }

        private void Textbox_NIC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button_AddStaff_Click(object sender, EventArgs e)
        {
            if (textbox_NIC.Text == "" || textbox_LastName.Text == "" || textbox_FirstName.Text == "" || comboBox2.Text == "" || comboBox1.Text == "" || textbox_DailyWorkHours.Text == "")
            {
                MessageBox.Show("Please enter mandatory fields");
            }
            else
            {

                string var = "";
                var = var + "@NIC = '" + textbox_NIC.Text + "'" + "," + "@FirstName = '" + textbox_FirstName.Text + "'" + "," + "@LastName = '" + textbox_LastName.Text + "'";
 

                var = var + "," + "@BranchId = '" + comboBox2.Text + "'" + "," + "@HiringDate = '" + datetimepicker_HiringDate.Value.ToString("yyyy-MM-dd") + "'" + "," + "@JobTitle = '" + comboBox1.Text + "'" + "," + "@WorkHours = '" + textbox_DailyWorkHours.Text + "'";
                Debug.WriteLine(var);
                
                DbConnection db = new DbConnection();

                con = db.conn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();


                Debug.WriteLine("EXEC[Add Staff]" + var);
                cmd.CommandText = "EXEC[Add Staff]" + var;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Staff added successfully");
            }

        }

        private void AddStaff_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Textbox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Textbox_DailyWorkHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void Datetimepicker_HiringDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Textbox_LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_NIC_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_LastName_Click(object sender, EventArgs e)
        {
                
        }
    }
}
