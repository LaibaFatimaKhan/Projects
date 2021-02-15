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
namespace RestaurantManagement
{
    public partial class AddOrders : Form
    {
        public string f;
        public AddOrders(string staff)
        {
            
            MessageBox.Show(staff);
            f = "abc";
            InitializeComponent();
            DbConnection db = new DbConnection();//
            string conString = db.GetConnectionString();//
            SqlConnection sq = new SqlConnection(conString);//
            SqlCommand command = new SqlCommand();//
            command.Connection = sq;
            string sql = "select idStaff from Staff where FirstName + ' '  +LastName = '" + staff + "'";
            command.CommandText = sql;
            sq.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                f = reader.GetValue(0).ToString();
            }
            comboBox1.Text = f;     
            db = new DbConnection();//
           conString = db.GetConnectionString();//
            sq = new SqlConnection(conString);//
            command = new SqlCommand();//
            command.Connection = sq;
            sql = "select Name from FoodItems";
            command.CommandText = sql;
            sq.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                combobox_FoodItems.Items.Add(reader.GetValue(0).ToString());
            }
            reader.Close();
            sql = "select idStaff from Staff";
            command.CommandText = sql;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
               comboBox1.Items.Add(reader.GetValue(0).ToString());
            }
            f = staff ;

        }

        private void button_AddOrder_Click(object sender, EventArgs e)
        {
            //bool flag = false;
            int quantity;
            string id;
            string CustID;
            string food;
            DbConnection db = new DbConnection();//
            string conString = db.GetConnectionString();//
            SqlConnection sq = new SqlConnection(conString);//
            SqlCommand command = new SqlCommand();//
            command.Connection = sq;
            string sql = "select NIC from Customers";
            command.CommandText = sql;
            command.Parameters.AddWithValue("@NIC", textbox_CustomerNIC.Text);
            sq.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetValue(0).ToString() == textbox_CustomerNIC.Text)
                {
                    MessageBox.Show("Customer already in Database, No new customer added.");
                    command = new SqlCommand();//

                    command.Connection = sq;
                    sql = "select top 1 idOrder from Orders order by idOrder desc";
                    command.CommandText = sql;
                    reader = command.ExecuteReader();
                    reader.Read();
                    id = (int.Parse(reader.GetValue(0).ToString()) + 1).ToString();
                    reader.Close();




                    command = new SqlCommand();//
                    command.Connection = sq;

                    sql = "select CustomerID from Customers where NIC = @NIC";
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@NIC", textbox_CustomerNIC.Text);

                    reader = command.ExecuteReader();
                    reader.Read();
                    CustID = int.Parse(reader.GetValue(0).ToString()).ToString();
                    reader.Close();


                    command = new SqlCommand();//
                    command.Connection = sq;

                    sql = "insert into Orders values (@id, @custId, @staffid ,@date)";
                    command.CommandText = sql;

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@custId", CustID);

                    command.Parameters.AddWithValue("@staffid", (comboBox1.Text));
                    command.Parameters.Add("@date", SqlDbType.Date).Value = dateTimePicker1.Value.Date;


                    MessageBox.Show(command.ExecuteNonQuery().ToString());

                    for (int i = 0; i < OrderedItems.Items.Count; i++)
                    {
                        food = OrderedItems.Items[i].ToString();
                        quantity = int.Parse(Quantity.Items[i].ToString());

                        command = new SqlCommand();//
                        command.Connection = sq;
                        sql = "select idFood from FoodItems where Name = @food";
                        command.CommandText = sql;
                        command.Parameters.AddWithValue("@food", food);
                        reader = command.ExecuteReader();
                        reader.Read();
                        string foodid = int.Parse(reader.GetValue(0).ToString()).ToString();
                        reader.Close();

                        command = new SqlCommand();//
                        command.Connection = sq;
                        sql = "insert into OrderItems values (@id, @foodid , @Quantity)";
                        command.CommandText = sql;
                        command.Parameters.AddWithValue("@id", int.Parse(id));
                        command.Parameters.AddWithValue("@foodid", foodid);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.ExecuteNonQuery();

                    }

                    return;

                }
            }
            reader.Close();
            if (textbox_CustomerNIC.Text == "")
            {
                MessageBox.Show("Please enter a CNIC");
                return;
            }
            if (textbox_FirstName.Text == "")
            {
                MessageBox.Show("Please enter FirstName ");
                return;
            }
            if (textbox_LastName.Text == "")
            {
                MessageBox.Show("Please enter LastName ");
                return;
            }
            MessageBox.Show("New customer added in database");

            command = new SqlCommand();//

            command.Connection = sq;
            sql = "select top 1 CustomerID from Customers order by CustomerID desc";
            command.CommandText = sql;
            reader = command.ExecuteReader();
            reader.Read();
            id = (int.Parse(reader.GetValue(0).ToString()) + 1).ToString();
            reader.Close();
            command = new SqlCommand();//
            command.Connection = sq;


            sql = "insert into Customers values (@id, @NIC , @FirtsName,@LastName)";
            command.CommandText = sql;

            command.CommandText = sql;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@NIC", textbox_CustomerNIC.Text);

            command.Parameters.AddWithValue("@FirtsName", textbox_FirstName.Text);
            command.Parameters.AddWithValue("@LastName", textbox_LastName.Text);
            command.ExecuteNonQuery();

            command = new SqlCommand();//

            command.Connection = sq;
            sql = "select top 1 idOrder from Orders order by idOrder desc";
            command.CommandText = sql;
            reader = command.ExecuteReader();
            reader.Read();
            id = (int.Parse(reader.GetValue(0).ToString()) + 1).ToString();
            reader.Close();
 



            command = new SqlCommand();//
            command.Connection = sq;

            sql = "select CustomerID from Customers where NIC = @NIC";
            command.CommandText = sql;
            command.Parameters.AddWithValue("@NIC", textbox_CustomerNIC.Text);

            reader = command.ExecuteReader();
            reader.Read();
            CustID = int.Parse(reader.GetValue(0).ToString()).ToString();
            reader.Close();


            command = new SqlCommand();//
            command.Connection = sq;

            sql = "insert into Orders values (@id, @custId, @staffid ,@date)";
            command.CommandText = sql;

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@custId", CustID);

            command.Parameters.AddWithValue("@staffid", (comboBox1.Text));
            command.Parameters.Add("@date", SqlDbType.Date).Value = dateTimePicker1.Value.Date;


            MessageBox.Show(command.ExecuteNonQuery().ToString());

            for (int i = 0; i < OrderedItems.Items.Count; i++)
            {
                food = OrderedItems.Items[i].ToString();
                quantity = int.Parse(Quantity.Items[i].ToString());

                command = new SqlCommand();//
                command.Connection = sq;
                sql = "select idFood from FoodItems where Name = @food";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@food", food);
                reader = command.ExecuteReader();
                reader.Read();
                string foodid = int.Parse(reader.GetValue(0).ToString()).ToString();
                reader.Close();

                command = new SqlCommand();//
                command.Connection = sq;
                sql = "insert into OrderItems values (@id, @foodid , @Quantity)";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@id", int.Parse(id));
                command.Parameters.AddWithValue("@foodid", foodid);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.ExecuteNonQuery();

            }










        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label_Date_Click(object sender, EventArgs e)
        {

        }

        private void button_BackToMenu_Click(object sender, EventArgs e)
        {
            
            StaffUnPriv Form = new StaffUnPriv(f);
            this.Hide();
            Form.Show();
        }

        private void AddOrders_Load(object sender, EventArgs e)
        {

        }

        private void Button_AddItem_Click(object sender, EventArgs e)
        {
            if (combobox_FoodItems.SelectedItem != null )
            {
                OrderedItems.Items.Add(combobox_FoodItems.SelectedItem.ToString());
                Quantity.Items.Add(QtyTextBox.Text);
            }
        }

        private void Textbox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Quantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrderedItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combobox_FoodItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupbox_CustomerDetails_Enter(object sender, EventArgs e)
        {

        }

        private void label_CustomerNIC_Click(object sender, EventArgs e)
        {

        }
    }
    
}
