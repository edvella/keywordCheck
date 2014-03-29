namespace keywordChecker
{
    partial class frmSettings
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
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblKeywords = new System.Windows.Forms.Label();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.brwPreview = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.Location = new System.Drawing.Point(12, 16);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(61, 23);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "URL";
            this.lblUrl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(79, 13);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(201, 20);
            this.txtUrl.TabIndex = 1;
            // 
            // lblKeywords
            // 
            this.lblKeywords.Location = new System.Drawing.Point(12, 44);
            this.lblKeywords.Name = "lblKeywords";
            this.lblKeywords.Size = new System.Drawing.Size(61, 23);
            this.lblKeywords.TabIndex = 2;
            this.lblKeywords.Text = "Keywords";
            this.lblKeywords.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtKeywords
            // 
            this.txtKeywords.Location = new System.Drawing.Point(79, 41);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(201, 20);
            this.txtKeywords.TabIndex = 3;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(205, 81);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(12, 117);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(268, 135);
            this.lblResult.TabIndex = 5;
            // 
            // brwPreview
            // 
            this.brwPreview.Location = new System.Drawing.Point(287, 13);
            this.brwPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.brwPreview.Name = "brwPreview";
            this.brwPreview.Size = new System.Drawing.Size(331, 239);
            this.brwPreview.TabIndex = 6;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 261);
            this.Controls.Add(this.brwPreview);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtKeywords);
            this.Controls.Add(this.lblKeywords);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Name = "frmSettings";
            this.Text = "Keyword Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblKeywords;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.WebBrowser brwPreview;
    }
}

