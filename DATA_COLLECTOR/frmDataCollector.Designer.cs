
namespace DATA_COLLECTOR
{
    partial class frmDataCollector
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tboxLog = new System.Windows.Forms.TextBox();
            this.rdoInfo = new System.Windows.Forms.RadioButton();
            this.rdoDebug = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoFatal = new System.Windows.Forms.RadioButton();
            this.rdoError = new System.Windows.Forms.RadioButton();
            this.rdoWarn = new System.Windows.Forms.RadioButton();
            this.btnLogging = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtbLogging = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxLog
            // 
            this.tboxLog.Location = new System.Drawing.Point(5, 19);
            this.tboxLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxLog.Name = "tboxLog";
            this.tboxLog.Size = new System.Drawing.Size(537, 21);
            this.tboxLog.TabIndex = 1;
            this.tboxLog.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tboxLog_KeyUp);
            // 
            // rdoInfo
            // 
            this.rdoInfo.AutoSize = true;
            this.rdoInfo.Checked = true;
            this.rdoInfo.Location = new System.Drawing.Point(13, 19);
            this.rdoInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoInfo.Name = "rdoInfo";
            this.rdoInfo.Size = new System.Drawing.Size(43, 16);
            this.rdoInfo.TabIndex = 3;
            this.rdoInfo.TabStop = true;
            this.rdoInfo.Text = "info";
            this.rdoInfo.UseVisualStyleBackColor = true;
            // 
            // rdoDebug
            // 
            this.rdoDebug.AutoSize = true;
            this.rdoDebug.Location = new System.Drawing.Point(64, 19);
            this.rdoDebug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoDebug.Name = "rdoDebug";
            this.rdoDebug.Size = new System.Drawing.Size(58, 16);
            this.rdoDebug.TabIndex = 4;
            this.rdoDebug.Text = "debug";
            this.rdoDebug.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoFatal);
            this.groupBox1.Controls.Add(this.rdoError);
            this.groupBox1.Controls.Add(this.rdoWarn);
            this.groupBox1.Controls.Add(this.rdoInfo);
            this.groupBox1.Controls.Add(this.rdoDebug);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(618, 45);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Level";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoFatal
            // 
            this.rdoFatal.AutoSize = true;
            this.rdoFatal.Location = new System.Drawing.Point(240, 19);
            this.rdoFatal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoFatal.Name = "rdoFatal";
            this.rdoFatal.Size = new System.Drawing.Size(46, 16);
            this.rdoFatal.TabIndex = 7;
            this.rdoFatal.Text = "fatal";
            this.rdoFatal.UseVisualStyleBackColor = true;
            // 
            // rdoError
            // 
            this.rdoError.AutoSize = true;
            this.rdoError.Location = new System.Drawing.Point(185, 19);
            this.rdoError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoError.Name = "rdoError";
            this.rdoError.Size = new System.Drawing.Size(49, 16);
            this.rdoError.TabIndex = 6;
            this.rdoError.Text = "error";
            this.rdoError.UseVisualStyleBackColor = true;
            // 
            // rdoWarn
            // 
            this.rdoWarn.AutoSize = true;
            this.rdoWarn.Location = new System.Drawing.Point(129, 19);
            this.rdoWarn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoWarn.Name = "rdoWarn";
            this.rdoWarn.Size = new System.Drawing.Size(51, 16);
            this.rdoWarn.TabIndex = 5;
            this.rdoWarn.Text = "warn";
            this.rdoWarn.UseVisualStyleBackColor = true;
            // 
            // btnLogging
            // 
            this.btnLogging.Location = new System.Drawing.Point(547, 18);
            this.btnLogging.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogging.Name = "btnLogging";
            this.btnLogging.Size = new System.Drawing.Size(66, 21);
            this.btnLogging.TabIndex = 6;
            this.btnLogging.Text = "Logging";
            this.btnLogging.UseVisualStyleBackColor = true;
            this.btnLogging.Click += new System.EventHandler(this.btnLogging_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tboxLog);
            this.groupBox2.Controls.Add(this.btnLogging);
            this.groupBox2.Location = new System.Drawing.Point(8, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(618, 50);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logging";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtbLogging);
            this.groupBox3.Location = new System.Drawing.Point(8, 113);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(618, 234);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // rtbLogging
            // 
            this.rtbLogging.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLogging.Location = new System.Drawing.Point(5, 19);
            this.rtbLogging.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbLogging.Name = "rtbLogging";
            this.rtbLogging.Size = new System.Drawing.Size(607, 210);
            this.rtbLogging.TabIndex = 8;
            this.rtbLogging.Text = "";
            // 
            // frmDataCollector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 353);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDataCollector";
            this.Text = "log";
            this.Load += new System.EventHandler(this.frmDataCollector_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tboxLog;
        private System.Windows.Forms.RadioButton rdoInfo;
        private System.Windows.Forms.RadioButton rdoDebug;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoFatal;
        private System.Windows.Forms.RadioButton rdoError;
        private System.Windows.Forms.RadioButton rdoWarn;
        private System.Windows.Forms.Button btnLogging;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbLogging;
    }
}

