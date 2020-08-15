namespace File_Compression_Tool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainDecompress = new System.Windows.Forms.Button();
            this.mainCompress = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(136, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "File Compression Tool";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.mainDecompress);
            this.panel1.Controls.Add(this.mainCompress);
            this.panel1.Location = new System.Drawing.Point(345, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 311);
            this.panel1.TabIndex = 9;
            // 
            // mainDecompress
            // 
            this.mainDecompress.BackColor = System.Drawing.Color.Maroon;
            this.mainDecompress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainDecompress.FlatAppearance.BorderSize = 0;
            this.mainDecompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainDecompress.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDecompress.ForeColor = System.Drawing.Color.White;
            this.mainDecompress.Location = new System.Drawing.Point(32, 150);
            this.mainDecompress.Name = "mainDecompress";
            this.mainDecompress.Size = new System.Drawing.Size(254, 68);
            this.mainDecompress.TabIndex = 1;
            this.mainDecompress.Text = "De Compress";
            this.mainDecompress.UseVisualStyleBackColor = false;
            this.mainDecompress.Click += new System.EventHandler(this.button2_Click);
            this.mainDecompress.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // mainCompress
            // 
            this.mainCompress.BackColor = System.Drawing.Color.Maroon;
            this.mainCompress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainCompress.FlatAppearance.BorderSize = 0;
            this.mainCompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainCompress.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCompress.ForeColor = System.Drawing.Color.White;
            this.mainCompress.Location = new System.Drawing.Point(32, 54);
            this.mainCompress.Name = "mainCompress";
            this.mainCompress.Size = new System.Drawing.Size(254, 67);
            this.mainCompress.TabIndex = 0;
            this.mainCompress.Text = "Compress";
            this.mainCompress.UseVisualStyleBackColor = false;
            this.mainCompress.Click += new System.EventHandler(this.button1_Click);
            this.mainCompress.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(221, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 100);
            this.panel2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1007, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mainDecompress;
        private System.Windows.Forms.Button mainCompress;
        private System.Windows.Forms.Panel panel2;
    }
}

