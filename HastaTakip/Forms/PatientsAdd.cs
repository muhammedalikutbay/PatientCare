using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using HastaTakip.Models;

namespace HastaTakip.Forms
{
    public partial class PatientsAdd : Form
    {
        int ownerid;

        public PatientsAdd()
        {
            InitializeComponent();
            LoadOwners();
        }

        private void LoadOwners()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=pf55.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT Id, OwnerName FROM PatientsOwner"; // OwnerName ve Id sorgusu
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DisplayMember = "OwnerName"; // ComboBox'ta gösterilecek sütun
                comboBox1.ValueMember = "Id"; // Seçildiğinde geri dönecek olan değer (Id)
                comboBox1.DataSource = dt; // ComboBox'a veri bağlama
            }
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                ownerid = Convert.ToInt32(comboBox1.SelectedValue);
            }
        }

        private void Btn_OwnerAdd_Click_1(object sender, EventArgs e)
        {
            this.Close();
            OwnerAdd ownerAdd = new OwnerAdd();
            ownerAdd.TopMost = true;
            ownerAdd.Show();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient()
            {
                PatientName = Txt_Name.Text,
                OwnerId = ownerid,
                PatientGender = Txt_Gender.Text,
                RegistrationDate = DateTime.Now.ToString("dd-MM-yyyy"),
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
    }
}
