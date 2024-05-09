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
    public partial class Form_patientTestingInformation : Form {
        public Form_patientTestingInformation() {
            InitializeComponent();
        }

        private void Button_close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Form_patientTestingInformation_Load(object sender, EventArgs e) {

        }

        private void Button_search_Click(object sender, EventArgs e) {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetTestingInfo();
        }
        DataTable GetTestingInfo() {
            DataTable data = new DataTable();
            string unique_number = Textbos_inputID.Text;
            string querry = "SELECT* FROM Testing_information WHERE p_unique_number = '" + unique_number + "'";
            string selectAll = "SELECT* FROM Testing_information";
            using (SqlConnection conn=new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                SqlDataAdapter adp;
                if (unique_number.Length == 0)
                    adp = new SqlDataAdapter(selectAll, conn);
                else adp = new SqlDataAdapter(querry, conn);
                adp.Fill(data);
                conn.Close();
            }
            return data;
        }
    }
}
