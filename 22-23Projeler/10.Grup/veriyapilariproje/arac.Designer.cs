
namespace veriyapilariproje
{
    partial class arac
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.csvLink = new System.Windows.Forms.TextBox();
            this.gozatbtn = new System.Windows.Forms.Button();
            this.dosyaacici = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.CausesValidation = false;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(104, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ARAÇ EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(215, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "ARAÇ SİL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(885, 384);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // csvLink
            // 
            this.csvLink.Location = new System.Drawing.Point(437, 55);
            this.csvLink.Name = "csvLink";
            this.csvLink.Size = new System.Drawing.Size(554, 20);
            this.csvLink.TabIndex = 6;
            this.csvLink.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gozatbtn
            // 
            this.gozatbtn.ForeColor = System.Drawing.Color.Black;
            this.gozatbtn.Location = new System.Drawing.Point(326, 52);
            this.gozatbtn.Name = "gozatbtn";
            this.gozatbtn.Size = new System.Drawing.Size(105, 23);
            this.gozatbtn.TabIndex = 7;
            this.gozatbtn.Text = "GÖZ AT";
            this.gozatbtn.UseVisualStyleBackColor = true;
            this.gozatbtn.Click += new System.EventHandler(this.gozatbtn_Click);
            // 
            // dosyaacici
            // 
            this.dosyaacici.FileName = "dosyaacici";
            this.dosyaacici.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // arac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 622);
            this.Controls.Add(this.gozatbtn);
            this.Controls.Add(this.csvLink);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "arac";
            this.Text = "arac";
            this.Load += new System.EventHandler(this.arac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox csvLink;
        private System.Windows.Forms.Button gozatbtn;
        private System.Windows.Forms.OpenFileDialog dosyaacici;
    }
}