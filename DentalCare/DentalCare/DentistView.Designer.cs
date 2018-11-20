namespace DentalCare
{
    partial class DentistView
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
            this.pnlNavDentist = new System.Windows.Forms.Panel();
            this.lblDentistUser = new System.Windows.Forms.Label();
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
            this.patietList = new System.Windows.Forms.DataGridView();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNavDentist.SuspendLayout();
            this.ReceptionistMenuStrip.SuspendLayout();
            this.pnlAddBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patietList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavDentist
            // 
            this.pnlNavDentist.BackColor = System.Drawing.Color.White;
            this.pnlNavDentist.Controls.Add(this.pictureBox1);
            this.pnlNavDentist.Controls.Add(this.lblDentistUser);
            this.pnlNavDentist.Controls.Add(this.label1);
            this.pnlNavDentist.Controls.Add(this.ReceptionistMenuStrip);
            this.pnlNavDentist.Location = new System.Drawing.Point(-4, 0);
            this.pnlNavDentist.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNavDentist.Name = "pnlNavDentist";
            this.pnlNavDentist.Size = new System.Drawing.Size(877, 137);
            this.pnlNavDentist.TabIndex = 1;
            // 
            // lblDentistUser
            // 
            this.lblDentistUser.AutoSize = true;
            this.lblDentistUser.Location = new System.Drawing.Point(676, 10);
            this.lblDentistUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDentistUser.Name = "lblDentistUser";
            this.lblDentistUser.Size = new System.Drawing.Size(46, 17);
            this.lblDentistUser.TabIndex = 2;
            this.lblDentistUser.Text = "label2";
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
            // 
            // seePatientListToolStripMenuItem
            // 
            this.seePatientListToolStripMenuItem.Name = "seePatientListToolStripMenuItem";
            this.seePatientListToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.seePatientListToolStripMenuItem.Text = "See Patient List";
            // 
            // dentalStaffsToolStripMenuItem
            // 
            this.dentalStaffsToolStripMenuItem.Name = "dentalStaffsToolStripMenuItem";
            this.dentalStaffsToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.dentalStaffsToolStripMenuItem.Text = "Dental Staff";
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
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pnlAddBooking
            // 
            this.pnlAddBooking.Controls.Add(this.patietList);
            this.pnlAddBooking.Controls.Add(this.btnSearchPatient);
            this.pnlAddBooking.Controls.Add(this.txtSearchPatient);
            this.pnlAddBooking.Location = new System.Drawing.Point(6, 141);
            this.pnlAddBooking.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddBooking.Name = "pnlAddBooking";
            this.pnlAddBooking.Size = new System.Drawing.Size(867, 482);
            this.pnlAddBooking.TabIndex = 2;
            this.pnlAddBooking.Visible = false;
            // 
            // patietList
            // 
            this.patietList.AllowUserToAddRows = false;
            this.patietList.AllowUserToDeleteRows = false;
            this.patietList.BackgroundColor = System.Drawing.Color.White;
            this.patietList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patietList.Location = new System.Drawing.Point(196, 80);
            this.patietList.Name = "patietList";
            this.patietList.ReadOnly = true;
            this.patietList.RowTemplate.Height = 24;
            this.patietList.Size = new System.Drawing.Size(442, 224);
            this.patietList.TabIndex = 3;
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Location = new System.Drawing.Point(449, 39);
            this.btnSearchPatient.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(100, 28);
            this.btnSearchPatient.TabIndex = 2;
            this.btnSearchPatient.Text = "Search";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.Location = new System.Drawing.Point(251, 45);
            this.txtSearchPatient.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(179, 22);
            this.txtSearchPatient.TabIndex = 1;
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
            // DentistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 539);
            this.Controls.Add(this.pnlAddBooking);
            this.Controls.Add(this.pnlNavDentist);
            this.Name = "DentistView";
            this.Text = "DentistView";
            this.pnlNavDentist.ResumeLayout(false);
            this.pnlNavDentist.PerformLayout();
            this.ReceptionistMenuStrip.ResumeLayout(false);
            this.ReceptionistMenuStrip.PerformLayout();
            this.pnlAddBooking.ResumeLayout(false);
            this.pnlAddBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patietList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavDentist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip ReceptionistMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewBookingStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seePatientListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dentalStaffsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAddBooking;
        private System.Windows.Forms.DataGridView patietList;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.TextBox txtSearchPatient;
        public System.Windows.Forms.Label lblDentistUser;
    }
}