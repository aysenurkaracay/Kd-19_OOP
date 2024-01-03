namespace _06_Kapsulleme3
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
            label1 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            label2 = new Label();
            txtTC = new TextBox();
            label3 = new Label();
            btnKaydet = new Button();
            btnSil = new Button();
            lstKayit = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 31);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(139, 28);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(139, 78);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 81);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Soyad";
            // 
            // txtTC
            // 
            txtTC.Location = new Point(139, 127);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(125, 27);
            txtTC.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 130);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 4;
            label3.Text = "TC";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(83, 175);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(65, 30);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(178, 175);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(65, 30);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // lstKayit
            // 
            lstKayit.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lstKayit.Dock = DockStyle.Bottom;
            lstKayit.FullRowSelect = true;
            lstKayit.GridLines = true;
            lstKayit.Location = new Point(0, 230);
            lstKayit.Name = "lstKayit";
            lstKayit.Size = new Size(489, 162);
            lstKayit.TabIndex = 8;
            lstKayit.UseCompatibleStateImageBehavior = false;
            lstKayit.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "TC";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyad";
            columnHeader3.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 392);
            Controls.Add(lstKayit);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(txtTC);
            Controls.Add(label3);
            Controls.Add(txtSoyad);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label label2;
        private TextBox txtTC;
        private Label label3;
        private Button btnKaydet;
        private Button btnSil;
        private ListView lstKayit;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}