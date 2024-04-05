using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservations
{
    public class DAL
    {
        public ConnectionState State = ConnectionState.Closed;
        public bool isProcall=false;

        List<SqlParameter>paralist=new List<SqlParameter>();

        private SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString= "Data Source=PRAJWALPC\\SQLEXPRESS;Initial Catalog=OctDB;Integrated Security=True";

            return conn;
        }

        public void ClearParameters()
        {
            paralist.Clear();
        }

        public void AddParameters(string paraname, string value)
        {
            paralist.Add(new SqlParameter(paraname, value));
        }

        private SqlCommand GetCommand(string Query)
        {
            SqlCommand cmd = new SqlCommand();

            if (isProcall)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(paralist.ToArray());
            }
            else
                cmd.CommandType= CommandType.Text;

            cmd.CommandText = Query;
            cmd.Connection = GetConnection();

            return cmd;
        }

        public object GetID(string Query)
        {
          
            SqlCommand cmd=GetCommand(Query);
            cmd.Connection.Open();
            object restval=cmd.ExecuteScalar();
            cmd.Connection.Close();

            return restval;
        }

       
        public int ExecuteQuery(string Query)
        {
            SqlCommand cmd=GetCommand(Query);
            cmd.Connection.Open();
            int restval=cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return restval;
        }

        public SqlDataReader GetReader(string Query)
        {
            SqlCommand cmd=GetCommand(Query);
            cmd.Connection.Open();
            SqlDataReader restval=cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return restval;
        }

        public DataTable GetTable(string Query)
        {
            DataTable dt = new DataTable();
            
            SqlCommand cmd = GetCommand(Query);
            cmd.Connection.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr != null && rdr.HasRows)
            {
                dt.Load(rdr);

            }
            cmd.Connection.Close();
            return dt;
        }
    }
}
