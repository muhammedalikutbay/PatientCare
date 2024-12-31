using System;
using System.Data.SQLite;
using System.Windows.Forms;
using HastaTakip.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace HastaTakip.Forms
{
    public partial class OwnerAdd : Form
    {
        public OwnerAdd()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            PatientOwner patientOwner = new PatientOwner()
            {
                OwnerName = Txt_Name.Text,
                OwnerAdress = Txt_Adress.Text,
                OwnerPhone = Txt_Phone.Text,
            };
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=pf55.db;Version=3;"))
            {
                conn.Open();

                string query =
                    $"INSERT INTO Patients (OwnerName,OwnerAdress,OwnerPhone) VALUES ('{patientOwner.OwnerName}','{patientOwner.OwnerAdress}','{patientOwner.OwnerPhone}')";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                    Clients clients = new Clients();
                    MessageBox.Show("Veri başarıyla eklendi!");
                    clients.LoadData();
                    this.Close();
                }
            }
        }
    }
}
