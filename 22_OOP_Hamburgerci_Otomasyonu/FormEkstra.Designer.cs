namespace _22_OOP_Hamburgerci_Otomasyonu
{
    partial class FormEkstra
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
            groupBox1 = new GroupBox();
            btnKaydet = new Button();
            nmrMalzemeFiyati = new NumericUpDown();
            label2 = new Label();
            txtMalzemeAdi = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMalzemeFiyati).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(nmrMalzemeFiyati);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMalzemeAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 248);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(0, 192, 0);
            btnKaydet.Location = new Point(95, 169);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(232, 42);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Ekstra Malzemeyi Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            // 
            // nmrMalzemeFiyati
            // 
            nmrMalzemeFiyati.Location = new Point(191, 100);
            nmrMalzemeFiyati.Name = "nmrMalzemeFiyati";
            nmrMalzemeFiyati.Size = new Size(136, 30);
            nmrMalzemeFiyati.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 102);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 2;
            label2.Text = "Fiyat:";
            // 
            // txtMalzemeAdi
            // 
            txtMalzemeAdi.Location = new Point(191, 53);
            txtMalzemeAdi.Name = "txtMalzemeAdi";
            txtMalzemeAdi.Size = new Size(125, 30);
            txtMalzemeAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 56);
            label1.Name = "label1";
            label1.Size = new Size(179, 23);
            label1.TabIndex = 0;
            label1.Text = "Ekstra Malzeme Adı: ";
            // 
            // FormEkstra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 267);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEkstra";
            StartPosition = FormStartPosition.Manual;
            Text = "FormEkstra";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMalzemeFiyati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMalzemeAdi;
        private Label label1;
        private Button btnKaydet;
        private NumericUpDown nmrMalzemeFiyati;
        private Label label2;
    }
}