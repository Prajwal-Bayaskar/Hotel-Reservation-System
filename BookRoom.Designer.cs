namespace HotelReservations
{
    partial class BookRoom
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges55 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges56 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges57 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges58 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges59 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges60 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtPrice = new TextBox();
            lblprice = new Label();
            lblBedType = new Label();
            txtNationality = new TextBox();
            lblNationality = new Label();
            txtContact = new TextBox();
            txtName = new TextBox();
            lblContactNo = new Label();
            lblbname = new Label();
            cmbBedType = new ComboBox();
            lblAddress = new Label();
            rtxtAddress = new RichTextBox();
            txtRoomNo = new TextBox();
            label2 = new Label();
            lblRoomNo = new Label();
            lblGender = new Label();
            cmbGender = new ComboBox();
            dtpDOB = new DateTimePicker();
            lblDOB = new Label();
            lblIdProof = new Label();
            txtIdProof = new TextBox();
            lblCheckIn = new Label();
            dtpCheckIn = new DateTimePicker();
            cmbType = new ComboBox();
            lblType = new Label();
            btnBookRoom = new Guna.UI2.WinForms.Guna2Button();
            btnClear = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice.Location = new Point(596, 528);
            txtPrice.Margin = new Padding(4, 5, 4, 5);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(241, 37);
            txtPrice.TabIndex = 9;
            txtPrice.Tag = "int";
            txtPrice.KeyPress += Control_KeyPress;
            // 
            // lblprice
            // 
            lblprice.AutoSize = true;
            lblprice.BackColor = Color.FromArgb(128, 128, 255);
            lblprice.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblprice.ForeColor = Color.White;
            lblprice.Location = new Point(596, 491);
            lblprice.Margin = new Padding(4, 0, 4, 0);
            lblprice.Name = "lblprice";
            lblprice.Size = new Size(70, 32);
            lblprice.TabIndex = 29;
            lblprice.Text = "Price";
           
            // 
            // lblBedType
            // 
            lblBedType.AutoSize = true;
            lblBedType.BackColor = Color.FromArgb(128, 128, 255);
            lblBedType.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBedType.ForeColor = Color.White;
            lblBedType.Location = new Point(596, 275);
            lblBedType.Margin = new Padding(4, 0, 4, 0);
            lblBedType.Name = "lblBedType";
            lblBedType.Size = new Size(122, 32);
            lblBedType.TabIndex = 28;
            lblBedType.Text = "Bed Type";
          
            // 
            // txtNationality
            // 
            txtNationality.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNationality.Location = new Point(166, 319);
            txtNationality.Margin = new Padding(4, 5, 4, 5);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(241, 37);
            txtNationality.TabIndex = 3;
            txtNationality.Tag = "string";
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.BackColor = Color.FromArgb(128, 128, 255);
            lblNationality.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNationality.ForeColor = Color.White;
            lblNationality.Location = new Point(166, 282);
            lblNationality.Margin = new Padding(4, 0, 4, 0);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(141, 32);
            lblNationality.TabIndex = 25;
            lblNationality.Text = "Nationality";
         
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtContact.Location = new Point(166, 220);
            txtContact.Margin = new Padding(4, 5, 4, 5);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(241, 37);
            txtContact.TabIndex = 2;
            txtContact.Tag = "int";
            txtContact.Enter += Control_Enter;
            txtContact.KeyPress += Control_KeyPress;
            txtContact.Leave += Control_Leave;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(166, 129);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(241, 37);
            txtName.TabIndex = 1;
            txtName.Tag = "string";
            txtName.Enter += Control_Enter;
            txtName.KeyPress += Control_KeyPress;
            txtName.Leave += Control_Leave;
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.BackColor = Color.FromArgb(128, 128, 255);
            lblContactNo.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContactNo.ForeColor = Color.White;
            lblContactNo.Location = new Point(166, 183);
            lblContactNo.Margin = new Padding(4, 0, 4, 0);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(151, 32);
            lblContactNo.TabIndex = 22;
            lblContactNo.Text = "Contact No.";
           
            // 
            // lblbname
            // 
            lblbname.AutoSize = true;
            lblbname.BackColor = Color.FromArgb(128, 128, 255);
            lblbname.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblbname.ForeColor = Color.White;
            lblbname.Location = new Point(167, 92);
            lblbname.Margin = new Padding(4, 0, 4, 0);
            lblbname.Name = "lblbname";
            lblbname.Size = new Size(82, 32);
            lblbname.TabIndex = 21;
            lblbname.Text = "Name";
           
            // 
            // cmbBedType
            // 
            cmbBedType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbBedType.FormattingEnabled = true;
            cmbBedType.Items.AddRange(new object[] { "Please Select", "Single", "Double", "Tiple" });
            cmbBedType.Location = new Point(596, 312);
            cmbBedType.Name = "cmbBedType";
            cmbBedType.Size = new Size(241, 40);
            cmbBedType.TabIndex = 8;
            cmbBedType.Validating += cmbPreference_Validating;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.FromArgb(128, 128, 255);
            lblAddress.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.ForeColor = Color.White;
            lblAddress.Location = new Point(596, 86);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(105, 32);
            lblAddress.TabIndex = 39;
            lblAddress.Text = "Address";
           
            // 
            // rtxtAddress
            // 
            rtxtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rtxtAddress.Location = new Point(596, 121);
            rtxtAddress.Name = "rtxtAddress";
            rtxtAddress.Size = new Size(241, 38);
            rtxtAddress.TabIndex = 7;
            rtxtAddress.Tag = "";
            rtxtAddress.Text = "";
            rtxtAddress.Enter += Control_Enter;
            rtxtAddress.KeyPress += Control_KeyPress;
            rtxtAddress.Leave += Control_Leave;
            // 
            // txtRoomNo
            // 
            txtRoomNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtRoomNo.Location = new Point(596, 638);
            txtRoomNo.Margin = new Padding(4, 5, 4, 5);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.Size = new Size(241, 37);
            txtRoomNo.TabIndex = 10;
            txtRoomNo.Tag = "int";
            txtRoomNo.Enter += Control_Enter;
            txtRoomNo.KeyPress += Control_KeyPress;
            txtRoomNo.Leave += Control_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1022, 831);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 42;
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.BackColor = Color.FromArgb(128, 128, 255);
            lblRoomNo.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoomNo.ForeColor = Color.White;
            lblRoomNo.Location = new Point(596, 598);
            lblRoomNo.Margin = new Padding(4, 0, 4, 0);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(126, 32);
            lblRoomNo.TabIndex = 43;
            lblRoomNo.Text = "Room_No";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.FromArgb(128, 128, 255);
            lblGender.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.ForeColor = Color.White;
            lblGender.Location = new Point(166, 380);
            lblGender.Margin = new Padding(4, 0, 4, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(98, 32);
            lblGender.TabIndex = 45;
            lblGender.Text = "Gender";
          
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cmbGender.Location = new Point(166, 418);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(241, 38);
            cmbGender.TabIndex = 4;
            // 
            // dtpDOB
            // 
            dtpDOB.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDOB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDOB.Location = new Point(166, 532);
            dtpDOB.Margin = new Padding(4, 5, 4, 5);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(241, 39);
            dtpDOB.TabIndex = 5;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.BackColor = Color.FromArgb(128, 128, 255);
            lblDOB.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDOB.ForeColor = Color.White;
            lblDOB.Location = new Point(166, 491);
            lblDOB.Margin = new Padding(4, 0, 4, 0);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(167, 32);
            lblDOB.TabIndex = 48;
            lblDOB.Text = "Date Of Birth";
            
            // 
            // lblIdProof
            // 
            lblIdProof.AutoSize = true;
            lblIdProof.BackColor = Color.FromArgb(128, 128, 255);
            lblIdProof.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdProof.ForeColor = Color.White;
            lblIdProof.Location = new Point(166, 598);
            lblIdProof.Margin = new Padding(4, 0, 4, 0);
            lblIdProof.Name = "lblIdProof";
            lblIdProof.Size = new Size(112, 32);
            lblIdProof.TabIndex = 49;
            lblIdProof.Text = "ID_Proof";
            lblIdProof.Click += lblIdProof_Click;
            // 
            // txtIdProof
            // 
            txtIdProof.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdProof.Location = new Point(166, 635);
            txtIdProof.Margin = new Padding(4, 5, 4, 5);
            txtIdProof.Name = "txtIdProof";
            txtIdProof.Size = new Size(241, 37);
            txtIdProof.TabIndex = 6;
            txtIdProof.Tag = "string";
            txtIdProof.Enter += Control_Enter;
            txtIdProof.KeyPress += Control_KeyPress;
            txtIdProof.Leave += Control_Leave;
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.BackColor = Color.FromArgb(128, 128, 255);
            lblCheckIn.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCheckIn.ForeColor = Color.White;
            lblCheckIn.Location = new Point(596, 389);
            lblCheckIn.Margin = new Padding(4, 0, 4, 0);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(114, 32);
            lblCheckIn.TabIndex = 50;
            lblCheckIn.Text = "Check In";
           //
            // dtpCheckIn
            // 
            dtpCheckIn.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpCheckIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpCheckIn.Location = new Point(596, 426);
            dtpCheckIn.Margin = new Padding(4, 5, 4, 5);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(241, 39);
            dtpCheckIn.TabIndex = 51;
            // 
            // cmbType
            // 
            cmbType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Please Select", "AC", "Non-AC" });
            cmbType.Location = new Point(596, 213);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(241, 40);
            cmbType.TabIndex = 55;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.BackColor = Color.FromArgb(128, 128, 255);
            lblType.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.ForeColor = Color.White;
            lblType.Location = new Point(596, 176);
            lblType.Margin = new Padding(4, 0, 4, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(145, 32);
            lblType.TabIndex = 56;
            lblType.Text = "Room Type";
           //
            // btnBookRoom
            // 
            btnBookRoom.BackColor = Color.Transparent;
            btnBookRoom.BorderRadius = 22;
            btnBookRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnBookRoom.CustomizableEdges = customizableEdges55;
            btnBookRoom.DisabledState.BorderColor = Color.DarkGray;
            btnBookRoom.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBookRoom.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBookRoom.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBookRoom.FillColor = Color.FromArgb(0, 192, 192);
            btnBookRoom.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBookRoom.ForeColor = Color.Black;
            btnBookRoom.Location = new Point(330, 770);
            btnBookRoom.Name = "btnBookRoom";
            btnBookRoom.ShadowDecoration.CustomizableEdges = customizableEdges56;
            btnBookRoom.Size = new Size(277, 54);
            btnBookRoom.TabIndex = 57;
            btnBookRoom.Text = "Book";
            btnBookRoom.Click += btnBookRoom_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Transparent;
            btnClear.BorderRadius = 22;
            btnClear.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnClear.CustomizableEdges = customizableEdges57;
            btnClear.DisabledState.BorderColor = Color.DarkGray;
            btnClear.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClear.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClear.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClear.FillColor = Color.FromArgb(0, 192, 192);
            btnClear.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(623, 770);
            btnClear.Name = "btnClear";
            btnClear.ShadowDecoration.CustomizableEdges = customizableEdges58;
            btnClear.Size = new Size(277, 54);
            btnClear.TabIndex = 58;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BorderRadius = 22;
            btnCancel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCancel.CustomizableEdges = customizableEdges59;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(0, 192, 192);
            btnCancel.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(908, 770);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges60;
            btnCancel.Size = new Size(277, 54);
            btnCancel.TabIndex = 59;
            btnCancel.Text = "Back";
            btnCancel.Click += btnCancel_Click;
            // 
            // BookRoom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 192, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1278, 744);
            Controls.Add(btnCancel);
            Controls.Add(btnClear);
            Controls.Add(btnBookRoom);
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
            Controls.Add(label2);
            Controls.Add(rtxtAddress);
            Controls.Add(lblAddress);
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
            Name = "BookRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookRoom";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPrice;
        private Label lblprice;
        private Label lblBedType;
        private TextBox txtNationality;
        private Label lblNationality;
        private TextBox txtContact;
        private TextBox txtName;
        private Label lblContactNo;
        private Label lblbname;
        private ComboBox cmbBedType;
        private Label lblAddress;
        private RichTextBox rtxtAddress;
        private TextBox txtRoomNo;
        private Label label2;
        private Label lblRoomNo;
        private Label lblGender;
        private ComboBox cmbGender;
        private DateTimePicker dtpDOB;
        private Label lblDOB;
        private Label lblIdProof;
        private TextBox txtIdProof;
        private Label lblCheckIn;
        private DateTimePicker dtpCheckIn;
    
       
       
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        
        private DataGridViewTextBoxColumn Column11;
        private ComboBox cmbType;
        private Label lblType;
        private Guna.UI2.WinForms.Guna2Button btnBookRoom;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}