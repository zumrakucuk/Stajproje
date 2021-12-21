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
    public partial class frmDepartments : Form
    {
        public frmDepartments()
        {
            InitializeComponent();
        }

        private void frmDepartments_Load(object sender, EventArgs e)
        {
            Departments.DepartmentBring(listView1);

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            Departments d = new Departments();
            d.Department = txtdepartment.Text;
            d.Description = txtdescription.Text;
            string query1="insert into Departments values('"+d.Department+"','"+d.Description+"')";
            SqlCommand query = new SqlCommand();
            Database.ESG(query, query1);
            MessageBox.Show("İşlem başarılı.");
            Departments.DepartmentBring(listView1);

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Departments d = new Departments();
            d.DepartmentID = int.Parse(txtdepartmentID.Text);
            d.Department = txtdepartment.Text;
            d.Description = txtdescription.Text;
            string query1 = "update Departments set department='"+d.Department+"',description='"+d.Description+"' where departmentID='"+d.DepartmentID+"'";
            SqlCommand query = new SqlCommand();
            Database.ESG(query, query1);
            MessageBox.Show("İşlem başarılı.");
            Departments.DepartmentBring(listView1);

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Departments d = new Departments();
                d.DepartmentID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                string query1 = "delete from Departments where departmentID='" + d.DepartmentID + "'";
                SqlCommand query = new SqlCommand();
                Database.ESG(query, query1);
                MessageBox.Show("İşlem başarılı.");
                Departments.DepartmentBring(listView1);
            }
            else
            {
                MessageBox.Show("İlk önce seçim yapılmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)//Listview'e çift tıklanıldığında tıklanılan bilgiler textboxlara gelir.
        {
            txtdepartmentID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtdepartment.Text= listView1.SelectedItems[0].SubItems[1].Text;
            txtdescription.Text= listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
