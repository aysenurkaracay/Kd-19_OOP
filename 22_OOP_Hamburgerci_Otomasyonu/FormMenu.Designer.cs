namespace _22_OOP_Hamburgerci_Otomasyonu
{
    partial class FormMenu
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
            nmrMenuFiyati = new NumericUpDown();
            label2 = new Label();
            txtMenuAdi = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMenuFiyati).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(nmrMenuFiyati);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMenuAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 248);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "MENÜ BİLGİLERİ";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(0, 192, 0);
            btnKaydet.Location = new Point(95, 169);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(232, 42);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "MENÜYÜ KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            // 
            // nmrMenuFiyati
            // 
            nmrMenuFiyati.Location = new Point(191, 100);
            nmrMenuFiyati.Name = "nmrMenuFiyati";
            nmrMenuFiyati.Size = new Size(136, 30);
            nmrMenuFiyati.TabIndex = 3;
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
            // txtMenuAdi
            // 
            txtMenuAdi.Location = new Point(191, 53);
            txtMenuAdi.Name = "txtMenuAdi";
            txtMenuAdi.Size = new Size(125, 30);
            txtMenuAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 56);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 0;
            label1.Text = "Menü Adı: ";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 274);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            StartPosition = FormStartPosition.Manual;
            Text = "FormMenu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMenuFiyati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnKaydet;
        private NumericUpDown nmrMenuFiyati;
        private Label label2;
        private TextBox txtMenuAdi;
        private Label label1;
    }
}