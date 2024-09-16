
namespace Hastane_Otomasyonu
{
    partial class Doktor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btndisPlay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtdoctorName = new System.Windows.Forms.TextBox();
            this.txtexperience = new System.Windows.Forms.TextBox();
            this.txtdoctorID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.deptabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitaldbDataSet3 = new Hastane_Otomasyonu.HospitaldbDataSet3();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deptabTableAdapter = new Hastane_Otomasyonu.HospitaldbDataSet3TableAdapters.deptabTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaldbDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 614);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1152, 143);
            this.dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(526, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doctor";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(201, 188);
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(201, 27);
            this.txtphone.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(29, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phone";
            // 
            // btndisPlay
            // 
            this.btndisPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndisPlay.ForeColor = System.Drawing.Color.White;
            this.btndisPlay.Image = ((System.Drawing.Image)(resources.GetObject("btndisPlay.Image")));
            this.btndisPlay.Location = new System.Drawing.Point(216, 308);
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
            this.btnDelete.Location = new System.Drawing.Point(44, 400);
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
            this.btnUpdate.Location = new System.Drawing.Point(397, 308);
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
            this.btnSave.Location = new System.Drawing.Point(44, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 74);
            this.btnSave.TabIndex = 6;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtdoctorName
            // 
            this.txtdoctorName.Location = new System.Drawing.Point(201, 83);
            this.txtdoctorName.Multiline = true;
            this.txtdoctorName.Name = "txtdoctorName";
            this.txtdoctorName.Size = new System.Drawing.Size(201, 27);
            this.txtdoctorName.TabIndex = 5;
            // 
            // txtexperience
            // 
            this.txtexperience.Location = new System.Drawing.Point(201, 131);
            this.txtexperience.Multiline = true;
            this.txtexperience.Name = "txtexperience";
            this.txtexperience.Size = new System.Drawing.Size(201, 27);
            this.txtexperience.TabIndex = 4;
            // 
            // txtdoctorID
            // 
            this.txtdoctorID.Location = new System.Drawing.Point(201, 35);
            this.txtdoctorID.Multiline = true;
            this.txtdoctorID.Name = "txtdoctorID";
            this.txtdoctorID.Size = new System.Drawing.Size(201, 27);
            this.txtdoctorID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(29, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Experience";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(29, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "DoctorName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "DoctorID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(602, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 498);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-54, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 108);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.department);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtphone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btndisPlay);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtdoctorName);
            this.groupBox1.Controls.Add(this.txtexperience);
            this.groupBox1.Controls.Add(this.txtdoctorID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 502);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Information";
            // 
            // department
            // 
            this.department.DataSource = this.deptabBindingSource;
            this.department.DisplayMember = "DeptName";
            this.department.FormattingEnabled = true;
            this.department.Location = new System.Drawing.Point(201, 249);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(201, 21);
            this.department.TabIndex = 18;
            this.department.ValueMember = "DeptName";
            // 
            // deptabBindingSource
            // 
            this.deptabBindingSource.DataMember = "deptab";
            this.deptabBindingSource.DataSource = this.hospitaldbDataSet3;
            // 
            // hospitaldbDataSet3
            // 
            this.hospitaldbDataSet3.DataSetName = "HospitaldbDataSet3";
            this.hospitaldbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(13, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 36);
            this.label6.TabIndex = 17;
            this.label6.Text = "Department";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(369, 415);
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
            this.button1.Location = new System.Drawing.Point(234, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 76);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deptabTableAdapter
            // 
            this.deptabTableAdapter.ClearBeforeFill = true;
            // 
            // Doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 777);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor";
            this.Load += new System.EventHandler(this.Doktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaldbDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndisPlay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtdoctorName;
        private System.Windows.Forms.TextBox txtexperience;
        private System.Windows.Forms.TextBox txtdoctorID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Label label6;
        private HospitaldbDataSet3 hospitaldbDataSet3;
        private System.Windows.Forms.BindingSource deptabBindingSource;
        private HospitaldbDataSet3TableAdapters.deptabTableAdapter deptabTableAdapter;
    }
}