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
    public partial class Form_patientReport : Form {
        public Form_patientReport() {
            InitializeComponent();
        }

        private void Button_close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Button_search_Click(object sender, EventArgs e) {
            string unique_number = Textbos_inputID.Text;
            //Grid of demographic:
            Grid_demographic.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            Grid_demographic.DataSource = GetDemographic(unique_number);
            //Grid of comorbidities:
            Grid_comorbidities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_comorbidities.DataSource = GetComorbidities(unique_number);
            //Grid of Symtoms
            Grid_symtoms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            Grid_symtoms.DataSource = GetSymtoms(unique_number);
            //Grid of Testing information:
            Grid_testingInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            Grid_testingInformation.DataSource = GetTesting(unique_number);
            //Grid of Treat:
            Grid_treatment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            Grid_treatment.DataSource = GetTreat(unique_number);
        }
        DataTable GetDemographic(string id) {
            DataTable data = new DataTable();
            string querry = "SELECT* FROM Patient";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                if (id.Length != 0)
                    querry += " WHERE unique_number='" + id + "'";
                SqlDataAdapter adp = new SqlDataAdapter(querry, conn);
                adp.Fill(data);
                conn.Close();
            }
            return data;
        }
        DataTable GetComorbidities(string id) {
            DataTable data = new DataTable();
            string querry = "SELECT P.unique_number, P.full_name, C.comorbidity FROM Patient AS P LEFT JOIN Comorbidities AS C ON P.unique_number=C.unique_number";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                if (id.Length != 0)
                    querry += " WHERE P.unique_number='" + id + "'";
                SqlDataAdapter adp = new SqlDataAdapter(querry, conn);
                adp.Fill(data);
                conn.Close();
            }
            return data;
        }
        DataTable GetSymtoms(string id) {
            DataTable data = new DataTable();
            string querry = "SELECT P.unique_number, P.full_name, S.recorded_time, S.symtom_name FROM Patient AS P LEFT JOIN Symtom AS S ON P.unique_number = S.unique_number";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                if (id.Length != 0)
                    querry += " WHERE P.unique_number='" + id + "'";
                SqlDataAdapter adp = new SqlDataAdapter(querry, conn);
                adp.Fill(data);
                conn.Close();
            }
            return data;
        }
        DataTable GetTesting(string id) {
            DataTable data = new DataTable();
            string querry = "SELECT* FROM Testing_information";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                if (id.Length != 0)
                    querry += " WHERE p_unique_number = '" + id + "'";
                SqlDataAdapter adp = new SqlDataAdapter(querry, conn);
                adp.Fill(data);
                conn.Close();
            }
            return data;
        }
        DataTable GetTreat(string id) {
            DataTable data = new DataTable();
            string querry = "SELECT* FROM Treat";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                if (id.Length != 0)
                    querry += " WHERE p_unique_number = '" + id + "'";
                SqlDataAdapter adp = new SqlDataAdapter(querry, conn);
                adp.Fill(data);
                conn.Close();
            }
            return data;    
        }

        private void Grid_demographic_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
