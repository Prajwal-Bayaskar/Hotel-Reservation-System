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
    public partial class ViewCustBooking : Form
    {
        public ViewCustBooking()
        {
            InitializeComponent();
        }
        DAL d=new DAL();
        public void FeedLoad()
        {
            try
            {
                DataTable dt = d.GetTable("select from tblOnlineCustomer where ");
                dataGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
