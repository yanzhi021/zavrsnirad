namespace zavrsnirad
{
    partial class Gost
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
            btnZaOvdje = new Button();
            btnZaVan = new Button();
            SuspendLayout();
            // 
            // btnZaOvdje
            // 
            btnZaOvdje.Location = new Point(188, 188);
            btnZaOvdje.Name = "btnZaOvdje";
            btnZaOvdje.Size = new Size(94, 29);
            btnZaOvdje.TabIndex = 0;
            btnZaOvdje.Text = "Za ovdje";
            btnZaOvdje.UseVisualStyleBackColor = true;
            btnZaOvdje.Click += btnZaOvdje_Click;
            // 
            // btnZaVan
            // 
            btnZaVan.Location = new Point(483, 188);
            btnZaVan.Name = "btnZaVan";
            btnZaVan.Size = new Size(94, 29);
            btnZaVan.TabIndex = 1;
            btnZaVan.Text = "Za van";
            btnZaVan.UseVisualStyleBackColor = true;
            // 
            // Gost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnZaVan);
            Controls.Add(btnZaOvdje);
            Name = "Gost";
            Text = "Gost";
            ResumeLayout(false);
        }

        #endregion

        private Button btnZaOvdje;
        private Button btnZaVan;
    }
}