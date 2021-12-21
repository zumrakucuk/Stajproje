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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Clean()
        {
            comboBoxQuestion.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.UsersID = int.Parse(txtUserID.Text);
            u.UsersName = txtUserName.Text;
            u.Sifre = txtPassword.Text;
            u.NameSurname = txtNameSurname.Text;
            u.Question = comboBoxQuestion.Text;
            u.Answer = txtAnswer.Text;
            u.Date = DateTime.Now;
            if (txtPassword==txtPassword2)
            {
                string sql = "update Users set UserName='" + u.UsersName + "', Password='" + u.Sifre + "',NameSurname='" + u.NameSurname + "',Question='" + u.Question + "',Answer='" + u.Answer + "',Date=@Date where UserID='" + u.UsersID + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = u.Date;
                Database.ESG(cmd, sql);
                MessageBox.Show("Kullanıcı bilgileri güncellendi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean();
               
            }

            else
            {
                MessageBox.Show("Şifreler aynı değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
