using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanrantineCampDatabase {
    public partial class Form_Menu : Form {
        public Form_Menu() {
            InitializeComponent();
        }

        private void Form_Menu_Load(object sender, EventArgs e) {

        }

        private void Button_logout_Click(object sender, EventArgs e) {
            Form_Login login = new Form_Login();
            login.Show();
            this.Hide();
        }

        private void Button_patientSearch_Click(object sender, EventArgs e) {
            Form_SearchPatient searchPatient = new Form_SearchPatient();
            searchPatient.Show();
        }

        private void Button_addPatient_Click(object sender, EventArgs e) {
            Form_AddPatientInformation add = new Form_AddPatientInformation();
            add.Show();
        }

        private void Button_testingInformation_Click(object sender, EventArgs e) {
            Form_patientTestingInformation testingInfo = new Form_patientTestingInformation();
            testingInfo.Show();
        }

        private void Button_patientReport_Click(object sender, EventArgs e) {
            Form_patientReport report = new Form_patientReport();
            report.Show();
        }

        private void Label_menu_Click(object sender, EventArgs e) {

        }
    }
}
