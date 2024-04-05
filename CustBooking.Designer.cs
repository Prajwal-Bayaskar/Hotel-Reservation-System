namespace HotelReservations
{
    partial class CustBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustBooking));
            cmbType = new ComboBox();
            lblType = new Label();
            dtpCheckIn = new DateTimePicker();
            lblCheckIn = new Label();
            txtIdProof = new TextBox();
            lblIdProof = new Label();
            dtpDOB = new DateTimePicker();
            lblDOB = new Label();
            cmbGender = new ComboBox();
            lblGender = new Label();
            lblRoomNo = new Label();
            txtRoomNo = new TextBox();
            rtxtAddress = new RichTextBox();
            lblAddress = new Label();
            btnClear = new Button();
            btnCancel = new Button();
            cmbBedType = new ComboBox();
            txtPrice = new TextBox();
            lblprice = new Label();
            lblBedType = new Label();
            txtNationality = new TextBox();
            lblNationality = new Label();
            txtContact = new TextBox();
            txtName = new TextBox();
            lblContactNo = new Label();
            lblbname = new Label();
            btnBookRoom = new Button();
            SuspendLayout();
            // 
            // cmbType
            // 
            cmbType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Please Select", "AC", "Non-AC" });
            cmbType.Location = new Point(1143, 181);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(241, 40);
            cmbType.TabIndex = 83;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(1143, 144);
            lblType.Margin = new Padding(4, 0, 4, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(145, 32);
            lblType.TabIndex = 84;
            lblType.Text = "Room Type";
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpCheckIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpCheckIn.Location = new Point(1143, 394);
            dtpCheckIn.Margin = new Padding(4, 5, 4, 5);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(241, 39);
            dtpCheckIn.TabIndex = 81;
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCheckIn.Location = new Point(1143, 357);
            lblCheckIn.Margin = new Padding(4, 0, 4, 0);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(114, 32);
            lblCheckIn.TabIndex = 80;
            lblCheckIn.Text = "Check In";
            // 
            // txtIdProof
            // 
            txtIdProof.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdProof.Location = new Point(755, 615);
            txtIdProof.Margin = new Padding(4, 5, 4, 5);
            txtIdProof.Name = "txtIdProof";
            txtIdProof.Size = new Size(241, 37);
            txtIdProof.TabIndex = 62;
            txtIdProof.Tag = "string";
            txtIdProof.Enter += Control_Enter;
            txtIdProof.KeyPress += Control_KeyPress;
            txtIdProof.Leave += Control_Leave;
            // 
            // lblIdProof
            // 
            lblIdProof.AutoSize = true;
            lblIdProof.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdProof.Location = new Point(755, 578);
            lblIdProof.Margin = new Padding(4, 0, 4, 0);
            lblIdProof.Name = "lblIdProof";
            lblIdProof.Size = new Size(112, 32);
            lblIdProof.TabIndex = 79;
            lblIdProof.Text = "ID_Proof";
            // 
            // dtpDOB
            // 
            dtpDOB.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDOB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDOB.Location = new Point(755, 512);
            dtpDOB.Margin = new Padding(4, 5, 4, 5);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(241, 39);
            dtpDOB.TabIndex = 61;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDOB.Location = new Point(748, 464);
            lblDOB.Margin = new Padding(4, 0, 4, 0);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(167, 32);
            lblDOB.TabIndex = 78;
            lblDOB.Text = "Date Of Birth";
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cmbGender.Location = new Point(755, 398);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(241, 38);
            cmbGender.TabIndex = 60;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.Location = new Point(755, 360);
            lblGender.Margin = new Padding(4, 0, 4, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(98, 32);
            lblGender.TabIndex = 77;
            lblGender.Text = "Gender";
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoomNo.Location = new Point(1143, 555);
            lblRoomNo.Margin = new Padding(4, 0, 4, 0);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(126, 32);
            lblRoomNo.TabIndex = 76;
            lblRoomNo.Text = "Room_No";
            // 
            // txtRoomNo
            // 
            txtRoomNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtRoomNo.Location = new Point(1143, 606);
            txtRoomNo.Margin = new Padding(4, 5, 4, 5);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.Size = new Size(241, 37);
            txtRoomNo.TabIndex = 66;
            txtRoomNo.Tag = "int";
            txtRoomNo.Enter += Control_Enter;
            txtRoomNo.KeyPress += Control_KeyPress;
            txtRoomNo.Leave += Control_Leave;
            // 
            // rtxtAddress
            // 
            rtxtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rtxtAddress.Location = new Point(1143, 89);
            rtxtAddress.Name = "rtxtAddress";
            rtxtAddress.Size = new Size(241, 38);
            rtxtAddress.TabIndex = 63;
            rtxtAddress.Tag = "";
            rtxtAddress.Text = "";
            rtxtAddress.Enter += Control_Enter;
            rtxtAddress.KeyPress += Control_KeyPress;
            rtxtAddress.Leave += Control_Leave;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(1143, 54);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(105, 32);
            lblAddress.TabIndex = 75;
            lblAddress.Text = "Address";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 255, 192);
            btnClear.Font = new Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(1030, 689);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(136, 51);
            btnClear.TabIndex = 68;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 255, 192);
            btnCancel.Font = new Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(1202, 689);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(136, 51);
            btnCancel.TabIndex = 69;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbBedType
            // 
            cmbBedType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbBedType.FormattingEnabled = true;
            cmbBedType.Items.AddRange(new object[] { "Please Select", "Single", "Double", "Triple" });
            cmbBedType.Location = new Point(1143, 280);
            cmbBedType.Name = "cmbBedType";
            cmbBedType.Size = new Size(241, 40);
            cmbBedType.TabIndex = 64;
            cmbBedType.Validating += cmbPreference_Validating;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice.Location = new Point(1143, 496);
            txtPrice.Margin = new Padding(4, 5, 4, 5);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(241, 37);
            txtPrice.TabIndex = 65;
            txtPrice.Tag = "double";
            txtPrice.Enter += Control_Enter;
            txtPrice.KeyPress += Control_KeyPress;
            txtPrice.Leave += Control_Leave;
            // 
            // lblprice
            // 
            lblprice.AutoSize = true;
            lblprice.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblprice.Location = new Point(1143, 459);
            lblprice.Margin = new Padding(4, 0, 4, 0);
            lblprice.Name = "lblprice";
            lblprice.Size = new Size(70, 32);
            lblprice.TabIndex = 74;
            lblprice.Text = "Price";
            // 
            // lblBedType
            // 
            lblBedType.AutoSize = true;
            lblBedType.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBedType.Location = new Point(1143, 243);
            lblBedType.Margin = new Padding(4, 0, 4, 0);
            lblBedType.Name = "lblBedType";
            lblBedType.Size = new Size(122, 32);
            lblBedType.TabIndex = 73;
            lblBedType.Text = "Bed Type";
            // 
            // txtNationality
            // 
            txtNationality.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNationality.Location = new Point(755, 299);
            txtNationality.Margin = new Padding(4, 5, 4, 5);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(241, 37);
            txtNationality.TabIndex = 59;
            txtNationality.Tag = "string";
            txtNationality.Enter += Control_Enter;
            txtNationality.KeyPress += Control_KeyPress;
            txtNationality.Leave += Control_Leave;
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNationality.Location = new Point(755, 262);
            lblNationality.Margin = new Padding(4, 0, 4, 0);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(141, 32);
            lblNationality.TabIndex = 72;
            lblNationality.Text = "Nationality";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtContact.Location = new Point(755, 200);
            txtContact.Margin = new Padding(4, 5, 4, 5);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(241, 37);
            txtContact.TabIndex = 58;
            txtContact.Tag = "int";
            txtContact.Enter += Control_Enter;
            txtContact.KeyPress += Control_KeyPress;
            txtContact.Leave += Control_Leave;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(755, 109);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(241, 37);
            txtName.TabIndex = 57;
            txtName.Tag = "string";
            txtName.Enter += Control_Enter;
            txtName.KeyPress += Control_KeyPress;
            txtName.Leave += Control_Leave;
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContactNo.Location = new Point(755, 163);
            lblContactNo.Margin = new Padding(4, 0, 4, 0);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(151, 32);
            lblContactNo.TabIndex = 71;
            lblContactNo.Text = "Contact No.";
            // 
            // lblbname
            // 
            lblbname.AutoSize = true;
            lblbname.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblbname.Location = new Point(755, 73);
            lblbname.Margin = new Padding(4, 0, 4, 0);
            lblbname.Name = "lblbname";
            lblbname.Size = new Size(82, 32);
            lblbname.TabIndex = 70;
            lblbname.Text = "Name";
            // 
            // btnBookRoom
            // 
            btnBookRoom.BackColor = Color.FromArgb(192, 255, 192);
            btnBookRoom.Font = new Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnBookRoom.Location = new Point(852, 689);
            btnBookRoom.Margin = new Padding(4, 5, 4, 5);
            btnBookRoom.Name = "btnBookRoom";
            btnBookRoom.Size = new Size(136, 51);
            btnBookRoom.TabIndex = 67;
            btnBookRoom.Text = "Book";
            btnBookRoom.UseVisualStyleBackColor = false;
            btnBookRoom.Click += btnBookRoom_Click;
            // 
            // CustBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1459, 744);
            Controls.Add(cmbType);
            Controls.Add(lblType);
            Controls.Add(dtpCheckIn);
            Controls.Add(lblCheckIn);
            Controls.Add(txtIdProof);
            Controls.Add(lblIdProof);
            Controls.Add(dtpDOB);
            Controls.Add(lblDOB);
            Controls.Add(cmbGender);
            Controls.Add(lblGender);
            Controls.Add(lblRoomNo);
            Controls.Add(txtRoomNo);
            Controls.Add(rtxtAddress);
            Controls.Add(lblAddress);
            Controls.Add(btnClear);
            Controls.Add(btnCancel);
            Controls.Add(cmbBedType);
            Controls.Add(txtPrice);
            Controls.Add(lblprice);
            Controls.Add(lblBedType);
            Controls.Add(txtNationality);
            Controls.Add(lblNationality);
            Controls.Add(txtContact);
            Controls.Add(txtName);
            Controls.Add(lblContactNo);
            Controls.Add(lblbname);
            Controls.Add(btnBookRoom);
            DoubleBuffered = true;
            Name = "CustBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustBooking";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbType;
        private Label lblType;
        private DateTimePicker dtpCheckIn;
        private Label lblCheckIn;
        private TextBox txtIdProof;
        private Label lblIdProof;
        private DateTimePicker dtpDOB;
        private Label lblDOB;
        private ComboBox cmbGender;
        private Label lblGender;
        private Label lblRoomNo;
        private TextBox txtRoomNo;
        private RichTextBox rtxtAddress;
        private Label lblAddress;
        private Button btnClear;
        private Button btnCancel;
        private ComboBox cmbBedType;
        private TextBox txtPrice;
        private Label lblprice;
        private Label lblBedType;
        private TextBox txtNationality;
        private Label lblNationality;
        private TextBox txtContact;
        private TextBox txtName;
        private Label lblContactNo;
        private Label lblbname;
        private Button btnBookRoom;
    }
}