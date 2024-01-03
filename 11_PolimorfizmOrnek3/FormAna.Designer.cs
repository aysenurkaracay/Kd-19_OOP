namespace _11_PolimorfizmOrnek3
{
    partial class FormAna
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
            menuStrip1 = new MenuStrip();
            ürünlerToolStripMenuItem = new ToolStripMenuItem();
            silindirProfilToolStripMenuItem = new ToolStripMenuItem();
            dörtgenProfilToolStripMenuItem = new ToolStripMenuItem();
            küpProfilToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ürünlerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(258, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ürünlerToolStripMenuItem
            // 
            ürünlerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { silindirProfilToolStripMenuItem, dörtgenProfilToolStripMenuItem, küpProfilToolStripMenuItem });
            ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            ürünlerToolStripMenuItem.Size = new Size(75, 24);
            ürünlerToolStripMenuItem.Text = " Ürünler";
            // 
            // silindirProfilToolStripMenuItem
            // 
            silindirProfilToolStripMenuItem.Name = "silindirProfilToolStripMenuItem";
            silindirProfilToolStripMenuItem.Size = new Size(224, 26);
            silindirProfilToolStripMenuItem.Text = "SilindirProfil";
            silindirProfilToolStripMenuItem.Click += silindirProfilToolStripMenuItem_Click;
            // 
            // dörtgenProfilToolStripMenuItem
            // 
            dörtgenProfilToolStripMenuItem.Name = "dörtgenProfilToolStripMenuItem";
            dörtgenProfilToolStripMenuItem.Size = new Size(224, 26);
            dörtgenProfilToolStripMenuItem.Text = "Dörtgen Profil";
            dörtgenProfilToolStripMenuItem.Click += dörtgenProfilToolStripMenuItem_Click;
            // 
            // küpProfilToolStripMenuItem
            // 
            küpProfilToolStripMenuItem.Name = "küpProfilToolStripMenuItem";
            küpProfilToolStripMenuItem.Size = new Size(224, 26);
            küpProfilToolStripMenuItem.Text = "Küp Profil";
            küpProfilToolStripMenuItem.Click += küpProfilToolStripMenuItem_Click;
            // 
            // FormAna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 273);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormAna";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ürünlerToolStripMenuItem;
        private ToolStripMenuItem silindirProfilToolStripMenuItem;
        private ToolStripMenuItem dörtgenProfilToolStripMenuItem;
        private ToolStripMenuItem küpProfilToolStripMenuItem;
    }
}