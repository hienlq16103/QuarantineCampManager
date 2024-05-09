using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanrantineCampDatabase {
    public partial class Form_SearchPatient : Form {
        public Form_SearchPatient() {
            InitializeComponent();
        }

        private void Button_close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Form_SearchPatient_Load(object sender, EventArgs e) {
            ;
        }

        private void Button_search_Click(object sender, EventArgs e) {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetPatientInfo();
        }
        DataTable GetPatientInfo() {
            DataTable data = new DataTable();
            string unique_number = Textbos_inputID.Text;
            string querry = "SELECT P.full_name, P.phone, C.comorbidity FROM Patient AS P LEFT JOIN  Comorbidities AS C ON P.unique_number = C.unique_number WHERE P.unique_number = '" + unique_number+"'";
            string selectAll= "SELECT P.full_name, P.phone, C.comorbidity FROM Patient AS P LEFT JOIN Comorbidities AS C ON P.unique_number = C.unique_number";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                SqlDataAdapter adp;
                if (unique_number.Length == 0) 
                    adp = new SqlDataAdapter(selectAll, conn);
                else 
                    adp = new SqlDataAdapter(querry, conn);
                adp.Fill(data);
                conn.Close();
            }
            return data;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
