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
using System.Xml.Linq;

namespace HotelReservations
{
    public partial class Feedback : BaseForm
    {
        public Feedback()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=PRAJWALPC\\SQLEXPRESS;Initial Catalog=DbHotel;Integrated Security=True");

        private void btnSend_Click(object sender, EventArgs e)
        {

            if (txtCustName.Text != "" && txtContact.Text != "" && txtEmail.Text != "" && rtxtReview.Text != "")
            {
                if (MessageBox.Show("Confirm Send ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_addFeedback", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustId", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtCustName.Text;
                cmd.Parameters.Add("@Contact_No", SqlDbType.NVarChar).Value = txtContact.Text;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
                cmd.Parameters.Add("@Review", SqlDbType.NVarChar).Value = rtxtReview.Text;



                cmd.ExecuteNonQuery();
                MessageBox.Show("Feedback Sent");
                con.Close();

                txtCustName.Text = "";
                txtContact.Text = "";
                txtEmail.Text = "";
                rtxtReview.Text = "";

            }
            else
            {
                MessageBox.Show(" Fill all fields..", "Warning.!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerPanel cp=new CustomerPanel();
            cp.Show();
        }
    }
}
