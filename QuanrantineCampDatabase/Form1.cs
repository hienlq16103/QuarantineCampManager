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
    public partial class Form_Login : Form {
        public Form_Login() {
            InitializeComponent();
        }

        private void Button_exit_Click(object sender, EventArgs e) {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }
        private void Button_OK_Click(object sender, EventArgs e) {
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string username = Textbox_username.Text;
            string password = Textbox_password.Text;

            if (username.Length == 0 || password.Length == 0) {
                MessageBox.Show("Please enter username and password",
                    "Username or password is empty", MessageBoxButtons.OK);
                return;
            }
            try {
                conn.Open();
                string sql = "SELECT* FROM Account WHERE " +
                    "username='" + username + "' AND password='" + password + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read()) {
                    Form_Menu menu = new Form_Menu();
                    menu.Show();
                    this.Hide();
                } else {
                    MessageBox.Show("username or password is incorrect"
                        , "Login error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Can not login to the server"
                    , "Login error"
                    , MessageBoxButtons.OK);
            }
            finally {
                conn.Close();
            }
        }

        private void Textbox_username_TextChanged(object sender, EventArgs e) {

        }
    }
}
