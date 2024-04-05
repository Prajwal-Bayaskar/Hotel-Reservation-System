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
    public partial class CustBooking : BaseForm
    {
        public CustBooking()
        {
            InitializeComponent();
            cmbBedType.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
        }
        DAL d = new DAL();
        SqlConnection con = new SqlConnection("Data Source=PRAJWALPC\\SQLEXPRESS;Initial Catalog=DbHotel;Integrated Security=True");

        private void btnBookRoom_Click(object sender, EventArgs e)
        {

            if (txtName.Text != "" && txtContact.Text != "" && txtNationality.Text != "" && rtxtAddress.Text != "" && cmbBedType.Text != "" && txtRoomNo.Text != "" && dtpCheckIn.Text != "" && txtPrice.Text != "")
            {
                if (MessageBox.Show("Confirm your booking ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_OnlineBookRoom", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtName.Text;
                cmd.Parameters.Add("@Contact", SqlDbType.NVarChar).Value = txtContact.Text;
                cmd.Parameters.Add("@Nationality", SqlDbType.NVarChar).Value = txtNationality.Text;
                cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = cmbGender.Text;
                cmd.Parameters.Add("@Birth_Date", SqlDbType.NVarChar).Value = dtpDOB.Text;
                cmd.Parameters.Add("@Id_Proof", SqlDbType.NVarChar).Value = txtIdProof.Text;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = rtxtAddress.Text;
                cmd.Parameters.Add("@Room_Type", SqlDbType.NVarChar).Value = cmbType.Text;
                cmd.Parameters.Add("@Bed_Type", SqlDbType.NVarChar).Value = cmbBedType.Text;
                cmd.Parameters.Add("@Check_In", SqlDbType.NVarChar).Value = dtpCheckIn.Value;
                //cmd.Parameters.Add("@Check_Out", SqlDbType.NVarChar).Value = "";
                // cmd.Parameters.Add("@Checked_Out", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@Room_No", SqlDbType.Int).Value = txtRoomNo.Text;
                cmd.Parameters.Add("@Price", SqlDbType.NVarChar).Value = txtPrice.Text;


                cmd.ExecuteNonQuery();
                MessageBox.Show("Booking Successfull...");
                con.Close();

                txtName.Text = "";
                txtContact.Text = "";
                txtNationality.Text = "";
                cmbGender.Text = "";
                dtpDOB.Text = "";
                txtIdProof.Text = "";
                rtxtAddress.Text = "";
                cmbType.Text = "";
                cmbBedType.Text = "";
                txtRoomNo.Text = "";
                dtpCheckIn.Value = DateTime.Now;
                txtPrice.Text = "";
            }
            else
            {
                MessageBox.Show(" Fill all fields..", "Warning.!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls(txtName, Controls);
        }

        private void cmbPreference_Validating(object sender, CancelEventArgs e)
        {

            if (cmbBedType.Text == "Single" && cmbType.Text == "AC")
                txtPrice.Text = "4000";

            else if (cmbBedType.Text == "Single" && cmbType.Text == "Non-AC")
                txtPrice.Text = "3000";

            else if (cmbBedType.Text == "Double" && cmbType.Text == "AC")
                txtPrice.Text = "8000";

            else if (cmbBedType.Text == "Double" && cmbType.Text == "Non-AC")
                txtPrice.Text = "7000";

            else if (cmbBedType.Text == "Triple" && cmbType.Text == "AC")
                txtPrice.Text = "9000";

            else if (cmbBedType.Text == "Triple" && cmbType.Text == "Non-AC")
                txtPrice.Text = "8000";
            else
                txtPrice.Text = "NA";


            try
            {
                // Open the connection
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_LoadRoomNo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Room_Type", SqlDbType.NVarChar).Value = cmbType.Text;
                cmd.Parameters.Add("@Bed_Type", SqlDbType.NVarChar).Value = cmbBedType.Text;
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
                    MessageBox.Show("No Rooms Available,Try different Combination !!");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerPanel d = new CustomerPanel();
            d.Show();
        }
    }
}
