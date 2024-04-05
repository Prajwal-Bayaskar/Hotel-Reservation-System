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
    public partial class CheckOut : Form
    {
        DAL d = new DAL();
        public CheckOut()
        {
            InitializeComponent();
            LoadGrid();
        }
        SqlConnection con = new SqlConnection("Data Source=PRAJWALPC\\SQLEXPRESS;Initial Catalog=DbHotel;Integrated Security=True");


        public void LoadGrid()
        {
            try
            {

                DataTable dt = d.GetTable("select * from tbl_Customers");

                dgvData.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_CheckOut", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustNo", SqlDbType.NVarChar).Value = txtCustId.Text;
                cmd.Parameters.Add("@Check_Out", SqlDbType.NVarChar).Value = dtpCheckOut.Text;


                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Checked Out...!!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadGrid();
            con.Close();
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

        private void btnChkOutHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckOutHistory cok = new CheckOutHistory();
            cok.Show();
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard d = new Dashboard();
            d.Show();
            //this.Close();
        }
    }


}
