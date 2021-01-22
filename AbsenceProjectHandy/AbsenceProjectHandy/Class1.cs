using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandyControl.Tools;
using System.Data.SqlClient;
using System.Data;




namespace AbsenceProjectHandy
{
    class Class1
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();

        public void Connecter()
        {
            if(con.State==ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.ConnectionString = "Data Source=DESKTOP-OA38PF8;Initial Catalog=Attendance-Management;Integrated Security=True";
                con.Open();
            }
        }

    }

  
}
