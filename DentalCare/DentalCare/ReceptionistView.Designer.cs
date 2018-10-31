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
            this.pnlAddBooking = new System.Windows.Forms.Panel();
            this.pnlPatientList = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnDateBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxMakeBooking = new System.Windows.Forms.GroupBox();
            this.btnSubmitMakeBooking = new System.Windows.Forms.Button();
            this.txtNotesMakeBooking = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFirstNameMakeBooking = new System.Windows.Forms.Label();
            this.lblLastNameMakeBooking = new System.Windows.Forms.Label();
            this.btnSearchPatientMakeBooking = new System.Windows.Forms.Button();
            this.txtSearchPatientMakeBooking = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNavReceptionist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ReceptionistMenuStrip.SuspendLayout();
            this.pnlAddBooking.SuspendLayout();
            this.pnlPatientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.pnlNavReceptionist.Location = new System.Drawing.Point(-3, 1);
            this.pnlNavReceptionist.Name = "pnlNavReceptionist";
            this.pnlNavReceptionist.Size = new System.Drawing.Size(658, 111);
            this.pnlNavReceptionist.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DentalCare.Properties.Resources.Logo7;
            this.pictureBox1.Location = new System.Drawing.Point(10, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblReceptionistUser
            // 
            this.lblReceptionistUser.AutoSize = true;
            this.lblReceptionistUser.Location = new System.Drawing.Point(507, 8);
            this.lblReceptionistUser.Name = "lblReceptionistUser";
            this.lblReceptionistUser.Size = new System.Drawing.Size(35, 13);
            this.lblReceptionistUser.TabIndex = 2;
            this.lblReceptionistUser.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Signed in as:";
            // 
            // ReceptionistMenuStrip
            // 
            this.ReceptionistMenuStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ReceptionistMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ReceptionistMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainPageToolStripMenuItem,
            this.appointmentsToolStripMenuItem,
            this.patientsToolStripMenuItem,
            this.dentalStaffsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.ReceptionistMenuStrip.Location = new System.Drawing.Point(3, 87);
            this.ReceptionistMenuStrip.MinimumSize = new System.Drawing.Size(650, 24);
            this.ReceptionistMenuStrip.Name = "ReceptionistMenuStrip";
            this.ReceptionistMenuStrip.Size = new System.Drawing.Size(650, 24);
            this.ReceptionistMenuStrip.TabIndex = 0;
            this.ReceptionistMenuStrip.Text = "menuStrip1";
            // 
            // mainPageToolStripMenuItem
            // 
            this.mainPageToolStripMenuItem.Name = "mainPageToolStripMenuItem";
            this.mainPageToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.mainPageToolStripMenuItem.Text = "Main Page";
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.NewBookingStripMenuItem});
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // NewBookingStripMenuItem
            // 
            this.NewBookingStripMenuItem.Name = "NewBookingStripMenuItem";
            this.NewBookingStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.NewBookingStripMenuItem.Text = "New booking";
            this.NewBookingStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPatientToolStripMenuItem,
            this.seePatientListToolStripMenuItem});
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.patientsToolStripMenuItem.Text = "Patients";
            // 
            // addNewPatientToolStripMenuItem
            // 
            this.addNewPatientToolStripMenuItem.Name = "addNewPatientToolStripMenuItem";
            this.addNewPatientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewPatientToolStripMenuItem.Text = "Add New Patient";
            // 
            // seePatientListToolStripMenuItem
            // 
            this.seePatientListToolStripMenuItem.Name = "seePatientListToolStripMenuItem";
            this.seePatientListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seePatientListToolStripMenuItem.Text = "See Patient List";
            this.seePatientListToolStripMenuItem.Click += new System.EventHandler(this.seePatientListToolStripMenuItem_Click);
            // 
            // dentalStaffsToolStripMenuItem
            // 
            this.dentalStaffsToolStripMenuItem.Name = "dentalStaffsToolStripMenuItem";
            this.dentalStaffsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.dentalStaffsToolStripMenuItem.Text = "Dental Staffs";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // pnlAddBooking
            // 
            this.pnlAddBooking.Controls.Add(this.gbxMakeBooking);
            this.pnlAddBooking.Controls.Add(this.lblFirstNameMakeBooking);
            this.pnlAddBooking.Controls.Add(this.lblLastNameMakeBooking);
            this.pnlAddBooking.Controls.Add(this.btnSearchPatientMakeBooking);
            this.pnlAddBooking.Controls.Add(this.txtSearchPatientMakeBooking);
            this.pnlAddBooking.Controls.Add(this.label2);
            this.pnlAddBooking.Location = new System.Drawing.Point(0, 115);
            this.pnlAddBooking.Name = "pnlAddBooking";
            this.pnlAddBooking.Size = new System.Drawing.Size(640, 392);
            this.pnlAddBooking.TabIndex = 1;
            this.pnlAddBooking.Visible = false;
            // 
            // pnlPatientList
            // 
            this.pnlPatientList.Controls.Add(this.label8);
            this.pnlPatientList.Controls.Add(this.comboBox2);
            this.pnlPatientList.Controls.Add(this.btnSearchPatient);
            this.pnlPatientList.Controls.Add(this.txtSearchPatient);
            this.pnlPatientList.Controls.Add(this.label7);
            this.pnlPatientList.Controls.Add(this.dataGridView1);
            this.pnlPatientList.Location = new System.Drawing.Point(0, 113);
            this.pnlPatientList.Name = "pnlPatientList";
            this.pnlPatientList.Size = new System.Drawing.Size(655, 391);
            this.pnlPatientList.TabIndex = 6;
            this.pnlPatientList.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
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
            this.comboBox2.Location = new System.Drawing.Point(405, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Location = new System.Drawing.Point(201, 15);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPatient.TabIndex = 3;
            this.btnSearchPatient.Text = "Search";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.Location = new System.Drawing.Point(95, 17);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(100, 20);
            this.txtSearchPatient.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Date of Birth:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDateBirth,
            this.ColumnFirstName,
            this.ColumnLastName});
            this.dataGridView1.Location = new System.Drawing.Point(65, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(503, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnDateBirth
            // 
            this.ColumnDateBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDateBirth.HeaderText = "Date of Birth";
            this.ColumnDateBirth.Name = "ColumnDateBirth";
            this.ColumnDateBirth.ReadOnly = true;
            // 
            // ColumnFirstName
            // 
            this.ColumnFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFirstName.HeaderText = "First Name";
            this.ColumnFirstName.Name = "ColumnFirstName";
            this.ColumnFirstName.ReadOnly = true;
            // 
            // ColumnLastName
            // 
            this.ColumnLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnLastName.HeaderText = "Last Name";
            this.ColumnLastName.Name = "ColumnLastName";
            this.ColumnLastName.ReadOnly = true;
            // 
            // gbxMakeBooking
            // 
            this.gbxMakeBooking.Controls.Add(this.btnSubmitMakeBooking);
            this.gbxMakeBooking.Controls.Add(this.txtNotesMakeBooking);
            this.gbxMakeBooking.Controls.Add(this.label6);
            this.gbxMakeBooking.Controls.Add(this.label5);
            this.gbxMakeBooking.Controls.Add(this.textBox2);
            this.gbxMakeBooking.Controls.Add(this.comboBox1);
            this.gbxMakeBooking.Controls.Add(this.label4);
            this.gbxMakeBooking.Controls.Add(this.textBox1);
            this.gbxMakeBooking.Controls.Add(this.label3);
            this.gbxMakeBooking.Location = new System.Drawing.Point(27, 79);
            this.gbxMakeBooking.Name = "gbxMakeBooking";
            this.gbxMakeBooking.Size = new System.Drawing.Size(607, 244);
            this.gbxMakeBooking.TabIndex = 5;
            this.gbxMakeBooking.TabStop = false;
            // 
            // btnSubmitMakeBooking
            // 
            this.btnSubmitMakeBooking.Location = new System.Drawing.Point(114, 184);
            this.btnSubmitMakeBooking.Name = "btnSubmitMakeBooking";
            this.btnSubmitMakeBooking.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitMakeBooking.TabIndex = 6;
            this.btnSubmitMakeBooking.Text = "Submit";
            this.btnSubmitMakeBooking.UseVisualStyleBackColor = true;
            // 
            // txtNotesMakeBooking
            // 
            this.txtNotesMakeBooking.Location = new System.Drawing.Point(304, 44);
            this.txtNotesMakeBooking.Multiline = true;
            this.txtNotesMakeBooking.Name = "txtNotesMakeBooking";
            this.txtNotesMakeBooking.Size = new System.Drawing.Size(286, 163);
            this.txtNotesMakeBooking.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Additional Notes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Examination Type";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Appointment Date:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dentist:";
            // 
            // lblFirstNameMakeBooking
            // 
            this.lblFirstNameMakeBooking.AutoSize = true;
            this.lblFirstNameMakeBooking.Location = new System.Drawing.Point(466, 10);
            this.lblFirstNameMakeBooking.Name = "lblFirstNameMakeBooking";
            this.lblFirstNameMakeBooking.Size = new System.Drawing.Size(60, 13);
            this.lblFirstNameMakeBooking.TabIndex = 4;
            this.lblFirstNameMakeBooking.Text = "First Name:";
            // 
            // lblLastNameMakeBooking
            // 
            this.lblLastNameMakeBooking.AutoSize = true;
            this.lblLastNameMakeBooking.Location = new System.Drawing.Point(466, 27);
            this.lblLastNameMakeBooking.Name = "lblLastNameMakeBooking";
            this.lblLastNameMakeBooking.Size = new System.Drawing.Size(61, 13);
            this.lblLastNameMakeBooking.TabIndex = 3;
            this.lblLastNameMakeBooking.Text = "Last Name:";
            // 
            // btnSearchPatientMakeBooking
            // 
            this.btnSearchPatientMakeBooking.Location = new System.Drawing.Point(331, 39);
            this.btnSearchPatientMakeBooking.Name = "btnSearchPatientMakeBooking";
            this.btnSearchPatientMakeBooking.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPatientMakeBooking.TabIndex = 2;
            this.btnSearchPatientMakeBooking.Text = "Search";
            this.btnSearchPatientMakeBooking.UseVisualStyleBackColor = true;
            // 
            // txtSearchPatientMakeBooking
            // 
            this.txtSearchPatientMakeBooking.Location = new System.Drawing.Point(331, 13);
            this.txtSearchPatientMakeBooking.Name = "txtSearchPatientMakeBooking";
            this.txtSearchPatientMakeBooking.Size = new System.Drawing.Size(129, 20);
            this.txtSearchPatientMakeBooking.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date of Birth:";
            // 
            // ReceptionistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 507);
            this.Controls.Add(this.pnlAddBooking);
            this.Controls.Add(this.pnlNavReceptionist);
            this.Controls.Add(this.pnlPatientList);
            this.MainMenuStrip = this.ReceptionistMenuStrip;
            this.Name = "ReceptionistView";
            this.Text = "DentalCare";
            this.Load += new System.EventHandler(this.ReceptionistView_Load);
            this.pnlNavReceptionist.ResumeLayout(false);
            this.pnlNavReceptionist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ReceptionistMenuStrip.ResumeLayout(false);
            this.ReceptionistMenuStrip.PerformLayout();
            this.pnlAddBooking.ResumeLayout(false);
            this.pnlAddBooking.PerformLayout();
            this.pnlPatientList.ResumeLayout(false);
            this.pnlPatientList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Panel pnlAddBooking;
        private System.Windows.Forms.GroupBox gbxMakeBooking;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFirstNameMakeBooking;
        private System.Windows.Forms.Label lblLastNameMakeBooking;
        private System.Windows.Forms.Button btnSearchPatientMakeBooking;
        private System.Windows.Forms.TextBox txtSearchPatientMakeBooking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlPatientList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.TextBox txtSearchPatient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastName;
        private System.Windows.Forms.Button btnSubmitMakeBooking;
        private System.Windows.Forms.TextBox txtNotesMakeBooking;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem addNewPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seePatientListToolStripMenuItem;
    }
}

