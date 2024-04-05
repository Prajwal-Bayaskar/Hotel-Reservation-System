namespace HotelReservations
{
    partial class CustFeedbacks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustFeedbacks));
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            lblMyBooking = new Label();
            dataGrid3 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGrid3).BeginInit();
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
            btnBack.Location = new Point(854, 538);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBack.Size = new Size(166, 54);
            btnBack.TabIndex = 92;
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // lblMyBooking
            // 
            lblMyBooking.AutoSize = true;
            lblMyBooking.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMyBooking.Location = new Point(71, 25);
            lblMyBooking.Margin = new Padding(4, 0, 4, 0);
            lblMyBooking.Name = "lblMyBooking";
            lblMyBooking.Size = new Size(378, 50);
            lblMyBooking.TabIndex = 90;
            lblMyBooking.Text = "Customer Feedbacks";
            // 
            // dataGrid3
            // 
            dataGrid3.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGrid3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid3.Location = new Point(71, 148);
            dataGrid3.Margin = new Padding(4, 5, 4, 5);
            dataGrid3.Name = "dataGrid3";
            dataGrid3.RowHeadersWidth = 62;
            dataGrid3.RowTemplate.Height = 25;
            dataGrid3.Size = new Size(909, 322);
            dataGrid3.TabIndex = 89;
            // 
            // CustFeedbacks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1451, 744);
            Controls.Add(btnBack);
            Controls.Add(lblMyBooking);
            Controls.Add(dataGrid3);
            Name = "CustFeedbacks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustFeedbacks";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGrid3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Label lblMyBooking;
        private DataGridView dataGrid3;
    }
}