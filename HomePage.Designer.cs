namespace HotelReservations
{
    partial class HomePage
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            btnCustomerLogin = new Guna.UI2.WinForms.Guna2Button();
            btnAdminLogin = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btnCustomerLogin
            // 
            btnCustomerLogin.BackColor = Color.Transparent;
            btnCustomerLogin.BorderRadius = 22;
            btnCustomerLogin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCustomerLogin.CustomizableEdges = customizableEdges1;
            btnCustomerLogin.DisabledState.BorderColor = Color.DarkGray;
            btnCustomerLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCustomerLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCustomerLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCustomerLogin.FillColor = Color.FromArgb(192, 192, 255);
            btnCustomerLogin.Font = new Font("Segoe Script", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomerLogin.ForeColor = Color.Black;
            btnCustomerLogin.Location = new Point(12, 200);
            btnCustomerLogin.Name = "btnCustomerLogin";
            btnCustomerLogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCustomerLogin.Size = new Size(298, 65);
            btnCustomerLogin.TabIndex = 97;
            btnCustomerLogin.Text = "Customer Login";
            btnCustomerLogin.Click += btnCustomerLogin_Click;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.BackColor = Color.Transparent;
            btnAdminLogin.BorderRadius = 22;
            btnAdminLogin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnAdminLogin.CustomizableEdges = customizableEdges3;
            btnAdminLogin.DisabledState.BorderColor = Color.DarkGray;
            btnAdminLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdminLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdminLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdminLogin.FillColor = Color.FromArgb(192, 192, 255);
            btnAdminLogin.Font = new Font("Segoe Script", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminLogin.ForeColor = Color.Black;
            btnAdminLogin.Location = new Point(12, 129);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAdminLogin.Size = new Size(298, 65);
            btnAdminLogin.TabIndex = 98;
            btnAdminLogin.Text = "Admin Login";
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 
            // HomePage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1294, 744);
            Controls.Add(btnAdminLogin);
            Controls.Add(btnCustomerLogin);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            WindowState = FormWindowState.Maximized;
            Load += HomePage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCustomerLogin;
        private Guna.UI2.WinForms.Guna2Button btnAdminLogin;
    }
}