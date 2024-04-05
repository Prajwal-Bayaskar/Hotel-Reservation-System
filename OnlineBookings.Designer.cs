namespace HotelReservations
{
    partial class OnlineBookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlineBookings));
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            btnCancelBooking = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            lblRoomNo = new Label();
            btnSearch = new Button();
            txtCustId = new TextBox();
            dataGrid = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txtRoomNo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BorderRadius = 22;
            btnBack.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnBack.CustomizableEdges = customizableEdges1;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.White;
            btnBack.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(943, 621);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBack.Size = new Size(230, 54);
            btnBack.TabIndex = 88;
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.BorderRadius = 22;
            btnCancelBooking.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCancelBooking.CustomizableEdges = customizableEdges3;
            btnCancelBooking.DisabledState.BorderColor = Color.DarkGray;
            btnCancelBooking.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelBooking.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelBooking.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelBooking.FillColor = Color.White;
            btnCancelBooking.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelBooking.ForeColor = Color.Black;
            btnCancelBooking.Location = new Point(661, 621);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancelBooking.Size = new Size(276, 54);
            btnCancelBooking.TabIndex = 87;
            btnCancelBooking.Text = "Cancel  Booking";
            btnCancelBooking.Click += btnCancelBooking_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(210, 30);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(291, 50);
            label2.TabIndex = 86;
            label2.Text = "Online Bookings";
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.BackColor = Color.White;
            lblRoomNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoomNo.Location = new Point(303, 210);
            lblRoomNo.Margin = new Padding(4, 0, 4, 0);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(87, 32);
            lblRoomNo.TabIndex = 85;
            lblRoomNo.Text = "CustId";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 255, 192);
            btnSearch.Font = new Font("Segoe UI Emoji", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(690, 197);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(146, 51);
            btnSearch.TabIndex = 84;
            btnSearch.Text = "Search ";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtCustId
            // 
            txtCustId.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCustId.Location = new Point(419, 205);
            txtCustId.Margin = new Padding(4, 5, 4, 5);
            txtCustId.Name = "txtCustId";
            txtCustId.Size = new Size(254, 37);
            txtCustId.TabIndex = 83;
            txtCustId.Validating += cmbCustId_Validating;
            // 
            // dataGrid
            // 
            dataGrid.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(107, 282);
            dataGrid.Margin = new Padding(4, 5, 4, 5);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 62;
            dataGrid.RowTemplate.Height = 25;
            dataGrid.Size = new Size(1256, 291);
            dataGrid.TabIndex = 82;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(143, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 89;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(641, 621);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 90;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 626);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 94;
            label1.Text = "Room No";
            // 
            // txtRoomNo
            // 
            txtRoomNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtRoomNo.Location = new Point(343, 621);
            txtRoomNo.Margin = new Padding(4, 5, 4, 5);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.Size = new Size(254, 37);
            txtRoomNo.TabIndex = 93;
            // 
            // OnlineBookings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1461, 744);
            Controls.Add(label1);
            Controls.Add(txtRoomNo);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnBack);
            Controls.Add(btnCancelBooking);
            Controls.Add(label2);
            Controls.Add(lblRoomNo);
            Controls.Add(btnSearch);
            Controls.Add(txtCustId);
            Controls.Add(dataGrid);
            Name = "OnlineBookings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBookings";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnCancelBooking;
        private Label label2;
        private Label lblRoomNo;
        private Button btnSearch;
        private TextBox txtCustId;
        private DataGridView dataGrid;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtRoomNo;
    }
}