namespace HotelReservations
{
    partial class CheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOut));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            lblCutId = new Label();
            btnSearchCust = new Button();
            txtCustId = new TextBox();
            dgvData = new DataGridView();
            dtpCheckOut = new DateTimePicker();
            lblCheckOut = new Label();
            btnChkOutHistory = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnCheckOut
            // 
            btnCheckOut.BorderRadius = 22;
            btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCheckOut.CustomizableEdges = customizableEdges1;
            btnCheckOut.DisabledState.BorderColor = Color.DarkGray;
            btnCheckOut.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCheckOut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCheckOut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCheckOut.FillColor = Color.White;
            btnCheckOut.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckOut.ForeColor = Color.Black;
            btnCheckOut.Location = new Point(703, 560);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCheckOut.Size = new Size(230, 54);
            btnCheckOut.TabIndex = 86;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // lblCutId
            // 
            lblCutId.AutoSize = true;
            lblCutId.BackColor = Color.White;
            lblCutId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCutId.Location = new Point(393, 125);
            lblCutId.Margin = new Padding(4, 0, 4, 0);
            lblCutId.Name = "lblCutId";
            lblCutId.Size = new Size(87, 32);
            lblCutId.TabIndex = 85;
            lblCutId.Text = "CustId";
            // 
            // btnSearchCust
            // 
            btnSearchCust.BackColor = Color.FromArgb(192, 255, 255);
            btnSearchCust.Font = new Font("Segoe UI Emoji", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchCust.Location = new Point(787, 115);
            btnSearchCust.Margin = new Padding(4, 5, 4, 5);
            btnSearchCust.Name = "btnSearchCust";
            btnSearchCust.Size = new Size(146, 51);
            btnSearchCust.TabIndex = 84;
            btnSearchCust.Text = "Search ";
            btnSearchCust.UseVisualStyleBackColor = false;
            btnSearchCust.Click += btnSearchCust_Click;
            // 
            // txtCustId
            // 
            txtCustId.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCustId.Location = new Point(512, 123);
            txtCustId.Margin = new Padding(4, 5, 4, 5);
            txtCustId.Name = "txtCustId";
            txtCustId.Size = new Size(254, 37);
            txtCustId.TabIndex = 83;
            txtCustId.Tag = "int";
            // 
            // dgvData
            // 
            dgvData.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(405, 188);
            dgvData.Margin = new Padding(4, 5, 4, 5);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(799, 270);
            dgvData.TabIndex = 82;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpCheckOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpCheckOut.Location = new Point(430, 565);
            dtpCheckOut.Margin = new Padding(4, 5, 4, 5);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(241, 39);
            dtpCheckOut.TabIndex = 89;
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCheckOut.Location = new Point(430, 531);
            lblCheckOut.Margin = new Padding(4, 0, 4, 0);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(188, 29);
            lblCheckOut.TabIndex = 88;
            lblCheckOut.Text = "Check Out Date";
            // 
            // btnChkOutHistory
            // 
            btnChkOutHistory.BorderRadius = 22;
            btnChkOutHistory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnChkOutHistory.CustomizableEdges = customizableEdges3;
            btnChkOutHistory.DisabledState.BorderColor = Color.DarkGray;
            btnChkOutHistory.DisabledState.CustomBorderColor = Color.DarkGray;
            btnChkOutHistory.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnChkOutHistory.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnChkOutHistory.FillColor = Color.White;
            btnChkOutHistory.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChkOutHistory.ForeColor = Color.Black;
            btnChkOutHistory.Location = new Point(1217, 12);
            btnChkOutHistory.Name = "btnChkOutHistory";
            btnChkOutHistory.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnChkOutHistory.Size = new Size(269, 69);
            btnChkOutHistory.TabIndex = 90;
            btnChkOutHistory.Text = "Check Out History";
            btnChkOutHistory.Click += btnChkOutHistory_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 91;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1140, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 92;
            pictureBox2.TabStop = false;
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
            btnCancel.Location = new Point(957, 560);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCancel.Size = new Size(230, 54);
            btnCancel.TabIndex = 93;
            btnCancel.Text = "Back";
            btnCancel.Click += btnCancel_Click;
            // 
            // CheckOut
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1493, 744);
            Controls.Add(btnCancel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnChkOutHistory);
            Controls.Add(dtpCheckOut);
            Controls.Add(lblCheckOut);
            Controls.Add(btnCheckOut);
            Controls.Add(lblCutId);
            Controls.Add(btnSearchCust);
            Controls.Add(txtCustId);
            Controls.Add(dgvData);
            Name = "CheckOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckOut";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Label lblCutId;
        private Button btnSearchCust;
        private TextBox txtCustId;
        private DataGridView dgvData;
        private DateTimePicker dtpCheckOut;
        private Label lblCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnChkOutHistory;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}