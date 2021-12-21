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
    class Personnels
    {
        private int _PersonnelID;
        private string _Name;
        private string _Surname;
        private string _Phone;
        private string _Address;
        private string _Email;
        private int _DepartmentID;
        private decimal _Salary;
        private DateTime _EntryDate;
        private string _Description;
        private DateTime _Date;
        private string _Operation;
        private DateTime _ReleaseDate;
        public int PersonnelID { get => _PersonnelID; set => _PersonnelID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Surname { get => _Surname; set => _Surname = value; }
        public string Phone { get => _Phone; set => _Phone = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string Email { get => _Email; set => _Email = value; }
        public int DepartmentID { get => _DepartmentID; set => _DepartmentID = value; }
        public decimal Salary { get => _Salary; set => _Salary = value; }
        public DateTime EntryDate { get => _EntryDate; set => _EntryDate = value; }
        public string Description { get => _Description; set => _Description = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public string Operation { get => _Operation; set => _Operation = value; }
        public DateTime ReleaseDate { get => _ReleaseDate; set => _ReleaseDate = value; }

        public static int PersonnelIDLastRecord(Personnels p)
        {
            Database.contact.Open();
            SqlCommand cmd = new SqlCommand("select ident_current('Personnels')",Database.contact);
            p.PersonnelID = int.Parse(cmd.ExecuteScalar().ToString());
            Database.contact.Close();
            return p.PersonnelID;
            
        }
        public static void PersonnelOperationAdd(Personnels p, Users u)
        {
         
            p.Date = DateTime.Now;
            string sql = "insert into PersonnelOperation values('"+u.UsersID+"','"+p.PersonnelID+"','"+p.Operation+"','"+p.Description+"',@Date)";
            
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = p.Date;
            Database.ESG(cmd,sql);
            
        }

        public static string sql = "select * from Departments";
        public static string value = "DepartmentID";
        public static string text = "Department";
        public static DataTable ComboboxRecordBring(ComboBox combo)
        {
            DataTable tbl = new DataTable();
            Database.contact.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql,Database.contact);
            adtr.Fill(tbl);
            combo.DataSource = tbl;
            combo.ValueMember = value;//Arka planda tutulan
            combo.DisplayMember = text;//Görünecek olan
            Database.contact.Close();
            return tbl;
        }
    }
}
