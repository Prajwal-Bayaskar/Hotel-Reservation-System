namespace HotelReservations
{
    partial class Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feedback));
            lblCustName = new Label();
            txtCustName = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            lblReview = new Label();
            rtxtReview = new RichTextBox();
            lblFeeback = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            btnSend = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // lblCustName
            // 
            lblCustName.AutoSize = true;
            lblCustName.BackColor = Color.FromArgb(192, 192, 255);
            lblCustName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustName.Location = new Point(482, 160);
            lblCustName.Margin = new Padding(4, 0, 4, 0);
            lblCustName.Name = "lblCustName";
            lblCustName.Size = new Size(138, 32);
            lblCustName.TabIndex = 87;
            lblCustName.Text = "Cust Name";
            // 
            // txtCustName
            // 
            txtCustName.BackColor = Color.White;
            txtCustName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCustName.Location = new Point(667, 158);
            txtCustName.Margin = new Padding(4, 5, 4, 5);
            txtCustName.Name = "txtCustName";
            txtCustName.Size = new Size(254, 37);
            txtCustName.TabIndex = 86;
            txtCustName.Enter += Control_Enter;
            txtCustName.KeyPress += Control_KeyPress;
            txtCustName.Leave += Control_Leave;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.BackColor = Color.FromArgb(192, 192, 255);
            lblContact.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContact.Location = new Point(482, 216);
            lblContact.Margin = new Padding(4, 0, 4, 0);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(102, 32);
            lblContact.TabIndex = 88;
            lblContact.Text = "Contact";
            // 
            // txtContact
            // 
            txtContact.BackColor = Color.White;
            txtContact.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtContact.Location = new Point(667, 216);
            txtContact.Margin = new Padding(4, 5, 4, 5);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(254, 37);
            txtContact.TabIndex = 89;
            txtContact.Enter += Control_Enter;
            txtContact.KeyPress += Control_KeyPress;
            txtContact.Leave += Control_Leave;
            // 
            // lblReview
            // 
            lblReview.AutoSize = true;
            lblReview.BackColor = Color.FromArgb(192, 192, 255);
            lblReview.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblReview.Location = new Point(482, 412);
            lblReview.Margin = new Padding(4, 0, 4, 0);
            lblReview.Name = "lblReview";
            lblReview.Size = new Size(94, 32);
            lblReview.TabIndex = 90;
            lblReview.Text = "Review";
            // 
            // rtxtReview
            // 
            rtxtReview.BackColor = Color.White;
            rtxtReview.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rtxtReview.Location = new Point(654, 359);
            rtxtReview.Name = "rtxtReview";
            rtxtReview.Size = new Size(291, 164);
            rtxtReview.TabIndex = 91;
            rtxtReview.Tag = "";
            rtxtReview.Text = "";
            rtxtReview.Enter += Control_Enter;
            rtxtReview.KeyPress += Control_KeyPress;
            rtxtReview.Leave += Control_Leave;
            // 
            // lblFeeback
            // 
            lblFeeback.AutoSize = true;
            lblFeeback.BackColor = Color.FromArgb(0, 192, 192);
            lblFeeback.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblFeeback.Location = new Point(53, 21);
            lblFeeback.Margin = new Padding(4, 0, 4, 0);
            lblFeeback.Name = "lblFeeback";
            lblFeeback.Size = new Size(175, 42);
            lblFeeback.TabIndex = 92;
            lblFeeback.Text = "Feedback";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(667, 279);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(254, 37);
            txtEmail.TabIndex = 94;
            txtEmail.Enter += Control_Enter;
            txtEmail.KeyPress += Control_KeyPress;
            txtEmail.Leave += Control_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 192, 255);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(482, 279);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 93;
            label3.Text = "e-mail";
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Transparent;
            btnSend.BorderRadius = 22;
            btnSend.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnSend.CustomizableEdges = customizableEdges1;
            btnSend.DisabledState.BorderColor = Color.DarkGray;
            btnSend.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSend.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSend.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSend.FillColor = Color.FromArgb(192, 255, 192);
            btnSend.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSend.ForeColor = Color.Black;
            btnSend.Location = new Point(461, 647);
            btnSend.Name = "btnSend";
            btnSend.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSend.Size = new Size(216, 54);
            btnSend.TabIndex = 95;
            btnSend.Text = "Send";
            btnSend.Click += btnSend_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BorderRadius = 22;
            btnCancel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCancel.CustomizableEdges = customizableEdges3;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(192, 255, 192);
            btnCancel.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(747, 647);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancel.Size = new Size(216, 54);
            btnCancel.TabIndex = 96;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // Feedback
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1570, 726);
            Controls.Add(btnCancel);
            Controls.Add(btnSend);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(lblFeeback);
            Controls.Add(rtxtReview);
            Controls.Add(lblReview);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(lblCustName);
            Controls.Add(txtCustName);
            Name = "Feedback";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Feedback";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustName;
        private TextBox txtCustName;
        private Label lblContact;
        private TextBox txtContact;
        private Label lblReview;
        private RichTextBox rtxtReview;
        private Label lblFeeback;
        private TextBox txtEmail;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}