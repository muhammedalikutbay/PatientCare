using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HastaTakip.Forms
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            // SQLite bağlantısı
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=pf55.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT * FROM Patients";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGW_Clients.DataSource = dt;
            }
        }

        private void Btn_Add_Click(object sender, System.EventArgs e)
        {
            PatientsAdd patientsAdd = new PatientsAdd();
            patientsAdd.ShowDialog();
        }

        private void Btn_Edit_Click(object sender, System.EventArgs e) { }

        private void Btn_Delete_Click(object sender, System.EventArgs e)
        {
            if (DGW_Clients.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(DGW_Clients.SelectedRows[0].Cells["Id"].Value);

                using (
                    SQLiteConnection conn = new SQLiteConnection("Data Source=pf55.db;Version=3;")
                )
                {
                    conn.Open();

                    // Silme sorgusu
                    string query = "DELETE FROM Patients WHERE Id = @Id";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", selectedId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt başarıyla silindi.");
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçin.");
            }
        }

        private void Txt_Refresh_Click(object sender, System.EventArgs e)
        {
            LoadData();
        }
    }
}
