using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajProjesi
{
    class Departments
    {
        private int _DepartmentID;
        private string _Department;
        private string _Description;

        public int DepartmentID { get => _DepartmentID; set => _DepartmentID = value; }
        public string Department { get => _Department; set => _Department = value; }
        public string Description { get => _Description; set => _Description = value; }

        public static SqlDataReader DepartmentBring(ListView lst)
        {
            lst.Items.Clear();
            Database.contact.Open();
            SqlCommand query = new SqlCommand("Select * from Departments",Database.contact);
            SqlDataReader dr = query.ExecuteReader();
            while(dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr[0].ToString();
                ekle.SubItems.Add(dr[1].ToString());
                ekle.SubItems.Add(dr[2].ToString());
                lst.Items.Add(ekle);

            }
            Database.contact.Close();
            return dr;
        }
    }
}
