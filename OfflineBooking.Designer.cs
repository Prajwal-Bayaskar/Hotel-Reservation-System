namespace HotelReservations
{
    partial class OfflineBooking
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfflineBooking));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            btnCancelBooking = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            lblRoomNo = new Label();
            btnSearch = new Button();
            txtCustId = new TextBox();
            dataGrid = new DataGridView();
            btnOnlineBooking = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            txtRoomNo = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BorderRadius = 22;
            btnBack.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnBack.CustomizableEdges = customizableEdges15;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.White;
            btnBack.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(928, 634);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnBack.Size = new Size(230, 54);
            btnBack.TabIndex = 81;
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.BorderRadius = 22;
            btnCancelBooking.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCancelBooking.CustomizableEdges = customizableEdges17;
            btnCancelBooking.DisabledState.BorderColor = Color.DarkGray;
            btnCancelBooking.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelBooking.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelBooking.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelBooking.FillColor = Color.White;
            btnCancelBooking.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelBooking.ForeColor = Color.Black;
            btnCancelBooking.Location = new Point(665, 634);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnCancelBooking.Size = new Size(230, 54);
            btnCancelBooking.TabIndex = 80;
            btnCancelBooking.Text = "Cancel  Booking";
            btnCancelBooking.Click += btnCancelBooking_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(132, 37);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(308, 50);
            label2.TabIndex = 79;
            label2.Text = "Offline Bookings";
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.BackColor = Color.White;
            lblRoomNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoomNo.Location = new Point(210, 169);
            lblRoomNo.Margin = new Padding(4, 0, 4, 0);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(87, 32);
            lblRoomNo.TabIndex = 78;
            lblRoomNo.Text = "CustId";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 255, 255);
            btnSearch.Font = new Font("Segoe UI Emoji", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(604, 159);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(146, 51);
            btnSearch.TabIndex = 77;
            btnSearch.Text = "Search ";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtCustId
            // 
            txtCustId.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCustId.Location = new Point(329, 167);
            txtCustId.Margin = new Padding(4, 5, 4, 5);
            txtCustId.Name = "txtCustId";
            txtCustId.Size = new Size(254, 37);
            txtCustId.TabIndex = 76;
            txtCustId.Enter += Control_Enter;
            txtCustId.KeyPress += Control_KeyPress;
            txtCustId.Leave += Control_Leave;
            txtCustId.Validating += cmbCustId_Validating;
            // 
            // dataGrid
            // 
            dataGrid.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(43, 249);
            dataGrid.Margin = new Padding(4, 5, 4, 5);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 62;
            dataGrid.RowTemplate.Height = 25;
            dataGrid.Size = new Size(1287, 291);
            dataGrid.TabIndex = 75;
            // 
            // btnOnlineBooking
            // 
            btnOnlineBooking.BorderRadius = 22;
            btnOnlineBooking.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnOnlineBooking.CustomizableEdges = customizableEdges19;
            btnOnlineBooking.DisabledState.BorderColor = Color.DarkGray;
            btnOnlineBooking.DisabledState.CustomBorderColor = Color.DarkGray;
            btnOnlineBooking.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnOnlineBooking.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnOnlineBooking.FillColor = Color.White;
            btnOnlineBooking.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOnlineBooking.ForeColor = Color.Black;
            btnOnlineBooking.Location = new Point(1087, 147);
            btnOnlineBooking.Name = "btnOnlineBooking";
            btnOnlineBooking.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnOnlineBooking.Size = new Size(243, 54);
            btnOnlineBooking.TabIndex = 82;
            btnOnlineBooking.Text = "Online Bookings";
            btnOnlineBooking.Click += btnOnlineBooking_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1311, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 83;
            pictureBox1.TabStop = false;
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
            guna2ImageButton3.Location = new Point(604, 621);
            guna2ImageButton3.Name = "guna2ImageButton3";
            guna2ImageButton3.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton3.ShadowDecoration.CustomizableEdges = customizableEdges21;
            guna2ImageButton3.Size = new Size(66, 67);
            guna2ImageButton3.TabIndex = 90;
            // 
            // txtRoomNo
            // 
            txtRoomNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtRoomNo.Location = new Point(295, 634);
            txtRoomNo.Margin = new Padding(4, 5, 4, 5);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.Size = new Size(254, 37);
            txtRoomNo.TabIndex = 91;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(143, 639);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 92;
            label1.Text = "Room No";
            // 
            // OfflineBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1565, 744);
            Controls.Add(label1);
            Controls.Add(txtRoomNo);
            Controls.Add(guna2ImageButton3);
            Controls.Add(pictureBox1);
            Controls.Add(btnOnlineBooking);
            Controls.Add(btnBack);
            Controls.Add(btnCancelBooking);
            Controls.Add(label2);
            Controls.Add(lblRoomNo);
            Controls.Add(btnSearch);
            Controls.Add(txtCustId);
            Controls.Add(dataGrid);
            Name = "OfflineBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBookings";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Guna.UI2.WinForms.Guna2Button btnOnlineBooking;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private TextBox txtRoomNo;
        private Label label1;
    }
}