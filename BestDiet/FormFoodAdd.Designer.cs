namespace BestDiet
{
    partial class FormFoodAdd
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudKalori = new System.Windows.Forms.NumericUpDown();
            this.txtYemekAdi = new System.Windows.Forms.TextBox();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.txtResimYolu = new System.Windows.Forms.TextBox();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudKalori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "kcal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(58, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kalori:";
            // 
            // nudKalori
            // 
            this.nudKalori.Location = new System.Drawing.Point(178, 186);
            this.nudKalori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudKalori.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudKalori.Name = "nudKalori";
            this.nudKalori.Size = new System.Drawing.Size(125, 25);
            this.nudKalori.TabIndex = 2;
            // 
            // txtYemekAdi
            // 
            this.txtYemekAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtYemekAdi.Location = new System.Drawing.Point(138, 130);
            this.txtYemekAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYemekAdi.Name = "txtYemekAdi";
            this.txtYemekAdi.Size = new System.Drawing.Size(230, 25);
            this.txtYemekAdi.TabIndex = 1;
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(138, 72);
            this.cmbKategoriler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(230, 28);
            this.cmbKategoriler.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(29, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yemek Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(46, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kategori:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKaydet.Location = new System.Drawing.Point(167, 550);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(136, 39);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(152, 339);
            this.pbResim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(165, 146);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 21;
            this.pbResim.TabStop = false;
            // 
            // txtResimYolu
            // 
            this.txtResimYolu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtResimYolu.Enabled = false;
            this.txtResimYolu.Location = new System.Drawing.Point(138, 269);
            this.txtResimYolu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResimYolu.Name = "txtResimYolu";
            this.txtResimYolu.Size = new System.Drawing.Size(230, 25);
            this.txtResimYolu.TabIndex = 3;
            // 
            // btnResimSec
            // 
            this.btnResimSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnResimSec.Location = new System.Drawing.Point(12, 264);
            this.btnResimSec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(103, 40);
            this.btnResimSec.TabIndex = 3;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(113, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Lütfen yemeğin 1 porsiyon için kalorisini giriniz";
            // 
            // FormFoodAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 602);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudKalori);
            this.Controls.Add(this.txtYemekAdi);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.txtResimYolu);
            this.Controls.Add(this.btnResimSec);
            this.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormFoodAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFoodAdd";
            this.Load += new System.EventHandler(this.FormFoodAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKalori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudKalori;
        private System.Windows.Forms.TextBox txtYemekAdi;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.TextBox txtResimYolu;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.Label label5;
    }
}