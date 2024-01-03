namespace _18_InterfaceOrnek2
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
            dataGridView1 = new DataGridView();
            btnKup = new Button();
            btndortgen = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(122, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(483, 217);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // btnKup
            // 
            btnKup.Location = new Point(144, 287);
            btnKup.Name = "btnKup";
            btnKup.Size = new Size(106, 42);
            btnKup.TabIndex = 1;
            btnKup.Text = "Küp Liste";
            btnKup.UseVisualStyleBackColor = true;
            btnKup.Click += btnKup_Click;
            // 
            // btndortgen
            // 
            btndortgen.Location = new Point(429, 287);
            btndortgen.Name = "btndortgen";
            btndortgen.Size = new Size(128, 42);
            btndortgen.TabIndex = 2;
            btndortgen.Text = "Dikdörtgen Liste";
            btndortgen.UseVisualStyleBackColor = true;
            btndortgen.Click += btndortgen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btndortgen);
            Controls.Add(btnKup);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnKup;
        private Button btndortgen;
    }
}