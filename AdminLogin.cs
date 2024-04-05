using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace HotelReservations
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=PRAJWALPC\\SQLEXPRESS;Initial Catalog=DbHotel;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (con != null)
            {
                con.Open();

                //SqlCommand cmd = new SqlCommand("sp_login", con);

                //cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add("@username", SqlDbType.NChar).Value = txtUserName.Text;
                //cmd.Parameters.Add("@password", SqlDbType.NChar).Value = txtPassword.Text;


                //SqlDataReader rdr = cmd.ExecuteReader();
                //if (rdr.Read())
                //{
                //    MessageBox.Show("Login Success!!");
                //    Dashboard ap = new Dashboard();
                //    ap.Show();
                

                SqlCommand cmd1 = new SqlCommand("staff_login", con);
                cmd1.CommandType = CommandType.StoredProcedure;

                cmd1.Parameters.Add("@username", SqlDbType.NChar).Value = txtUserName.Text;
                cmd1.Parameters.Add("@password", SqlDbType.NChar).Value = txtPassword.Text;


                SqlDataReader rdr1 = cmd1.ExecuteReader();


                if (rdr1.Read())
                {
                    MessageBox.Show("Login Success!!");
                    Dashboard dp = new Dashboard();
                    dp.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login Failed!!");
                }
                con.Close();


            }

        }
    }
}

                

            
        
   








