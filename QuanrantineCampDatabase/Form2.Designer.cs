
namespace QuanrantineCampDatabase {
    partial class Form_Menu {
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
            this.Label_menu = new System.Windows.Forms.Label();
            this.Button_patientSearch = new System.Windows.Forms.Button();
            this.Button_addPatient = new System.Windows.Forms.Button();
            this.Button_testingInformation = new System.Windows.Forms.Button();
            this.Button_patientReport = new System.Windows.Forms.Button();
            this.Button_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_menu
            // 
            this.Label_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_menu.Location = new System.Drawing.Point(12, 24);
            this.Label_menu.Name = "Label_menu";
            this.Label_menu.Size = new System.Drawing.Size(1063, 44);
            this.Label_menu.TabIndex = 0;
            this.Label_menu.Text = "MENU";
            this.Label_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_menu.Click += new System.EventHandler(this.Label_menu_Click);
            // 
            // Button_patientSearch
            // 
            this.Button_patientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_patientSearch.Location = new System.Drawing.Point(293, 133);
            this.Button_patientSearch.Name = "Button_patientSearch";
            this.Button_patientSearch.Size = new System.Drawing.Size(494, 61);
            this.Button_patientSearch.TabIndex = 1;
            this.Button_patientSearch.Text = "Search Patient Information";
            this.Button_patientSearch.UseVisualStyleBackColor = true;
            this.Button_patientSearch.Click += new System.EventHandler(this.Button_patientSearch_Click);
            // 
            // Button_addPatient
            // 
            this.Button_addPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_addPatient.Location = new System.Drawing.Point(293, 222);
            this.Button_addPatient.Name = "Button_addPatient";
            this.Button_addPatient.Size = new System.Drawing.Size(494, 61);
            this.Button_addPatient.TabIndex = 2;
            this.Button_addPatient.Text = "Add Patient Information";
            this.Button_addPatient.UseVisualStyleBackColor = true;
            this.Button_addPatient.Click += new System.EventHandler(this.Button_addPatient_Click);
            // 
            // Button_testingInformation
            // 
            this.Button_testingInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_testingInformation.Location = new System.Drawing.Point(293, 327);
            this.Button_testingInformation.Name = "Button_testingInformation";
            this.Button_testingInformation.Size = new System.Drawing.Size(494, 61);
            this.Button_testingInformation.TabIndex = 3;
            this.Button_testingInformation.Text = "Search Testing Information";
            this.Button_testingInformation.UseVisualStyleBackColor = true;
            this.Button_testingInformation.Click += new System.EventHandler(this.Button_testingInformation_Click);
            // 
            // Button_patientReport
            // 
            this.Button_patientReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_patientReport.Location = new System.Drawing.Point(293, 424);
            this.Button_patientReport.Name = "Button_patientReport";
            this.Button_patientReport.Size = new System.Drawing.Size(494, 61);
            this.Button_patientReport.TabIndex = 4;
            this.Button_patientReport.Text = "Patient Report";
            this.Button_patientReport.UseVisualStyleBackColor = true;
            this.Button_patientReport.Click += new System.EventHandler(this.Button_patientReport_Click);
            // 
            // Button_logout
            // 
            this.Button_logout.AutoSize = true;
            this.Button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_logout.Location = new System.Drawing.Point(841, 519);
            this.Button_logout.Name = "Button_logout";
            this.Button_logout.Size = new System.Drawing.Size(153, 46);
            this.Button_logout.TabIndex = 5;
            this.Button_logout.Text = "Logout";
            this.Button_logout.UseVisualStyleBackColor = true;
            this.Button_logout.Click += new System.EventHandler(this.Button_logout_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1087, 577);
            this.Controls.Add(this.Button_logout);
            this.Controls.Add(this.Button_patientReport);
            this.Controls.Add(this.Button_testingInformation);
            this.Controls.Add(this.Button_addPatient);
            this.Controls.Add(this.Button_patientSearch);
            this.Controls.Add(this.Label_menu);
            this.Name = "Form_Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_menu;
        private System.Windows.Forms.Button Button_patientSearch;
        private System.Windows.Forms.Button Button_addPatient;
        private System.Windows.Forms.Button Button_patientReport;
        private System.Windows.Forms.Button Button_logout;
        private System.Windows.Forms.Button Button_testingInformation;
    }
}