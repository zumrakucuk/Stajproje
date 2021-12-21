using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajProjesi
{
    class Database
    {
        public static SqlConnection contact = new SqlConnection("Data Source=DESKTOP-28J7JRG;Initial Catalog=PersonnelAutomationProject;Integrated Security=True");

        public static void ESG(SqlCommand cmd, string sql)
        {
            contact.Open();
            cmd.Connection = contact;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            contact.Close();
        }

        public static DataTable List_Search(DataGridView gridView, string sql)
        {
            DataTable tbl = new DataTable();
            contact.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, contact);
            adtr.Fill(tbl);
            gridView.DataSource = tbl;
            contact.Close();
            return tbl;
        }
    }
}
