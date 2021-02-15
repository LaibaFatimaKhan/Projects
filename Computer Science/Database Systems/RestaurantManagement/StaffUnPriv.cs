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
    public partial class StaffUnPriv : Form
    {
        public string staff;
        public StaffUnPriv(string staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

        private void button_AddOrder_Click(object sender, EventArgs e)
        {
            AddOrders Form = new AddOrders(staff);
            this.Hide();
            Form.Show();

        }

        private void button_SearchOrder_Click(object sender, EventArgs e)
        {
            SearchOrder Form = new SearchOrder(staff);
            this.Hide();
            Form.Show();
        }

        private void button_BackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Login Form = new Login();
            Form.Show();
        }

        private void StaffUnPriv_Load(object sender, EventArgs e)
        {

        }
    }
}
