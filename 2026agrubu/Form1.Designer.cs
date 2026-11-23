namespace _2026agrubu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMusteri = new TextBox();
            yazdir = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            txtUrunAd = new TextBox();
            txtAdet = new TextBox();
            txtFiyat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnEkle = new Button();
            dgvUrunler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // txtMusteri
            // 
            txtMusteri.Location = new Point(65, 9);
            txtMusteri.Multiline = true;
            txtMusteri.Name = "txtMusteri";
            txtMusteri.Size = new Size(237, 27);
            txtMusteri.TabIndex = 1;
            // 
            // yazdir
            // 
            yazdir.Location = new Point(5, 172);
            yazdir.Name = "yazdir";
            yazdir.Size = new Size(297, 23);
            yazdir.TabIndex = 2;
            yazdir.Text = "Yazdır";
            yazdir.UseVisualStyleBackColor = true;
            yazdir.Click += yazdir_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(65, 41);
            txtUrunAd.Multiline = true;
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(237, 27);
            txtUrunAd.TabIndex = 3;
            // 
            // txtAdet
            // 
            txtAdet.Location = new Point(65, 74);
            txtAdet.Multiline = true;
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(237, 24);
            txtAdet.TabIndex = 4;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(65, 106);
            txtFiyat.Multiline = true;
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(237, 27);
            txtFiyat.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 6;
            label1.Text = "Müşteri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 41);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "Ürün Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 8;
            label3.Text = "Adet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 106);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 9;
            label4.Text = "Fiyat";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(5, 143);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(297, 23);
            btnEkle.TabIndex = 11;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click_1;
            // 
            // dgvUrunler
            // 
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(325, 9);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.Size = new Size(463, 186);
            dgvUrunler.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvUrunler);
            Controls.Add(btnEkle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFiyat);
            Controls.Add(txtAdet);
            Controls.Add(txtUrunAd);
            Controls.Add(yazdir);
            Controls.Add(txtMusteri);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMusteri;
        private Button yazdir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private TextBox txtUrunAd;
        private TextBox txtAdet;
        private TextBox txtFiyat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnEkle;
        private DataGridView dgvUrunler;
    }
}
