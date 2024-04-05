using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservations
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnCustomerLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerLogin cl = new CustomerLogin();
            cl.Show();
        }



        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLogin cl = new AdminLogin();
            cl.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
