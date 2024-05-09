
namespace QuanrantineCampDatabase {
    partial class Form_patientReport {
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
            this.Button_close = new System.Windows.Forms.Button();
            this.Label_PatientId = new System.Windows.Forms.Label();
            this.Textbos_inputID = new System.Windows.Forms.TextBox();
            this.Button_search = new System.Windows.Forms.Button();
            this.Grid_demographic = new System.Windows.Forms.DataGridView();
            this.Grid_comorbidities = new System.Windows.Forms.DataGridView();
            this.Grid_symtoms = new System.Windows.Forms.DataGridView();
            this.Grid_treatment = new System.Windows.Forms.DataGridView();
            this.Grid_testingInformation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_demographic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_comorbidities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_symtoms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_treatment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_testingInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_close
            // 
            this.Button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_close.Location = new System.Drawing.Point(1026, 780);
            this.Button_close.Name = "Button_close";
            this.Button_close.Size = new System.Drawing.Size(117, 51);
            this.Button_close.TabIndex = 5;
            this.Button_close.Text = "Close";
            this.Button_close.UseVisualStyleBackColor = true;
            this.Button_close.Click += new System.EventHandler(this.Button_close_Click);
            // 
            // Label_PatientId
            // 
            this.Label_PatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PatientId.Location = new System.Drawing.Point(28, 37);
            this.Label_PatientId.Name = "Label_PatientId";
            this.Label_PatientId.Size = new System.Drawing.Size(212, 49);
            this.Label_PatientId.TabIndex = 6;
            this.Label_PatientId.Text = "Patient Id";
            this.Label_PatientId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Textbos_inputID
            // 
            this.Textbos_inputID.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbos_inputID.Location = new System.Drawing.Point(268, 37);
            this.Textbos_inputID.Name = "Textbos_inputID";
            this.Textbos_inputID.Size = new System.Drawing.Size(296, 49);
            this.Textbos_inputID.TabIndex = 7;
            // 
            // Button_search
            // 
            this.Button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_search.Location = new System.Drawing.Point(620, 37);
            this.Button_search.Name = "Button_search";
            this.Button_search.Size = new System.Drawing.Size(201, 51);
            this.Button_search.TabIndex = 8;
            this.Button_search.Text = "Search";
            this.Button_search.UseVisualStyleBackColor = true;
            this.Button_search.Click += new System.EventHandler(this.Button_search_Click);
            // 
            // Grid_demographic
            // 
            this.Grid_demographic.AllowUserToAddRows = false;
            this.Grid_demographic.AllowUserToDeleteRows = false;
            this.Grid_demographic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_demographic.Location = new System.Drawing.Point(61, 150);
            this.Grid_demographic.Name = "Grid_demographic";
            this.Grid_demographic.ReadOnly = true;
            this.Grid_demographic.RowHeadersWidth = 51;
            this.Grid_demographic.RowTemplate.Height = 24;
            this.Grid_demographic.Size = new System.Drawing.Size(581, 218);
            this.Grid_demographic.TabIndex = 9;
            this.Grid_demographic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_demographic_CellContentClick);
            // 
            // Grid_comorbidities
            // 
            this.Grid_comorbidities.AllowUserToAddRows = false;
            this.Grid_comorbidities.AllowUserToDeleteRows = false;
            this.Grid_comorbidities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_comorbidities.Location = new System.Drawing.Point(680, 141);
            this.Grid_comorbidities.Name = "Grid_comorbidities";
            this.Grid_comorbidities.ReadOnly = true;
            this.Grid_comorbidities.RowHeadersWidth = 51;
            this.Grid_comorbidities.RowTemplate.Height = 24;
            this.Grid_comorbidities.Size = new System.Drawing.Size(435, 127);
            this.Grid_comorbidities.TabIndex = 10;
            // 
            // Grid_symtoms
            // 
            this.Grid_symtoms.AllowUserToAddRows = false;
            this.Grid_symtoms.AllowUserToDeleteRows = false;
            this.Grid_symtoms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_symtoms.Location = new System.Drawing.Point(680, 299);
            this.Grid_symtoms.Name = "Grid_symtoms";
            this.Grid_symtoms.ReadOnly = true;
            this.Grid_symtoms.RowHeadersWidth = 51;
            this.Grid_symtoms.RowTemplate.Height = 24;
            this.Grid_symtoms.Size = new System.Drawing.Size(435, 130);
            this.Grid_symtoms.TabIndex = 11;
            // 
            // Grid_treatment
            // 
            this.Grid_treatment.AllowUserToAddRows = false;
            this.Grid_treatment.AllowUserToDeleteRows = false;
            this.Grid_treatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_treatment.Location = new System.Drawing.Point(344, 443);
            this.Grid_treatment.Name = "Grid_treatment";
            this.Grid_treatment.ReadOnly = true;
            this.Grid_treatment.RowHeadersWidth = 51;
            this.Grid_treatment.RowTemplate.Height = 24;
            this.Grid_treatment.Size = new System.Drawing.Size(771, 147);
            this.Grid_treatment.TabIndex = 12;
            // 
            // Grid_testingInformation
            // 
            this.Grid_testingInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_testingInformation.Location = new System.Drawing.Point(61, 605);
            this.Grid_testingInformation.Name = "Grid_testingInformation";
            this.Grid_testingInformation.RowHeadersWidth = 51;
            this.Grid_testingInformation.RowTemplate.Height = 24;
            this.Grid_testingInformation.Size = new System.Drawing.Size(1054, 155);
            this.Grid_testingInformation.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Demographic information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(675, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Comorbidities";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(675, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Symtoms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Treatment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 565);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Testing information";
            // 
            // Form_patientReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1155, 843);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grid_testingInformation);
            this.Controls.Add(this.Grid_treatment);
            this.Controls.Add(this.Grid_symtoms);
            this.Controls.Add(this.Grid_comorbidities);
            this.Controls.Add(this.Grid_demographic);
            this.Controls.Add(this.Button_search);
            this.Controls.Add(this.Textbos_inputID);
            this.Controls.Add(this.Label_PatientId);
            this.Controls.Add(this.Button_close);
            this.Name = "Form_patientReport";
            this.Text = "Patient Report";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_demographic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_comorbidities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_symtoms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_treatment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_testingInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_close;
        private System.Windows.Forms.Label Label_PatientId;
        private System.Windows.Forms.TextBox Textbos_inputID;
        private System.Windows.Forms.Button Button_search;
        private System.Windows.Forms.DataGridView Grid_demographic;
        private System.Windows.Forms.DataGridView Grid_comorbidities;
        private System.Windows.Forms.DataGridView Grid_symtoms;
        private System.Windows.Forms.DataGridView Grid_treatment;
        private System.Windows.Forms.DataGridView Grid_testingInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}