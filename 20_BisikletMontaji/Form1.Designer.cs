namespace _20_BisikletMontaji
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
            cmbFren = new ComboBox();
            cmbkadro = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dtModelYil = new DateTimePicker();
            label4 = new Label();
            txtYas = new TextBox();
            btnGonder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 56);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Fren Tipi";
            // 
            // cmbFren
            // 
            cmbFren.FormattingEnabled = true;
            cmbFren.Location = new Point(136, 48);
            cmbFren.Name = "cmbFren";
            cmbFren.Size = new Size(229, 28);
            cmbFren.TabIndex = 1;
            // 
            // cmbkadro
            // 
            cmbkadro.FormattingEnabled = true;
            cmbkadro.Location = new Point(136, 96);
            cmbkadro.Name = "cmbkadro";
            cmbkadro.Size = new Size(229, 28);
            cmbkadro.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 104);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "KadroTipi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 154);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 4;
            label3.Text = "Model Yılı";
            // 
            // dtModelYil
            // 
            dtModelYil.Location = new Point(133, 147);
            dtModelYil.Name = "dtModelYil";
            dtModelYil.Size = new Size(232, 27);
            dtModelYil.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 204);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 6;
            label4.Text = "Yaşı";
            // 
            // txtYas
            // 
            txtYas.Enabled = false;
            txtYas.Location = new Point(136, 197);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(229, 27);
            txtYas.TabIndex = 7;
            // 
            // btnGonder
            // 
            btnGonder.Location = new Point(181, 243);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(152, 53);
            btnGonder.TabIndex = 8;
            btnGonder.Text = "Classa Gönder";
            btnGonder.UseVisualStyleBackColor = true;
            btnGonder.Click += btnGonder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 321);
            Controls.Add(btnGonder);
            Controls.Add(txtYas);
            Controls.Add(label4);
            Controls.Add(dtModelYil);
            Controls.Add(label3);
            Controls.Add(cmbkadro);
            Controls.Add(label2);
            Controls.Add(cmbFren);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbFren;
        private ComboBox cmbkadro;
        private Label label2;
        private Label label3;
        private DateTimePicker dtModelYil;
        private Label label4;
        private TextBox txtYas;
        private Button btnGonder;
    }
}