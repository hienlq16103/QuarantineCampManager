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
    public partial class Form_AddPatientInformation : Form {
        public Form_AddPatientInformation() {
            InitializeComponent();
        }

        private void Button_close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Form_AddPatientInformation_Load(object sender, EventArgs e) {

        }

        private void Button_add_Click(object sender, EventArgs e) {
            string insertString = "INSERT INTO Patient VALUES (@unique_number,@full_name,@identifying_number,@phone,@gender,@p_address,@N_id)";
            using(SqlConnection conn=new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                try {
                    SqlCommand cmd = new SqlCommand(insertString, conn);
                    cmd.Parameters.AddWithValue("@unique_number", Textbox_uniqueNumber.Text);
                    cmd.Parameters.AddWithValue("@full_name", Textbox__fullName.Text);
                    cmd.Parameters.AddWithValue("@identifying_number", Textbox_identifyingNumber.Text);
                    cmd.Parameters.AddWithValue("@phone", Textbox_phone.Text);
                    cmd.Parameters.AddWithValue("@gender", Textbox_gender.Text);
                    cmd.Parameters.AddWithValue("@p_address", Textbox_address.Text);
                    cmd.Parameters.AddWithValue("@N_id", Textbox_nurseId.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insertion successfully", "Congrat", MessageBoxButtons.OK);
                }
                catch {
                    MessageBox.Show("Can not insert into the database", "Insertion error", MessageBoxButtons.OK);
                }
                conn.Close();
            }
        }
    }
}
