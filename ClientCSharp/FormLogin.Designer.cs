namespace ClientCSharp
{
    partial class FormLogin
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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(263, 141);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(263, 167);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(263, 227);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "로그인";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(263, 256);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "회원가입";
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(241, 207);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(130, 14);
            this.hyperlinkLabelControl1.TabIndex = 4;
            this.hyperlinkLabelControl1.Text = "비밀번호를 잊어버리셨나요?";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(187, 144);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 14);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "아이디";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(187, 170);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 14);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "비밀번호";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 336);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Name = "FormLogin";
            this.Text = "캐치마인드";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}