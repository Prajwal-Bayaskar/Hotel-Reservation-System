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
    public partial class RegisterCustomer : BaseForm
    {
        public RegisterCustomer()
        {
            InitializeComponent();
        }
        DAL d = new DAL();
        SqlConnection con = new SqlConnection("Data Source=PRAJWALPC\\SQLEXPRESS;Initial Catalog=DbHotel;Integrated Security=True");

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (txtEmpName.Text != "" && txtContact.Text != "" && rtxtAddress.Text != "")
            {
                if (MessageBox.Show("Confirm Register ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                con.Open();
                SqlCommand cmd = new SqlCommand("sp_AddNewCust", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtEmpName.Text;
                cmd.Parameters.Add("@Contact_No", SqlDbType.NVarChar).Value = txtContact.Text;
                cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = cmbGender.Text;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = rtxtAddress.Text;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtUserName.Text;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtPassword.Text;
                cmd.Parameters.Add("@ConfPassword", SqlDbType.NVarChar).Value = txtConfPassword.Text;





                cmd.ExecuteNonQuery();
                MessageBox.Show("Registeration Successfull");
                this.Close();
                CustomerLogin cl = new CustomerLogin();
                cl.Show();
                con.Close();

                txtEmpName.Text = "";
                txtContact.Text = "";

                cmbGender.Text = "";

                rtxtAddress.Text = "";

            }
            else
            {
                MessageBox.Show(" Fill all fields..", "Warning.!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls(txtEmpName, Controls);
        }

        private void RegisterCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
