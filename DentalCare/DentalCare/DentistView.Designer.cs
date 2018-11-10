using System;

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
            this.pnlNavReceptionist = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblReceptionistUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReceptionistMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pnlNavReceptionist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ReceptionistMenuStrip.SuspendLayout();
            this.pnlPatientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientList)).BeginInit();
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
            this.viewToolStripMenuItem});
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.viewToolStripMenuItem.Text = "View";
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
            this.pnlPatientList.Location = new System.Drawing.Point(0, 139);
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
            // DentistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 624);
            this.Controls.Add(this.pnlNavReceptionist);
            this.Controls.Add(this.pnlPatientList);
            this.MainMenuStrip = this.ReceptionistMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DentistView";
            this.Text = "DentalCare";
            this.Load += new System.EventHandler(this.DentistView_Load);
            this.pnlNavReceptionist.ResumeLayout(false);
            this.pnlNavReceptionist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ReceptionistMenuStrip.ResumeLayout(false);
            this.ReceptionistMenuStrip.PerformLayout();
            this.pnlPatientList.ResumeLayout(false);
            this.pnlPatientList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientList)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Panel pnlNavReceptionist;
        private System.Windows.Forms.MenuStrip ReceptionistMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
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
    }
}