using System;

namespace steganograhy_project
{
    partial class steganographyFrm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnENCRYPT = new System.Windows.Forms.Button();
            this.btn_textENCRYPT = new System.Windows.Forms.Button();
            this.btn_imageENCRYPT = new System.Windows.Forms.Button();
            this.textENCRYPT = new System.Windows.Forms.TextBox();
            this.imageENCRYPT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDECRYPT = new System.Windows.Forms.Button();
            this.btn_textDECRYPT = new System.Windows.Forms.Button();
            this.btn_imageDECRYPT = new System.Windows.Forms.Button();
            this.textDECRYPT = new System.Windows.Forms.TextBox();
            this.imgDECRYPT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dialog_imageENCRYPT = new System.Windows.Forms.OpenFileDialog();
            this.dialog_textENCRYPT = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.savetextENCRYPT = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.savetextDECRYPT = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordENCRYPT = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(462, 240);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(454, 214);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encryption";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordENCRYPT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnENCRYPT);
            this.groupBox1.Controls.Add(this.btn_textENCRYPT);
            this.groupBox1.Controls.Add(this.btn_imageENCRYPT);
            this.groupBox1.Controls.Add(this.textENCRYPT);
            this.groupBox1.Controls.Add(this.imageENCRYPT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnENCRYPT
            // 
            this.btnENCRYPT.Location = new System.Drawing.Point(164, 140);
            this.btnENCRYPT.Name = "btnENCRYPT";
            this.btnENCRYPT.Size = new System.Drawing.Size(75, 23);
            this.btnENCRYPT.TabIndex = 3;
            this.btnENCRYPT.Text = "Hide";
            this.btnENCRYPT.UseVisualStyleBackColor = true;
            this.btnENCRYPT.Click += new System.EventHandler(this.btnENCRYPT_Click);
            // 
            // btn_textENCRYPT
            // 
            this.btn_textENCRYPT.Location = new System.Drawing.Point(286, 56);
            this.btn_textENCRYPT.Name = "btn_textENCRYPT";
            this.btn_textENCRYPT.Size = new System.Drawing.Size(75, 23);
            this.btn_textENCRYPT.TabIndex = 2;
            this.btn_textENCRYPT.Text = "Browse";
            this.btn_textENCRYPT.UseVisualStyleBackColor = true;
            this.btn_textENCRYPT.Click += new System.EventHandler(this.btn_textENCRYPT_Click);
            // 
            // btn_imageENCRYPT
            // 
            this.btn_imageENCRYPT.Location = new System.Drawing.Point(286, 21);
            this.btn_imageENCRYPT.Name = "btn_imageENCRYPT";
            this.btn_imageENCRYPT.Size = new System.Drawing.Size(75, 23);
            this.btn_imageENCRYPT.TabIndex = 2;
            this.btn_imageENCRYPT.Text = "Browse";
            this.btn_imageENCRYPT.UseVisualStyleBackColor = true;
            this.btn_imageENCRYPT.Click += new System.EventHandler(this.btn_imageENCRYPT_Click);
            // 
            // textENCRYPT
            // 
            this.textENCRYPT.Location = new System.Drawing.Point(114, 59);
            this.textENCRYPT.Name = "textENCRYPT";
            this.textENCRYPT.Size = new System.Drawing.Size(152, 20);
            this.textENCRYPT.TabIndex = 1;
            // 
            // imageENCRYPT
            // 
            this.imageENCRYPT.Location = new System.Drawing.Point(114, 25);
            this.imageENCRYPT.Name = "imageENCRYPT";
            this.imageENCRYPT.Size = new System.Drawing.Size(152, 20);
            this.imageENCRYPT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Upload Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upload Image";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(454, 214);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decryption";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDECRYPT);
            this.groupBox2.Controls.Add(this.btn_textDECRYPT);
            this.groupBox2.Controls.Add(this.btn_imageDECRYPT);
            this.groupBox2.Controls.Add(this.textDECRYPT);
            this.groupBox2.Controls.Add(this.imgDECRYPT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(39, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnDECRYPT
            // 
            this.btnDECRYPT.Location = new System.Drawing.Point(164, 108);
            this.btnDECRYPT.Name = "btnDECRYPT";
            this.btnDECRYPT.Size = new System.Drawing.Size(75, 23);
            this.btnDECRYPT.TabIndex = 3;
            this.btnDECRYPT.Text = "Extract";
            this.btnDECRYPT.UseVisualStyleBackColor = true;
            this.btnDECRYPT.Click += new System.EventHandler(this.btnDECRYPT_Click);
            // 
            // btn_textDECRYPT
            // 
            this.btn_textDECRYPT.Location = new System.Drawing.Point(286, 56);
            this.btn_textDECRYPT.Name = "btn_textDECRYPT";
            this.btn_textDECRYPT.Size = new System.Drawing.Size(75, 23);
            this.btn_textDECRYPT.TabIndex = 2;
            this.btn_textDECRYPT.Text = "Browse";
            this.btn_textDECRYPT.UseVisualStyleBackColor = true;
            this.btn_textDECRYPT.Click += new System.EventHandler(this.btn_textDECRYPT_Click);
            // 
            // btn_imageDECRYPT
            // 
            this.btn_imageDECRYPT.Location = new System.Drawing.Point(286, 21);
            this.btn_imageDECRYPT.Name = "btn_imageDECRYPT";
            this.btn_imageDECRYPT.Size = new System.Drawing.Size(75, 23);
            this.btn_imageDECRYPT.TabIndex = 2;
            this.btn_imageDECRYPT.Text = "Browse";
            this.btn_imageDECRYPT.UseVisualStyleBackColor = true;
            this.btn_imageDECRYPT.Click += new System.EventHandler(this.btn_imageDECRYPT_Click);
            // 
            // textDECRYPT
            // 
            this.textDECRYPT.Location = new System.Drawing.Point(114, 59);
            this.textDECRYPT.Name = "textDECRYPT";
            this.textDECRYPT.Size = new System.Drawing.Size(152, 20);
            this.textDECRYPT.TabIndex = 1;
            // 
            // imgDECRYPT
            // 
            this.imgDECRYPT.Location = new System.Drawing.Point(114, 25);
            this.imgDECRYPT.Name = "imgDECRYPT";
            this.imgDECRYPT.Size = new System.Drawing.Size(152, 20);
            this.imgDECRYPT.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Save Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Upload Image";
            // 
            // dialog_imageENCRYPT
            // 
            this.dialog_imageENCRYPT.Filter = "JPG Files (*.jpg)|*.jpg|All files(*.*)|*.*";
            // 
            // dialog_textENCRYPT
            // 
            this.dialog_textENCRYPT.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // savetextENCRYPT
            // 
            this.savetextENCRYPT.Filter = "JPG Files (*.jpg)|*.jpg";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 301);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(464, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabel1.Text = "Okay";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(198, 260);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter Password";
            // 
            // passwordENCRYPT
            // 
            this.passwordENCRYPT.Location = new System.Drawing.Point(114, 101);
            this.passwordENCRYPT.Name = "passwordENCRYPT";
            this.passwordENCRYPT.Size = new System.Drawing.Size(152, 20);
            this.passwordENCRYPT.TabIndex = 5;
            // 
            // steganographyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 323);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "steganographyFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_textENCRYPT;
        private System.Windows.Forms.Button btn_imageENCRYPT;
        private System.Windows.Forms.TextBox textENCRYPT;
        private System.Windows.Forms.TextBox imageENCRYPT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnENCRYPT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDECRYPT;
        private System.Windows.Forms.Button btn_textDECRYPT;
        private System.Windows.Forms.Button btn_imageDECRYPT;
        private System.Windows.Forms.TextBox textDECRYPT;
        private System.Windows.Forms.TextBox imgDECRYPT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog dialog_imageENCRYPT;
        private System.Windows.Forms.OpenFileDialog dialog_textENCRYPT;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.SaveFileDialog savetextENCRYPT;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.FolderBrowserDialog savetextDECRYPT;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox passwordENCRYPT;
        private System.Windows.Forms.Label label5;
    }
}

