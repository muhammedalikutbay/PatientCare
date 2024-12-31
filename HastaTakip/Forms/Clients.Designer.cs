namespace HastaTakip.Forms
{
    partial class Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.DGW_Clients = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Add = new Bunifu.Framework.UI.BunifuTileButton();
            this.Btn_Delete = new Bunifu.Framework.UI.BunifuTileButton();
            this.Btn_Edit = new Bunifu.Framework.UI.BunifuTileButton();
            this.Txt_Refresh = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Clients)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(322, 185);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(120, 46);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Clients";
            // 
            // DGW_Clients
            // 
            this.DGW_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Clients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGW_Clients.Location = new System.Drawing.Point(0, 0);
            this.DGW_Clients.Name = "DGW_Clients";
            this.DGW_Clients.Size = new System.Drawing.Size(800, 450);
            this.DGW_Clients.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Txt_Refresh);
            this.panel1.Controls.Add(this.Btn_Delete);
            this.panel1.Controls.Add(this.Btn_Edit);
            this.panel1.Controls.Add(this.Btn_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 2;
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Add.color = System.Drawing.Color.SeaGreen;
            this.Btn_Add.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Btn_Add.ForeColor = System.Drawing.Color.White;
            this.Btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Add.Image")));
            this.Btn_Add.ImagePosition = 0;
            this.Btn_Add.ImageZoom = 64;
            this.Btn_Add.LabelPosition = 30;
            this.Btn_Add.LabelText = "Ekle";
            this.Btn_Add.Location = new System.Drawing.Point(43, 21);
            this.Btn_Add.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(64, 64);
            this.Btn_Add.TabIndex = 0;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Delete.color = System.Drawing.Color.SeaGreen;
            this.Btn_Delete.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Btn_Delete.ForeColor = System.Drawing.Color.White;
            this.Btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Delete.Image")));
            this.Btn_Delete.ImagePosition = 0;
            this.Btn_Delete.ImageZoom = 64;
            this.Btn_Delete.LabelPosition = 30;
            this.Btn_Delete.LabelText = "Sil";
            this.Btn_Delete.Location = new System.Drawing.Point(195, 21);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(64, 64);
            this.Btn_Delete.TabIndex = 2;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Edit.color = System.Drawing.Color.SeaGreen;
            this.Btn_Edit.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_Edit.ForeColor = System.Drawing.Color.White;
            this.Btn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Edit.Image")));
            this.Btn_Edit.ImagePosition = 0;
            this.Btn_Edit.ImageZoom = 64;
            this.Btn_Edit.LabelPosition = 16;
            this.Btn_Edit.LabelText = "Düzenle";
            this.Btn_Edit.Location = new System.Drawing.Point(121, 21);
            this.Btn_Edit.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(62, 64);
            this.Btn_Edit.TabIndex = 1;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Txt_Refresh
            // 
            this.Txt_Refresh.BackColor = System.Drawing.Color.SeaGreen;
            this.Txt_Refresh.color = System.Drawing.Color.SeaGreen;
            this.Txt_Refresh.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Txt_Refresh.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Txt_Refresh.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Txt_Refresh.ForeColor = System.Drawing.Color.White;
            this.Txt_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Txt_Refresh.Image")));
            this.Txt_Refresh.ImagePosition = 0;
            this.Txt_Refresh.ImageZoom = 64;
            this.Txt_Refresh.LabelPosition = 30;
            this.Txt_Refresh.LabelText = "Yenile";
            this.Txt_Refresh.Location = new System.Drawing.Point(271, 21);
            this.Txt_Refresh.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_Refresh.Name = "Txt_Refresh";
            this.Txt_Refresh.Size = new System.Drawing.Size(64, 64);
            this.Txt_Refresh.TabIndex = 3;
            this.Txt_Refresh.UseWaitCursor = true;
            this.Txt_Refresh.Click += new System.EventHandler(this.Txt_Refresh_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGW_Clients);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clients";
            this.Text = "Clients";
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Clients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.DataGridView DGW_Clients;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton Btn_Delete;
        private Bunifu.Framework.UI.BunifuTileButton Btn_Add;
        private Bunifu.Framework.UI.BunifuTileButton Btn_Edit;
        private Bunifu.Framework.UI.BunifuTileButton Txt_Refresh;
    }
}