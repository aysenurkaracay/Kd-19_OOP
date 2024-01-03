namespace _21_HastaneOtomasyonu
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
            btnTest = new Button();
            lstVlist = new ListView();
            btnListele = new Button();
            btnDoktorEkle = new Button();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.Location = new Point(12, 12);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(306, 76);
            btnTest.TabIndex = 0;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // lstVlist
            // 
            lstVlist.Location = new Point(12, 106);
            lstVlist.Name = "lstVlist";
            lstVlist.Size = new Size(306, 123);
            lstVlist.TabIndex = 1;
            lstVlist.UseCompatibleStateImageBehavior = false;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(12, 260);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(148, 53);
            btnListele.TabIndex = 2;
            btnListele.Text = "Listele Formunu Aç";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnDoktorEkle
            // 
            btnDoktorEkle.Location = new Point(170, 260);
            btnDoktorEkle.Name = "btnDoktorEkle";
            btnDoktorEkle.Size = new Size(148, 53);
            btnDoktorEkle.TabIndex = 3;
            btnDoktorEkle.Text = "Doktor Ekleme Sayfasını Aç";
            btnDoktorEkle.UseVisualStyleBackColor = true;
            btnDoktorEkle.Click += btnDoktorEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 340);
            Controls.Add(btnDoktorEkle);
            Controls.Add(btnListele);
            Controls.Add(lstVlist);
            Controls.Add(btnTest);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTest;
        private ListView lstVlist;
        private Button btnListele;
        private Button btnDoktorEkle;
    }
}