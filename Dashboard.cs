using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservations
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }



        private void btnSearchRoom_Click(object sender, EventArgs e)
        {


            OfflineBooking vb = new OfflineBooking();
            vb.Show();
            this.Close();
            
        }

        private void btnRoomAdd_Click(object sender, EventArgs e)
        {


            AddRooms ar = new AddRooms();
            ar.Show();
            this.Close();
        }



        private void btnManageEmp_Click(object sender, EventArgs e)
        {


            ManageEmployee me = new ManageEmployee();
            me.Show();
            this.Close();
        }

        private void btnLog_Out_Click(object sender, EventArgs e)
        {

            this.Close();
            HomePage hp = new HomePage();
            hp.Show();

        }

        private void btnChkOut_Click(object sender, EventArgs e)
        {

            this.Close();
            CheckOut ck = new CheckOut();
            ck.Show();
        }

        private void btnFeedbacks_Click(object sender, EventArgs e)
        {
            this.Close();
            CustFeedbacks cf = new CustFeedbacks();
            cf.Show();
        }

       

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            BookRoom b=new BookRoom();
            b.Show();
            this.Close();
        }
    }
}
