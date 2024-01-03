namespace _11_PolimorfizmOrnek3
{
    partial class FormDortgen
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
            lstUrun = new ListBox();
            dtUrunler = new DataGridView();
            label1 = new Label();
            txtId = new TextBox();
            txtAd = new TextBox();
            label2 = new Label();
            txtYukseklik = new TextBox();
            label3 = new Label();
            txtkisaKenar = new TextBox();
            label4 = new Label();
            txtUzunKenar = new TextBox();
            label5 = new Label();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            txtTabanalani = new TextBox();
            label6 = new Label();
            txtHacim = new TextBox();
            label7 = new Label();
            txtFire = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtUrunler).BeginInit();
            SuspendLayout();
            // 
            // lstUrun
            // 
            lstUrun.FormattingEnabled = true;
            lstUrun.ItemHeight = 20;
            lstUrun.Location = new Point(21, 29);
            lstUrun.Name = "lstUrun";
            lstUrun.Size = new Size(239, 204);
            lstUrun.TabIndex = 0;
            lstUrun.SelectedIndexChanged += lstUrun_SelectedIndexChanged;
            // 
            // dtUrunler
            // 
            dtUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtUrunler.Location = new Point(317, 29);
            dtUrunler.Name = "dtUrunler";
            dtUrunler.RowHeadersWidth = 51;
            dtUrunler.RowTemplate.Height = 29;
            dtUrunler.Size = new Size(261, 204);
            dtUrunler.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(601, 66);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 2;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(701, 59);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 3;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(701, 92);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(601, 99);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 4;
            label2.Text = "Ad";
            // 
            // txtYukseklik
            // 
            txtYukseklik.Location = new Point(701, 125);
            txtYukseklik.Name = "txtYukseklik";
            txtYukseklik.Size = new Size(125, 27);
            txtYukseklik.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(601, 132);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 6;
            label3.Text = "Yükseklik";
            // 
            // txtkisaKenar
            // 
            txtkisaKenar.Location = new Point(701, 158);
            txtkisaKenar.Name = "txtkisaKenar";
            txtkisaKenar.Size = new Size(125, 27);
            txtkisaKenar.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(601, 165);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 8;
            label4.Text = "Kısa Kenar";
            // 
            // txtUzunKenar
            // 
            txtUzunKenar.Location = new Point(701, 191);
            txtUzunKenar.Name = "txtUzunKenar";
            txtUzunKenar.Size = new Size(125, 27);
            txtUzunKenar.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(601, 198);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 10;
            label5.Text = "Uzun Kenar";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(46, 277);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(67, 29);
            btnEkle.TabIndex = 12;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(133, 277);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(67, 29);
            btnSil.TabIndex = 13;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(84, 324);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(77, 29);
            btnGuncelle.TabIndex = 14;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtTabanalani
            // 
            txtTabanalani.Enabled = false;
            txtTabanalani.Location = new Point(453, 266);
            txtTabanalani.Name = "txtTabanalani";
            txtTabanalani.Size = new Size(84, 27);
            txtTabanalani.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(353, 273);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 15;
            label6.Text = "Taban Alanı";
            // 
            // txtHacim
            // 
            txtHacim.Enabled = false;
            txtHacim.Location = new Point(701, 330);
            txtHacim.Name = "txtHacim";
            txtHacim.Size = new Size(84, 27);
            txtHacim.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(642, 333);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 17;
            label7.Text = "Hacim";
            // 
            // txtFire
            // 
            txtFire.Enabled = false;
            txtFire.Location = new Point(701, 372);
            txtFire.Name = "txtFire";
            txtFire.Size = new Size(84, 27);
            txtFire.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(642, 375);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 19;
            label8.Text = "Fire";
            // 
            // FormDortgen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 446);
            Controls.Add(txtFire);
            Controls.Add(label8);
            Controls.Add(txtHacim);
            Controls.Add(label7);
            Controls.Add(txtTabanalani);
            Controls.Add(label6);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtUzunKenar);
            Controls.Add(label5);
            Controls.Add(txtkisaKenar);
            Controls.Add(label4);
            Controls.Add(txtYukseklik);
            Controls.Add(label3);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dtUrunler);
            Controls.Add(lstUrun);
            Name = "FormDortgen";
            Text = "FormDortgen";
            ((System.ComponentModel.ISupportInitialize)dtUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstUrun;
        private DataGridView dtUrunler;
        private Label label1;
        private TextBox txtId;
        private TextBox txtAd;
        private Label label2;
        private TextBox txtYukseklik;
        private Label label3;
        private TextBox txtkisaKenar;
        private Label label4;
        private TextBox txtUzunKenar;
        private Label label5;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private TextBox txtTabanalani;
        private Label label6;
        private TextBox txtHacim;
        private Label label7;
        private TextBox txtFire;
        private Label label8;
    }
}