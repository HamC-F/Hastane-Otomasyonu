
namespace Hastane_Otomasyonu
{
    partial class Randevu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randevu));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btndisPlay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtappID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hospitaldbDataSet1 = new Hastane_Otomasyonu.HospitaldbDataSet1();
            this.doctortabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctortabTableAdapter = new Hastane_Otomasyonu.HospitaldbDataSet1TableAdapters.DoctortabTableAdapter();
            this.patientname = new System.Windows.Forms.ComboBox();
            this.hospitaldbDataSet2 = new Hastane_Otomasyonu.HospitaldbDataSet2();
            this.patientabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientabTableAdapter = new Hastane_Otomasyonu.HospitaldbDataSet2TableAdapters.PatientabTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaldbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctortabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaldbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientabBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(236, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 76);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.patientname);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btndisPlay);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtappID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 502);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(369, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 61);
            this.button4.TabIndex = 16;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(38, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "AppointmentDate";
            // 
            // btndisPlay
            // 
            this.btndisPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndisPlay.ForeColor = System.Drawing.Color.White;
            this.btndisPlay.Image = ((System.Drawing.Image)(resources.GetObject("btndisPlay.Image")));
            this.btndisPlay.Location = new System.Drawing.Point(217, 281);
            this.btndisPlay.Name = "btndisPlay";
            this.btndisPlay.Size = new System.Drawing.Size(103, 76);
            this.btndisPlay.TabIndex = 10;
            this.btndisPlay.UseVisualStyleBackColor = true;
            this.btndisPlay.Click += new System.EventHandler(this.btndisPlay_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(44, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 76);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(397, 283);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 76);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(44, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 74);
            this.btnSave.TabIndex = 6;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtappID
            // 
            this.txtappID.Location = new System.Drawing.Point(272, 45);
            this.txtappID.Multiline = true;
            this.txtappID.Name = "txtappID";
            this.txtappID.Size = new System.Drawing.Size(201, 27);
            this.txtappID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(38, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "DoctorName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(38, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "PatientName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "AppID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(567, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 517);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, -22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 108);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(453, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Randevu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 608);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1152, 170);
            this.dataGridView1.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(273, 232);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.doctortabBindingSource;
            this.comboBox1.DisplayMember = "DoctorName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(273, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "DoctorName";
            // 
            // hospitaldbDataSet1
            // 
            this.hospitaldbDataSet1.DataSetName = "HospitaldbDataSet1";
            this.hospitaldbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctortabBindingSource
            // 
            this.doctortabBindingSource.DataMember = "Doctortab";
            this.doctortabBindingSource.DataSource = this.hospitaldbDataSet1;
            // 
            // doctortabTableAdapter
            // 
            this.doctortabTableAdapter.ClearBeforeFill = true;
            // 
            // patientname
            // 
            this.patientname.DataSource = this.patientabBindingSource;
            this.patientname.DisplayMember = "PatientName";
            this.patientname.FormattingEnabled = true;
            this.patientname.Location = new System.Drawing.Point(273, 113);
            this.patientname.Name = "patientname";
            this.patientname.Size = new System.Drawing.Size(200, 21);
            this.patientname.TabIndex = 19;
            this.patientname.ValueMember = "PatientName";
            // 
            // hospitaldbDataSet2
            // 
            this.hospitaldbDataSet2.DataSetName = "HospitaldbDataSet2";
            this.hospitaldbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientabBindingSource
            // 
            this.patientabBindingSource.DataMember = "Patientab";
            this.patientabBindingSource.DataSource = this.hospitaldbDataSet2;
            // 
            // patientabTableAdapter
            // 
            this.patientabTableAdapter.ClearBeforeFill = true;
            // 
            // Randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1153, 777);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Randevu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu";
            this.Load += new System.EventHandler(this.Randevu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaldbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctortabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaldbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientabBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndisPlay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtappID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private HospitaldbDataSet1 hospitaldbDataSet1;
        private System.Windows.Forms.BindingSource doctortabBindingSource;
        private HospitaldbDataSet1TableAdapters.DoctortabTableAdapter doctortabTableAdapter;
        private System.Windows.Forms.ComboBox patientname;
        private HospitaldbDataSet2 hospitaldbDataSet2;
        private System.Windows.Forms.BindingSource patientabBindingSource;
        private HospitaldbDataSet2TableAdapters.PatientabTableAdapter patientabTableAdapter;
    }
}