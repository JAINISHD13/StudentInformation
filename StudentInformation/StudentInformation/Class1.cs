using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace StudentInformation
{     
   public class Class1
    {

        public SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Class1()
        {
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Visual Studio 2015\Samples\StudentInformation\StudentInformation\StudentInformation.mdf;Integrated Security=True";
        }

        public void ins_up_dlt(String str)
        {
            cn.Open();
            cmd.CommandText = str;
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable sel(String str)
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(str, cn);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            cn.Close();
            return dt;

        }
    }
}
