
namespace veriyapilariproje
{
    partial class islem
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
            this.button3 = new System.Windows.Forms.Button();
            this.CikisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(56, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 94);
            this.button1.TabIndex = 0;
            this.button1.Text = "ARAÇLARIMIZ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(56, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 94);
            this.button2.TabIndex = 1;
            this.button2.Text = "PERSONELLERİMİZ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(56, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 94);
            this.button3.TabIndex = 2;
            this.button3.Text = "SEFERLERMİZ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CikisYap
            // 
            this.CikisYap.BackColor = System.Drawing.Color.LightGray;
            this.CikisYap.Location = new System.Drawing.Point(660, 12);
            this.CikisYap.Name = "CikisYap";
            this.CikisYap.Size = new System.Drawing.Size(75, 23);
            this.CikisYap.TabIndex = 3;
            this.CikisYap.Text = "Çıkış Yap";
            this.CikisYap.UseVisualStyleBackColor = false;
            this.CikisYap.Click += new System.EventHandler(this.CikisYap_Click);
            // 
            // islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::veriyapilariproje.Properties.Resources.LüksArtvinv2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CikisYap);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "islem";
            this.Text = "islem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button CikisYap;
    }
}