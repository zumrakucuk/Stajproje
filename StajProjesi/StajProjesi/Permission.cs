using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajProjesi
{
   
    class Permission :Personnels
    {
        public Permission()
        {
            Permission.sql = "select * from PermissionTypes";
            Permission.value = "PermissionTypeID";
            Permission.text = "PermissionType1";
        }
        private int _PermissionMoveID;
        private int _PermissionTypeID;
        private int _UserID;
        private string _PermissionType1;
        private DateTime _PermissionStartingDate;
        private DateTime _PermissionFinishDate;
        private DateTime _Hour;

        public int PermissionMoveID { get => _PermissionMoveID; set => _PermissionMoveID = value; }
        public int PermissionTypeID { get => _PermissionTypeID; set => _PermissionTypeID = value; }
        public int UserID { get => _UserID; set => _UserID = value; }
        public string PermissionType1 { get => _PermissionType1; set => _PermissionType1 = value; }
        public DateTime PermissionStartingDate { get => _PermissionStartingDate; set => _PermissionStartingDate = value; }
        public DateTime PermissionFinishDate { get => _PermissionFinishDate; set => _PermissionFinishDate = value; }
        public DateTime Hour { get => _Hour; set => _Hour = value; }

        public static SqlDataReader ListviewRecord(ListView lst)
        {
            lst.Items.Clear();
            Database.contact.Open();
            SqlCommand cmd = new SqlCommand("select * from PermissionTypes", Database.contact);
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
