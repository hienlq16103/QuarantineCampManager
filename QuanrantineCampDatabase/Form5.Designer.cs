
namespace QuanrantineCampDatabase {
    partial class Form_patientTestingInformation {
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_close
            // 
            this.Button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_close.Location = new System.Drawing.Point(1286, 469);
            this.Button_close.Name = "Button_close";
            this.Button_close.Size = new System.Drawing.Size(117, 51);
            this.Button_close.TabIndex = 4;
            this.Button_close.Text = "Close";
            this.Button_close.UseVisualStyleBackColor = true;
            this.Button_close.Click += new System.EventHandler(this.Button_close_Click);
            // 
            // Label_PatientId
            // 
            this.Label_PatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PatientId.Location = new System.Drawing.Point(26, 43);
            this.Label_PatientId.Name = "Label_PatientId";
            this.Label_PatientId.Size = new System.Drawing.Size(212, 49);
            this.Label_PatientId.TabIndex = 5;
            this.Label_PatientId.Text = "Patient Id";
            this.Label_PatientId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Textbos_inputID
            // 
            this.Textbos_inputID.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbos_inputID.Location = new System.Drawing.Point(257, 43);
            this.Textbos_inputID.Name = "Textbos_inputID";
            this.Textbos_inputID.Size = new System.Drawing.Size(296, 49);
            this.Textbos_inputID.TabIndex = 6;
            // 
            // Button_search
            // 
            this.Button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_search.Location = new System.Drawing.Point(617, 41);
            this.Button_search.Name = "Button_search";
            this.Button_search.Size = new System.Drawing.Size(201, 51);
            this.Button_search.TabIndex = 7;
            this.Button_search.Text = "Search";
            this.Button_search.UseVisualStyleBackColor = true;
            this.Button_search.Click += new System.EventHandler(this.Button_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1377, 345);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form_patientTestingInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1431, 532);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Button_search);
            this.Controls.Add(this.Textbos_inputID);
            this.Controls.Add(this.Label_PatientId);
            this.Controls.Add(this.Button_close);
            this.Name = "Form_patientTestingInformation";
            this.Text = "Patient Testing Infromation";
            this.Load += new System.EventHandler(this.Form_patientTestingInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_close;
        private System.Windows.Forms.Label Label_PatientId;
        private System.Windows.Forms.TextBox Textbos_inputID;
        private System.Windows.Forms.Button Button_search;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}