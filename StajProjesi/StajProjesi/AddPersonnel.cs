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
    public partial class AddPersonnel : Form
    {
        public AddPersonnel()
        {
            InitializeComponent();
        }

        private void AddPersonnel_Load(object sender, EventArgs e)
        {
            Personnels.ComboboxRecordBring(comboboxDepartment);

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void btninsert_Click(object sender, EventArgs e)
        {
            p.Name = txtName.Text;
            p.Surname = txtSurname.Text;
            p.Phone = txtPhone.Text;
            p.Address = txtAddress.Text;
            p.Email = txtEmail.Text;
            p.DepartmentID = (int)comboboxDepartment.SelectedValue;
            p.Salary = decimal.Parse(txtSalary.Text);
            p.EntryDate = EntryDate.Value;
            p.Description = txtDescription.Text;
            string query1 = "insert into Personnels(PersonnelName,PersonnelSurname,PersonnelPhone,PersonnelAddress,PersonnelEmail,DepartmentID,Salary,EntryDate,Description) values('" + p.Name + "','" + p.Surname + "','" + p.Phone + "','" + p.Address + "','" + p.Email + "','" + p.DepartmentID + "',@Salary, @EntryDate,'" + p.Description + "')";
            SqlCommand query = new SqlCommand();
            query.Parameters.Add("@Salary", SqlDbType.Decimal).Value=p.Salary;
            query.Parameters.Add("@EntryDate", SqlDbType.Date).Value =p.EntryDate;

            Database.ESG(query, query1);
            Personnels.PersonnelIDLastRecord(p);
            p.Operation = p.PersonnelID + "nolu yeni personel kaydı oluşturuldu.";
            p.Description = "Yeni personel ekleme";
            
            Personnels.PersonnelOperationAdd(p, u);
            Clean();
            MessageBox.Show("İşlem başarılı.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
