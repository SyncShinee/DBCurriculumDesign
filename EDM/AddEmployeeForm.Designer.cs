namespace EDM
{
    partial class AddEmployeeForm
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
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.textBoxPhn = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.location = new System.Windows.Forms.Label();
            this.locationText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Location = new System.Drawing.Point(280, 130);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(51, 22);
            this.maleButton.TabIndex = 38;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "男";
            this.maleButton.UseVisualStyleBackColor = true;
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Location = new System.Drawing.Point(206, 130);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(51, 22);
            this.femaleButton.TabIndex = 37;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "女";
            this.femaleButton.UseVisualStyleBackColor = true;
            // 
            // textBoxPhn
            // 
            this.textBoxPhn.Location = new System.Drawing.Point(206, 265);
            this.textBoxPhn.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhn.Name = "textBoxPhn";
            this.textBoxPhn.Size = new System.Drawing.Size(168, 28);
            this.textBoxPhn.TabIndex = 36;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(206, 199);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(168, 28);
            this.textBoxAge.TabIndex = 35;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(206, 63);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(168, 28);
            this.textBoxName.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 268);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "手机";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "年龄";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "姓名";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 59);
            this.button1.TabIndex = 39;
            this.button1.Text = "增加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Location = new System.Drawing.Point(102, 335);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(44, 18);
            this.location.TabIndex = 40;
            this.location.Text = "地点";
            // 
            // locationText
            // 
            this.locationText.Location = new System.Drawing.Point(206, 332);
            this.locationText.Margin = new System.Windows.Forms.Padding(4);
            this.locationText.Name = "locationText";
            this.locationText.Size = new System.Drawing.Size(168, 28);
            this.locationText.TabIndex = 41;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 550);
            this.Controls.Add(this.locationText);
            this.Controls.Add(this.location);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maleButton);
            this.Controls.Add(this.femaleButton);
            this.Controls.Add(this.textBoxPhn);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "AddEmployeeForm";
            this.Text = "增加新员工";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.TextBox textBoxPhn;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.TextBox locationText;
    }
}