namespace HastaTakip.Forms
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            this.PB_PatientsType = new System.Windows.Forms.PictureBox();
            this.PB_PatientsGender = new System.Windows.Forms.PictureBox();
            this.PN_Patients = new System.Windows.Forms.Panel();
            this.LB_OwnerAdress = new System.Windows.Forms.Label();
            this.LB_PatientOwnerAdress = new System.Windows.Forms.Label();
            this.LB_PatientOwnerName = new System.Windows.Forms.Label();
            this.LB_PatientOwner = new System.Windows.Forms.Label();
            this.LB_PatientNames = new System.Windows.Forms.Label();
            this.LB_PHPatient = new System.Windows.Forms.Label();
            this.PN_About = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_About = new Bunifu.Framework.UI.BunifuTileButton();
            this.TB_PatientAbout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnTreatment = new Bunifu.Framework.UI.BunifuTileButton();
            this.TB_Treatment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Diagnosis = new System.Windows.Forms.TextBox();
            this.Btn_Di = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PatientsType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PatientsGender)).BeginInit();
            this.PN_Patients.SuspendLayout();
            this.PN_About.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_PatientsType
            // 
            this.PB_PatientsType.Image = ((System.Drawing.Image)(resources.GetObject("PB_PatientsType.Image")));
            this.PB_PatientsType.Location = new System.Drawing.Point(0, 0);
            this.PB_PatientsType.Margin = new System.Windows.Forms.Padding(0);
            this.PB_PatientsType.Name = "PB_PatientsType";
            this.PB_PatientsType.Size = new System.Drawing.Size(128, 128);
            this.PB_PatientsType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_PatientsType.TabIndex = 0;
            this.PB_PatientsType.TabStop = false;
            // 
            // PB_PatientsGender
            // 
            this.PB_PatientsGender.Image = ((System.Drawing.Image)(resources.GetObject("PB_PatientsGender.Image")));
            this.PB_PatientsGender.Location = new System.Drawing.Point(128, 7);
            this.PB_PatientsGender.Margin = new System.Windows.Forms.Padding(0);
            this.PB_PatientsGender.Name = "PB_PatientsGender";
            this.PB_PatientsGender.Size = new System.Drawing.Size(32, 32);
            this.PB_PatientsGender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_PatientsGender.TabIndex = 1;
            this.PB_PatientsGender.TabStop = false;
            // 
            // PN_Patients
            // 
            this.PN_Patients.Controls.Add(this.LB_OwnerAdress);
            this.PN_Patients.Controls.Add(this.LB_PatientOwnerAdress);
            this.PN_Patients.Controls.Add(this.LB_PatientOwnerName);
            this.PN_Patients.Controls.Add(this.LB_PatientOwner);
            this.PN_Patients.Controls.Add(this.LB_PatientNames);
            this.PN_Patients.Controls.Add(this.LB_PHPatient);
            this.PN_Patients.Controls.Add(this.PB_PatientsType);
            this.PN_Patients.Controls.Add(this.PB_PatientsGender);
            this.PN_Patients.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Patients.Location = new System.Drawing.Point(0, 0);
            this.PN_Patients.Margin = new System.Windows.Forms.Padding(32);
            this.PN_Patients.Name = "PN_Patients";
            this.PN_Patients.Padding = new System.Windows.Forms.Padding(32);
            this.PN_Patients.Size = new System.Drawing.Size(720, 128);
            this.PN_Patients.TabIndex = 2;
            // 
            // LB_OwnerAdress
            // 
            this.LB_OwnerAdress.AutoSize = true;
            this.LB_OwnerAdress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LB_OwnerAdress.Location = new System.Drawing.Point(226, 69);
            this.LB_OwnerAdress.Name = "LB_OwnerAdress";
            this.LB_OwnerAdress.Size = new System.Drawing.Size(494, 30);
            this.LB_OwnerAdress.TabIndex = 7;
            this.LB_OwnerAdress.Text = "Ahatlı Mahallesi 3143. Sokak  Bina No:20 Daire No:3";
            // 
            // LB_PatientOwnerAdress
            // 
            this.LB_PatientOwnerAdress.AutoSize = true;
            this.LB_PatientOwnerAdress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LB_PatientOwnerAdress.Location = new System.Drawing.Point(163, 69);
            this.LB_PatientOwnerAdress.Name = "LB_PatientOwnerAdress";
            this.LB_PatientOwnerAdress.Size = new System.Drawing.Size(71, 30);
            this.LB_PatientOwnerAdress.TabIndex = 6;
            this.LB_PatientOwnerAdress.Text = "Adres:";
            // 
            // LB_PatientOwnerName
            // 
            this.LB_PatientOwnerName.AutoSize = true;
            this.LB_PatientOwnerName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LB_PatientOwnerName.Location = new System.Drawing.Point(288, 39);
            this.LB_PatientOwnerName.Name = "LB_PatientOwnerName";
            this.LB_PatientOwnerName.Size = new System.Drawing.Size(143, 30);
            this.LB_PatientOwnerName.TabIndex = 5;
            this.LB_PatientOwnerName.Text = "Necmi Kutbay";
            // 
            // LB_PatientOwner
            // 
            this.LB_PatientOwner.AutoSize = true;
            this.LB_PatientOwner.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LB_PatientOwner.Location = new System.Drawing.Point(163, 39);
            this.LB_PatientOwner.Name = "LB_PatientOwner";
            this.LB_PatientOwner.Size = new System.Drawing.Size(133, 30);
            this.LB_PatientOwner.TabIndex = 4;
            this.LB_PatientOwner.Text = "Hasta Sahibi:";
            // 
            // LB_PatientNames
            // 
            this.LB_PatientNames.AutoSize = true;
            this.LB_PatientNames.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LB_PatientNames.Location = new System.Drawing.Point(264, 9);
            this.LB_PatientNames.Name = "LB_PatientNames";
            this.LB_PatientNames.Size = new System.Drawing.Size(59, 30);
            this.LB_PatientNames.TabIndex = 3;
            this.LB_PatientNames.Text = "Yırtık";
            // 
            // LB_PHPatient
            // 
            this.LB_PHPatient.AutoSize = true;
            this.LB_PHPatient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LB_PHPatient.Location = new System.Drawing.Point(163, 9);
            this.LB_PHPatient.Name = "LB_PHPatient";
            this.LB_PHPatient.Size = new System.Drawing.Size(108, 30);
            this.LB_PHPatient.TabIndex = 2;
            this.LB_PHPatient.Text = "Hasta Adı:";
            // 
            // PN_About
            // 
            this.PN_About.Controls.Add(this.panel3);
            this.PN_About.Controls.Add(this.panel1);
            this.PN_About.Controls.Add(this.TB_PatientAbout);
            this.PN_About.Controls.Add(this.label1);
            this.PN_About.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_About.Location = new System.Drawing.Point(0, 128);
            this.PN_About.Name = "PN_About";
            this.PN_About.Size = new System.Drawing.Size(720, 128);
            this.PN_About.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 98);
            this.panel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_About);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(656, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 98);
            this.panel1.TabIndex = 2;
            // 
            // Btn_About
            // 
            this.Btn_About.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_About.color = System.Drawing.Color.SeaGreen;
            this.Btn_About.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Btn_About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_About.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Btn_About.ForeColor = System.Drawing.Color.White;
            this.Btn_About.Image = ((System.Drawing.Image)(resources.GetObject("Btn_About.Image")));
            this.Btn_About.ImagePosition = 8;
            this.Btn_About.ImageZoom = 64;
            this.Btn_About.LabelPosition = 0;
            this.Btn_About.LabelText = "";
            this.Btn_About.Location = new System.Drawing.Point(0, 66);
            this.Btn_About.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_About.Name = "Btn_About";
            this.Btn_About.Size = new System.Drawing.Size(32, 32);
            this.Btn_About.TabIndex = 0;
            this.Btn_About.Click += new System.EventHandler(this.Btn_About_Click);
            // 
            // TB_PatientAbout
            // 
            this.TB_PatientAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_PatientAbout.Enabled = false;
            this.TB_PatientAbout.Location = new System.Drawing.Point(0, 30);
            this.TB_PatientAbout.Multiline = true;
            this.TB_PatientAbout.Name = "TB_PatientAbout";
            this.TB_PatientAbout.Size = new System.Drawing.Size(720, 98);
            this.TB_PatientAbout.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(64, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(301, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Hakkında Notlar";
            this.label1.UseMnemonic = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 458);
            this.panel2.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnTreatment, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TB_Treatment, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TB_Diagnosis, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Di, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 458);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // BtnTreatment
            // 
            this.BtnTreatment.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnTreatment.color = System.Drawing.Color.SeaGreen;
            this.BtnTreatment.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.BtnTreatment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTreatment.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.BtnTreatment.ForeColor = System.Drawing.Color.White;
            this.BtnTreatment.Image = ((System.Drawing.Image)(resources.GetObject("BtnTreatment.Image")));
            this.BtnTreatment.ImagePosition = 8;
            this.BtnTreatment.ImageZoom = 64;
            this.BtnTreatment.LabelPosition = 0;
            this.BtnTreatment.LabelText = "";
            this.BtnTreatment.Location = new System.Drawing.Point(682, 387);
            this.BtnTreatment.Margin = new System.Windows.Forms.Padding(6);
            this.BtnTreatment.Name = "BtnTreatment";
            this.BtnTreatment.Size = new System.Drawing.Size(32, 32);
            this.BtnTreatment.TabIndex = 4;
            this.BtnTreatment.Click += new System.EventHandler(this.BtnTreatment_Click);
            // 
            // TB_Treatment
            // 
            this.TB_Treatment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Treatment.Enabled = false;
            this.TB_Treatment.Location = new System.Drawing.Point(363, 79);
            this.TB_Treatment.Multiline = true;
            this.TB_Treatment.Name = "TB_Treatment";
            this.TB_Treatment.Size = new System.Drawing.Size(354, 299);
            this.TB_Treatment.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(360, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(128, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(203, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tedavi";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(128, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(199, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Teşhis";
            // 
            // TB_Diagnosis
            // 
            this.TB_Diagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Diagnosis.Enabled = false;
            this.TB_Diagnosis.Location = new System.Drawing.Point(3, 79);
            this.TB_Diagnosis.Multiline = true;
            this.TB_Diagnosis.Name = "TB_Diagnosis";
            this.TB_Diagnosis.Size = new System.Drawing.Size(354, 299);
            this.TB_Diagnosis.TabIndex = 2;
            // 
            // Btn_Di
            // 
            this.Btn_Di.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Di.color = System.Drawing.Color.SeaGreen;
            this.Btn_Di.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Di.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Di.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Btn_Di.ForeColor = System.Drawing.Color.White;
            this.Btn_Di.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Di.Image")));
            this.Btn_Di.ImagePosition = 8;
            this.Btn_Di.ImageZoom = 64;
            this.Btn_Di.LabelPosition = 0;
            this.Btn_Di.LabelText = "";
            this.Btn_Di.Location = new System.Drawing.Point(322, 387);
            this.Btn_Di.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Di.Name = "Btn_Di";
            this.Btn_Di.Size = new System.Drawing.Size(32, 32);
            this.Btn_Di.TabIndex = 6;
            this.Btn_Di.Click += new System.EventHandler(this.Btn_Di_Click);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 714);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PN_About);
            this.Controls.Add(this.PN_Patients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patients";
            this.Text = "Patients";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.PB_PatientsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PatientsGender)).EndInit();
            this.PN_Patients.ResumeLayout(false);
            this.PN_Patients.PerformLayout();
            this.PN_About.ResumeLayout(false);
            this.PN_About.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_PatientsType;
        private System.Windows.Forms.PictureBox PB_PatientsGender;
        private System.Windows.Forms.Panel PN_Patients;
        private System.Windows.Forms.Label LB_PHPatient;
        private System.Windows.Forms.Label LB_PatientNames;
        private System.Windows.Forms.Label LB_PatientOwnerName;
        private System.Windows.Forms.Label LB_PatientOwner;
        private System.Windows.Forms.Label LB_OwnerAdress;
        private System.Windows.Forms.Label LB_PatientOwnerAdress;
        private System.Windows.Forms.Panel PN_About;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_PatientAbout;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton Btn_About;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuTileButton BtnTreatment;
        private System.Windows.Forms.TextBox TB_Treatment;
        private System.Windows.Forms.TextBox TB_Diagnosis;
        private Bunifu.Framework.UI.BunifuTileButton Btn_Di;
    }
}