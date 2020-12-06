
namespace Kart
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listKulKart = new System.Windows.Forms.ListBox();
            this.listBilKart = new System.Windows.Forms.ListBox();
            this.labelKullanici = new System.Windows.Forms.Label();
            this.labelBilgisayar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSkorBil = new System.Windows.Forms.Label();
            this.lblSkorKul = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBilAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textKulAdi = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelPozisyon = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(831, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Oyunu Başlat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listKulKart
            // 
            this.listKulKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listKulKart.FormattingEnabled = true;
            this.listKulKart.ItemHeight = 16;
            this.listKulKart.Location = new System.Drawing.Point(145, 51);
            this.listKulKart.Name = "listKulKart";
            this.listKulKart.Size = new System.Drawing.Size(140, 180);
            this.listKulKart.TabIndex = 5;
            this.listKulKart.Visible = false;
            // 
            // listBilKart
            // 
            this.listBilKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBilKart.FormattingEnabled = true;
            this.listBilKart.ItemHeight = 16;
            this.listBilKart.Location = new System.Drawing.Point(611, 51);
            this.listBilKart.Name = "listBilKart";
            this.listBilKart.Size = new System.Drawing.Size(140, 180);
            this.listBilKart.TabIndex = 6;
            this.listBilKart.Visible = false;
            // 
            // labelKullanici
            // 
            this.labelKullanici.AutoSize = true;
            this.labelKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullanici.Location = new System.Drawing.Point(311, 115);
            this.labelKullanici.Name = "labelKullanici";
            this.labelKullanici.Size = new System.Drawing.Size(29, 31);
            this.labelKullanici.TabIndex = 8;
            this.labelKullanici.Text = "0";
            this.labelKullanici.Visible = false;
            // 
            // labelBilgisayar
            // 
            this.labelBilgisayar.AutoSize = true;
            this.labelBilgisayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBilgisayar.Location = new System.Drawing.Point(539, 115);
            this.labelBilgisayar.Name = "labelBilgisayar";
            this.labelBilgisayar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelBilgisayar.Size = new System.Drawing.Size(29, 31);
            this.labelBilgisayar.TabIndex = 9;
            this.labelBilgisayar.Text = "0";
            this.labelBilgisayar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.lblSonuc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblSkorBil);
            this.panel1.Controls.Add(this.lblSkorKul);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblBilAdi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textKulAdi);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.listBilKart);
            this.panel1.Controls.Add(this.listKulKart);
            this.panel1.Controls.Add(this.labelBilgisayar);
            this.panel1.Controls.Add(this.labelPozisyon);
            this.panel1.Controls.Add(this.labelKullanici);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 274);
            this.panel1.TabIndex = 11;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(311, 179);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(65, 24);
            this.lblSonuc.TabIndex = 22;
            this.lblSonuc.Text = "Sonuç";
            this.lblSonuc.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(325, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "FUTBOLCU KARTI SEÇ";
            this.label2.Visible = false;
            // 
            // lblSkorBil
            // 
            this.lblSkorBil.AutoSize = true;
            this.lblSkorBil.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkorBil.Location = new System.Drawing.Point(501, 6);
            this.lblSkorBil.Name = "lblSkorBil";
            this.lblSkorBil.Size = new System.Drawing.Size(36, 39);
            this.lblSkorBil.TabIndex = 20;
            this.lblSkorBil.Text = "0";
            // 
            // lblSkorKul
            // 
            this.lblSkorKul.AutoSize = true;
            this.lblSkorKul.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkorKul.Location = new System.Drawing.Point(363, 6);
            this.lblSkorKul.Name = "lblSkorKul";
            this.lblSkorKul.Size = new System.Drawing.Size(36, 39);
            this.lblSkorKul.TabIndex = 19;
            this.lblSkorKul.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(451, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "-";
            // 
            // lblBilAdi
            // 
            this.lblBilAdi.AutoSize = true;
            this.lblBilAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilAdi.Location = new System.Drawing.Point(605, 9);
            this.lblBilAdi.Name = "lblBilAdi";
            this.lblBilAdi.Size = new System.Drawing.Size(176, 31);
            this.lblBilAdi.TabIndex = 14;
            this.lblBilAdi.Text = "BİLGİSAYAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(139, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "KULLANICI ADI";
            // 
            // textKulAdi
            // 
            this.textKulAdi.AccessibleDescription = "";
            this.textKulAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKulAdi.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textKulAdi.Location = new System.Drawing.Point(831, 13);
            this.textKulAdi.MaxLength = 12;
            this.textKulAdi.Name = "textKulAdi";
            this.textKulAdi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textKulAdi.Size = new System.Drawing.Size(153, 26);
            this.textKulAdi.TabIndex = 12;
            this.textKulAdi.Tag = "";
            this.textKulAdi.Text = "Kullanıcı Adı Giriniz";
            this.textKulAdi.Enter += new System.EventHandler(this.textKulAdi_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(317, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(251, 41);
            this.button3.TabIndex = 11;
            this.button3.Text = "Rastgele Pozisyon At";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(831, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 60);
            this.button2.TabIndex = 10;
            this.button2.Text = "Kullanıcı Kaydet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelPozisyon
            // 
            this.labelPozisyon.AutoSize = true;
            this.labelPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPozisyon.Location = new System.Drawing.Point(311, 51);
            this.labelPozisyon.Name = "labelPozisyon";
            this.labelPozisyon.Size = new System.Drawing.Size(257, 31);
            this.labelPozisyon.TabIndex = 7;
            this.labelPozisyon.Text = "Rastgele Pozisyon";
            this.labelPozisyon.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(12, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 153);
            this.panel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(240, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 49);
            this.label4.TabIndex = 13;
            this.label4.Text = ".";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(610, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 45);
            this.label5.TabIndex = 25;
            this.label5.Text = "0";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(447, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 45);
            this.label6.TabIndex = 24;
            this.label6.Text = "0";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(524, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 49);
            this.label7.TabIndex = 23;
            this.label7.Text = "-";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(670, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 45);
            this.label8.TabIndex = 22;
            this.label8.Text = "BİLGİSAYAR";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(198, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 45);
            this.label9.TabIndex = 21;
            this.label9.Text = "KULLANICI ADI";
            this.label9.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1009, 456);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listKulKart;
        private System.Windows.Forms.ListBox listBilKart;
        private System.Windows.Forms.Label labelKullanici;
        private System.Windows.Forms.Label labelBilgisayar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textKulAdi;
        private System.Windows.Forms.Label lblBilAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPozisyon;
        public System.Windows.Forms.Label lblSkorBil;
        public System.Windows.Forms.Label lblSkorKul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

