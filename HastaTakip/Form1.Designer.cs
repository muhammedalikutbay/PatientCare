namespace HastaTakip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMainPage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMainPage = new System.Windows.Forms.Panel();
            this.pnClients = new System.Windows.Forms.Panel();
            this.btnClient = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnToDo = new System.Windows.Forms.Panel();
            this.btnToDo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnCheckList = new System.Windows.Forms.Panel();
            this.btnCheckList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnBalanceSheet = new System.Windows.Forms.Panel();
            this.btnBalanceSheet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.btnSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.pnContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnMainPage.SuspendLayout();
            this.pnClients.SuspendLayout();
            this.pnToDo.SuspendLayout();
            this.pnCheckList.SuspendLayout();
            this.pnBalanceSheet.SuspendLayout();
            this.pnSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMainPage
            // 
            this.btnMainPage.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnMainPage.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.btnMainPage, "btnMainPage");
            this.btnMainPage.BorderRadius = 0;
            this.btnMainPage.ButtonText = "Ana Sayfa";
            this.btnMainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainPage.DisabledColor = System.Drawing.Color.Gray;
            this.btnMainPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMainPage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMainPage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMainPage.Iconimage")));
            this.btnMainPage.Iconimage_right = null;
            this.btnMainPage.Iconimage_right_Selected = null;
            this.btnMainPage.Iconimage_Selected = null;
            this.btnMainPage.IconMarginLeft = 32;
            this.btnMainPage.IconMarginRight = 0;
            this.btnMainPage.IconRightVisible = true;
            this.btnMainPage.IconRightZoom = 0D;
            this.btnMainPage.IconVisible = true;
            this.btnMainPage.IconZoom = 64D;
            this.btnMainPage.IsTab = false;
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnMainPage.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btnMainPage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMainPage.selected = false;
            this.btnMainPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMainPage.Textcolor = System.Drawing.Color.Black;
            this.btnMainPage.TextFont = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHam);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // nightControlBox1
            // 
            resources.ApplyResources(this.nightControlBox1, "nightControlBox1");
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnHam
            // 
            resources.ApplyResources(this.btnHam, "btnHam");
            this.btnHam.Name = "btnHam";
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.Menu;
            this.sidebar.Controls.Add(this.pnMainPage);
            this.sidebar.Controls.Add(this.pnClients);
            this.sidebar.Controls.Add(this.pnToDo);
            this.sidebar.Controls.Add(this.pnCheckList);
            this.sidebar.Controls.Add(this.pnBalanceSheet);
            this.sidebar.Controls.Add(this.pnSettings);
            resources.ApplyResources(this.sidebar, "sidebar");
            this.sidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sidebar.Name = "sidebar";
            // 
            // pnMainPage
            // 
            this.pnMainPage.Controls.Add(this.btnMainPage);
            resources.ApplyResources(this.pnMainPage, "pnMainPage");
            this.pnMainPage.Name = "pnMainPage";
            // 
            // pnClients
            // 
            this.pnClients.Controls.Add(this.btnClient);
            resources.ApplyResources(this.pnClients, "pnClients");
            this.pnClients.Name = "pnClients";
            // 
            // btnClient
            // 
            this.btnClient.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnClient.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.btnClient, "btnClient");
            this.btnClient.BorderRadius = 0;
            this.btnClient.ButtonText = "Hastalar";
            this.btnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient.DisabledColor = System.Drawing.Color.Gray;
            this.btnClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClient.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClient.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClient.Iconimage")));
            this.btnClient.Iconimage_right = null;
            this.btnClient.Iconimage_right_Selected = null;
            this.btnClient.Iconimage_Selected = null;
            this.btnClient.IconMarginLeft = 32;
            this.btnClient.IconMarginRight = 0;
            this.btnClient.IconRightVisible = true;
            this.btnClient.IconRightZoom = 0D;
            this.btnClient.IconVisible = true;
            this.btnClient.IconZoom = 64D;
            this.btnClient.IsTab = false;
            this.btnClient.Name = "btnClient";
            this.btnClient.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnClient.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btnClient.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClient.selected = false;
            this.btnClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClient.Textcolor = System.Drawing.Color.Black;
            this.btnClient.TextFont = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // pnToDo
            // 
            this.pnToDo.Controls.Add(this.btnToDo);
            resources.ApplyResources(this.pnToDo, "pnToDo");
            this.pnToDo.Name = "pnToDo";
            // 
            // btnToDo
            // 
            this.btnToDo.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnToDo.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.btnToDo, "btnToDo");
            this.btnToDo.BorderRadius = 0;
            this.btnToDo.ButtonText = "Yapılacaklar";
            this.btnToDo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToDo.DisabledColor = System.Drawing.Color.Gray;
            this.btnToDo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnToDo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnToDo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnToDo.Iconimage")));
            this.btnToDo.Iconimage_right = null;
            this.btnToDo.Iconimage_right_Selected = null;
            this.btnToDo.Iconimage_Selected = null;
            this.btnToDo.IconMarginLeft = 32;
            this.btnToDo.IconMarginRight = 0;
            this.btnToDo.IconRightVisible = true;
            this.btnToDo.IconRightZoom = 0D;
            this.btnToDo.IconVisible = true;
            this.btnToDo.IconZoom = 64D;
            this.btnToDo.IsTab = false;
            this.btnToDo.Name = "btnToDo";
            this.btnToDo.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnToDo.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btnToDo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnToDo.selected = false;
            this.btnToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnToDo.Textcolor = System.Drawing.Color.Black;
            this.btnToDo.TextFont = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToDo.Click += new System.EventHandler(this.BtnToDo_Click);
            // 
            // pnCheckList
            // 
            this.pnCheckList.Controls.Add(this.btnCheckList);
            resources.ApplyResources(this.pnCheckList, "pnCheckList");
            this.pnCheckList.Name = "pnCheckList";
            // 
            // btnCheckList
            // 
            this.btnCheckList.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnCheckList.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.btnCheckList, "btnCheckList");
            this.btnCheckList.BorderRadius = 0;
            this.btnCheckList.ButtonText = "Yapılmışlar";
            this.btnCheckList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckList.DisabledColor = System.Drawing.Color.Gray;
            this.btnCheckList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckList.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCheckList.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCheckList.Iconimage")));
            this.btnCheckList.Iconimage_right = null;
            this.btnCheckList.Iconimage_right_Selected = null;
            this.btnCheckList.Iconimage_Selected = null;
            this.btnCheckList.IconMarginLeft = 32;
            this.btnCheckList.IconMarginRight = 0;
            this.btnCheckList.IconRightVisible = true;
            this.btnCheckList.IconRightZoom = 0D;
            this.btnCheckList.IconVisible = true;
            this.btnCheckList.IconZoom = 64D;
            this.btnCheckList.IsTab = false;
            this.btnCheckList.Name = "btnCheckList";
            this.btnCheckList.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnCheckList.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btnCheckList.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCheckList.selected = false;
            this.btnCheckList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheckList.Textcolor = System.Drawing.Color.Black;
            this.btnCheckList.TextFont = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheckList.Click += new System.EventHandler(this.BtnCheckList_Click);
            // 
            // pnBalanceSheet
            // 
            this.pnBalanceSheet.Controls.Add(this.btnBalanceSheet);
            resources.ApplyResources(this.pnBalanceSheet, "pnBalanceSheet");
            this.pnBalanceSheet.Name = "pnBalanceSheet";
            // 
            // btnBalanceSheet
            // 
            this.btnBalanceSheet.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnBalanceSheet.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.btnBalanceSheet, "btnBalanceSheet");
            this.btnBalanceSheet.BorderRadius = 0;
            this.btnBalanceSheet.ButtonText = "Bilanço";
            this.btnBalanceSheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBalanceSheet.DisabledColor = System.Drawing.Color.Gray;
            this.btnBalanceSheet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBalanceSheet.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBalanceSheet.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBalanceSheet.Iconimage")));
            this.btnBalanceSheet.Iconimage_right = null;
            this.btnBalanceSheet.Iconimage_right_Selected = null;
            this.btnBalanceSheet.Iconimage_Selected = null;
            this.btnBalanceSheet.IconMarginLeft = 32;
            this.btnBalanceSheet.IconMarginRight = 0;
            this.btnBalanceSheet.IconRightVisible = true;
            this.btnBalanceSheet.IconRightZoom = 0D;
            this.btnBalanceSheet.IconVisible = true;
            this.btnBalanceSheet.IconZoom = 64D;
            this.btnBalanceSheet.IsTab = false;
            this.btnBalanceSheet.Name = "btnBalanceSheet";
            this.btnBalanceSheet.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnBalanceSheet.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btnBalanceSheet.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBalanceSheet.selected = false;
            this.btnBalanceSheet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBalanceSheet.Textcolor = System.Drawing.Color.Black;
            this.btnBalanceSheet.TextFont = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBalanceSheet.Click += new System.EventHandler(this.btnBalanceSheet_Click);
            // 
            // pnSettings
            // 
            this.pnSettings.Controls.Add(this.btnSettings);
            resources.ApplyResources(this.pnSettings, "pnSettings");
            this.pnSettings.Name = "pnSettings";
            // 
            // btnSettings
            // 
            this.btnSettings.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnSettings.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.BorderRadius = 0;
            this.btnSettings.ButtonText = "Ayarlar";
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.DisabledColor = System.Drawing.Color.Gray;
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSettings.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSettings.Iconimage")));
            this.btnSettings.Iconimage_right = null;
            this.btnSettings.Iconimage_right_Selected = null;
            this.btnSettings.Iconimage_Selected = null;
            this.btnSettings.IconMarginLeft = 32;
            this.btnSettings.IconMarginRight = 0;
            this.btnSettings.IconRightVisible = true;
            this.btnSettings.IconRightZoom = 0D;
            this.btnSettings.IconVisible = true;
            this.btnSettings.IconZoom = 64D;
            this.btnSettings.IsTab = false;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnSettings.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btnSettings.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSettings.selected = false;
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSettings.Textcolor = System.Drawing.Color.Black;
            this.btnSettings.TextFont = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.SidebarTransiton_Tick);
            // 
            // pnContent
            // 
            resources.ApplyResources(this.pnContent, "pnContent");
            this.pnContent.Name = "pnContent";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ControlBox = false;
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnMainPage.ResumeLayout(false);
            this.pnClients.ResumeLayout(false);
            this.pnToDo.ResumeLayout(false);
            this.pnCheckList.ResumeLayout(false);
            this.pnBalanceSheet.ResumeLayout(false);
            this.pnSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnMainPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnMainPage;
        private System.Windows.Forms.Panel pnToDo;
        private Bunifu.Framework.UI.BunifuFlatButton btnToDo;
        private System.Windows.Forms.Panel pnCheckList;
        private Bunifu.Framework.UI.BunifuFlatButton btnCheckList;
        private System.Windows.Forms.Panel pnSettings;
        private Bunifu.Framework.UI.BunifuFlatButton btnSettings;
        private System.Windows.Forms.Panel pnBalanceSheet;
        private Bunifu.Framework.UI.BunifuFlatButton btnBalanceSheet;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel pnClients;
        private Bunifu.Framework.UI.BunifuFlatButton btnClient;
        private System.Windows.Forms.Panel pnContent;
    }
}

