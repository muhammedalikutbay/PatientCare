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

        private void Btn_Delete_Click(object sender, System.EventArgs e) { }

        private void Txt_Refresh_Click(object sender, System.EventArgs e)
        {
            LoadData();
        }
    }
}
