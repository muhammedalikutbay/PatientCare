using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace HastaTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);  // Form yüklendiğinde çalışacak event
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
