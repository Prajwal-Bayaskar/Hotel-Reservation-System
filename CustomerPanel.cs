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
    public partial class CustomerPanel : Form
    {
        public CustomerPanel()
        {
            InitializeComponent();
        }



        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            CustBooking Bk = new CustBooking();
            Bk.Show();
        }



        private void btnViewBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCustBooking vc = new ViewCustBooking();
            vc.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage hp = new HomePage();
            hp.Show();
        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feedback f = new Feedback();
            f.Show();
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            ViewRooms vr = new ViewRooms();
            vr.Show();
            this.Hide();
        }

       
    }
}
