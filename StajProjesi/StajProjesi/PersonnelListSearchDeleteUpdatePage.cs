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
    public partial class PersonnelListSearchDeleteUpdatePage : Form
    {
        public PersonnelListSearchDeleteUpdatePage()
        {
            InitializeComponent();
        }

        SqlConnection contact = new SqlConnection("Data Source=DESKTOP-28J7JRG;Initial Catalog=PersonnelAutomationProject;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        string sql = "Select * from Personnels";

        void List(string aranan)
        {
            da = new SqlDataAdapter(sql, contact);
            dt = new DataTable();
            contact.Open();
            da.Fill(dt);
            contact.Close();
            dataGridView1.DataSource = dt;
        }

        private void PersonnelListSearchDeleteUpdatePage_Load(object sender, EventArgs e)
        {
            Personnels.ComboboxRecordBring(comboboxDepartment);
            RefreshList();
        }
    
        private void RefreshList()
        {
            Database.List_Search(dataGridView1, "select p.PersonnelID, p.PersonnelName, p.PersonnelSurname, p.PersonnelPhone, p.PersonnelAddress,p.PersonnelEmail," +
                "d.Department,p.IsActive, p.Salary,p.EntryDate, p.Description from Personnels p,Departments d" +
                " where p.DepartmentID = d.DepartmentID");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                sql = "Select *from Personnels where PersonnelID='" + textBox1.Text + "' ";
            }

            else if(radioButton2.Checked)
            {
                sql = "Select *from Personnels where PersonnelName='" + textBox1.Text + "'";
            }

            else if(radioButton3.Checked)
            {
                sql = "Select *from Personnels where PersonnelSurname='" + textBox1.Text + "'";
            }

            else if(radioButton4.Checked)
            {
                sql = "Select *from Personnels where PersonnelPhone='" + textBox1.Text + "' ";
            }

            else
            {
                sql = "Select *from Personnels";
            }

            List(sql);
        }
        void Clean()
        {
            EntryDate.Value = DateTime.Now;
            comboboxDepartment.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        Personnels p = new Personnels();
        Users u = new Users();

        private void btnupdate_Click(object sender, EventArgs e)
        {
        
            p.PersonnelID = int.Parse(txtPersonnelID.Text);
            p.Name = txtName.Text;
            p.Surname = txtSurname.Text;
            p.Phone = txtPhone.Text;
            p.Address = txtAddress.Text;
            p.Email = txtEmail.Text;
            p.DepartmentID = (int)comboboxDepartment.SelectedValue;
            p.Salary = decimal.Parse(txtSalary.Text);
            p.EntryDate = EntryDate.Value;
            p.Description = txtDescription.Text;
            string query1 = "update Personnels set PersonnelName='"+p.Name+"',PersonnelSurname='"+p.Surname+"',PersonnelPhone='"+p.Phone+"',PersonnelAddress='"+p.Address+"',PersonnelEmail='"+p.Email+"',DepartmentID='"+p.DepartmentID+"',Salary=@Salary,EntryDate=@EntryDate,Description='"+p.Description+"' " +
            " where PersonnelID='"+p.PersonnelID+"'";
            SqlCommand query = new SqlCommand();
            query.Parameters.Add("@Salary", SqlDbType.Decimal).Value = p.Salary;
            query.Parameters.Add("@EntryDate", SqlDbType.Date).Value = p.EntryDate;
            Database.ESG(query, query1);
            p.Operation = p.PersonnelID + "nolu personelin bilgileri güncellendi.";
            p.Description = "Personel güncelleme";
            Personnels.PersonnelOperationAdd(p,u);
            Clean();
            MessageBox.Show("İşlem başarılı.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshList();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
            p.PersonnelID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            p.ReleaseDate = DateTime.Now;
            string query1 = "update Personnels set IsActive='Pasif',ReleaseDate=@ReleaseDate where PersonnelID='"+p.PersonnelID+"'";
            SqlCommand query = new SqlCommand();
            query.Parameters.Add("@ReleaseDate", SqlDbType.Date).Value = p.ReleaseDate;
            Database.ESG(query, query1);
            p.Operation = p.PersonnelID + "nolu personel işten çıkarıldı.";
            p.Description = "İşten Çıkarma";
            Personnels.PersonnelOperationAdd(p, u);
            Clean();
            MessageBox.Show("İşlem başarılı.", "Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonnelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboboxDepartment.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtSalary.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            EntryDate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            txtDescription.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
