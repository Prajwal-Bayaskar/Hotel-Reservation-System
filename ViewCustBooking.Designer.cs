namespace HotelReservations
{
    partial class ViewCustBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCustBooking));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            btnCancelBooking = new Guna.UI2.WinForms.Guna2Button();
            lblMyBooking = new Label();
            dataGrid = new DataGridView();
            guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
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
            btnBack.Location = new Point(960, 402);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBack.Size = new Size(230, 54);
            btnBack.TabIndex = 88;
            btnBack.Text = "Back";
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
            btnCancelBooking.Location = new Point(697, 402);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancelBooking.Size = new Size(230, 54);
            btnCancelBooking.TabIndex = 87;
            btnCancelBooking.Text = "Cancel  Booking";
            // 
            // lblMyBooking
            // 
            lblMyBooking.AutoSize = true;
            lblMyBooking.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMyBooking.Location = new Point(173, 47);
            lblMyBooking.Margin = new Padding(4, 0, 4, 0);
            lblMyBooking.Name = "lblMyBooking";
            lblMyBooking.Size = new Size(236, 50);
            lblMyBooking.TabIndex = 86;
            lblMyBooking.Text = "My Bookings";
            // 
            // dataGrid
            // 
            dataGrid.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(13, 164);
            dataGrid.Margin = new Padding(4, 5, 4, 5);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 62;
            dataGrid.RowTemplate.Height = 25;
            dataGrid.Size = new Size(1385, 107);
            dataGrid.TabIndex = 82;
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
            guna2ImageButton3.Location = new Point(634, 389);
            guna2ImageButton3.Name = "guna2ImageButton3";
            guna2ImageButton3.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton3.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2ImageButton3.Size = new Size(66, 67);
            guna2ImageButton3.TabIndex = 89;
            // 
            // ViewCustBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1453, 721);
            Controls.Add(guna2ImageButton3);
            Controls.Add(btnBack);
            Controls.Add(btnCancelBooking);
            Controls.Add(lblMyBooking);
            Controls.Add(dataGrid);
            Name = "ViewCustBooking";
            Text = "ViewCustBooking";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnCancelBooking;
        private Label lblMyBooking;
        private DataGridView dataGrid;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
    }
}