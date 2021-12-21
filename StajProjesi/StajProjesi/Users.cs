using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProjesi
{
    class Users
    {
        private int _UsersID;
        private string _UsersName;
        private string _Password;
        private string _NameSurname;
        private string _Question;
        private string _Answer;
        private DateTime _Date;

        public int UsersID { get => _UsersID; set => _UsersID = value; }
        public string UsersName { get => _UsersName; set => _UsersName = value; }
        public string Sifre { get => _Password; set => _Password = value; }
        public string NameSurname { get => _NameSurname; set => _NameSurname = value; }
        public string Question { get => _Question; set => _Question = value; }
        public string Answer { get => _Answer; set => _Answer = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        
        public static bool status = false;
        public static int kid = 0;
        public static SqlDataReader UserLogin(string username, string password)
        {
            Users u = new Users();
            u._UsersName = username;
            u._Password = password;
            Database.contact.Open();
            SqlCommand query = new SqlCommand("select * from Users where UserName='"+u._UsersName+"' and Password='"+u._Password+"'",Database.contact);
            SqlDataReader dr = query.ExecuteReader();
            if(dr.Read())
            {
                status = true;
                kid = int.Parse(dr[0].ToString());
            }

            else
            {

            }
            dr.Close();
            Database.contact.Close();
            return dr;

        }
    }
}
