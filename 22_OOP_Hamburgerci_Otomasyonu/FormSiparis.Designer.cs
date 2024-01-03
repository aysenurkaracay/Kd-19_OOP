namespace _22_OOP_Hamburgerci_Otomasyonu
{
    partial class FormSiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSiparis));
            pblogo = new PictureBox();
            label1 = new Label();
            cmbMenuler = new ComboBox();
            grpBoyutlar = new GroupBox();
            rdbBuyuk = new RadioButton();
            rdbOrta = new RadioButton();
            rdbKucuk = new RadioButton();
            flpEkstraMalzemeler = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            nmrAdet = new NumericUpDown();
            btnSiparisEkle = new Button();
            lstSiparisler = new ListBox();
            label4 = new Label();
            lblToplamTutar = new Label();
            btnSiparisTamamla = new Button();
            ((System.ComponentModel.ISupportInitialize)pblogo).BeginInit();
            grpBoyutlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
            SuspendLayout();
            // 
            // pblogo
            // 
            pblogo.Image = (Image)resources.GetObject("pblogo.Image");
            pblogo.Location = new Point(29, 21);
            pblogo.Name = "pblogo";
            pblogo.Size = new Size(255, 206);
            pblogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pblogo.TabIndex = 0;
            pblogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(44, 240);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 1;
            label1.Text = "MENÜ SEÇİN";
            // 
            // cmbMenuler
            // 
            cmbMenuler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMenuler.FormattingEnabled = true;
            cmbMenuler.Location = new Point(28, 268);
            cmbMenuler.Name = "cmbMenuler";
            cmbMenuler.Size = new Size(255, 28);
            cmbMenuler.TabIndex = 2;
            // 
            // grpBoyutlar
            // 
            grpBoyutlar.Controls.Add(rdbBuyuk);
            grpBoyutlar.Controls.Add(rdbOrta);
            grpBoyutlar.Controls.Add(rdbKucuk);
            grpBoyutlar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpBoyutlar.ForeColor = Color.Turquoise;
            grpBoyutlar.Location = new Point(32, 313);
            grpBoyutlar.Name = "grpBoyutlar";
            grpBoyutlar.Size = new Size(250, 125);
            grpBoyutlar.TabIndex = 3;
            grpBoyutlar.TabStop = false;
            grpBoyutlar.Text = "BOYUT SEÇİNİZ";
            // 
            // rdbBuyuk
            // 
            rdbBuyuk.AutoSize = true;
            rdbBuyuk.Location = new Point(161, 57);
            rdbBuyuk.Name = "rdbBuyuk";
            rdbBuyuk.Size = new Size(74, 24);
            rdbBuyuk.TabIndex = 2;
            rdbBuyuk.TabStop = true;
            rdbBuyuk.Text = "Büyük";
            rdbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rdbOrta
            // 
            rdbOrta.AutoSize = true;
            rdbOrta.Location = new Point(94, 57);
            rdbOrta.Name = "rdbOrta";
            rdbOrta.Size = new Size(61, 24);
            rdbOrta.TabIndex = 1;
            rdbOrta.TabStop = true;
            rdbOrta.Text = "Orta";
            rdbOrta.UseVisualStyleBackColor = true;
            // 
            // rdbKucuk
            // 
            rdbKucuk.AutoSize = true;
            rdbKucuk.Location = new Point(15, 57);
            rdbKucuk.Name = "rdbKucuk";
            rdbKucuk.Size = new Size(73, 24);
            rdbKucuk.TabIndex = 0;
            rdbKucuk.TabStop = true;
            rdbKucuk.Text = "Küçük";
            rdbKucuk.UseVisualStyleBackColor = true;
            // 
            // flpEkstraMalzemeler
            // 
            flpEkstraMalzemeler.Location = new Point(33, 476);
            flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            flpEkstraMalzemeler.Size = new Size(250, 125);
            flpEkstraMalzemeler.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(28, 448);
            label2.Name = "label2";
            label2.Size = new Size(201, 20);
            label2.TabIndex = 5;
            label2.Text = "EKSTRA MALZEME SEÇİNİZ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 617);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 6;
            label3.Text = "ADET";
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(134, 618);
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(150, 27);
            nmrAdet.TabIndex = 7;
            nmrAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.BackColor = Color.PaleTurquoise;
            btnSiparisEkle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisEkle.ForeColor = Color.Red;
            btnSiparisEkle.Location = new Point(32, 665);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(267, 64);
            btnSiparisEkle.TabIndex = 8;
            btnSiparisEkle.Text = "SİPARİŞ EKLE";
            btnSiparisEkle.UseVisualStyleBackColor = false;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // lstSiparisler
            // 
            lstSiparisler.FormattingEnabled = true;
            lstSiparisler.ItemHeight = 20;
            lstSiparisler.Location = new Point(306, 14);
            lstSiparisler.Name = "lstSiparisler";
            lstSiparisler.Size = new Size(581, 464);
            lstSiparisler.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(443, 504);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 10;
            label4.Text = "TOPLAM TUTAR";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamTutar.ForeColor = Color.Red;
            lblToplamTutar.Location = new Point(480, 539);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(22, 25);
            lblToplamTutar.TabIndex = 11;
            lblToplamTutar.Text = "0";
            // 
            // btnSiparisTamamla
            // 
            btnSiparisTamamla.BackColor = Color.DeepSkyBlue;
            btnSiparisTamamla.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisTamamla.ForeColor = Color.Red;
            btnSiparisTamamla.Location = new Point(602, 519);
            btnSiparisTamamla.Name = "btnSiparisTamamla";
            btnSiparisTamamla.Size = new Size(267, 64);
            btnSiparisTamamla.TabIndex = 12;
            btnSiparisTamamla.Text = "SİPARİŞİ TAMAMLA";
            btnSiparisTamamla.UseVisualStyleBackColor = false;
            btnSiparisTamamla.Click += btnSiparisTamamla_Click;
            // 
            // FormSiparis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 742);
            Controls.Add(btnSiparisTamamla);
            Controls.Add(lblToplamTutar);
            Controls.Add(label4);
            Controls.Add(lstSiparisler);
            Controls.Add(btnSiparisEkle);
            Controls.Add(nmrAdet);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(flpEkstraMalzemeler);
            Controls.Add(grpBoyutlar);
            Controls.Add(cmbMenuler);
            Controls.Add(label1);
            Controls.Add(pblogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSiparis";
            StartPosition = FormStartPosition.Manual;
            Text = "FormSiparis";
            Load += FormSiparis_Load;
            ((System.ComponentModel.ISupportInitialize)pblogo).EndInit();
            grpBoyutlar.ResumeLayout(false);
            grpBoyutlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pblogo;
        private Label label1;
        private ComboBox cmbMenuler;
        private GroupBox grpBoyutlar;
        private RadioButton rdbKucuk;
        private RadioButton rdbBuyuk;
        private RadioButton rdbOrta;
        private FlowLayoutPanel flpEkstraMalzemeler;
        private Label label2;
        private Label label3;
        private NumericUpDown nmrAdet;
        private Button btnSiparisEkle;
        private ListBox lstSiparisler;
        private Label label4;
        private Label lblToplamTutar;
        private Button btnSiparisTamamla;
    }
}