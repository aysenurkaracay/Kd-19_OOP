namespace _21_HastaneOtomasyonu
{
    partial class Listele
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
            lstvDoktorlar = new ListView();
            SuspendLayout();
            // 
            // lstvDoktorlar
            // 
            lstvDoktorlar.Dock = DockStyle.Fill;
            lstvDoktorlar.Location = new Point(0, 0);
            lstvDoktorlar.Name = "lstvDoktorlar";
            lstvDoktorlar.Size = new Size(320, 322);
            lstvDoktorlar.TabIndex = 0;
            lstvDoktorlar.UseCompatibleStateImageBehavior = false;
            // 
            // Listele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 322);
            Controls.Add(lstvDoktorlar);
            Name = "Listele";
            Text = "Listele";
            Load += Listele_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lstvDoktorlar;
    }
}