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
    public partial class CheckOutHistory : Form
    {
        DAL d=new DAL();    
        public CheckOutHistory()
        {
            InitializeComponent();
            LoadGrid();
        }
        SqlConnection con = new SqlConnection("Data Source=PRAJWALPC\\SQLEXPRESS;Initial Catalog=DbHotel;Integrated Security=True");

        public void LoadGrid()
        {
            try
            {

                DataTable dt = d.GetTable("select * from tbl_Customers where Checked_Out = 'YES'");

                dgvData.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckOut co = new CheckOut();
            co.Show();
        }

        private void btnSearchCust_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_viewCustomers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CustNo", SqlDbType.NVarChar).Value = txtCustId.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvData.DataSource = dt;
            con.Close();
        }
    }
}
