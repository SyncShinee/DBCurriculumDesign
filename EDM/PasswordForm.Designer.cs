﻿namespace EDM
{
    partial class PasswordForm
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
            this.oldPassword = new System.Windows.Forms.Label();
            this.oldPswdText = new System.Windows.Forms.TextBox();
            this.confirmText = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Label();
            this.newPswdText = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.Label();
            this.modifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldPassword
            // 
            this.oldPassword.AutoSize = true;
            this.oldPassword.Location = new System.Drawing.Point(106, 99);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(62, 18);
            this.oldPassword.TabIndex = 0;
            this.oldPassword.Text = "旧密码";
            // 
            // oldPswdText
            // 
            this.oldPswdText.Location = new System.Drawing.Point(226, 96);
            this.oldPswdText.Name = "oldPswdText";
            this.oldPswdText.Size = new System.Drawing.Size(160, 28);
            this.oldPswdText.TabIndex = 1;
            // 
            // confirmText
            // 
            this.confirmText.Location = new System.Drawing.Point(226, 219);
            this.confirmText.Name = "confirmText";
            this.confirmText.Size = new System.Drawing.Size(160, 28);
            this.confirmText.TabIndex = 3;
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Location = new System.Drawing.Point(106, 222);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(98, 18);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "确认新密码";
            // 
            // newPswdText
            // 
            this.newPswdText.Location = new System.Drawing.Point(226, 154);
            this.newPswdText.Name = "newPswdText";
            this.newPswdText.Size = new System.Drawing.Size(160, 28);
            this.newPswdText.TabIndex = 5;
            // 
            // newPassword
            // 
            this.newPassword.AutoSize = true;
            this.newPassword.Location = new System.Drawing.Point(106, 157);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(62, 18);
            this.newPassword.TabIndex = 4;
            this.newPassword.Text = "新密码";
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(208, 321);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(114, 51);
            this.modifyButton.TabIndex = 6;
            this.modifyButton.Text = "修改密码";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 468);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.newPswdText);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.confirmText);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.oldPswdText);
            this.Controls.Add(this.oldPassword);
            this.Name = "PasswordForm";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldPassword;
        private System.Windows.Forms.TextBox oldPswdText;
        private System.Windows.Forms.TextBox confirmText;
        private System.Windows.Forms.Label confirm;
        private System.Windows.Forms.TextBox newPswdText;
        private System.Windows.Forms.Label newPassword;
        private System.Windows.Forms.Button modifyButton;
    }
}