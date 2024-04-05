using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservations
{
    public partial class CustFeedbacks : Form
    {
        public CustFeedbacks()
        {
            InitializeComponent();
            FeedLoad();
        }
        SqlConnection con = new SqlConnection("Data Source=PRAJWALPC\\SQLEXPRESS;Initial Catalog=DbHotel;Integrated Security=True");

        DAL d = new DAL();

        public void FeedLoad()
        {
            try
            {
                DataTable dt = d.GetTable("select * from tbl_feedback");
                dataGrid3.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard d=new Dashboard();
            d.Show();

        }
    }
}
