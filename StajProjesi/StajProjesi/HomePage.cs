using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajProjesi
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            frmDepartments frm = new frmDepartments();
            frm.ShowDialog();

        }

        private void btnPersonnelAdd_Click(object sender, EventArgs e)
        {
            AddPersonnel frm = new AddPersonnel();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonnelListSearchDeleteUpdatePage frm = new PersonnelListSearchDeleteUpdatePage();
            frm.ShowDialog();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            UserLogin ul = new UserLogin();
            ul.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ProjectMove pma = new ProjectMove();
            pma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PermissionMovementList pml = new PermissionMovementList();
            pml.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //UserLogin ul = new UserLogin();
            //ul.ShowDialog();
            this.Close();
        }
    }
}
