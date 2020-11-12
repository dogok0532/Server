namespace ServerCSharp
{
    partial class MainForm
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
            this.txtRunInfo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.txtClientResult = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRunInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientResult.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRunInfo
            // 
            this.txtRunInfo.Location = new System.Drawing.Point(88, 12);
            this.txtRunInfo.Name = "txtRunInfo";
            this.txtRunInfo.Size = new System.Drawing.Size(100, 20);
            this.txtRunInfo.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "labelControl1";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(398, 413);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "실행";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(479, 413);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "정지";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtClientResult
            // 
            this.txtClientResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientResult.Location = new System.Drawing.Point(208, 14);
            this.txtClientResult.Name = "txtClientResult";
            this.txtClientResult.Size = new System.Drawing.Size(346, 393);
            this.txtClientResult.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 448);
            this.Controls.Add(this.txtClientResult);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtRunInfo);
            this.Name = "MainForm";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.txtRunInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientResult.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtRunInfo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.SimpleButton btnStop;
        private DevExpress.XtraEditors.MemoEdit txtClientResult;
    }
}