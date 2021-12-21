using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajProjesi
{
    class Project : Personnels
    {
        public Project()
        {
            Project.sql = "select * from ProjectType";
            Project.value ="ProjectTypeID";
            Project.text ="ProjectType1";

        }
       // private string _ProjectName;
        private int _ProjectID;
        private int _ProjectTypeID;
        private int _UserID;
        private string _ProjectType1;
        private DateTime _ProjectStartDate;
        private DateTime _ProjectFinishDate;

        public int ProjectID { get => _ProjectID; set => _ProjectID = value; }
        public int ProjectTypeID { get => _ProjectTypeID; set => _ProjectTypeID = value; }
        public int UserID { get => _UserID; set => _UserID = value; }
        public string ProjectType1 { get => _ProjectType1; set => _ProjectType1 = value; }
        public DateTime ProjectStartDate { get => _ProjectStartDate; set => _ProjectStartDate = value; }
        public DateTime ProjectFinishDate { get => _ProjectFinishDate; set => _ProjectFinishDate = value; }
       // public string ProjectName { get => _ProjectName; set => _ProjectName = value; }

        public static SqlDataReader ListviewRecord(ListView lst)
        {
            lst.Items.Clear();
            Database.contact.Open();
            SqlCommand cmd = new SqlCommand("select * from ProjectType", Database.contact);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr[0].ToString();
                add.SubItems.Add(dr[1].ToString());
                lst.Items.Add(add);

            }
            Database.contact.Close();
            return dr;
        }
    }
}