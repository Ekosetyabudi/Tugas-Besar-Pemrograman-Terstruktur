﻿namespace Bimbingan_konseling
{
    partial class M_data_kls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_data_kls));
            this.panel1 = new System.Windows.Forms.Panel();
            this.edt_penguna = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_kls = new System.Windows.Forms.TextBox();
            this.nama_kls = new System.Windows.Forms.TextBox();
            this.sub_kls = new System.Windows.Forms.TextBox();
            this.simpan = new System.Windows.Forms.Button();
            this.batal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.guruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bimbingan_konselingAll = new Bimbingan_konseling.Bimbingan_konselingAll();
            this.guruTableAdapter = new Bimbingan_konseling.Bimbingan_konselingAllTableAdapters.GuruTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimbingan_konselingAll)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.edt_penguna);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 62);
            this.panel1.TabIndex = 0;
            // 
            // edt_penguna
            // 
            this.edt_penguna.Enabled = false;
            this.edt_penguna.Location = new System.Drawing.Point(708, 32);
            this.edt_penguna.Name = "edt_penguna";
            this.edt_penguna.Size = new System.Drawing.Size(100, 20);
            this.edt_penguna.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(638, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Data Kelas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Kelas ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Kelas ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sub Kelas ";
            // 
            // id_kls
            // 
            this.id_kls.Location = new System.Drawing.Point(159, 90);
            this.id_kls.Name = "id_kls";
            this.id_kls.Size = new System.Drawing.Size(162, 20);
            this.id_kls.TabIndex = 4;
            // 
            // nama_kls
            // 
            this.nama_kls.Location = new System.Drawing.Point(159, 133);
            this.nama_kls.Name = "nama_kls";
            this.nama_kls.Size = new System.Drawing.Size(162, 20);
            this.nama_kls.TabIndex = 5;
            // 
            // sub_kls
            // 
            this.sub_kls.Location = new System.Drawing.Point(159, 183);
            this.sub_kls.Name = "sub_kls";
            this.sub_kls.Size = new System.Drawing.Size(162, 20);
            this.sub_kls.TabIndex = 6;
            // 
            // simpan
            // 
            this.simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan.Location = new System.Drawing.Point(505, 337);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(121, 58);
            this.simpan.TabIndex = 7;
            this.simpan.Text = "Simpan";
            this.simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.simpan.UseVisualStyleBackColor = true;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // batal
            // 
            this.batal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal.Location = new System.Drawing.Point(644, 337);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(121, 58);
            this.batal.TabIndex = 8;
            this.batal.Text = "Refresh";
            this.batal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.batal.UseVisualStyleBackColor = true;
            this.batal.Click += new System.EventHandler(this.batal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(515, 348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(655, 348);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Guru Kelas";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.guruBindingSource;
            this.comboBox1.DisplayMember = "NIP";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(159, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "NIP";
            // 
            // guruBindingSource
            // 
            this.guruBindingSource.DataMember = "Guru";
            this.guruBindingSource.DataSource = this.bimbingan_konselingAll;
            // 
            // bimbingan_konselingAll
            // 
            this.bimbingan_konselingAll.DataSetName = "Bimbingan_konselingAll";
            this.bimbingan_konselingAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guruTableAdapter
            // 
            this.guruTableAdapter.ClearBeforeFill = true;
            // 
            // M_data_kls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(819, 434);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.batal);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.sub_kls);
            this.Controls.Add(this.nama_kls);
            this.Controls.Add(this.id_kls);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "M_data_kls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M_data_kls";
            this.Load += new System.EventHandler(this.M_data_kls_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimbingan_konselingAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id_kls;
        private System.Windows.Forms.TextBox nama_kls;
        private System.Windows.Forms.TextBox sub_kls;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.Button batal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bimbingan_konselingAll bimbingan_konselingAll;
        private System.Windows.Forms.BindingSource guruBindingSource;
        private Bimbingan_konselingAllTableAdapters.GuruTableAdapter guruTableAdapter;
        public System.Windows.Forms.TextBox edt_penguna;
    }
}