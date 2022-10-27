namespace BestDiet
{
    partial class FormAdmin
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
            this.lvAktivite = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAra = new System.Windows.Forms.TextBox();
            this.lvKullanici = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAktiviteGuncelle = new System.Windows.Forms.Button();
            this.grpYemekler = new System.Windows.Forms.GroupBox();
            this.btnYemekAkitfPasif = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lvYemek = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtYemekAra = new System.Windows.Forms.TextBox();
            this.btnYemekGüncelle = new System.Windows.Forms.Button();
            this.btnYemekEkle = new System.Windows.Forms.Button();
            this.txtAktiviteAra = new System.Windows.Forms.TextBox();
            this.btnAktiviteEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAktiviteAktifPasif = new System.Windows.Forms.Button();
            this.btnKullaniciAktifPasif = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.grpYemekler.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAktivite
            // 
            this.lvAktivite.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader15});
            this.lvAktivite.HideSelection = false;
            this.lvAktivite.Location = new System.Drawing.Point(13, 64);
            this.lvAktivite.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lvAktivite.Name = "lvAktivite";
            this.lvAktivite.Size = new System.Drawing.Size(385, 271);
            this.lvAktivite.TabIndex = 0;
            this.lvAktivite.UseCompatibleStateImageBehavior = false;
            this.lvAktivite.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Aktivite Adı";
            this.columnHeader4.Width = 142;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kalori";
            this.columnHeader5.Width = 83;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Durum";
            this.columnHeader15.Width = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(859, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ara:";
            // 
            // txtKullaniciAra
            // 
            this.txtKullaniciAra.Location = new System.Drawing.Point(903, 28);
            this.txtKullaniciAra.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtKullaniciAra.Name = "txtKullaniciAra";
            this.txtKullaniciAra.Size = new System.Drawing.Size(173, 27);
            this.txtKullaniciAra.TabIndex = 0;
            this.txtKullaniciAra.TextChanged += new System.EventHandler(this.txtKullaniciAra_TextChanged);
            // 
            // lvKullanici
            // 
            this.lvKullanici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader6,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25});
            this.lvKullanici.HideSelection = false;
            this.lvKullanici.Location = new System.Drawing.Point(6, 70);
            this.lvKullanici.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lvKullanici.Name = "lvKullanici";
            this.lvKullanici.Size = new System.Drawing.Size(1070, 308);
            this.lvKullanici.TabIndex = 0;
            this.lvKullanici.UseCompatibleStateImageBehavior = false;
            this.lvKullanici.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Ad";
            this.columnHeader17.Width = 130;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Soyad";
            this.columnHeader18.Width = 131;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kullanıcı Adı";
            this.columnHeader6.Width = 162;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Yaş";
            this.columnHeader19.Width = 54;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Boy";
            this.columnHeader20.Width = 44;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Kilo";
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Hedef Kilo";
            this.columnHeader22.Width = 112;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Favori Yiyecek";
            this.columnHeader23.Width = 128;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Favori Aktivite";
            this.columnHeader24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader24.Width = 131;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Durum";
            this.columnHeader25.Width = 112;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtKullaniciAra);
            this.groupBox3.Controls.Add(this.lvKullanici);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox3.Location = new System.Drawing.Point(14, 364);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox3.Size = new System.Drawing.Size(1080, 403);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kullanıcılar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ara:";
            // 
            // btnAktiviteGuncelle
            // 
            this.btnAktiviteGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAktiviteGuncelle.Location = new System.Drawing.Point(416, 241);
            this.btnAktiviteGuncelle.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnAktiviteGuncelle.Name = "btnAktiviteGuncelle";
            this.btnAktiviteGuncelle.Size = new System.Drawing.Size(80, 37);
            this.btnAktiviteGuncelle.TabIndex = 3;
            this.btnAktiviteGuncelle.Text = "Güncelle";
            this.btnAktiviteGuncelle.UseVisualStyleBackColor = true;
            this.btnAktiviteGuncelle.Click += new System.EventHandler(this.btnAktiviteGuncelle_Click);
            // 
            // grpYemekler
            // 
            this.grpYemekler.BackColor = System.Drawing.Color.White;
            this.grpYemekler.Controls.Add(this.btnYemekAkitfPasif);
            this.grpYemekler.Controls.Add(this.label2);
            this.grpYemekler.Controls.Add(this.lvYemek);
            this.grpYemekler.Controls.Add(this.txtYemekAra);
            this.grpYemekler.Controls.Add(this.btnYemekGüncelle);
            this.grpYemekler.Controls.Add(this.btnYemekEkle);
            this.grpYemekler.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpYemekler.Location = new System.Drawing.Point(11, 13);
            this.grpYemekler.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpYemekler.Name = "grpYemekler";
            this.grpYemekler.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpYemekler.Size = new System.Drawing.Size(569, 343);
            this.grpYemekler.TabIndex = 0;
            this.grpYemekler.TabStop = false;
            this.grpYemekler.Text = "Yemekler";
            // 
            // btnYemekAkitfPasif
            // 
            this.btnYemekAkitfPasif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnYemekAkitfPasif.Location = new System.Drawing.Point(475, 170);
            this.btnYemekAkitfPasif.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnYemekAkitfPasif.Name = "btnYemekAkitfPasif";
            this.btnYemekAkitfPasif.Size = new System.Drawing.Size(80, 37);
            this.btnYemekAkitfPasif.TabIndex = 4;
            this.btnYemekAkitfPasif.Text = "Aktif/Pasif";
            this.btnYemekAkitfPasif.UseVisualStyleBackColor = true;
            this.btnYemekAkitfPasif.Click += new System.EventHandler(this.btnYemekAkitfPasif_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ara:";
            // 
            // lvYemek
            // 
            this.lvYemek.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader14});
            this.lvYemek.HideSelection = false;
            this.lvYemek.Location = new System.Drawing.Point(5, 74);
            this.lvYemek.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lvYemek.Name = "lvYemek";
            this.lvYemek.Size = new System.Drawing.Size(452, 261);
            this.lvYemek.TabIndex = 0;
            this.lvYemek.UseCompatibleStateImageBehavior = false;
            this.lvYemek.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Yemek";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kategori";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kalori";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Durum";
            this.columnHeader14.Width = 85;
            // 
            // txtYemekAra
            // 
            this.txtYemekAra.Location = new System.Drawing.Point(284, 33);
            this.txtYemekAra.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtYemekAra.Name = "txtYemekAra";
            this.txtYemekAra.Size = new System.Drawing.Size(173, 27);
            this.txtYemekAra.TabIndex = 0;
            this.txtYemekAra.TextChanged += new System.EventHandler(this.txtYemekAra_TextChanged);
            // 
            // btnYemekGüncelle
            // 
            this.btnYemekGüncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnYemekGüncelle.Location = new System.Drawing.Point(475, 230);
            this.btnYemekGüncelle.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnYemekGüncelle.Name = "btnYemekGüncelle";
            this.btnYemekGüncelle.Size = new System.Drawing.Size(80, 37);
            this.btnYemekGüncelle.TabIndex = 3;
            this.btnYemekGüncelle.Text = "Güncelle";
            this.btnYemekGüncelle.UseVisualStyleBackColor = true;
            this.btnYemekGüncelle.Click += new System.EventHandler(this.btnYemekGüncelle_Click);
            // 
            // btnYemekEkle
            // 
            this.btnYemekEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnYemekEkle.Location = new System.Drawing.Point(475, 112);
            this.btnYemekEkle.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnYemekEkle.Name = "btnYemekEkle";
            this.btnYemekEkle.Size = new System.Drawing.Size(80, 37);
            this.btnYemekEkle.TabIndex = 1;
            this.btnYemekEkle.Text = "Ekle";
            this.btnYemekEkle.UseVisualStyleBackColor = true;
            this.btnYemekEkle.Click += new System.EventHandler(this.btnYemekEkle_Click);
            // 
            // txtAktiviteAra
            // 
            this.txtAktiviteAra.Location = new System.Drawing.Point(225, 28);
            this.txtAktiviteAra.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtAktiviteAra.Name = "txtAktiviteAra";
            this.txtAktiviteAra.Size = new System.Drawing.Size(173, 27);
            this.txtAktiviteAra.TabIndex = 0;
            this.txtAktiviteAra.TextChanged += new System.EventHandler(this.txtAktiviteAra_TextChanged);
            // 
            // btnAktiviteEkle
            // 
            this.btnAktiviteEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAktiviteEkle.Location = new System.Drawing.Point(416, 123);
            this.btnAktiviteEkle.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnAktiviteEkle.Name = "btnAktiviteEkle";
            this.btnAktiviteEkle.Size = new System.Drawing.Size(80, 37);
            this.btnAktiviteEkle.TabIndex = 1;
            this.btnAktiviteEkle.Text = "Ekle";
            this.btnAktiviteEkle.UseVisualStyleBackColor = true;
            this.btnAktiviteEkle.Click += new System.EventHandler(this.btnAktiviteEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lvAktivite);
            this.groupBox2.Controls.Add(this.btnAktiviteAktifPasif);
            this.groupBox2.Controls.Add(this.btnAktiviteGuncelle);
            this.groupBox2.Controls.Add(this.txtAktiviteAra);
            this.groupBox2.Controls.Add(this.btnAktiviteEkle);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox2.Location = new System.Drawing.Point(584, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox2.Size = new System.Drawing.Size(510, 343);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aktiviteler";
            // 
            // btnAktiviteAktifPasif
            // 
            this.btnAktiviteAktifPasif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAktiviteAktifPasif.Location = new System.Drawing.Point(416, 181);
            this.btnAktiviteAktifPasif.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnAktiviteAktifPasif.Name = "btnAktiviteAktifPasif";
            this.btnAktiviteAktifPasif.Size = new System.Drawing.Size(80, 37);
            this.btnAktiviteAktifPasif.TabIndex = 3;
            this.btnAktiviteAktifPasif.Text = "Aktif/Pasif";
            this.btnAktiviteAktifPasif.UseVisualStyleBackColor = true;
            this.btnAktiviteAktifPasif.Click += new System.EventHandler(this.btnAktiviteAktifPasif_Click);
            // 
            // btnKullaniciAktifPasif
            // 
            this.btnKullaniciAktifPasif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKullaniciAktifPasif.Location = new System.Drawing.Point(14, 779);
            this.btnKullaniciAktifPasif.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnKullaniciAktifPasif.Name = "btnKullaniciAktifPasif";
            this.btnKullaniciAktifPasif.Size = new System.Drawing.Size(80, 37);
            this.btnKullaniciAktifPasif.TabIndex = 5;
            this.btnKullaniciAktifPasif.Text = "Aktif/Pasif";
            this.btnKullaniciAktifPasif.UseVisualStyleBackColor = true;
            this.btnKullaniciAktifPasif.Click += new System.EventHandler(this.btnKullaniciAktifPasif_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1110, 834);
            this.Controls.Add(this.btnKullaniciAktifPasif);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpYemekler);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpYemekler.ResumeLayout(false);
            this.grpYemekler.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvAktivite;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAra;
        private System.Windows.Forms.ListView lvKullanici;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAktiviteGuncelle;
        private System.Windows.Forms.GroupBox grpYemekler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvYemek;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.TextBox txtYemekAra;
        private System.Windows.Forms.Button btnYemekGüncelle;
        private System.Windows.Forms.Button btnYemekEkle;
        private System.Windows.Forms.TextBox txtAktiviteAra;
        private System.Windows.Forms.Button btnAktiviteEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnAktiviteAktifPasif;
        private System.Windows.Forms.Button btnYemekAkitfPasif;
        private System.Windows.Forms.Button btnKullaniciAktifPasif;
    }
}