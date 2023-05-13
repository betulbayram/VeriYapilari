
namespace veriyapilariproje
{
    partial class sefer
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
            this.label1 = new System.Windows.Forms.Label();
            this.seferEkle = new System.Windows.Forms.Button();
            this.seferSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "seferlistesi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // seferEkle
            // 
            this.seferEkle.Location = new System.Drawing.Point(108, 300);
            this.seferEkle.Name = "seferEkle";
            this.seferEkle.Size = new System.Drawing.Size(107, 23);
            this.seferEkle.TabIndex = 1;
            this.seferEkle.Text = "Sefer Ekle";
            this.seferEkle.UseVisualStyleBackColor = true;
            this.seferEkle.Click += new System.EventHandler(this.seferEkle_Click);
            // 
            // seferSil
            // 
            this.seferSil.Location = new System.Drawing.Point(285, 300);
            this.seferSil.Name = "seferSil";
            this.seferSil.Size = new System.Drawing.Size(105, 23);
            this.seferSil.TabIndex = 2;
            this.seferSil.Text = "Sefer Sil";
            this.seferSil.UseVisualStyleBackColor = true;
            this.seferSil.Click += new System.EventHandler(this.seferSil_Click);
            // 
            // sefer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seferSil);
            this.Controls.Add(this.seferEkle);
            this.Controls.Add(this.label1);
            this.Name = "sefer";
            this.Text = "sefer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button seferEkle;
        private System.Windows.Forms.Button seferSil;
    }
}