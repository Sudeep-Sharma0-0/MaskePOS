namespace MaskeyPOS
{
    partial class LoginForm
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
            this.baseFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.idlabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.baseFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseFlowLayout
            // 
            this.baseFlowLayout.AutoSize = true;
            this.baseFlowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.baseFlowLayout.Controls.Add(this.splitContainer1);
            this.baseFlowLayout.Location = new System.Drawing.Point(234, 159);
            this.baseFlowLayout.Name = "baseFlowLayout";
            this.baseFlowLayout.Padding = new System.Windows.Forms.Padding(10);
            this.baseFlowLayout.Size = new System.Drawing.Size(305, 170);
            this.baseFlowLayout.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(13, 13);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.idlabel);
            this.splitContainer1.Panel1.Controls.Add(this.passLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.passBox);
            this.splitContainer1.Panel2.Controls.Add(this.loginBtn);
            this.splitContainer1.Panel2.Controls.Add(this.idBox);
            this.splitContainer1.Size = new System.Drawing.Size(279, 144);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 2;
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(46, 18);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(49, 16);
            this.idlabel.TabIndex = 0;
            this.idlabel.Text = "UserID";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(28, 62);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(67, 16);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Password";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(3, 59);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(103, 22);
            this.passBox.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Location = new System.Drawing.Point(3, 103);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(103, 38);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(3, 15);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(103, 22);
            this.idBox.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.baseFlowLayout);
            this.Name = "LoginForm";
            this.Text = "Maske Ltd. Login";
            this.baseFlowLayout.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel baseFlowLayout;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button loginBtn;
    }
}

