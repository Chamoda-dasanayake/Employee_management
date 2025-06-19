using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void signup_loginbtn_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();

        }

        private void signin_btn_Click(object sender, EventArgs e)
        {

        }

        private void psswrd_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = 
        }
    }
}
