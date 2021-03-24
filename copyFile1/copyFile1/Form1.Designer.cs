namespace copyFile1
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Source_Btn = new System.Windows.Forms.Button();
            this.Dest_Btn = new System.Windows.Forms.Button();
            this.CopyRun_Btn = new System.Windows.Forms.Button();
            this.SourceFile_TB = new System.Windows.Forms.TextBox();
            this.DestFile_TB = new System.Windows.Forms.TextBox();
            this.CopyFailFile_TB = new System.Windows.Forms.TextBox();
            this.FindInLog_Btn = new System.Windows.Forms.Button();
            this.FindInResult_Btn = new System.Windows.Forms.Button();
            this.LogFile_TB = new System.Windows.Forms.TextBox();
            this.ResultFile_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Source_Btn
            // 
            this.Source_Btn.Location = new System.Drawing.Point(322, 12);
            this.Source_Btn.Name = "Source_Btn";
            this.Source_Btn.Size = new System.Drawing.Size(75, 23);
            this.Source_Btn.TabIndex = 0;
            this.Source_Btn.Text = "Source";
            this.Source_Btn.UseVisualStyleBackColor = true;
            this.Source_Btn.Click += new System.EventHandler(this.Source_Btn_Click);
            // 
            // Dest_Btn
            // 
            this.Dest_Btn.Location = new System.Drawing.Point(322, 39);
            this.Dest_Btn.Name = "Dest_Btn";
            this.Dest_Btn.Size = new System.Drawing.Size(75, 23);
            this.Dest_Btn.TabIndex = 1;
            this.Dest_Btn.Text = "Dest";
            this.Dest_Btn.UseVisualStyleBackColor = true;
            this.Dest_Btn.Click += new System.EventHandler(this.Dest_Btn_Click);
            // 
            // CopyRun_Btn
            // 
            this.CopyRun_Btn.Location = new System.Drawing.Point(12, 124);
            this.CopyRun_Btn.Name = "CopyRun_Btn";
            this.CopyRun_Btn.Size = new System.Drawing.Size(385, 23);
            this.CopyRun_Btn.TabIndex = 2;
            this.CopyRun_Btn.Text = "Run";
            this.CopyRun_Btn.UseVisualStyleBackColor = true;
            this.CopyRun_Btn.Click += new System.EventHandler(this.CopyRun_Btn_Click);
            // 
            // SourceFile_TB
            // 
            this.SourceFile_TB.Location = new System.Drawing.Point(12, 12);
            this.SourceFile_TB.Name = "SourceFile_TB";
            this.SourceFile_TB.ReadOnly = true;
            this.SourceFile_TB.Size = new System.Drawing.Size(304, 22);
            this.SourceFile_TB.TabIndex = 3;
            // 
            // DestFile_TB
            // 
            this.DestFile_TB.Location = new System.Drawing.Point(12, 40);
            this.DestFile_TB.Name = "DestFile_TB";
            this.DestFile_TB.ReadOnly = true;
            this.DestFile_TB.Size = new System.Drawing.Size(304, 22);
            this.DestFile_TB.TabIndex = 4;
            // 
            // CopyFailFile_TB
            // 
            this.CopyFailFile_TB.Location = new System.Drawing.Point(12, 153);
            this.CopyFailFile_TB.Multiline = true;
            this.CopyFailFile_TB.Name = "CopyFailFile_TB";
            this.CopyFailFile_TB.ReadOnly = true;
            this.CopyFailFile_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CopyFailFile_TB.Size = new System.Drawing.Size(384, 237);
            this.CopyFailFile_TB.TabIndex = 5;
            // 
            // FindInLog_Btn
            // 
            this.FindInLog_Btn.Location = new System.Drawing.Point(322, 67);
            this.FindInLog_Btn.Name = "FindInLog_Btn";
            this.FindInLog_Btn.Size = new System.Drawing.Size(75, 23);
            this.FindInLog_Btn.TabIndex = 6;
            this.FindInLog_Btn.Text = "FindLog";
            this.FindInLog_Btn.UseVisualStyleBackColor = true;
            this.FindInLog_Btn.Click += new System.EventHandler(this.FindInLog_Btn_Click);
            // 
            // FindInResult_Btn
            // 
            this.FindInResult_Btn.Location = new System.Drawing.Point(322, 95);
            this.FindInResult_Btn.Name = "FindInResult_Btn";
            this.FindInResult_Btn.Size = new System.Drawing.Size(75, 23);
            this.FindInResult_Btn.TabIndex = 7;
            this.FindInResult_Btn.Text = "FindResult";
            this.FindInResult_Btn.UseVisualStyleBackColor = true;
            this.FindInResult_Btn.Click += new System.EventHandler(this.FindInResult_Btn_Click);
            // 
            // LogFile_TB
            // 
            this.LogFile_TB.Location = new System.Drawing.Point(12, 68);
            this.LogFile_TB.Name = "LogFile_TB";
            this.LogFile_TB.ReadOnly = true;
            this.LogFile_TB.Size = new System.Drawing.Size(304, 22);
            this.LogFile_TB.TabIndex = 8;
            // 
            // ResultFile_TB
            // 
            this.ResultFile_TB.Location = new System.Drawing.Point(12, 96);
            this.ResultFile_TB.Name = "ResultFile_TB";
            this.ResultFile_TB.ReadOnly = true;
            this.ResultFile_TB.Size = new System.Drawing.Size(304, 22);
            this.ResultFile_TB.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(444, 403);
            this.Controls.Add(this.ResultFile_TB);
            this.Controls.Add(this.LogFile_TB);
            this.Controls.Add(this.FindInResult_Btn);
            this.Controls.Add(this.FindInLog_Btn);
            this.Controls.Add(this.CopyFailFile_TB);
            this.Controls.Add(this.DestFile_TB);
            this.Controls.Add(this.SourceFile_TB);
            this.Controls.Add(this.CopyRun_Btn);
            this.Controls.Add(this.Dest_Btn);
            this.Controls.Add(this.Source_Btn);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CopyFile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Source_Btn;
        private System.Windows.Forms.Button Dest_Btn;
        private System.Windows.Forms.Button CopyRun_Btn;
        private System.Windows.Forms.TextBox SourceFile_TB;
        private System.Windows.Forms.TextBox DestFile_TB;
        private System.Windows.Forms.TextBox CopyFailFile_TB;
        private System.Windows.Forms.Button FindInLog_Btn;
        private System.Windows.Forms.Button FindInResult_Btn;
        private System.Windows.Forms.TextBox LogFile_TB;
        private System.Windows.Forms.TextBox ResultFile_TB;
    }
}

