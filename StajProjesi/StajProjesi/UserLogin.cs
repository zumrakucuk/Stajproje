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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Users.UserLogin(txtUserName.Text, txtPassword.Text);
            if(Users.status)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya şifre yanlış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.ShowDialog();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            NewUser nu = new NewUser();
            nu.ShowDialog();
        }
    }
}
