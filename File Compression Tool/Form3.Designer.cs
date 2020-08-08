namespace File_Compression_Tool
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label4 = new System.Windows.Forms.Label();
            this.browsCodingScheme = new System.Windows.Forms.Button();
            this.show_In_Folder_link_lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.merge = new System.Windows.Forms.Button();
            this.browseCompressed = new System.Windows.Forms.Button();
            this.deCompress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textCompresssedFile = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textCodingSchemeFile = new System.Windows.Forms.RichTextBox();
            this.back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(170, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 27);
            this.label4.TabIndex = 24;
            this.label4.Text = "De Compress";
            // 
            // browsCodingScheme
            // 
            this.browsCodingScheme.BackColor = System.Drawing.Color.Maroon;
            this.browsCodingScheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browsCodingScheme.FlatAppearance.BorderSize = 0;
            this.browsCodingScheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browsCodingScheme.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsCodingScheme.ForeColor = System.Drawing.Color.White;
            this.browsCodingScheme.Location = new System.Drawing.Point(231, 14);
            this.browsCodingScheme.Name = "browsCodingScheme";
            this.browsCodingScheme.Size = new System.Drawing.Size(164, 40);
            this.browsCodingScheme.TabIndex = 23;
            this.browsCodingScheme.Text = "Code Scheme File";
            this.browsCodingScheme.UseVisualStyleBackColor = false;
            this.browsCodingScheme.Click += new System.EventHandler(this.button4_Click);
            // 
            // show_In_Folder_link_lb
            // 
            this.show_In_Folder_link_lb.AutoSize = true;
            this.show_In_Folder_link_lb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_In_Folder_link_lb.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_In_Folder_link_lb.ForeColor = System.Drawing.Color.White;
            this.show_In_Folder_link_lb.Location = new System.Drawing.Point(780, 55);
            this.show_In_Folder_link_lb.Name = "show_In_Folder_link_lb";
            this.show_In_Folder_link_lb.Size = new System.Drawing.Size(113, 18);
            this.show_In_Folder_link_lb.TabIndex = 22;
            this.show_In_Folder_link_lb.Text = "Show in folder";
            this.show_In_Folder_link_lb.Click += new System.EventHandler(this.show_In_Folder_link_lb_Click);
            this.show_In_Folder_link_lb.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.show_In_Folder_link_lb.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(670, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Bonus Task";
            // 
            // merge
            // 
            this.merge.BackColor = System.Drawing.Color.Maroon;
            this.merge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.merge.FlatAppearance.BorderSize = 0;
            this.merge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.merge.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.merge.ForeColor = System.Drawing.Color.White;
            this.merge.Location = new System.Drawing.Point(674, 50);
            this.merge.Name = "merge";
            this.merge.Size = new System.Drawing.Size(86, 30);
            this.merge.TabIndex = 20;
            this.merge.Text = "Merge";
            this.merge.UseVisualStyleBackColor = false;
            this.merge.Click += new System.EventHandler(this.merge_Click);
            // 
            // browseCompressed
            // 
            this.browseCompressed.BackColor = System.Drawing.Color.Maroon;
            this.browseCompressed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseCompressed.FlatAppearance.BorderSize = 0;
            this.browseCompressed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseCompressed.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseCompressed.ForeColor = System.Drawing.Color.White;
            this.browseCompressed.Location = new System.Drawing.Point(19, 14);
            this.browseCompressed.Name = "browseCompressed";
            this.browseCompressed.Size = new System.Drawing.Size(206, 40);
            this.browseCompressed.TabIndex = 19;
            this.browseCompressed.Text = "Browse Compressed File";
            this.browseCompressed.UseVisualStyleBackColor = false;
            this.browseCompressed.Click += new System.EventHandler(this.button2_Click);
            // 
            // deCompress
            // 
            this.deCompress.BackColor = System.Drawing.Color.Maroon;
            this.deCompress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deCompress.FlatAppearance.BorderSize = 0;
            this.deCompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deCompress.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deCompress.ForeColor = System.Drawing.Color.White;
            this.deCompress.Location = new System.Drawing.Point(401, 14);
            this.deCompress.Name = "deCompress";
            this.deCompress.Size = new System.Drawing.Size(124, 40);
            this.deCompress.TabIndex = 18;
            this.deCompress.Text = "De Compress";
            this.deCompress.UseVisualStyleBackColor = false;
            this.deCompress.Click += new System.EventHandler(this.deCompress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "File:";
            // 
            // textCompresssedFile
            // 
            this.textCompresssedFile.Location = new System.Drawing.Point(0, 0);
            this.textCompresssedFile.Name = "textCompresssedFile";
            this.textCompresssedFile.Size = new System.Drawing.Size(333, 316);
            this.textCompresssedFile.TabIndex = 16;
            this.textCompresssedFile.Text = "Compressed File:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textCodingSchemeFile);
            this.panel1.Controls.Add(this.textCompresssedFile);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.merge);
            this.panel1.Controls.Add(this.show_In_Folder_link_lb);
            this.panel1.Location = new System.Drawing.Point(41, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 316);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textCodingSchemeFile
            // 
            this.textCodingSchemeFile.Location = new System.Drawing.Point(339, 0);
            this.textCodingSchemeFile.Name = "textCodingSchemeFile";
            this.textCodingSchemeFile.Size = new System.Drawing.Size(325, 316);
            this.textCodingSchemeFile.TabIndex = 23;
            this.textCodingSchemeFile.Text = "Code Scheme File:";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Maroon;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(60, 34);
            this.back.TabIndex = 35;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.browseCompressed);
            this.panel2.Controls.Add(this.deCompress);
            this.panel2.Controls.Add(this.browsCodingScheme);
            this.panel2.Location = new System.Drawing.Point(41, 451);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 68);
            this.panel2.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(227, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 68);
            this.panel3.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(374, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "File:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 20);
            this.textBox1.TabIndex = 39;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(421, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 20);
            this.textBox2.TabIndex = 40;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1007, 522);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button browsCodingScheme;
        private System.Windows.Forms.Label show_In_Folder_link_lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button merge;
        private System.Windows.Forms.Button browseCompressed;
        private System.Windows.Forms.Button deCompress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textCompresssedFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox textCodingSchemeFile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}