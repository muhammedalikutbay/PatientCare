using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakip.Forms
{
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void Btn_About_Click(object sender, EventArgs e)
        {
            TB_PatientAbout.Enabled = true;
        }

        private void Btn_Di_Click(object sender, EventArgs e)
        {
            TB_Diagnosis.Enabled = true;
        }

        private void BtnTreatment_Click(object sender, EventArgs e)
        {
            TB_Treatment.Enabled = true;
        }
    }
}
