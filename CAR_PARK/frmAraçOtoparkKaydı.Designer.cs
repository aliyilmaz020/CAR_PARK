namespace CAR_PARK
{
    partial class frmAraçOtoparkKaydı
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
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.comboSeri = new System.Windows.Forms.ComboBox();
            this.comboParkYeri = new System.Windows.Forms.ComboBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.grupKişi = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grupAraç = new System.Windows.Forms.GroupBox();
            this.btnSeri = new System.Windows.Forms.Button();
            this.btnMarka = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.grupKişi.SuspendLayout();
            this.grupAraç.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(94, 21);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 22);
            this.txtTc.TabIndex = 0;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(94, 50);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(94, 78);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(94, 106);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 3;
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(121, 53);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(121, 24);
            this.comboMarka.TabIndex = 6;
            this.comboMarka.SelectedIndexChanged += new System.EventHandler(this.comboMarka_SelectedIndexChanged);
            // 
            // comboSeri
            // 
            this.comboSeri.FormattingEnabled = true;
            this.comboSeri.Location = new System.Drawing.Point(121, 83);
            this.comboSeri.Name = "comboSeri";
            this.comboSeri.Size = new System.Drawing.Size(121, 24);
            this.comboSeri.TabIndex = 7;
            // 
            // comboParkYeri
            // 
            this.comboParkYeri.FormattingEnabled = true;
            this.comboParkYeri.Location = new System.Drawing.Point(121, 143);
            this.comboParkYeri.Name = "comboParkYeri";
            this.comboParkYeri.Size = new System.Drawing.Size(121, 24);
            this.comboParkYeri.TabIndex = 9;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(121, 115);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(121, 22);
            this.txtRenk.TabIndex = 10;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(121, 24);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(121, 22);
            this.txtPlaka.TabIndex = 11;
            // 
            // grupKişi
            // 
            this.grupKişi.Controls.Add(this.label4);
            this.grupKişi.Controls.Add(this.label3);
            this.grupKişi.Controls.Add(this.label2);
            this.grupKişi.Controls.Add(this.label1);
            this.grupKişi.Controls.Add(this.txtSoyad);
            this.grupKişi.Controls.Add(this.txtTc);
            this.grupKişi.Controls.Add(this.txtAd);
            this.grupKişi.Controls.Add(this.txtTelefon);
            this.grupKişi.Location = new System.Drawing.Point(39, 52);
            this.grupKişi.Name = "grupKişi";
            this.grupKişi.Size = new System.Drawing.Size(280, 215);
            this.grupKişi.TabIndex = 12;
            this.grupKişi.TabStop = false;
            this.grupKişi.Text = "Kişi Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "TC";
            // 
            // grupAraç
            // 
            this.grupAraç.Controls.Add(this.btnSeri);
            this.grupAraç.Controls.Add(this.btnMarka);
            this.grupAraç.Controls.Add(this.label6);
            this.grupAraç.Controls.Add(this.label7);
            this.grupAraç.Controls.Add(this.label8);
            this.grupAraç.Controls.Add(this.label9);
            this.grupAraç.Controls.Add(this.label10);
            this.grupAraç.Controls.Add(this.txtPlaka);
            this.grupAraç.Controls.Add(this.comboMarka);
            this.grupAraç.Controls.Add(this.comboSeri);
            this.grupAraç.Controls.Add(this.txtRenk);
            this.grupAraç.Controls.Add(this.comboParkYeri);
            this.grupAraç.Location = new System.Drawing.Point(347, 52);
            this.grupAraç.Name = "grupAraç";
            this.grupAraç.Size = new System.Drawing.Size(300, 215);
            this.grupAraç.TabIndex = 13;
            this.grupAraç.TabStop = false;
            this.grupAraç.Text = "Araç Bilgileri";
            // 
            // btnSeri
            // 
            this.btnSeri.Location = new System.Drawing.Point(258, 87);
            this.btnSeri.Name = "btnSeri";
            this.btnSeri.Size = new System.Drawing.Size(27, 23);
            this.btnSeri.TabIndex = 24;
            this.btnSeri.Text = "+";
            this.btnSeri.UseVisualStyleBackColor = true;
            this.btnSeri.Click += new System.EventHandler(this.btnSeri_Click);
            // 
            // btnMarka
            // 
            this.btnMarka.Location = new System.Drawing.Point(258, 54);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(27, 23);
            this.btnMarka.TabIndex = 16;
            this.btnMarka.Text = "+";
            this.btnMarka.UseVisualStyleBackColor = true;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Park Yeri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Renk";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Seri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Marka";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Plaka";
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(225, 367);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(75, 23);
            this.btnKayit.TabIndex = 14;
            this.btnKayit.Text = "Kayıt";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(318, 367);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 15;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
//            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // frmAraçOtoparkKaydı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.grupAraç);
            this.Controls.Add(this.grupKişi);
            this.Name = "frmAraçOtoparkKaydı";
            this.Text = "Araç Otopark Kaydı";
            this.Load += new System.EventHandler(this.frmAraçOtoparkKaydı_Load);
            this.grupKişi.ResumeLayout(false);
            this.grupKişi.PerformLayout();
            this.grupAraç.ResumeLayout(false);
            this.grupAraç.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.ComboBox comboSeri;
        private System.Windows.Forms.ComboBox comboParkYeri;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.GroupBox grupKişi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grupAraç;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnSeri;
        private System.Windows.Forms.Button btnMarka;
    }
}