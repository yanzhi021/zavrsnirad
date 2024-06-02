namespace zavrsnirad
{
    partial class NarudžbaZaOvdje
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
            label1 = new Label();
            txbBrojStola = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Broj stola:";
            // 
            // txbBrojStola
            // 
            txbBrojStola.Location = new Point(105, 6);
            txbBrojStola.Name = "txbBrojStola";
            txbBrojStola.Size = new Size(125, 27);
            txbBrojStola.TabIndex = 2;
            // 
            // NarudžbaZaOvdje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txbBrojStola);
            Controls.Add(label1);
            Name = "NarudžbaZaOvdje";
            Text = "NarudžbaZaOvdje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbBrojStola;
    }
}