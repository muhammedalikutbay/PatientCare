using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaTakip.Forms;
using HastaTakip.Interfaces;
using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.ApplicationServices;

namespace HastaTakip
{
    public partial class Form1 : Form
    {
        /*
        MainPage mainPage;
        Clients clients;
        ToDo todo;
        CheckList checkList;
        BalanceSheet balanceSheet;
        Settings settings;
        */


        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load); // Form yüklendiğinde çalışacak event
            MainPage mainPage = new MainPage();
            LoadFormIntoPanel(mainPage);
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void LoadFormIntoPanel(Form form)
        {
            // Paneli temizle
            pnContent.Controls.Clear();

            // Formun özelliklerini ayarla
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            // Formu panel içine ekle ve göster
            pnContent.Controls.Add(form);
            form.Show();
        }

        bool sidebarExpand = true;

        /* public void panelWidth(int sidebarWidth)
         {
             pnMainPage.Width= sidebarWidth;
             pnToDo.Width = sidebarWidth;
             pnCheckList.Width = sidebarWidth;
             pnBalanceSheet.Width = sidebarWidth;
             pnSettings.Width = sidebarWidth;
             pnClients.Width = sidebarWidth;
         }
        */
        private void SidebarTransiton_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 16;
                if (sidebar.Width <= 128)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    // panelWidth(sidebar.Width);
                }
            }
            else
            {
                sidebar.Width += 16;
                if (sidebar.Width >= 384)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    // panelWidth(sidebar.Width);
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            LoadFormIntoPanel(mainPage);
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            LoadFormIntoPanel(clients);
        }

        private void BtnToDo_Click(object sender, EventArgs e)
        {
            ToDo toDo = new ToDo();
            LoadFormIntoPanel(toDo);
        }

        private void BtnCheckList_Click(object sender, EventArgs e)
        {
            CheckList checkList = new CheckList();
            LoadFormIntoPanel(checkList);
        }

        private void btnBalanceSheet_Click(object sender, EventArgs e)
        {
            BalanceSheet balanceSheet = new BalanceSheet();
            LoadFormIntoPanel(balanceSheet);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            LoadFormIntoPanel(settings);
        }
    }
}
