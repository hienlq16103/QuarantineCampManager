
namespace QuanrantineCampDatabase {
    partial class Form_Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Label_login = new System.Windows.Forms.Label();
            this.Label_username = new System.Windows.Forms.Label();
            this.Label_password = new System.Windows.Forms.Label();
            this.Textbox_username = new System.Windows.Forms.TextBox();
            this.Textbox_password = new System.Windows.Forms.TextBox();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_login
            // 
            this.Label_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_login.Location = new System.Drawing.Point(38, 35);
            this.Label_login.Name = "Label_login";
            this.Label_login.Size = new System.Drawing.Size(853, 64);
            this.Label_login.TabIndex = 0;
            this.Label_login.Text = "LOGIN";
            this.Label_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_username
            // 
            this.Label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_username.Location = new System.Drawing.Point(39, 126);
            this.Label_username.Name = "Label_username";
            this.Label_username.Size = new System.Drawing.Size(275, 73);
            this.Label_username.TabIndex = 1;
            this.Label_username.Text = "username";
            this.Label_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_password
            // 
            this.Label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_password.Location = new System.Drawing.Point(39, 248);
            this.Label_password.Name = "Label_password";
            this.Label_password.Size = new System.Drawing.Size(275, 73);
            this.Label_password.TabIndex = 2;
            this.Label_password.Text = "password";
            this.Label_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Textbox_username
            // 
            this.Textbox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_username.Location = new System.Drawing.Point(338, 140);
            this.Textbox_username.Name = "Textbox_username";
            this.Textbox_username.Size = new System.Drawing.Size(512, 45);
            this.Textbox_username.TabIndex = 3;
            this.Textbox_username.TextChanged += new System.EventHandler(this.Textbox_username_TextChanged);
            // 
            // Textbox_password
            // 
            this.Textbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_password.Location = new System.Drawing.Point(338, 262);
            this.Textbox_password.Name = "Textbox_password";
            this.Textbox_password.PasswordChar = '*';
            this.Textbox_password.Size = new System.Drawing.Size(512, 45);
            this.Textbox_password.TabIndex = 4;
            // 
            // Button_OK
            // 
            this.Button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_OK.Location = new System.Drawing.Point(338, 365);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(217, 55);
            this.Button_OK.TabIndex = 5;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_exit
            // 
            this.Button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_exit.Location = new System.Drawing.Point(633, 365);
            this.Button_exit.Name = "Button_exit";
            this.Button_exit.Size = new System.Drawing.Size(217, 55);
            this.Button_exit.TabIndex = 6;
            this.Button_exit.Text = "EXIT";
            this.Button_exit.UseVisualStyleBackColor = true;
            this.Button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(927, 547);
            this.Controls.Add(this.Button_exit);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.Textbox_password);
            this.Controls.Add(this.Textbox_username);
            this.Controls.Add(this.Label_password);
            this.Controls.Add(this.Label_username);
            this.Controls.Add(this.Label_login);
            this.Name = "Form_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_login;
        private System.Windows.Forms.Label Label_username;
        private System.Windows.Forms.Label Label_password;
        private System.Windows.Forms.TextBox Textbox_username;
        private System.Windows.Forms.TextBox Textbox_password;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_exit;
    }
}

