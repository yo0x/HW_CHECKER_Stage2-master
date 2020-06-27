namespace DropFilesTest1
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.UserName = new System.Windows.Forms.Label();
            this.UN = new System.Windows.Forms.TextBox();
            this.PassWord = new System.Windows.Forms.Label();
            this.PW = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(358, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(381, 126);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // UserName
            // 
            this.UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.OrangeRed;
            this.UserName.Location = new System.Drawing.Point(95, 358);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(158, 31);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "UserName";
            // 
            // UN
            // 
            this.UN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UN.Location = new System.Drawing.Point(358, 358);
            this.UN.Multiline = true;
            this.UN.Name = "UN";
            this.UN.Size = new System.Drawing.Size(365, 41);
            this.UN.TabIndex = 3;
            // 
            // PassWord
            // 
            this.PassWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PassWord.AutoSize = true;
            this.PassWord.BackColor = System.Drawing.Color.Transparent;
            this.PassWord.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWord.ForeColor = System.Drawing.Color.OrangeRed;
            this.PassWord.Location = new System.Drawing.Point(95, 423);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(152, 31);
            this.PassWord.TabIndex = 4;
            this.PassWord.Text = "PassWord";
            // 
            // PW
            // 
            this.PW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PW.Location = new System.Drawing.Point(358, 423);
            this.PW.Multiline = true;
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(365, 41);
            this.PW.TabIndex = 5;
            // 
            // Enter
            // 
            this.Enter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Enter.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Location = new System.Drawing.Point(623, 592);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(154, 53);
            this.Enter.TabIndex = 7;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(288, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.UN);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.pictureBox2);
            this.Name = "SignIn";
            this.Text = "Main";
            this.MaximizedBoundsChanged += new System.EventHandler(this.Enter_Click);
            this.MaximumSizeChanged += new System.EventHandler(this.Enter_Click);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox UN;
        private System.Windows.Forms.Label PassWord;
        private System.Windows.Forms.TextBox PW;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button button1;
    }
}