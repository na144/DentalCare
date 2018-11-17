namespace DentalCare
{
    partial class ReceptionistView
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
            this.pnlNavReceptionist = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblReceptionistUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReceptionistMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewBookingStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seePatientListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dentalStaffsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPatientList = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewPatientList = new System.Windows.Forms.DataGridView();
            this.pnlAddBooking = new System.Windows.Forms.Panel();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.lblClientname = new System.Windows.Forms.Label();
            this.txb3 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.gbxMakeBooking = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnSubmitMakeBooking = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExaminationType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFirstNameMakeBooking = new System.Windows.Forms.Label();
            this.lblLastNameMakeBooking = new System.Windows.Forms.Label();
            this.btnSearchPatientMakeBooking = new System.Windows.Forms.Button();
            this.txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlNavReceptionist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ReceptionistMenuStrip.SuspendLayout();
            this.pnlPatientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientList)).BeginInit();
            this.pnlAddBooking.SuspendLayout();
            this.gbxMakeBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavReceptionist
            // 
            this.pnlNavReceptionist.BackColor = System.Drawing.Color.White;
            this.pnlNavReceptionist.Controls.Add(this.pictureBox1);
            this.pnlNavReceptionist.Controls.Add(this.lblReceptionistUser);
            this.pnlNavReceptionist.Controls.Add(this.label1);
            this.pnlNavReceptionist.Controls.Add(this.ReceptionistMenuStrip);
            this.pnlNavReceptionist.Location = new System.Drawing.Point(-4, 1);
            this.pnlNavReceptionist.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNavReceptionist.Name = "pnlNavReceptionist";
            this.pnlNavReceptionist.Size = new System.Drawing.Size(877, 137);
            this.pnlNavReceptionist.TabIndex = 0;
            this.pnlNavReceptionist.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNavReceptionist_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DentalCare.Properties.Resources.Logo7;
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblReceptionistUser
            // 
            this.lblReceptionistUser.AutoSize = true;
            this.lblReceptionistUser.Location = new System.Drawing.Point(676, 10);
            this.lblReceptionistUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceptionistUser.Name = "lblReceptionistUser";
            this.lblReceptionistUser.Size = new System.Drawing.Size(46, 17);
            this.lblReceptionistUser.TabIndex = 2;
            this.lblReceptionistUser.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Signed in as:";
            // 
            // ReceptionistMenuStrip
            // 
            this.ReceptionistMenuStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ReceptionistMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ReceptionistMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ReceptionistMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainPageToolStripMenuItem,
            this.appointmentsToolStripMenuItem,
            this.patientsToolStripMenuItem,
            this.dentalStaffsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.ReceptionistMenuStrip.Location = new System.Drawing.Point(4, 107);
            this.ReceptionistMenuStrip.MinimumSize = new System.Drawing.Size(867, 30);
            this.ReceptionistMenuStrip.Name = "ReceptionistMenuStrip";
            this.ReceptionistMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.ReceptionistMenuStrip.Size = new System.Drawing.Size(867, 30);
            this.ReceptionistMenuStrip.TabIndex = 0;
            this.ReceptionistMenuStrip.Text = "menuStrip1";
            // 
            // mainPageToolStripMenuItem
            // 
            this.mainPageToolStripMenuItem.Name = "mainPageToolStripMenuItem";
            this.mainPageToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
            this.mainPageToolStripMenuItem.Text = "Main Page";
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.NewBookingStripMenuItem});
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // NewBookingStripMenuItem
            // 
            this.NewBookingStripMenuItem.Name = "NewBookingStripMenuItem";
            this.NewBookingStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.NewBookingStripMenuItem.Text = "New booking";
            this.NewBookingStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPatientToolStripMenuItem,
            this.seePatientListToolStripMenuItem});
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(72, 26);
            this.patientsToolStripMenuItem.Text = "Patients";
            // 
            // addNewPatientToolStripMenuItem
            // 
            this.addNewPatientToolStripMenuItem.Name = "addNewPatientToolStripMenuItem";
            this.addNewPatientToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.addNewPatientToolStripMenuItem.Text = "Add New Patient";
            this.addNewPatientToolStripMenuItem.Click += new System.EventHandler(this.addNewPatientToolStripMenuItem_Click);
            // 
            // seePatientListToolStripMenuItem
            // 
            this.seePatientListToolStripMenuItem.Name = "seePatientListToolStripMenuItem";
            this.seePatientListToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.seePatientListToolStripMenuItem.Text = "See Patient List";
            this.seePatientListToolStripMenuItem.Click += new System.EventHandler(this.seePatientListToolStripMenuItem_Click);
            // 
            // dentalStaffsToolStripMenuItem
            // 
            this.dentalStaffsToolStripMenuItem.Name = "dentalStaffsToolStripMenuItem";
            this.dentalStaffsToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.dentalStaffsToolStripMenuItem.Text = "Dental Staffs";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // pnlPatientList
            // 
            this.pnlPatientList.Controls.Add(this.label8);
            this.pnlPatientList.Controls.Add(this.comboBox2);
            this.pnlPatientList.Controls.Add(this.btnSearchPatient);
            this.pnlPatientList.Controls.Add(this.txtSearchPatient);
            this.pnlPatientList.Controls.Add(this.label7);
            this.pnlPatientList.Controls.Add(this.dataGridViewPatientList);
            this.pnlPatientList.Location = new System.Drawing.Point(0, 142);
            this.pnlPatientList.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPatientList.Name = "pnlPatientList";
            this.pnlPatientList.Size = new System.Drawing.Size(867, 481);
            this.pnlPatientList.TabIndex = 6;
            this.pnlPatientList.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Sort by:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Last Name",
            "First Name",
            "Date of Birth"});
            this.comboBox2.Location = new System.Drawing.Point(540, 22);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Location = new System.Drawing.Point(268, 18);
            this.btnSearchPatient.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(100, 28);
            this.btnSearchPatient.TabIndex = 3;
            this.btnSearchPatient.Text = "Search";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.Location = new System.Drawing.Point(127, 21);
            this.txtSearchPatient.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(132, 22);
            this.txtSearchPatient.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Date of Birth:";
            // 
            // dataGridViewPatientList
            // 
            this.dataGridViewPatientList.AllowUserToAddRows = false;
            this.dataGridViewPatientList.AllowUserToDeleteRows = false;
            this.dataGridViewPatientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatientList.Location = new System.Drawing.Point(87, 96);
            this.dataGridViewPatientList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPatientList.Name = "dataGridViewPatientList";
            this.dataGridViewPatientList.ReadOnly = true;
            this.dataGridViewPatientList.Size = new System.Drawing.Size(671, 352);
            this.dataGridViewPatientList.TabIndex = 0;
            // 
            // pnlAddBooking
            // 
            this.pnlAddBooking.Controls.Add(this.txtClientID);
            this.pnlAddBooking.Controls.Add(this.lblClientname);
            this.pnlAddBooking.Controls.Add(this.txb3);
            this.pnlAddBooking.Controls.Add(this.txb2);
            this.pnlAddBooking.Controls.Add(this.gbxMakeBooking);
            this.pnlAddBooking.Controls.Add(this.lblFirstNameMakeBooking);
            this.pnlAddBooking.Controls.Add(this.lblLastNameMakeBooking);
            this.pnlAddBooking.Controls.Add(this.btnSearchPatientMakeBooking);
            this.pnlAddBooking.Controls.Add(this.txb);
            this.pnlAddBooking.Controls.Add(this.label2);
            this.pnlAddBooking.Location = new System.Drawing.Point(4, 137);
            this.pnlAddBooking.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddBooking.Name = "pnlAddBooking";
            this.pnlAddBooking.Size = new System.Drawing.Size(863, 482);
            this.pnlAddBooking.TabIndex = 7;
            this.pnlAddBooking.Visible = false;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(704, 59);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(117, 22);
            this.txtClientID.TabIndex = 17;
            // 
            // lblClientname
            // 
            this.lblClientname.AutoSize = true;
            this.lblClientname.Location = new System.Drawing.Point(637, 59);
            this.lblClientname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientname.Name = "lblClientname";
            this.lblClientname.Size = new System.Drawing.Size(64, 17);
            this.lblClientname.TabIndex = 16;
            this.lblClientname.Text = "Client ID:";
            // 
            // txb3
            // 
            this.txb3.Location = new System.Drawing.Point(704, 33);
            this.txb3.Margin = new System.Windows.Forms.Padding(4);
            this.txb3.Name = "txb3";
            this.txb3.Size = new System.Drawing.Size(117, 22);
            this.txb3.TabIndex = 15;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(704, 9);
            this.txb2.Margin = new System.Windows.Forms.Padding(4);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(117, 22);
            this.txb2.TabIndex = 14;
            // 
            // gbxMakeBooking
            // 
            this.gbxMakeBooking.Controls.Add(this.lblTime);
            this.gbxMakeBooking.Controls.Add(this.txtTime);
            this.gbxMakeBooking.Controls.Add(this.txtDate);
            this.gbxMakeBooking.Controls.Add(this.txtNotes);
            this.gbxMakeBooking.Controls.Add(this.btnSubmitMakeBooking);
            this.gbxMakeBooking.Controls.Add(this.label6);
            this.gbxMakeBooking.Controls.Add(this.label5);
            this.gbxMakeBooking.Controls.Add(this.txtExaminationType);
            this.gbxMakeBooking.Controls.Add(this.label4);
            this.gbxMakeBooking.Controls.Add(this.txtEmployeeID);
            this.gbxMakeBooking.Controls.Add(this.label3);
            this.gbxMakeBooking.Location = new System.Drawing.Point(36, 97);
            this.gbxMakeBooking.Margin = new System.Windows.Forms.Padding(4);
            this.gbxMakeBooking.Name = "gbxMakeBooking";
            this.gbxMakeBooking.Padding = new System.Windows.Forms.Padding(4);
            this.gbxMakeBooking.Size = new System.Drawing.Size(809, 327);
            this.gbxMakeBooking.TabIndex = 5;
            this.gbxMakeBooking.TabStop = false;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(152, 71);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(171, 22);
            this.txtDate.TabIndex = 14;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(405, 54);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(380, 200);
            this.txtNotes.TabIndex = 13;
            // 
            // btnSubmitMakeBooking
            // 
            this.btnSubmitMakeBooking.Location = new System.Drawing.Point(241, 206);
            this.btnSubmitMakeBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitMakeBooking.Name = "btnSubmitMakeBooking";
            this.btnSubmitMakeBooking.Size = new System.Drawing.Size(82, 28);
            this.btnSubmitMakeBooking.TabIndex = 6;
            this.btnSubmitMakeBooking.Text = "Submit";
            this.btnSubmitMakeBooking.UseVisualStyleBackColor = true;
            this.btnSubmitMakeBooking.Click += new System.EventHandler(this.btnSubmitMakeBooking_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Additional Notes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Examination Type:";
            // 
            // txtExaminationType
            // 
            this.txtExaminationType.Location = new System.Drawing.Point(152, 112);
            this.txtExaminationType.Margin = new System.Windows.Forms.Padding(4);
            this.txtExaminationType.Name = "txtExaminationType";
            this.txtExaminationType.Size = new System.Drawing.Size(171, 22);
            this.txtExaminationType.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Appointment Date:";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(152, 30);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(171, 22);
            this.txtEmployeeID.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dentist:";
            // 
            // lblFirstNameMakeBooking
            // 
            this.lblFirstNameMakeBooking.AutoSize = true;
            this.lblFirstNameMakeBooking.Location = new System.Drawing.Point(621, 12);
            this.lblFirstNameMakeBooking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstNameMakeBooking.Name = "lblFirstNameMakeBooking";
            this.lblFirstNameMakeBooking.Size = new System.Drawing.Size(80, 17);
            this.lblFirstNameMakeBooking.TabIndex = 4;
            this.lblFirstNameMakeBooking.Text = "First Name:";
            // 
            // lblLastNameMakeBooking
            // 
            this.lblLastNameMakeBooking.AutoSize = true;
            this.lblLastNameMakeBooking.Location = new System.Drawing.Point(621, 33);
            this.lblLastNameMakeBooking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastNameMakeBooking.Name = "lblLastNameMakeBooking";
            this.lblLastNameMakeBooking.Size = new System.Drawing.Size(80, 17);
            this.lblLastNameMakeBooking.TabIndex = 3;
            this.lblLastNameMakeBooking.Text = "Last Name:";
            // 
            // btnSearchPatientMakeBooking
            // 
            this.btnSearchPatientMakeBooking.Location = new System.Drawing.Point(441, 48);
            this.btnSearchPatientMakeBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchPatientMakeBooking.Name = "btnSearchPatientMakeBooking";
            this.btnSearchPatientMakeBooking.Size = new System.Drawing.Size(87, 28);
            this.btnSearchPatientMakeBooking.TabIndex = 2;
            this.btnSearchPatientMakeBooking.Text = "Search";
            this.btnSearchPatientMakeBooking.UseVisualStyleBackColor = true;
            this.btnSearchPatientMakeBooking.Click += new System.EventHandler(this.btnSearchPatientMakeBooking_Click_1);
            // 
            // txb
            // 
            this.txb.Location = new System.Drawing.Point(440, 16);
            this.txb.Margin = new System.Windows.Forms.Padding(4);
            this.txb.Name = "txb";
            this.txb.Size = new System.Drawing.Size(155, 22);
            this.txb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date of Birth:";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(152, 157);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(171, 22);
            this.txtTime.TabIndex = 15;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(98, 160);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 17);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "Time:";
            // 
            // ReceptionistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 624);
            this.Controls.Add(this.pnlAddBooking);
            this.Controls.Add(this.pnlNavReceptionist);
            this.Controls.Add(this.pnlPatientList);
            this.MainMenuStrip = this.ReceptionistMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReceptionistView";
            this.Text = "DentalCare";
            this.Load += new System.EventHandler(this.ReceptionistView_Load);
            this.pnlNavReceptionist.ResumeLayout(false);
            this.pnlNavReceptionist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ReceptionistMenuStrip.ResumeLayout(false);
            this.ReceptionistMenuStrip.PerformLayout();
            this.pnlPatientList.ResumeLayout(false);
            this.pnlPatientList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientList)).EndInit();
            this.pnlAddBooking.ResumeLayout(false);
            this.pnlAddBooking.PerformLayout();
            this.gbxMakeBooking.ResumeLayout(false);
            this.gbxMakeBooking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavReceptionist;
        private System.Windows.Forms.MenuStrip ReceptionistMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewBookingStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblReceptionistUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dentalStaffsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlPatientList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.TextBox txtSearchPatient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewPatientList;
        private System.Windows.Forms.ToolStripMenuItem addNewPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seePatientListToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAddBooking;
        private System.Windows.Forms.GroupBox gbxMakeBooking;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSubmitMakeBooking;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExaminationType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFirstNameMakeBooking;
        private System.Windows.Forms.Label lblLastNameMakeBooking;
        private System.Windows.Forms.Button btnSearchPatientMakeBooking;
        private System.Windows.Forms.TextBox txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb3;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label lblClientname;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
    }
}

