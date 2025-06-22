namespace WinFormsApp1
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            signup_btn = new Button();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtPassword_login = new TextBox();
            psswrd_login = new CheckBox();
            login_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(signup_btn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-14, -16);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 599);
            panel1.TabIndex = 0;
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
            // signup_btn
            // 
            signup_btn.BackColor = Color.FromArgb(0, 0, 64);
            signup_btn.BackgroundImageLayout = ImageLayout.None;
            signup_btn.FlatStyle = FlatStyle.Popup;
            signup_btn.ForeColor = Color.White;
            signup_btn.Location = new Point(106, 511);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(156, 40);
            signup_btn.TabIndex = 2;
            signup_btn.Text = "Sign Up";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(87, 475);
            label5.Name = "label5";
            label5.Size = new Size(207, 22);
            label5.TabIndex = 1;
            label5.Text = "Register Your Account";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(409, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(209, 33);
            label1.TabIndex = 1;
            label1.Text = "Login Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(417, 122);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 2;
            label2.Text = "User Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(413, 237);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // txtName
            // 
            txtName.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(413, 167);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(364, 29);
            txtName.TabIndex = 4;
            // 
            // txtPassword_login
            // 
            txtPassword_login.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword_login.Location = new Point(413, 281);
            txtPassword_login.Margin = new Padding(4, 3, 4, 3);
            txtPassword_login.Name = "txtPassword_login";
            txtPassword_login.Size = new Size(364, 29);
            txtPassword_login.TabIndex = 5;
            // 
            // psswrd_login
            // 
            psswrd_login.AutoSize = true;
            psswrd_login.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            psswrd_login.Location = new Point(614, 343);
            psswrd_login.Margin = new Padding(4, 3, 4, 3);
            psswrd_login.Name = "psswrd_login";
            psswrd_login.Size = new Size(148, 25);
            psswrd_login.TabIndex = 6;
            psswrd_login.Text = "Show Password";
            psswrd_login.UseVisualStyleBackColor = true;
            psswrd_login.CheckedChanged += psswrd_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(0, 0, 64);
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.Snow;
            login_btn.Location = new Point(409, 428);
            login_btn.Margin = new Padding(4, 3, 4, 3);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(133, 41);
            login_btn.TabIndex = 7;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += button1_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 579);
            Controls.Add(login_btn);
            Controls.Add(psswrd_login);
            Controls.Add(txtPassword_login);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "loginForm";
            Text = "Login Form";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtPassword_login;
        private CheckBox psswrd_login;
        private Button login_btn;
        private Button signup_btn;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
