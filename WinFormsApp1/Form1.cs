using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class loginForm : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=StudentDb;Integrated Security=True";
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            registerForm regForm = new registerForm();
            regForm.Show();
            this.Hide();
        }

        private void psswrd_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
