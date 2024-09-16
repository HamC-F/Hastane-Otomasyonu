
namespace Hastane_Otomasyonu
{
    partial class Ödeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ödeme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PatientName = new System.Windows.Forms.ComboBox();
            this.patientabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitaldbDataSet2 = new Hastane_Otomasyonu.HospitaldbDataSet2();
            this.payment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btndisPlay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.howmoney = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientabTableAdapter = new Hastane_Otomasyonu.HospitaldbDataSet2TableAdapters.PatientabTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaldbDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PatientName);
            this.groupBox1.Controls.Add(this.payment);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btndisPlay);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.howmoney);
            this.groupBox1.Controls.Add(this.txtPID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 477);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // PatientName
            // 
            this.PatientName.DataSource = this.patientabBindingSource;
            this.PatientName.DisplayMember = "PatientName";
            this.PatientName.FormattingEnabled = true;
            this.PatientName.Location = new System.Drawing.Point(290, 153);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(201, 21);
            this.PatientName.TabIndex = 20;
            this.PatientName.ValueMember = "PatientName";
            // 
            // patientabBindingSource
            // 
            this.patientabBindingSource.DataMember = "Patientab";
            this.patientabBindingSource.DataSource = this.hospitaldbDataSet2;
            // 
            // hospitaldbDataSet2
            // 
            this.hospitaldbDataSet2.DataSetName = "HospitaldbDataSet2";
            this.hospitaldbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payment
            // 
            this.payment.FormattingEnabled = true;
            this.payment.Items.AddRange(new object[] {
            "Nakit",
            "Kart"});
            this.payment.Location = new System.Drawing.Point(290, 94);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(201, 21);
            this.payment.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(48, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 36);
            this.label4.TabIndex = 17;
            this.label4.Text = "Amount";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(360, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 61);
            this.button4.TabIndex = 16;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(234, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 76);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(48, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "PatientName";
            // 
            // btndisPlay
            // 
            this.btndisPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndisPlay.ForeColor = System.Drawing.Color.White;
            this.btndisPlay.Image = ((System.Drawing.Image)(resources.GetObject("btndisPlay.Image")));
            this.btndisPlay.Location = new System.Drawing.Point(221, 278);
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
            this.btnDelete.Location = new System.Drawing.Point(44, 380);
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
            this.btnUpdate.Location = new System.Drawing.Point(375, 278);
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
            this.btnSave.Location = new System.Drawing.Point(34, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 74);
            this.btnSave.TabIndex = 6;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // howmoney
            // 
            this.howmoney.Location = new System.Drawing.Point(290, 205);
            this.howmoney.Multiline = true;
            this.howmoney.Name = "howmoney";
            this.howmoney.Size = new System.Drawing.Size(201, 27);
            this.howmoney.TabIndex = 5;
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(290, 40);
            this.txtPID.Multiline = true;
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(201, 27);
            this.txtPID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(48, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "PaymentMethod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "PID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-110, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1373, 105);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(593, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(714, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 229);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 604);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1156, 143);
            this.dataGridView1.TabIndex = 14;
            // 
            // patientabTableAdapter
            // 
            this.patientabTableAdapter.ClearBeforeFill = true;
            // 
            // Ödeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1153, 777);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ödeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme";
            this.Load += new System.EventHandler(this.Ödeme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaldbDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndisPlay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox howmoney;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox payment;
        private System.Windows.Forms.ComboBox PatientName;
        private HospitaldbDataSet2 hospitaldbDataSet2;
        private System.Windows.Forms.BindingSource patientabBindingSource;
        private HospitaldbDataSet2TableAdapters.PatientabTableAdapter patientabTableAdapter;
    }
}