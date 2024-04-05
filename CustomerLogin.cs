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
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }
        DAL d = new DAL();

        SqlConnection con = new SqlConnection("Data Source=PRAJWALPC\\SQLEXPRESS;Initial Catalog=DbHotel;Integrated Security=True");



        private void btnNewRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterCustomer rc = new RegisterCustomer();
            rc.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("sp_CustLogin", con);
            cmd1.CommandType = CommandType.StoredProcedure;

            cmd1.Parameters.Add("@username", SqlDbType.NChar).Value = txtUserName.Text;
            cmd1.Parameters.Add("@password", SqlDbType.NChar).Value = txtPassword.Text;


            SqlDataReader rdr1 = cmd1.ExecuteReader();


            if (rdr1.Read())
            {
                MessageBox.Show("Login Success!!");
                CustomerPanel dp = new CustomerPanel();
                dp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed!!");
            }
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
