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

namespace StajProjesi
{
    public partial class PermissionType : Form
    {
        public PermissionType()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PermissionType_Load(object sender, EventArgs e)
        {
            Permission.ListviewRecord(listView1);
        }

        private void Clear()
        {
            txtPermissionID.Text = "";
            txtPermissionType.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Permission p = new Permission();
                p.PermissionType1 = txtPermissionType.Text;
                string sql = "insert into PermissionTypes values ('" + p.PermissionType1 + "')";
                SqlCommand cmd = new SqlCommand();
                Database.ESG(cmd, sql);
                MessageBox.Show("Kayıt eklendi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Permission.ListviewRecord(listView1);
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata türü");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Permission p = new Permission();
                p.PermissionTypeID = int.Parse(txtPermissionID.Text);
                p.PermissionType1 = txtPermissionType.Text;
                string sql = "update PermissionTypes set PermissionType1='"+p.PermissionType1+"' where PermissionTypeID='"+p.PermissionTypeID+"'";
                SqlCommand cmd = new SqlCommand();
                Database.ESG(cmd, sql);
                MessageBox.Show("Kayıt güncellendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Permission.ListviewRecord(listView1);
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata türü");
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtPermissionID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtPermissionType.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                Permission p = new Permission();
                p.PermissionTypeID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
               
                string sql = "delete from PermissionTypes where PermissionTypeID='"+p.PermissionTypeID+"'";
                SqlCommand cmd = new SqlCommand();
                Database.ESG(cmd, sql);
                MessageBox.Show("Kayıt silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Permission.ListviewRecord(listView1);
                Clear();
            }
            else
            {
                MessageBox.Show("Önce kayıt seçilmelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
