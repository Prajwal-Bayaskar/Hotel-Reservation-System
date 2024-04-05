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
    public partial class ManageEmployee : BaseForm
    {
        public ManageEmployee()
        {
            InitializeComponent();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            AddNewEmp emp = new AddNewEmp();
            emp.Show();
        }
        SqlConnection con = new SqlConnection("Data Source=PRAJWALPC\\SQLEXPRESS;Initial Catalog=DbHotel;Integrated Security=True");

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_viewEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EmpId", SqlDbType.NVarChar).Value = txtEmpSearch.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridEmp.DataSource = dt;
            con.Close();
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_deleteEmp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EmpId", SqlDbType.NVarChar).Value = txtEmpSearch.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridEmp.DataSource = dt;
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();


        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
