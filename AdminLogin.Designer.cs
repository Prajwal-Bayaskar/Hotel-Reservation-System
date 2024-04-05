namespace HotelReservations
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblPass = new Label();
            lblUserName = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            lblError = new Label();
            panel1 = new Panel();
            btnCancel = new Guna.UI2.WinForms.Guna2CircleButton();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.Location = new Point(405, 167);
            lblPass.Margin = new Padding(4, 0, 4, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(139, 39);
            lblPass.TabIndex = 7;
            lblPass.Text = "Password";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(405, 59);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(150, 39);
            lblUserName.TabIndex = 6;
            lblUserName.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(200, 30);
            label1.Name = "label1";
            label1.Size = new Size(187, 39);
            label1.TabIndex = 10;
            label1.Text = "Admin Login";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(145, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.White;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(362, 357);
            lblError.Name = "lblError";
            lblError.Size = new Size(268, 25);
            lblError.TabIndex = 13;
            lblError.Text = "Wrong Username or Password";
            lblError.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblPass);
            panel1.Location = new Point(522, 240);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 446);
            panel1.TabIndex = 14;
            // 
            // btnCancel
            // 
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.Empty;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageSize = new Size(30, 30);
            btnCancel.Location = new Point(3, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnCancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnCancel.Size = new Size(33, 37);
            btnCancel.TabIndex = 17;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 22;
            btnLogin.CustomizableEdges = customizableEdges2;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(0, 192, 0);
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(405, 282);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnLogin.Size = new Size(240, 54);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUserName
            // 
            txtUserName.BorderRadius = 18;
            txtUserName.CustomizableEdges = customizableEdges4;
            txtUserName.DefaultText = "";
            txtUserName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUserName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUserName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUserName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUserName.FillColor = Color.FromArgb(224, 224, 224);
            txtUserName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserName.IconLeft = (Image)resources.GetObject("txtUserName.IconLeft");
            txtUserName.IconLeftSize = new Size(27, 27);
            txtUserName.Location = new Point(405, 101);
            txtUserName.Name = "txtUserName";
            txtUserName.PasswordChar = '\0';
            txtUserName.PlaceholderText = "Username";
            txtUserName.SelectedText = "";
            txtUserName.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtUserName.Size = new Size(264, 49);
            txtUserName.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Transparent;
            txtPassword.BorderColor = Color.White;
            txtPassword.BorderRadius = 18;
            txtPassword.CustomizableEdges = customizableEdges6;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FillColor = Color.FromArgb(224, 224, 224);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.IconLeft = (Image)resources.GetObject("txtPassword.IconLeft");
            txtPassword.IconLeftSize = new Size(26, 26);
            txtPassword.Location = new Point(405, 209);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges7;
            txtPassword.Size = new Size(264, 52);
            txtPassword.TabIndex = 16;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 310);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1565, 744);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Name = "AdminLogin";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPass;
        private Label lblUserName;
        private Label label1;
        private PictureBox pictureBox2;
        private Label lblError;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton btnCancel;
    }
}
