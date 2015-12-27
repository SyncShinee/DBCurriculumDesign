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
            this.maleButton.Location = new System.Drawing.Point(187, 87);
            this.maleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(35, 16);
            this.maleButton.TabIndex = 38;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "男";
            this.maleButton.UseVisualStyleBackColor = true;
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Location = new System.Drawing.Point(137, 87);
            this.femaleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(35, 16);
            this.femaleButton.TabIndex = 37;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "女";
            this.femaleButton.UseVisualStyleBackColor = true;
            // 
            // textBoxPhn
            // 
            this.textBoxPhn.Location = new System.Drawing.Point(137, 177);
            this.textBoxPhn.Name = "textBoxPhn";
            this.textBoxPhn.Size = new System.Drawing.Size(113, 21);
            this.textBoxPhn.TabIndex = 36;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(137, 133);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(113, 21);
            this.textBoxAge.TabIndex = 35;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(137, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(113, 21);
            this.textBoxName.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 33;
            this.label7.Text = "手机";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 32;
            this.label6.Text = "年龄";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "姓名";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 265);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 39);
            this.button1.TabIndex = 39;
            this.button1.Text = "增加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Location = new System.Drawing.Point(68, 223);
            this.location.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(29, 12);
            this.location.TabIndex = 40;
            this.location.Text = "地点";
            // 
            // locationText
            // 
            this.locationText.Location = new System.Drawing.Point(137, 221);
            this.locationText.Name = "locationText";
            this.locationText.Size = new System.Drawing.Size(113, 21);
            this.locationText.TabIndex = 41;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 367);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddEmployeeForm";
            this.Text = "增加新员工";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
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