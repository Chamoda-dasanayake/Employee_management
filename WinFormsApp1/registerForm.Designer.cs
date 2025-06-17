namespace WinFormsApp1
{
    partial class registerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerForm));
            signup_loginbtn = new Button();
            psswrd = new CheckBox();
            txtPassword = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            signin_btn = new Button();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // signup_loginbtn
            // 
            signup_loginbtn.BackColor = Color.FromArgb(0, 0, 64);
            signup_loginbtn.FlatStyle = FlatStyle.Flat;
            signup_loginbtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_loginbtn.ForeColor = Color.Snow;
            signup_loginbtn.Location = new Point(429, 450);
            signup_loginbtn.Margin = new Padding(4, 3, 4, 3);
            signup_loginbtn.Name = "signup_loginbtn";
            signup_loginbtn.Size = new Size(133, 41);
            signup_loginbtn.TabIndex = 15;
            signup_loginbtn.Text = "Sign Up";
            signup_loginbtn.UseVisualStyleBackColor = false;
            signup_loginbtn.Click += signup_loginbtn_Click;
            // 
            // psswrd
            // 
            psswrd.AutoSize = true;
            psswrd.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            psswrd.Location = new Point(634, 365);
            psswrd.Margin = new Padding(4, 3, 4, 3);
            psswrd.Name = "psswrd";
            psswrd.Size = new Size(148, 25);
            psswrd.TabIndex = 14;
            psswrd.Text = "Show Password";
            psswrd.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(433, 303);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(364, 29);
            txtPassword.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(433, 189);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(364, 29);
            txtName.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(433, 259);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 11;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(437, 144);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 10;
            label2.Text = "User Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(435, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 33);
            label1.TabIndex = 9;
            label1.Text = "Register Account";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(signin_btn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(5, -10);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 599);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // signin_btn
            // 
            signin_btn.BackColor = Color.FromArgb(0, 0, 64);
            signin_btn.BackgroundImageLayout = ImageLayout.None;
            signin_btn.FlatStyle = FlatStyle.Popup;
            signin_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signin_btn.ForeColor = Color.White;
            signin_btn.Location = new Point(40, 511);
            signin_btn.Name = "signin_btn";
            signin_btn.Size = new Size(314, 40);
            signin_btn.TabIndex = 2;
            signin_btn.Text = "Sign In";
            signin_btn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(100, 475);
            label5.Name = "label5";
            label5.Size = new Size(180, 22);
            label5.TabIndex = 1;
            label5.Text = "Login Your Account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(40, 249);
            label4.Name = "label4";
            label4.Size = new Size(329, 25);
            label4.TabIndex = 0;
            label4.Text = "Employee Management System";
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 579);
            Controls.Add(signup_loginbtn);
            Controls.Add(psswrd);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "registerForm";
            Text = "Register Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signup_loginbtn;
        private CheckBox psswrd;
        private TextBox txtPassword;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button signin_btn;
        private Label label5;
        private Label label4;
    }
}