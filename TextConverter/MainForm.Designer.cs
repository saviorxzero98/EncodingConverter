namespace TextConverter
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.InputText = new System.Windows.Forms.TextBox();
            this.Base64EncodeBtn = new System.Windows.Forms.Button();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.Base64DncodeBtn = new System.Windows.Forms.Button();
            this.Md5EncodeBtn = new System.Windows.Forms.Button();
            this.Sha1EncodeBtn = new System.Windows.Forms.Button();
            this.Sha256EncodeBtn = new System.Windows.Forms.Button();
            this.Sha384EncodeBtn = new System.Windows.Forms.Button();
            this.Sha512EncodeBtn = new System.Windows.Forms.Button();
            this.UrlEncodeBtn = new System.Windows.Forms.Button();
            this.UrlDecodeBtn = new System.Windows.Forms.Button();
            this.UnicodeEncodeBtn = new System.Windows.Forms.Button();
            this.UnicodeDecodeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(15, 17);
            this.InputText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(779, 212);
            this.InputText.TabIndex = 0;
            // 
            // Base64EncodeBtn
            // 
            this.Base64EncodeBtn.Location = new System.Drawing.Point(14, 239);
            this.Base64EncodeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Base64EncodeBtn.Name = "Base64EncodeBtn";
            this.Base64EncodeBtn.Size = new System.Drawing.Size(125, 31);
            this.Base64EncodeBtn.TabIndex = 1;
            this.Base64EncodeBtn.Text = "Base64 Encode";
            this.Base64EncodeBtn.UseVisualStyleBackColor = true;
            this.Base64EncodeBtn.Click += new System.EventHandler(this.Base64EncodeBtn_Click);
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(14, 316);
            this.OutputText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(780, 212);
            this.OutputText.TabIndex = 0;
            // 
            // Base64DncodeBtn
            // 
            this.Base64DncodeBtn.Location = new System.Drawing.Point(14, 277);
            this.Base64DncodeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Base64DncodeBtn.Name = "Base64DncodeBtn";
            this.Base64DncodeBtn.Size = new System.Drawing.Size(125, 31);
            this.Base64DncodeBtn.TabIndex = 1;
            this.Base64DncodeBtn.Text = "Base64 Decode";
            this.Base64DncodeBtn.UseVisualStyleBackColor = true;
            this.Base64DncodeBtn.Click += new System.EventHandler(this.Base64DncodeBtn_Click);
            // 
            // Md5EncodeBtn
            // 
            this.Md5EncodeBtn.Location = new System.Drawing.Point(145, 239);
            this.Md5EncodeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Md5EncodeBtn.Name = "Md5EncodeBtn";
            this.Md5EncodeBtn.Size = new System.Drawing.Size(125, 31);
            this.Md5EncodeBtn.TabIndex = 1;
            this.Md5EncodeBtn.Text = "MD5 Encode";
            this.Md5EncodeBtn.UseVisualStyleBackColor = true;
            this.Md5EncodeBtn.Click += new System.EventHandler(this.Md5EncodeBtn_Click);
            // 
            // Sha1EncodeBtn
            // 
            this.Sha1EncodeBtn.Location = new System.Drawing.Point(276, 239);
            this.Sha1EncodeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sha1EncodeBtn.Name = "Sha1EncodeBtn";
            this.Sha1EncodeBtn.Size = new System.Drawing.Size(125, 31);
            this.Sha1EncodeBtn.TabIndex = 1;
            this.Sha1EncodeBtn.Text = "SHA1 Encode";
            this.Sha1EncodeBtn.UseVisualStyleBackColor = true;
            this.Sha1EncodeBtn.Click += new System.EventHandler(this.Sha1EncodeBtn_Click);
            // 
            // Sha256EncodeBtn
            // 
            this.Sha256EncodeBtn.Location = new System.Drawing.Point(276, 277);
            this.Sha256EncodeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sha256EncodeBtn.Name = "Sha256EncodeBtn";
            this.Sha256EncodeBtn.Size = new System.Drawing.Size(125, 31);
            this.Sha256EncodeBtn.TabIndex = 1;
            this.Sha256EncodeBtn.Text = "SHA256 Encode";
            this.Sha256EncodeBtn.UseVisualStyleBackColor = true;
            this.Sha256EncodeBtn.Click += new System.EventHandler(this.Sha256EncodeBtn_Click);
            // 
            // Sha384EncodeBtn
            // 
            this.Sha384EncodeBtn.Location = new System.Drawing.Point(407, 239);
            this.Sha384EncodeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sha384EncodeBtn.Name = "Sha384EncodeBtn";
            this.Sha384EncodeBtn.Size = new System.Drawing.Size(125, 31);
            this.Sha384EncodeBtn.TabIndex = 1;
            this.Sha384EncodeBtn.Text = "SHA384 Encode";
            this.Sha384EncodeBtn.UseVisualStyleBackColor = true;
            this.Sha384EncodeBtn.Click += new System.EventHandler(this.Sha384EncodeBtn_Click);
            // 
            // Sha512EncodeBtn
            // 
            this.Sha512EncodeBtn.Location = new System.Drawing.Point(407, 277);
            this.Sha512EncodeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sha512EncodeBtn.Name = "Sha512EncodeBtn";
            this.Sha512EncodeBtn.Size = new System.Drawing.Size(125, 31);
            this.Sha512EncodeBtn.TabIndex = 1;
            this.Sha512EncodeBtn.Text = "SHA512 Encode";
            this.Sha512EncodeBtn.UseVisualStyleBackColor = true;
            this.Sha512EncodeBtn.Click += new System.EventHandler(this.Sha512EncodeBtn_Click);
            // 
            // UrlEncodeBtn
            // 
            this.UrlEncodeBtn.Location = new System.Drawing.Point(538, 239);
            this.UrlEncodeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UrlEncodeBtn.Name = "UrlEncodeBtn";
            this.UrlEncodeBtn.Size = new System.Drawing.Size(125, 31);
            this.UrlEncodeBtn.TabIndex = 1;
            this.UrlEncodeBtn.Text = "URL Encode";
            this.UrlEncodeBtn.UseVisualStyleBackColor = true;
            this.UrlEncodeBtn.Click += new System.EventHandler(this.UrlEncodeBtn_Click);
            // 
            // UrlDecodeBtn
            // 
            this.UrlDecodeBtn.Location = new System.Drawing.Point(538, 277);
            this.UrlDecodeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UrlDecodeBtn.Name = "UrlDecodeBtn";
            this.UrlDecodeBtn.Size = new System.Drawing.Size(125, 31);
            this.UrlDecodeBtn.TabIndex = 1;
            this.UrlDecodeBtn.Text = "URL Decode";
            this.UrlDecodeBtn.UseVisualStyleBackColor = true;
            this.UrlDecodeBtn.Click += new System.EventHandler(this.UrlDecodeBtn_Click);
            // 
            // UnicodeEncodeBtn
            // 
            this.UnicodeEncodeBtn.Location = new System.Drawing.Point(669, 239);
            this.UnicodeEncodeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UnicodeEncodeBtn.Name = "UnicodeEncodeBtn";
            this.UnicodeEncodeBtn.Size = new System.Drawing.Size(125, 31);
            this.UnicodeEncodeBtn.TabIndex = 1;
            this.UnicodeEncodeBtn.Text = "Unicode Encode";
            this.UnicodeEncodeBtn.UseVisualStyleBackColor = true;
            this.UnicodeEncodeBtn.Click += new System.EventHandler(this.UnicodeEncodeBtn_Click);
            // 
            // UnicodeDecodeBtn
            // 
            this.UnicodeDecodeBtn.Location = new System.Drawing.Point(669, 277);
            this.UnicodeDecodeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UnicodeDecodeBtn.Name = "UnicodeDecodeBtn";
            this.UnicodeDecodeBtn.Size = new System.Drawing.Size(125, 31);
            this.UnicodeDecodeBtn.TabIndex = 1;
            this.UnicodeDecodeBtn.Text = "Unicode Decode";
            this.UnicodeDecodeBtn.UseVisualStyleBackColor = true;
            this.UnicodeDecodeBtn.Click += new System.EventHandler(this.UnicodeDecodeBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 549);
            this.Controls.Add(this.Base64DncodeBtn);
            this.Controls.Add(this.Sha512EncodeBtn);
            this.Controls.Add(this.Sha384EncodeBtn);
            this.Controls.Add(this.Sha256EncodeBtn);
            this.Controls.Add(this.Sha1EncodeBtn);
            this.Controls.Add(this.UrlDecodeBtn);
            this.Controls.Add(this.UnicodeDecodeBtn);
            this.Controls.Add(this.UnicodeEncodeBtn);
            this.Controls.Add(this.UrlEncodeBtn);
            this.Controls.Add(this.Md5EncodeBtn);
            this.Controls.Add(this.Base64EncodeBtn);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.InputText);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "編碼轉換器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Button Base64EncodeBtn;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Button Base64DncodeBtn;
        private System.Windows.Forms.Button Md5EncodeBtn;
        private System.Windows.Forms.Button Sha1EncodeBtn;
        private System.Windows.Forms.Button Sha256EncodeBtn;
        private System.Windows.Forms.Button Sha384EncodeBtn;
        private System.Windows.Forms.Button Sha512EncodeBtn;
        private System.Windows.Forms.Button UrlEncodeBtn;
        private System.Windows.Forms.Button UrlDecodeBtn;
        private System.Windows.Forms.Button UnicodeEncodeBtn;
        private System.Windows.Forms.Button UnicodeDecodeBtn;
    }
}

