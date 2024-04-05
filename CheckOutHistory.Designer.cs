namespace HotelReservations
{
    partial class CheckOutHistory
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblCutId = new Label();
            btnSearchCust = new Button();
            txtCustId = new TextBox();
            dgvData = new DataGridView();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // lblCutId
            // 
            lblCutId.AutoSize = true;
            lblCutId.BackColor = Color.White;
            lblCutId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCutId.Location = new Point(311, 141);
            lblCutId.Margin = new Padding(4, 0, 4, 0);
            lblCutId.Name = "lblCutId";
            lblCutId.Size = new Size(87, 32);
            lblCutId.TabIndex = 89;
            lblCutId.Text = "CustId";
            // 
            // btnSearchCust
            // 
            btnSearchCust.BackColor = Color.FromArgb(192, 255, 255);
            btnSearchCust.Font = new Font("Segoe UI Emoji", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchCust.Location = new Point(705, 131);
            btnSearchCust.Margin = new Padding(4, 5, 4, 5);
            btnSearchCust.Name = "btnSearchCust";
            btnSearchCust.Size = new Size(146, 51);
            btnSearchCust.TabIndex = 88;
            btnSearchCust.Text = "Search ";
            btnSearchCust.UseVisualStyleBackColor = false;
            btnSearchCust.Click += btnSearchCust_Click;
            // 
            // txtCustId
            // 
            txtCustId.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCustId.Location = new Point(430, 139);
            txtCustId.Margin = new Padding(4, 5, 4, 5);
            txtCustId.Name = "txtCustId";
            txtCustId.Size = new Size(254, 37);
            txtCustId.TabIndex = 87;
            // 
            // dgvData
            // 
            dgvData.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(229, 208);
            dgvData.Margin = new Padding(4, 5, 4, 5);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(984, 270);
            dgvData.TabIndex = 86;
            // 
            // btnBack
            // 
            btnBack.BorderRadius = 22;
            btnBack.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnBack.CustomizableEdges = customizableEdges3;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.White;
            btnBack.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(1027, 545);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnBack.Size = new Size(230, 54);
            btnBack.TabIndex = 90;
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(354, 34);
            label1.TabIndex = 91;
            label1.Text = "Checked Out Customers";
            // 
            // CheckOutHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(1436, 744);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(lblCutId);
            Controls.Add(btnSearchCust);
            Controls.Add(txtCustId);
            Controls.Add(dgvData);
            Name = "CheckOutHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckOutHistory";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCutId;
        private Button btnSearchCust;
        private TextBox txtCustId;
        private DataGridView dgvData;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Label label1;
    }
}