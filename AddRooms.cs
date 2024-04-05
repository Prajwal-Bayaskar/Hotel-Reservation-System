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
    public partial class AddRooms : BaseForm
    {
        public AddRooms()
        {
            InitializeComponent();
            LoadGrid();
        }
        SqlConnection con = new SqlConnection("Data Source=PRAJWALPC\\SQLEXPRESS;Initial Catalog=DbHotel;Integrated Security=True");
        DAL d = new DAL();
        public void LoadGrid()
        {
            try
            {
                SqlDataReader dt = d.GetReader("select * from Information");
                dataGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure want to add room ?", "Add Room", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_AddRoom", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Room_No", SqlDbType.NVarChar).Value = txtRoom_No.Text;
            cmd.Parameters.Add("@Room_Type", SqlDbType.NVarChar).Value = cmbRoom_Type.Text;
            cmd.Parameters.Add("@Bed_Type", SqlDbType.NVarChar).Value = cmbBed_Type.Text;
            cmd.Parameters.Add("@Price", SqlDbType.NVarChar).Value = txtPrice.Text;
            cmd.Parameters.Add("@R_Status", SqlDbType.NVarChar).Value = cmbStatus.Text;



            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Added Sucessfully");
            con.Close();
            LoadGrid();

            txtRoom_No.Text = "";
            cmbRoom_Type.Text = "";
            cmbBed_Type.Text = "";
            txtPrice.Text = "";
            cmbStatus.Text = "";
        }

        private void btnViewRooms_Click(object sender, EventArgs e)
        {
            ViewRooms vr = new ViewRooms();
            vr.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_viewRooms", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Room_No", SqlDbType.NVarChar).Value = txtRoomSearch.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid.DataSource = dt;
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard d= new Dashboard();
            d.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls(txtRoom_No, Controls);
        }

        private void cmbPreference_Validating(object sender, CancelEventArgs e)
        {
            if (cmbBed_Type.Text == "Single" && cmbRoom_Type.Text == "AC")
                txtPrice.Text = "4000";

            else if (cmbBed_Type.Text == "Single" && cmbRoom_Type.Text == "Non-AC")
                txtPrice.Text = "3000";

            else if (cmbBed_Type.Text == "Double" && cmbRoom_Type.Text == "AC")
                txtPrice.Text = "8000";

            else if (cmbBed_Type.Text == "Double" && cmbRoom_Type.Text == "Non-AC")
                txtPrice.Text = "7000";

            else if (cmbBed_Type.Text == "Triple" && cmbRoom_Type.Text == "AC")
                txtPrice.Text = "9000";

            else if (cmbBed_Type.Text == "Triple" && cmbRoom_Type.Text == "Non-AC")
                txtPrice.Text = "8000";
            else
                txtPrice.Text = "NA";

        }
    }
}
    

