namespace HastaTakip.Forms
{
    partial class OwnerAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerAdd));
            this.Txt_Phone = new System.Windows.Forms.TextBox();
            this.Txt_Adress = new System.Windows.Forms.TextBox();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.foxBigLabel1 = new ReaLTaiizor.Controls.FoxBigLabel();
            this.Btn_Add = new Bunifu.Framework.UI.BunifuTileButton();
            this.foxLabel3 = new ReaLTaiizor.Controls.FoxLabel();
            this.foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            this.foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            this.SuspendLayout();
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Phone.Location = new System.Drawing.Point(161, 135);
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.Size = new System.Drawing.Size(253, 31);
            this.Txt_Phone.TabIndex = 26;
            // 
            // Txt_Adress
            // 
            this.Txt_Adress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Adress.Location = new System.Drawing.Point(161, 102);
            this.Txt_Adress.Name = "Txt_Adress";
            this.Txt_Adress.Size = new System.Drawing.Size(253, 31);
            this.Txt_Adress.TabIndex = 25;
            // 
            // Txt_Name
            // 
            this.Txt_Name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Name.Location = new System.Drawing.Point(161, 69);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(253, 31);
            this.Txt_Name.TabIndex = 24;
            // 
            // foxBigLabel1
            // 
            this.foxBigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foxBigLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.foxBigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxBigLabel1.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.foxBigLabel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.foxBigLabel1.Location = new System.Drawing.Point(25, 12);
            this.foxBigLabel1.Name = "foxBigLabel1";
            this.foxBigLabel1.Size = new System.Drawing.Size(259, 41);
            this.foxBigLabel1.TabIndex = 23;
            this.foxBigLabel1.Text = "Hasta Sahibi Ekleme";
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
            this.Btn_Add.ImagePosition = 16;
            this.Btn_Add.ImageZoom = 32;
            this.Btn_Add.LabelPosition = 32;
            this.Btn_Add.LabelText = "Ekle";
            this.Btn_Add.Location = new System.Drawing.Point(350, 175);
            this.Btn_Add.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(64, 64);
            this.Btn_Add.TabIndex = 22;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click_1);
            // 
            // foxLabel3
            // 
            this.foxLabel3.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.foxLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel3.Location = new System.Drawing.Point(25, 139);
            this.foxLabel3.Name = "foxLabel3";
            this.foxLabel3.Size = new System.Drawing.Size(118, 29);
            this.foxLabel3.TabIndex = 20;
            this.foxLabel3.Text = "Telefon No:";
            // 
            // foxLabel1
            // 
            this.foxLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.foxLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel1.Location = new System.Drawing.Point(25, 69);
            this.foxLabel1.Name = "foxLabel1";
            this.foxLabel1.Size = new System.Drawing.Size(118, 29);
            this.foxLabel1.TabIndex = 18;
            this.foxLabel1.Text = "Adı Soyadı:";
            // 
            // foxLabel2
            // 
            this.foxLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.foxLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel2.Location = new System.Drawing.Point(25, 104);
            this.foxLabel2.Name = "foxLabel2";
            this.foxLabel2.Size = new System.Drawing.Size(118, 29);
            this.foxLabel2.TabIndex = 19;
            this.foxLabel2.Text = "Adresi:";
            // 
            // OwnerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 256);
            this.Controls.Add(this.Txt_Phone);
            this.Controls.Add(this.Txt_Adress);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.foxBigLabel1);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.foxLabel3);
            this.Controls.Add(this.foxLabel2);
            this.Controls.Add(this.foxLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OwnerAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OwnerAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Phone;
        private System.Windows.Forms.TextBox Txt_Adress;
        private System.Windows.Forms.TextBox Txt_Name;
        private ReaLTaiizor.Controls.FoxBigLabel foxBigLabel1;
        private Bunifu.Framework.UI.BunifuTileButton Btn_Add;
        private ReaLTaiizor.Controls.FoxLabel foxLabel3;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
    }
}