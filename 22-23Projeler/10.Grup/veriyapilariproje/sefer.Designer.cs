
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
            this.sefrgözat = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // seferEkle
            // 
            this.seferEkle.Location = new System.Drawing.Point(60, 50);
            this.seferEkle.Name = "seferEkle";
            this.seferEkle.Size = new System.Drawing.Size(107, 23);
            this.seferEkle.TabIndex = 1;
            this.seferEkle.Text = "Sefer Ekle";
            this.seferEkle.UseVisualStyleBackColor = true;
            this.seferEkle.Click += new System.EventHandler(this.seferEkle_Click);
            // 
            // seferSil
            // 
            this.seferSil.Location = new System.Drawing.Point(194, 50);
            this.seferSil.Name = "seferSil";
            this.seferSil.Size = new System.Drawing.Size(105, 23);
            this.seferSil.TabIndex = 2;
            this.seferSil.Text = "Sefer Sil";
            this.seferSil.UseVisualStyleBackColor = true;
            this.seferSil.Click += new System.EventHandler(this.seferSil_Click);
            // 
            // sefrgözat
            // 
            this.sefrgözat.Location = new System.Drawing.Point(337, 50);
            this.sefrgözat.Name = "sefrgözat";
            this.sefrgözat.Size = new System.Drawing.Size(107, 23);
            this.sefrgözat.TabIndex = 3;
            this.sefrgözat.Text = "Göz At";
            this.sefrgözat.UseVisualStyleBackColor = true;
            this.sefrgözat.Click += new System.EventHandler(this.sefrgözat_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(471, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 326);
            this.dataGridView1.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sefer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(902, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sefrgözat);
            this.Controls.Add(this.seferSil);
            this.Controls.Add(this.seferEkle);
            this.Controls.Add(this.label1);
            this.Name = "sefer";
            this.Text = "sefer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button seferEkle;
        private System.Windows.Forms.Button seferSil;
        private System.Windows.Forms.Button sefrgözat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}