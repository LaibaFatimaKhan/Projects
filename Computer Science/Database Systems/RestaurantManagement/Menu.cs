using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    
    public partial class Menu : Form
    {

        public string staff1;
        public Menu(string staff)
        {
            InitializeComponent();
            staff1 = staff;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddOrders Form = new AddOrders(staff1);
            this.Hide();
            Form.Show();
        }

        private void button_SearchOrder_Click(object sender, EventArgs e)
        {
            SearchOrder Form = new SearchOrder(staff1);
            this.Hide();
            Form.Show();
        }

        private void button_AddStaff_Click(object sender, EventArgs e)
        {
            AddStaff Form = new AddStaff();
            this.Hide();
            Form.Show();

        }

        private void button_SearchStaff_Click(object sender, EventArgs e)
        {
            SearchStaff Form = new SearchStaff();
            this.Hide();
   
            Form.Show();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button_BackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Login Form = new Login();
            Form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            AddFood Form = new AddFood();
            Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login Form = new Login();
            Form.Show();
        }
    }
}
