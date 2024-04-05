namespace HotelReservations
{
    partial class ManageEmployee
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployee));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Employee_Id = new Label();
            btnSearchEmp = new Button();
            txtEmpSearch = new TextBox();
            dataGridEmp = new DataGridView();
            btnAddEmp = new Guna.UI2.WinForms.Guna2Button();
            btnDeleteEmp = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)dataGridEmp).BeginInit();
            SuspendLayout();
            // 
            // Employee_Id
            // 
            Employee_Id.AutoSize = true;
            Employee_Id.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Employee_Id.Location = new Point(324, 191);
            Employee_Id.Name = "Employee_Id";
            Employee_Id.Size = new Size(155, 32);
            Employee_Id.TabIndex = 9;
            Employee_Id.Text = "Employee Id";
            // 
            // btnSearchEmp
            // 
            btnSearchEmp.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchEmp.Location = new Point(802, 181);
            btnSearchEmp.Name = "btnSearchEmp";
            btnSearchEmp.Size = new Size(112, 42);
            btnSearchEmp.TabIndex = 8;
            btnSearchEmp.Text = "Search";
            btnSearchEmp.UseVisualStyleBackColor = true;
            btnSearchEmp.Click += btnSearchEmp_Click;
            // 
            // txtEmpSearch
            // 
            txtEmpSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmpSearch.Location = new Point(509, 184);
            txtEmpSearch.Name = "txtEmpSearch";
            txtEmpSearch.Size = new Size(258, 39);
            txtEmpSearch.TabIndex = 7;
            txtEmpSearch.Enter += Control_Enter;
            txtEmpSearch.KeyPress += Control_KeyPress;
            txtEmpSearch.Leave += Control_Leave;
            // 
            // dataGridEmp
            // 
            dataGridEmp.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmp.Location = new Point(112, 253);
            dataGridEmp.Name = "dataGridEmp";
            dataGridEmp.RowHeadersWidth = 62;
            dataGridEmp.RowTemplate.Height = 33;
            dataGridEmp.Size = new Size(1067, 329);
            dataGridEmp.TabIndex = 6;
            // 
            // btnAddEmp
            // 
            btnAddEmp.BorderRadius = 22;
            btnAddEmp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnAddEmp.CustomizableEdges = customizableEdges1;
            btnAddEmp.DisabledState.BorderColor = Color.DarkGray;
            btnAddEmp.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddEmp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddEmp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddEmp.FillColor = Color.White;
            btnAddEmp.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddEmp.ForeColor = Color.Black;
            btnAddEmp.Location = new Point(1259, 91);
            btnAddEmp.Name = "btnAddEmp";
            btnAddEmp.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddEmp.Size = new Size(202, 54);
            btnAddEmp.TabIndex = 17;
            btnAddEmp.Text = "Add Employee";
            btnAddEmp.Click += btnAddEmp_Click;
            // 
            // btnDeleteEmp
            // 
            btnDeleteEmp.BorderRadius = 22;
            btnDeleteEmp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnDeleteEmp.CustomizableEdges = customizableEdges3;
            btnDeleteEmp.DisabledState.BorderColor = Color.DarkGray;
            btnDeleteEmp.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDeleteEmp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDeleteEmp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDeleteEmp.FillColor = Color.White;
            btnDeleteEmp.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteEmp.ForeColor = Color.Black;
            btnDeleteEmp.Location = new Point(721, 638);
            btnDeleteEmp.Name = "btnDeleteEmp";
            btnDeleteEmp.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDeleteEmp.Size = new Size(230, 54);
            btnDeleteEmp.TabIndex = 18;
            btnDeleteEmp.Text = "Delete Employee";
            btnDeleteEmp.Click += btnDeleteEmp_Click;
            // 
            // btnCancel
            // 
            btnCancel.BorderRadius = 22;
            btnCancel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCancel.CustomizableEdges = customizableEdges5;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.White;
            btnCancel.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(981, 638);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCancel.Size = new Size(230, 54);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Back";
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(532, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(344, 50);
            label1.TabIndex = 72;
            label1.Text = "Manage Employees";
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.AnimatedGIF = true;
            guna2ImageButton1.BackgroundImageLayout = ImageLayout.Center;
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.Location = new Point(1187, 78);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2ImageButton1.Size = new Size(66, 67);
            guna2ImageButton1.TabIndex = 79;
            guna2ImageButton1.Click += guna2ImageButton1_Click;
            // 
            // guna2ImageButton2
            // 
            guna2ImageButton2.AnimatedGIF = true;
            guna2ImageButton2.BackColor = Color.FromArgb(192, 192, 255);
            guna2ImageButton2.BackgroundImageLayout = ImageLayout.Center;
            guna2ImageButton2.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton2.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton2.Image = (Image)resources.GetObject("guna2ImageButton2.Image");
            guna2ImageButton2.ImageOffset = new Point(0, 0);
            guna2ImageButton2.ImageRotate = 0F;
            guna2ImageButton2.Location = new Point(459, 12);
            guna2ImageButton2.Name = "guna2ImageButton2";
            guna2ImageButton2.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2ImageButton2.Size = new Size(77, 63);
            guna2ImageButton2.TabIndex = 80;
            // 
            // guna2ImageButton3
            // 
            guna2ImageButton3.AnimatedGIF = true;
            guna2ImageButton3.BackgroundImageLayout = ImageLayout.Center;
            guna2ImageButton3.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton3.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton3.Image = (Image)resources.GetObject("guna2ImageButton3.Image");
            guna2ImageButton3.ImageOffset = new Point(0, 0);
            guna2ImageButton3.ImageRotate = 0F;
            guna2ImageButton3.Location = new Point(649, 625);
            guna2ImageButton3.Name = "guna2ImageButton3";
            guna2ImageButton3.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton3.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2ImageButton3.Size = new Size(66, 67);
            guna2ImageButton3.TabIndex = 81;
            guna2ImageButton3.Click += guna2ImageButton3_Click;
            // 
            // ManageEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1706, 715);
            Controls.Add(guna2ImageButton3);
            Controls.Add(guna2ImageButton2);
            Controls.Add(guna2ImageButton1);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnDeleteEmp);
            Controls.Add(btnAddEmp);
            Controls.Add(Employee_Id);
            Controls.Add(btnSearchEmp);
            Controls.Add(txtEmpSearch);
            Controls.Add(dataGridEmp);
            Name = "ManageEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageEmployee";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridEmp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Employee_Id;
        private Button btnSearchEmp;
        private TextBox txtEmpSearch;
        private DataGridView dataGridEmp;
        private Guna.UI2.WinForms.Guna2Button btnAddEmp;
        private Guna.UI2.WinForms.Guna2Button btnDeleteEmp;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
    }
}