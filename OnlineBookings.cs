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
    public partial class OnlineBookings : Form
    {
        public OnlineBookings()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=PRAJWALPC\\SQLEXPRESS;Initial Catalog=DbHotel;Integrated Security=True");

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_viewOnlineCust", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CustNo", SqlDbType.NVarChar).Value = txtCustId.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid.DataSource = dt;
            con.Close();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Do you want to Cancel the booking?", "Cancel", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_OnbookCancel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CustNo", SqlDbType.NVarChar).Value = txtCustId.Text;
            cmd.Parameters.Add("@RoomNo", SqlDbType.NVarChar).Value = txtRoomNo.Text;




            cmd.ExecuteNonQuery();
            MessageBox.Show("Booking Canceled Successfully.!!");
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            OfflineBooking ob=new OfflineBooking();
            ob.Show();
            
        }

        private void cmbCustId_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtCustId.Text != null)
                {


                    // Open the connection
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_OnLoadCustRoomNo", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@CustNo", SqlDbType.NVarChar).Value = txtCustId.Text;

                    // Execute the query and get the result
                    object result = cmd.ExecuteScalar();

                    // Check if result is not null
                    if (result != null)
                    {
                        // Set the result to the textbox
                        txtRoomNo.Text = result.ToString();
                    }
                    else
                    {
                        // Handle if no result is returned
                        //MessageBox.Show("No Rooms Available,Try different Combination !!");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
            con.Close();
        }
    }
}

