namespace BestDiet
{
    partial class FormReport
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
            this.lvOgunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAktiviteler = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnListele = new System.Windows.Forms.Button();
            this.dtpTarih2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvSu = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFavoriYiyecek = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFavoriAktivite = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblToplamKalori = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblYakilanKalori = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvOgunler
            // 
            this.lvOgunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader11,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader9});
            this.lvOgunler.HideSelection = false;
            this.lvOgunler.Location = new System.Drawing.Point(12, 13);
            this.lvOgunler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvOgunler.Name = "lvOgunler";
            this.lvOgunler.Size = new System.Drawing.Size(691, 332);
            this.lvOgunler.TabIndex = 0;
            this.lvOgunler.UseCompatibleStateImageBehavior = false;
            this.lvOgunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Yemek Adı";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Yemek Kategorisi";
            this.columnHeader11.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Öğün";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Alınan Kalori";
            this.columnHeader3.Width = 112;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Porsiyon";
            this.columnHeader4.Width = 68;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adet";
            this.columnHeader5.Width = 68;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tarih";
            this.columnHeader9.Width = 104;
            // 
            // lvAktiviteler
            // 
            this.lvAktiviteler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10});
            this.lvAktiviteler.HideSelection = false;
            this.lvAktiviteler.Location = new System.Drawing.Point(13, 353);
            this.lvAktiviteler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvAktiviteler.Name = "lvAktiviteler";
            this.lvAktiviteler.Size = new System.Drawing.Size(409, 278);
            this.lvAktiviteler.TabIndex = 1;
            this.lvAktiviteler.UseCompatibleStateImageBehavior = false;
            this.lvAktiviteler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Aktivite";
            this.columnHeader6.Width = 92;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Yakılan Kalori";
            this.columnHeader7.Width = 125;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Dakika";
            this.columnHeader8.Width = 81;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tarih";
            this.columnHeader10.Width = 100;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(834, 21);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(145, 29);
            this.dtpTarih.TabIndex = 3;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.White;
            this.btnListele.Font = new System.Drawing.Font("Sitka Banner Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnListele.Location = new System.Drawing.Point(776, 139);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(145, 36);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dtpTarih2
            // 
            this.dtpTarih2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih2.Location = new System.Drawing.Point(834, 89);
            this.dtpTarih2.Name = "dtpTarih2";
            this.dtpTarih2.Size = new System.Drawing.Size(145, 29);
            this.dtpTarih2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(716, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(748, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // lvSu
            // 
            this.lvSu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13});
            this.lvSu.HideSelection = false;
            this.lvSu.Location = new System.Drawing.Point(429, 353);
            this.lvSu.Name = "lvSu";
            this.lvSu.Size = new System.Drawing.Size(274, 278);
            this.lvSu.TabIndex = 8;
            this.lvSu.UseCompatibleStateImageBehavior = false;
            this.lvSu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "İçilen Su (lt)";
            this.columnHeader12.Width = 96;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Tarih";
            this.columnHeader13.Width = 97;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFavoriYiyecek);
            this.groupBox1.Location = new System.Drawing.Point(752, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Favori Yiyecek";
            // 
            // lblFavoriYiyecek
            // 
            this.lblFavoriYiyecek.AutoSize = true;
            this.lblFavoriYiyecek.Font = new System.Drawing.Font("Sitka Banner Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFavoriYiyecek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFavoriYiyecek.Location = new System.Drawing.Point(41, 48);
            this.lblFavoriYiyecek.Name = "lblFavoriYiyecek";
            this.lblFavoriYiyecek.Size = new System.Drawing.Size(128, 29);
            this.lblFavoriYiyecek.TabIndex = 0;
            this.lblFavoriYiyecek.Text = "Favori Yiyecek";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFavoriAktivite);
            this.groupBox2.Location = new System.Drawing.Point(752, 514);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Favori Aktivite";
            // 
            // lblFavoriAktivite
            // 
            this.lblFavoriAktivite.AutoSize = true;
            this.lblFavoriAktivite.Font = new System.Drawing.Font("Sitka Banner Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFavoriAktivite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFavoriAktivite.Location = new System.Drawing.Point(41, 46);
            this.lblFavoriAktivite.Name = "lblFavoriAktivite";
            this.lblFavoriAktivite.Size = new System.Drawing.Size(128, 29);
            this.lblFavoriAktivite.TabIndex = 0;
            this.lblFavoriAktivite.Text = "Favori Aktivite";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblToplamKalori);
            this.groupBox3.Location = new System.Drawing.Point(752, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alınan Toplam Kalori";
            // 
            // lblToplamKalori
            // 
            this.lblToplamKalori.AutoSize = true;
            this.lblToplamKalori.Font = new System.Drawing.Font("Sitka Banner Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKalori.ForeColor = System.Drawing.Color.Green;
            this.lblToplamKalori.Location = new System.Drawing.Point(63, 41);
            this.lblToplamKalori.Name = "lblToplamKalori";
            this.lblToplamKalori.Size = new System.Drawing.Size(27, 33);
            this.lblToplamKalori.TabIndex = 0;
            this.lblToplamKalori.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblYakilanKalori);
            this.groupBox4.Location = new System.Drawing.Point(752, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Yakılan Toplam Kalori";
            // 
            // lblYakilanKalori
            // 
            this.lblYakilanKalori.AutoSize = true;
            this.lblYakilanKalori.Font = new System.Drawing.Font("Sitka Banner Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYakilanKalori.ForeColor = System.Drawing.Color.Blue;
            this.lblYakilanKalori.Location = new System.Drawing.Point(63, 51);
            this.lblYakilanKalori.Name = "lblYakilanKalori";
            this.lblYakilanKalori.Size = new System.Drawing.Size(27, 33);
            this.lblYakilanKalori.TabIndex = 0;
            this.lblYakilanKalori.Text = "0";
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 643);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvSu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTarih2);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.lvAktiviteler);
            this.Controls.Add(this.lvOgunler);
            this.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvOgunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView lvAktiviteler;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DateTimePicker dtpTarih2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ListView lvSu;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFavoriYiyecek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFavoriAktivite;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblToplamKalori;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblYakilanKalori;
    }
}