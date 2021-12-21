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
    public partial class ProjectType : Form
    {
        public ProjectType()
        {
            InitializeComponent();
        }

       

        private void ProjectType_Load(object sender, EventArgs e)
        {
            Project.ListviewRecord(listView1);
        }

        private void Clear()
        {
            txtProjectTypeID.Text = "";
            txtProjectType.Text = "";
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Project p = new Project();
                p.ProjectType1 = txtProjectType.Text;
                string sql = "insert into ProjectType values ('" + p.ProjectType1 + "')";
                SqlCommand cmd = new SqlCommand();
                Database.ESG(cmd, sql);
                MessageBox.Show("Kayıt eklendi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Project.ListviewRecord(listView1);
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
                Project p = new Project();
                p.ProjectTypeID = int.Parse(txtProjectTypeID.Text);
                p.ProjectType1 = txtProjectType.Text;
                string sql = "update ProjectType set ProjectType1='" + p.ProjectType1 + "' where ProjectTypeID='" + p.ProjectTypeID + "'";
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
            txtProjectTypeID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtProjectType.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Project p = new Project();
                p.ProjectTypeID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

                string sql = "delete from ProjectType where ProjectTypeID='" + p.ProjectTypeID + "'";
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
