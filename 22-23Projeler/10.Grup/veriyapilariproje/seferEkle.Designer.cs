
namespace veriyapilariproje
{
    partial class seferEkle
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
            this.idtxt = new System.Windows.Forms.TextBox();
            this.kalkis = new System.Windows.Forms.TextBox();
            this.dttxt = new System.Windows.Forms.TextBox();
            this.varis = new System.Windows.Forms.TextBox();
            this.ucrettxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(275, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sefer Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(264, 97);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 20);
            this.idtxt.TabIndex = 1;
            this.idtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // kalkis
            // 
            this.kalkis.Location = new System.Drawing.Point(264, 149);
            this.kalkis.Name = "kalkis";
            this.kalkis.Size = new System.Drawing.Size(100, 20);
            this.kalkis.TabIndex = 2;
            // 
            // dttxt
            // 
            this.dttxt.Location = new System.Drawing.Point(264, 123);
            this.dttxt.Name = "dttxt";
            this.dttxt.Size = new System.Drawing.Size(100, 20);
            this.dttxt.TabIndex = 3;
            this.dttxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // varis
            // 
            this.varis.Location = new System.Drawing.Point(264, 175);
            this.varis.Name = "varis";
            this.varis.Size = new System.Drawing.Size(100, 20);
            this.varis.TabIndex = 4;
            // 
            // ucrettxt
            // 
            this.ucrettxt.Location = new System.Drawing.Point(264, 201);
            this.ucrettxt.Name = "ucrettxt";
            this.ucrettxt.Size = new System.Drawing.Size(100, 20);
            this.ucrettxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Eklenecek Sefer Bilgilerini Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kalkış:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Varış:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 11;
            this.label6.Tag = "ü";
            this.label6.Text = "Ücret:";
            // 
            // seferEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(523, 463);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucrettxt);
            this.Controls.Add(this.varis);
            this.Controls.Add(this.dttxt);
            this.Controls.Add(this.kalkis);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.button1);
            this.Name = "seferEkle";
            this.Text = "seferEkle";
            this.Load += new System.EventHandler(this.seferEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox kalkis;
        private System.Windows.Forms.TextBox dttxt;
        private System.Windows.Forms.TextBox varis;
        private System.Windows.Forms.TextBox ucrettxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}