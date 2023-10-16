namespace VersionOfProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lab_Name = new Label();
            lab_pass = new Label();
            txt_Email = new TextBox();
            txt_Password = new TextBox();
            btn_login = new Button();
            CheckShowPassword = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lab_Name
            // 
            lab_Name.AutoSize = true;
            lab_Name.BackColor = Color.SaddleBrown;
            lab_Name.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lab_Name.ForeColor = Color.White;
            lab_Name.Location = new Point(389, 212);
            lab_Name.Margin = new Padding(5, 0, 5, 0);
            lab_Name.Name = "lab_Name";
            lab_Name.Size = new Size(91, 32);
            lab_Name.TabIndex = 0;
            lab_Name.Text = "Email";
            // 
            // lab_pass
            // 
            lab_pass.AutoSize = true;
            lab_pass.BackColor = Color.SaddleBrown;
            lab_pass.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lab_pass.ForeColor = Color.White;
            lab_pass.Location = new Point(389, 269);
            lab_pass.Margin = new Padding(5, 0, 5, 0);
            lab_pass.Name = "lab_pass";
            lab_pass.Size = new Size(146, 32);
            lab_pass.TabIndex = 1;
            lab_pass.Text = "Password";
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Email.Location = new Point(560, 206);
            txt_Email.Margin = new Padding(5, 6, 5, 6);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(304, 38);
            txt_Email.TabIndex = 2;
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Password.Location = new Point(560, 269);
            txt_Password.Margin = new Padding(5, 6, 5, 6);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(304, 38);
            txt_Password.TabIndex = 3;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.SaddleBrown;
            btn_login.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(392, 401);
            btn_login.Margin = new Padding(5, 6, 5, 6);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(475, 53);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // CheckShowPassword
            // 
            CheckShowPassword.AutoSize = true;
            CheckShowPassword.BackColor = SystemColors.ButtonFace;
            CheckShowPassword.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            CheckShowPassword.ForeColor = Color.Black;
            CheckShowPassword.Location = new Point(560, 316);
            CheckShowPassword.Name = "CheckShowPassword";
            CheckShowPassword.Size = new Size(236, 36);
            CheckShowPassword.TabIndex = 5;
            CheckShowPassword.Text = "Show Pasword";
            CheckShowPassword.UseVisualStyleBackColor = false;
            CheckShowPassword.CheckedChanged += CheckShowPassword_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SaddleBrown;
            label1.Font = new Font("Blackadder ITC", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(456, 75);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(362, 103);
            label1.TabIndex = 6;
            label1.Text = "Ball Hana";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(159, 111, 79);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1209, 566);
            Controls.Add(label1);
            Controls.Add(CheckShowPassword);
            Controls.Add(btn_login);
            Controls.Add(txt_Password);
            Controls.Add(txt_Email);
            Controls.Add(lab_pass);
            Controls.Add(lab_Name);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_Name;
        private Label lab_pass;
        private TextBox txt_Email;
        private TextBox txt_Password;
        private Button btn_login;
        private CheckBox CheckShowPassword;
        private Label label1;
    }
}