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
    public partial class PermissionMovementList : Form
    {
        public PermissionMovementList()
        {
            InitializeComponent();
        }

        Permission p = new Permission();

        private void btnPermissionType_Click(object sender, EventArgs e)
        {
            PermissionType pt = new PermissionType();
            pt.ShowDialog();
        }
        public static SqlDataReader PersonnelNameSurnameBring(TextBox txtPersonnelID,TextBox txtNameSurname)
        {
            Database.contact.Open();
            SqlCommand cmd = new SqlCommand("select *from Personnels where PersonnelID='" + txtPersonnelID.Text + "'", Database.contact);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtNameSurname.Text = dr[1] + "" + dr[2];
            }
            Database.contact.Close();
            return dr;
        }
        private void PermissionMovementList_Load(object sender, EventArgs e)
        {
            Database.List_Search(dataGridView1, "select PermissionMoveID AS 'İzin Hareket ID', PersonnelID AS 'Personel ID',UserID AS 'Kullanıcı ID', pt.PermissionType1 AS 'İzin Türü' ,PermissionStartingDate AS 'İzin Başlangıç Tarihi', PermissionFinishDate AS 'İzin Bitiş Tarihi',Operation AS 'İşlem' , Description AS 'Açıklama' ,Date AS 'Tarih', Hour AS 'Saat' from PermissionMove pm, PermissionTypes pt where pm.PermissionTypeID=pt.PermissionTypeID");
            Personnels.ComboboxRecordBring(comboBoxPermissionType);
        }

        private void txtPersonnelID_TextChanged(object sender, EventArgs e)
        {
            PersonnelNameSurnameBring(txtPersonnelID, txtNameSurname);
            if (txtPersonnelID.Text=="")
            {
                txtNameSurname.Text= "";
            }
        }

        private void Clean()
        {
            dateTimePickerPermissionStartingDate.Value = DateTime.Now;
            dateTimePickerPermissionFinishDate.Value = DateTime.Now;
            Personnels.ComboboxRecordBring(comboBoxPermissionType);
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Permission p = new Permission();
            p.PersonnelID = int.Parse(txtPersonnelID.Text);
            p.UserID = Users.kid;
            p.PermissionTypeID = (int)comboBoxPermissionType.SelectedValue;
            p.PermissionStartingDate = dateTimePickerPermissionStartingDate.Value;
            p.PermissionFinishDate = dateTimePickerPermissionFinishDate.Value;
            p.Operation = p.PersonnelID + "-" + txtNameSurname.Text + "için" + comboBoxPermissionType.Text + "oluşturuldu";
            p.Description = txtDescription.Text;
            p.Date = DateTime.Now;
            p.Hour = DateTime.Now;
            string sql = "insert into PermissionMove values('"+p.PersonnelID+"','"+p.UserID+"','"+p.PermissionTypeID+"',@PermissionStartingDate,@PermissionFinishDate,'"+p.Operation+"','"+p.Description+"',@Date,@Hour)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add("@PermissionStartingDate", SqlDbType.Date).Value = p.PermissionStartingDate;
            cmd.Parameters.Add("@PermissionFinishDate", SqlDbType.Date).Value = p.PermissionFinishDate;
            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = p.Date;
            cmd.Parameters.Add("@Hour", SqlDbType.DateTime).Value = p.Hour;
            try
            {
                Database.ESG(cmd,sql);
                Clean();
                MessageBox.Show("İzin kaydı oluşturuldu", "İzin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Database.List_Search(dataGridView1, "select PermissionMoveID, PersonnelID,UserID, pt.PermissionType1 ,PermissionStartingDate, PermissionFinishDate,Operation, Description,Date, Hour from PermissionMove pm, PermissionTypes pt where pm.PermissionTypeID=pt.PermissionTypeID");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Uyarı");
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPermissionMoveID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPersonnelID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxPermissionType.Text = dataGridView1.CurrentRow.Cells["PermissionType1"].Value.ToString();
            dateTimePickerPermissionStartingDate.Text = dataGridView1.CurrentRow.Cells["PermissionStartingDate"].Value.ToString();
            dateTimePickerPermissionFinishDate.Text =  dataGridView1.CurrentRow.Cells["PermissionFinishDate"].Value.ToString();
            txtDescription.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Permission p = new Permission();
            p.PermissionMoveID = int.Parse(txtPermissionMoveID.Text);
            p.PersonnelID = int.Parse(txtPersonnelID.Text);
            p.UserID = Users.kid;
            p.PermissionTypeID = (int)comboBoxPermissionType.SelectedValue;
            p.PermissionStartingDate = dateTimePickerPermissionStartingDate.Value;
            p.PermissionFinishDate = dateTimePickerPermissionFinishDate.Value;
            p.Description = txtDescription.Text;
            p.Date = DateTime.Now;
            p.Hour = DateTime.Now;
            p.Operation = p.PermissionMoveID + "nolu izin bilgileri değiştirildi";
            string sql = "update PermissionMove set PersonnelID='"+p.PersonnelID+"',PermissionTypeID='"+p.PermissionTypeID+ "',PermissionStartingDate=@PermissionStartingDate,PermissionFinishDate=@PermissionFinishDate, Operation='"+p.Operation+"',Description='"+p.Description+"',Date=@Date,Hour=@Hour where PermissionMoveID='"+p.PermissionMoveID+"'";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add("@PermissionStartingDate", SqlDbType.Date).Value = p.PermissionStartingDate;
            cmd.Parameters.Add("@PermissionFinishDate", SqlDbType.Date).Value = p.PermissionFinishDate;
            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = p.Date;
            cmd.Parameters.Add("@Hour", SqlDbType.DateTime).Value = p.Hour;
            try
            {
                Database.ESG(cmd, sql);
                Clean();
                MessageBox.Show("İzin bilgileri güncellendi.", "İzin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Database.List_Search(dataGridView1, "select PermissionMoveID, PersonnelID,UserID, pt.PermissionType1 ,PermissionStartingDate, PermissionFinishDate,Operation, Description,Date, Hour from PermissionMove pm, PermissionTypes pt where pm.PermissionTypeID=pt.PermissionTypeID");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Uyarı");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Permission p = new Permission();
            p.PermissionMoveID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string sql = "delete from PermissionMove where PermissionMoveID='" + p.PermissionMoveID + "'";
            SqlCommand cmd = new SqlCommand();
            try
            {
                Database.ESG(cmd, sql);
                Clean();
                MessageBox.Show("İzin bilgileri silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Database.List_Search(dataGridView1, "select PermissionMoveID, PersonnelID,UserID, pt.PermissionType1 ,PermissionStartingDate, PermissionFinishDate,Operation, Description,Date, Hour from PermissionMove pm, PermissionTypes pt where pm.PermissionTypeID=pt.PermissionTypeID");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Uyarı");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}