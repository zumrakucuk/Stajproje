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
    public partial class ProjectMove : Form
    {
        public ProjectMove()
        {
            InitializeComponent();
        }

        Project p = new Project();

        private void btnProjectType_Click(object sender, EventArgs e)
        {
            ProjectType pt = new ProjectType();
            pt.ShowDialog();
        }
        public static SqlDataReader PersonnelNameSurnameBring(TextBox txtPersonnelID, TextBox txtNameSurname)
        {
            Database.contact.Open();
            SqlCommand cmd = new SqlCommand("select * from Personnels where PersonnelID='" + txtPersonnelID.Text + "'", Database.contact);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtNameSurname.Text = dr[1] + "" + dr[2];
            }
            Database.contact.Close();
            return dr;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            p.PersonnelID = int.Parse(txtPersonnelID.Text);
            p.UserID = Users.kid;
            p.ProjectTypeID = (int)comboBoxProjectType.SelectedValue;
            // p.ProjectName=txtProjectName.Text;
            p.ProjectStartDate = dateTimePickerProjectStartDate.Value;
            p.ProjectFinishDate = dateTimePickerProjectEndDate.Value;
            p.Description = Description.Text;
            string sql = "insert into Projects values('" + p.UserID + "','" + p.PersonnelID + "','" + p.ProjectTypeID + "',@ProjectStartDate,@ProjectFinishDate,'" + p.Description + "')";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add("@ProjectStartDate", SqlDbType.Date).Value = p.ProjectStartDate;

            cmd.Parameters.Add("@ProjectFinishDate", SqlDbType.Date).Value = p.ProjectFinishDate;
            try
            {
                Database.ESG(cmd, sql);
                Clean();
                MessageBox.Show("Proje kaydı oluşturuldu", "Proje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Database.List_Search(dataGridView1, "select ProjectID, UserID, PersonnelID, pt.ProjectType1, ProjectStartDate, ProjectFinishDate,Description from Projects p, ProjectType pt where p.ProjectTypeID=pt.ProjectTypeID");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Uyarı");
            }
        }

        private void ProjectMove_Load(object sender, EventArgs e)
        {
            Database.List_Search(dataGridView1, "select ProjectID AS 'Proje ID', UserID AS 'Kullanıcı ID', PersonnelID AS 'Personel ID', pt.ProjectType1 AS 'Proje Türü', ProjectStartDate AS 'Proje Başlangıç Tarihi', ProjectFinishDate AS 'Proje Bitiş Tarihi',Description AS 'Açıklama' from Projects p, ProjectType pt where p.ProjectTypeID=pt.ProjectTypeID");
            Personnels.ComboboxRecordBring(comboBoxProjectType);
        }

        private void txtPersonnelID_TextChanged(object sender, EventArgs e)
        {
            PersonnelNameSurnameBring(txtPersonnelID, txtNameSurname);
            if (txtPersonnelID.Text == "")
            {
                txtNameSurname.Text = "";
            }
        }
        private void Clean()
        {
            dateTimePickerProjectStartDate.Value = DateTime.Now;
            dateTimePickerProjectEndDate.Value = DateTime.Now;
            Personnels.ComboboxRecordBring(comboBoxProjectType);
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            p.ProjectID = int.Parse(txtProjectID.Text);
            p.PersonnelID = int.Parse(txtProjectID.Text);
            p.UserID = Users.kid;
            p.ProjectTypeID = (int)comboBoxProjectType.SelectedValue;
            // p.ProjectName = txtProjectName.Text;
            p.ProjectStartDate = dateTimePickerProjectStartDate.Value;
            p.ProjectFinishDate = dateTimePickerProjectEndDate.Value;
            p.Description = Description.Text;
            string sql = "update Projects set PersonnelID='" + p.PersonnelID + "',ProjectTypeID='"+ p.ProjectTypeID + "',ProjectStartDate=@ProjectStartDate,ProjectFinishDate=@ProjectFinishDate,Description='" + p.Description + "'  where ProjectID='"+ p.ProjectID +"'";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add("@ProjectStartDate", SqlDbType.Date).Value = p.ProjectStartDate;
            cmd.Parameters.Add("@ProjectFinishDate", SqlDbType.Date).Value = p.ProjectFinishDate;
            try
            {
                Database.ESG(cmd, sql);
                Clean();
                MessageBox.Show("Proje bilgileri güncellendi", "Proje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Database.List_Search(dataGridView1, "select ProjectID, UserID, PersonnelID, pt.ProjectType1, ProjectStartDate, ProjectFinishDate,Description from Projects p ProjectType pt where p.ProjectTypeID=pt.ProjectTypeID");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Uyarı");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            p.ProjectID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()); 
            string sql = "delete  from Projects where ProjectID='" + p.ProjectID + "'";
            SqlCommand cmd = new SqlCommand();
            try
            {
                Database.ESG(cmd, sql);
                Clean();
                MessageBox.Show("Proje bilgileri silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Uyarı");
            }
        }
    }
}
