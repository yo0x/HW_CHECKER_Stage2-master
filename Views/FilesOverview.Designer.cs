namespace DropFilesTest1
{
    partial class FilesOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesOverview));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4NumCfiles = new System.Windows.Forms.Label();
            this.label4NumPythonFiles = new System.Windows.Forms.Label();
            this.label4NumJavaFiles = new System.Windows.Forms.Label();
            this.button1Cfiles = new System.Windows.Forms.Button();
            this.button2Python = new System.Windows.Forms.Button();
            this.button3Java = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "C-Files:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Python Files:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Java Files:";
            // 
            // label4NumCfiles
            // 
            this.label4NumCfiles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4NumCfiles.AutoSize = true;
            this.label4NumCfiles.Location = new System.Drawing.Point(573, 383);
            this.label4NumCfiles.Name = "label4NumCfiles";
            this.label4NumCfiles.Size = new System.Drawing.Size(13, 13);
            this.label4NumCfiles.TabIndex = 3;
            this.label4NumCfiles.Text = "0";
            // 
            // label4NumPythonFiles
            // 
            this.label4NumPythonFiles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4NumPythonFiles.AutoSize = true;
            this.label4NumPythonFiles.Location = new System.Drawing.Point(371, 404);
            this.label4NumPythonFiles.Name = "label4NumPythonFiles";
            this.label4NumPythonFiles.Size = new System.Drawing.Size(13, 13);
            this.label4NumPythonFiles.TabIndex = 4;
            this.label4NumPythonFiles.Text = "0";
            // 
            // label4NumJavaFiles
            // 
            this.label4NumJavaFiles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4NumJavaFiles.AutoSize = true;
            this.label4NumJavaFiles.Location = new System.Drawing.Point(126, 404);
            this.label4NumJavaFiles.Name = "label4NumJavaFiles";
            this.label4NumJavaFiles.Size = new System.Drawing.Size(13, 13);
            this.label4NumJavaFiles.TabIndex = 5;
            this.label4NumJavaFiles.Text = "0";
            // 
            // button1Cfiles
            // 
            this.button1Cfiles.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1Cfiles.Location = new System.Drawing.Point(563, 475);
            this.button1Cfiles.Name = "button1Cfiles";
            this.button1Cfiles.Size = new System.Drawing.Size(75, 23);
            this.button1Cfiles.TabIndex = 6;
            this.button1Cfiles.Text = "Run C-Files";
            this.button1Cfiles.UseVisualStyleBackColor = true;
            this.button1Cfiles.Click += new System.EventHandler(this.Button1Cfiles_Click);
            // 
            // button2Python
            // 
            this.button2Python.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2Python.Location = new System.Drawing.Point(374, 475);
            this.button2Python.Name = "button2Python";
            this.button2Python.Size = new System.Drawing.Size(75, 23);
            this.button2Python.TabIndex = 7;
            this.button2Python.Text = "run Python";
            this.button2Python.UseVisualStyleBackColor = true;
            // 
            // button3Java
            // 
            this.button3Java.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3Java.Location = new System.Drawing.Point(129, 475);
            this.button3Java.Name = "button3Java";
            this.button3Java.Size = new System.Drawing.Size(75, 23);
            this.button3Java.TabIndex = 8;
            this.button3Java.Text = "run java";
            this.button3Java.UseVisualStyleBackColor = true;
            // 
            // FilesOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.button3Java);
            this.Controls.Add(this.button2Python);
            this.Controls.Add(this.button1Cfiles);
            this.Controls.Add(this.label4NumJavaFiles);
            this.Controls.Add(this.label4NumPythonFiles);
            this.Controls.Add(this.label4NumCfiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FilesOverview";
            this.Text = "Files overview";
            this.Load += new System.EventHandler(this.FilesOverview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4NumCfiles;
        private System.Windows.Forms.Label label4NumPythonFiles;
        private System.Windows.Forms.Label label4NumJavaFiles;
        private System.Windows.Forms.Button button1Cfiles;
        private System.Windows.Forms.Button button2Python;
        private System.Windows.Forms.Button button3Java;
    }
}