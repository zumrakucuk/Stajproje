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
    public partial class NewUser : Form
    {
        public NewUser()
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
            foreach(Control item in Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (txtPassword==txtPassword2)
            {
                Users u = new Users();
                u.UsersName = txtUserName.Text;
                u.Sifre = txtPassword.Text;
                u.NameSurname = txtNameSurname.Text;
                u.Question = comboBoxQuestion.Text;
                u.Answer = txtAnswer.Text;
                u.Date = DateTime.Now;
                string sql = "insert into Users values('" + u.UsersName + "','" + u.Sifre + "'+'" + u.Question + "','" + u.Answer + "',@Date)";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = u.Date;
                Database.ESG(cmd, sql);
                MessageBox.Show("Yeni kullanıcı eklendi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean();
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifreler aynı değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
