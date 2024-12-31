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
using HastaTakip.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaTakip.Forms
{
    public partial class PatientsAdd : Form
    {
        public PatientsAdd()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient()
            {
                PatientName = Txt_Name.Text,
                OwnerId = Convert.ToInt32(Txt_Owner.Text),
                PatientGender = Txt_Gender.Text,
                RegistrationDate = DateTime.Now.ToString(),
                PatientNote = Txt_Note.Text,
            };

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=pf55.db;Version=3;"))
            {
                conn.Open();

                string query =
                    $"INSERT INTO Patients (PatientName,OwnerId,RegistrationDate,PatientGender,PatientNote) VALUES ('{patient.PatientName}',{patient.OwnerId},'{patient.RegistrationDate}','{patient.PatientGender}','{patient.PatientNote}')";
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

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            
        }
    }
}
