namespace EF_CodeFirstMimarisi
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudStok = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTedarikci = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.rdbArtan = new System.Windows.Forms.RadioButton();
            this.rdbAzalan = new System.Windows.Forms.RadioButton();
            this.btnIlkOnKayit = new System.Windows.Forms.Button();
            this.btnSonOnKayit = new System.Windows.Forms.Button();
            this.btnRaporForm = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(846, 320);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(16, 30);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat";
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(134, 29);
            this.nudFiyat.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(120, 20);
            this.nudFiyat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stok";
            // 
            // nudStok
            // 
            this.nudStok.Location = new System.Drawing.Point(272, 30);
            this.nudStok.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.nudStok.Name = "nudStok";
            this.nudStok.Size = new System.Drawing.Size(120, 20);
            this.nudStok.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kategori:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(416, 29);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tedarikçi:";
            // 
            // cmbTedarikci
            // 
            this.cmbTedarikci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTedarikci.FormattingEnabled = true;
            this.cmbTedarikci.Location = new System.Drawing.Point(543, 30);
            this.cmbTedarikci.Name = "cmbTedarikci";
            this.cmbTedarikci.Size = new System.Drawing.Size(121, 21);
            this.cmbTedarikci.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(692, 30);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ürün Adına Göre Arayınız:";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(19, 430);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(125, 20);
            this.txtAra.TabIndex = 8;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // rdbArtan
            // 
            this.rdbArtan.AutoSize = true;
            this.rdbArtan.Checked = true;
            this.rdbArtan.Location = new System.Drawing.Point(172, 430);
            this.rdbArtan.Name = "rdbArtan";
            this.rdbArtan.Size = new System.Drawing.Size(107, 17);
            this.rdbArtan.TabIndex = 9;
            this.rdbArtan.TabStop = true;
            this.rdbArtan.Text = "Fiyata Göre Artan";
            this.rdbArtan.UseVisualStyleBackColor = true;
            this.rdbArtan.CheckedChanged += new System.EventHandler(this.rdbArtan_CheckedChanged);
            // 
            // rdbAzalan
            // 
            this.rdbAzalan.AutoSize = true;
            this.rdbAzalan.Location = new System.Drawing.Point(300, 430);
            this.rdbAzalan.Name = "rdbAzalan";
            this.rdbAzalan.Size = new System.Drawing.Size(114, 17);
            this.rdbAzalan.TabIndex = 9;
            this.rdbAzalan.Text = "Fiyata Göre Azalan";
            this.rdbAzalan.UseVisualStyleBackColor = true;
            this.rdbAzalan.CheckedChanged += new System.EventHandler(this.rdbAzalan_CheckedChanged);
            // 
            // btnIlkOnKayit
            // 
            this.btnIlkOnKayit.Location = new System.Drawing.Point(446, 424);
            this.btnIlkOnKayit.Name = "btnIlkOnKayit";
            this.btnIlkOnKayit.Size = new System.Drawing.Size(75, 23);
            this.btnIlkOnKayit.TabIndex = 10;
            this.btnIlkOnKayit.Text = "İlk 10 Kayıt";
            this.btnIlkOnKayit.UseVisualStyleBackColor = true;
            this.btnIlkOnKayit.Click += new System.EventHandler(this.btnIlkOnKayit_Click);
            // 
            // btnSonOnKayit
            // 
            this.btnSonOnKayit.Location = new System.Drawing.Point(557, 424);
            this.btnSonOnKayit.Name = "btnSonOnKayit";
            this.btnSonOnKayit.Size = new System.Drawing.Size(75, 23);
            this.btnSonOnKayit.TabIndex = 11;
            this.btnSonOnKayit.Text = "Son 10 Kayıt";
            this.btnSonOnKayit.UseVisualStyleBackColor = true;
            this.btnSonOnKayit.Click += new System.EventHandler(this.btnSonOnKayit_Click);
            // 
            // btnRaporForm
            // 
            this.btnRaporForm.Location = new System.Drawing.Point(655, 424);
            this.btnRaporForm.Name = "btnRaporForm";
            this.btnRaporForm.Size = new System.Drawing.Size(112, 23);
            this.btnRaporForm.TabIndex = 12;
            this.btnRaporForm.Text = "Rapor Formunu Aç";
            this.btnRaporForm.UseVisualStyleBackColor = true;
            this.btnRaporForm.Click += new System.EventHandler(this.btnRaporForm_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(783, 30);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 463);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnRaporForm);
            this.Controls.Add(this.btnSonOnKayit);
            this.Controls.Add(this.btnIlkOnKayit);
            this.Controls.Add(this.rdbAzalan);
            this.Controls.Add(this.rdbArtan);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbTedarikci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudStok);
            this.Controls.Add(this.nudFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTedarikci;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.RadioButton rdbArtan;
        private System.Windows.Forms.RadioButton rdbAzalan;
        private System.Windows.Forms.Button btnIlkOnKayit;
        private System.Windows.Forms.Button btnSonOnKayit;
        private System.Windows.Forms.Button btnRaporForm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

