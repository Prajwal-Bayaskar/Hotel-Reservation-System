namespace HotelReservations
{
    partial class AddRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRooms));
            lblPrice = new Label();
            txtPrice = new TextBox();
            label2 = new Label();
            btnClear = new Button();
            btnCancel = new Button();
            cmbRoom_Type = new ComboBox();
            lblAvailable = new Label();
            lblBeds = new Label();
            txtRoom_No = new TextBox();
            lblRoom_Type = new Label();
            lblRoom_No = new Label();
            btnAddRoom = new Button();
            cmbBed_Type = new ComboBox();
            cmbStatus = new ComboBox();
            label1 = new Label();
            btnSearch = new Button();
            txtRoomSearch = new TextBox();
            dataGrid = new DataGridView();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(65, 321);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(70, 32);
            lblPrice.TabIndex = 65;
            lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice.Location = new Point(263, 316);
            txtPrice.Margin = new Padding(4, 5, 4, 5);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(241, 37);
            txtPrice.TabIndex = 63;
            txtPrice.Tag = "int";
            txtPrice.Enter += Control_Enter;
            txtPrice.KeyPress += Control_KeyPress;
            txtPrice.Leave += Control_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(143, 319);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 64;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Heebo", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(384, 504);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(136, 51);
            btnClear.TabIndex = 52;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Heebo", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(574, 504);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(136, 51);
            btnCancel.TabIndex = 53;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbRoom_Type
            // 
            cmbRoom_Type.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbRoom_Type.FormattingEnabled = true;
            cmbRoom_Type.Items.AddRange(new object[] { "Please Select", "AC", "Non-AC" });
            cmbRoom_Type.Location = new Point(263, 176);
            cmbRoom_Type.Name = "cmbRoom_Type";
            cmbRoom_Type.Size = new Size(241, 40);
            cmbRoom_Type.TabIndex = 47;
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAvailable.Location = new Point(60, 401);
            lblAvailable.Margin = new Padding(4, 0, 4, 0);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(85, 32);
            lblAvailable.TabIndex = 57;
            lblAvailable.Text = "Status";
            // 
            // lblBeds
            // 
            lblBeds.AutoSize = true;
            lblBeds.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBeds.Location = new Point(65, 242);
            lblBeds.Margin = new Padding(4, 0, 4, 0);
            lblBeds.Name = "lblBeds";
            lblBeds.Size = new Size(69, 32);
            lblBeds.TabIndex = 56;
            lblBeds.Text = "Beds";
            // 
            // txtRoom_No
            // 
            txtRoom_No.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtRoom_No.Location = new Point(263, 116);
            txtRoom_No.Margin = new Padding(4, 5, 4, 5);
            txtRoom_No.Name = "txtRoom_No";
            txtRoom_No.Size = new Size(241, 37);
            txtRoom_No.TabIndex = 44;
            txtRoom_No.Tag = "int";
            txtRoom_No.Enter += Control_Enter;
            txtRoom_No.KeyPress += Control_KeyPress;
            txtRoom_No.Leave += Control_Leave;
            // 
            // lblRoom_Type
            // 
            lblRoom_Type.AutoSize = true;
            lblRoom_Type.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoom_Type.Location = new Point(65, 179);
            lblRoom_Type.Margin = new Padding(4, 0, 4, 0);
            lblRoom_Type.Name = "lblRoom_Type";
            lblRoom_Type.Size = new Size(145, 32);
            lblRoom_Type.TabIndex = 55;
            lblRoom_Type.Text = "Room Type";
            // 
            // lblRoom_No
            // 
            lblRoom_No.AutoSize = true;
            lblRoom_No.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoom_No.Location = new Point(65, 118);
            lblRoom_No.Margin = new Padding(4, 0, 4, 0);
            lblRoom_No.Name = "lblRoom_No";
            lblRoom_No.Size = new Size(123, 32);
            lblRoom_No.TabIndex = 54;
            lblRoom_No.Text = "Room No";
            // 
            // btnAddRoom
            // 
            btnAddRoom.Font = new Font("Heebo", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddRoom.Location = new Point(174, 504);
            btnAddRoom.Margin = new Padding(4, 5, 4, 5);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(136, 51);
            btnAddRoom.TabIndex = 51;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = true;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // cmbBed_Type
            // 
            cmbBed_Type.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbBed_Type.FormattingEnabled = true;
            cmbBed_Type.Items.AddRange(new object[] { "Please Select", "Single", "Double", "Triple" });
            cmbBed_Type.Location = new Point(263, 242);
            cmbBed_Type.Name = "cmbBed_Type";
            cmbBed_Type.Size = new Size(241, 40);
            cmbBed_Type.TabIndex = 66;
            cmbBed_Type.Validating += cmbPreference_Validating;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Please Select", "Available", "Booked" });
            cmbStatus.Location = new Point(263, 393);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(241, 40);
            cmbStatus.TabIndex = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(726, 42);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 73;
            label1.Text = "Room No";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(1204, 42);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 42);
            btnSearch.TabIndex = 72;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtRoomSearch
            // 
            txtRoomSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtRoomSearch.Location = new Point(896, 39);
            txtRoomSearch.Name = "txtRoomSearch";
            txtRoomSearch.Size = new Size(258, 39);
            txtRoomSearch.TabIndex = 71;
            txtRoomSearch.Tag = "int";
            txtRoomSearch.Enter += Control_Enter;
            txtRoomSearch.KeyPress += Control_KeyPress;
            txtRoomSearch.Leave += Control_Leave;
            // 
            // dataGrid
            // 
            dataGrid.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(670, 130);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 62;
            dataGrid.RowTemplate.Height = 33;
            dataGrid.Size = new Size(812, 346);
            dataGrid.TabIndex = 70;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(276, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(285, 50);
            label3.TabIndex = 74;
            label3.Text = "Add New Room";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(209, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 93;
            pictureBox2.TabStop = false;
            // 
            // AddRooms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1446, 744);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtRoomSearch);
            Controls.Add(dataGrid);
            Controls.Add(cmbStatus);
            Controls.Add(cmbBed_Type);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(btnClear);
            Controls.Add(btnCancel);
            Controls.Add(cmbRoom_Type);
            Controls.Add(lblAvailable);
            Controls.Add(lblBeds);
            Controls.Add(txtRoom_No);
            Controls.Add(lblRoom_Type);
            Controls.Add(lblRoom_No);
            Controls.Add(btnAddRoom);
            Name = "AddRooms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddRooms";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrice;
        private TextBox txtPrice;
        private Label label2;
        private Button btnClear;
        private Button btnCancel;
        private ComboBox cmbRoom_Type;
        private Label lblAvailable;
        private Label lblBeds;
        private TextBox txtRoom_No;
        private Label lblRoom_Type;
        private Label lblRoom_No;
        private Button btnAddRoom;
        private ComboBox cmbBed_Type;
        private ComboBox cmbStatus;
        private Label label1;
        private Button btnSearch;
        private TextBox txtRoomSearch;
        private DataGridView dataGrid;
        private Label label3;
        private PictureBox pictureBox2;
    }
}