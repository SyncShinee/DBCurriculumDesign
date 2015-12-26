namespace EDM
{
    partial class EmployeeForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.taskTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.distributeTab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.infoTab = new System.Windows.Forms.TabPage();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.buttonUpdKey = new System.Windows.Forms.Button();
            this.infoUpdate = new System.Windows.Forms.Button();
            this.textBoxPhn = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adminTab = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.taskTab.SuspendLayout();
            this.distributeTab.SuspendLayout();
            this.infoTab.SuspendLayout();
            this.adminTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.taskTab);
            this.tabControl1.Controls.Add(this.infoTab);
            this.tabControl1.Controls.Add(this.distributeTab);
            this.tabControl1.Controls.Add(this.adminTab);
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1077, 598);
            this.tabControl1.TabIndex = 0;
            // 
            // taskTab
            // 
            this.taskTab.Controls.Add(this.button1);
            this.taskTab.Location = new System.Drawing.Point(4, 28);
            this.taskTab.Name = "taskTab";
            this.taskTab.Padding = new System.Windows.Forms.Padding(3);
            this.taskTab.Size = new System.Drawing.Size(1069, 566);
            this.taskTab.TabIndex = 0;
            this.taskTab.Text = "我的任务";
            this.taskTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "查询我的任务";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // distributeTab
            // 
            this.distributeTab.Controls.Add(this.button3);
            this.distributeTab.Controls.Add(this.button2);
            this.distributeTab.Location = new System.Drawing.Point(4, 28);
            this.distributeTab.Name = "distributeTab";
            this.distributeTab.Size = new System.Drawing.Size(1069, 566);
            this.distributeTab.TabIndex = 2;
            this.distributeTab.Text = "分配任务";
            this.distributeTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(243, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 69);
            this.button3.TabIndex = 2;
            this.button3.Text = "分配任务";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "查询未分配的任务";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // infoTab
            // 
            this.infoTab.Controls.Add(this.maleButton);
            this.infoTab.Controls.Add(this.femaleButton);
            this.infoTab.Controls.Add(this.buttonUpdKey);
            this.infoTab.Controls.Add(this.infoUpdate);
            this.infoTab.Controls.Add(this.textBoxPhn);
            this.infoTab.Controls.Add(this.textBoxAge);
            this.infoTab.Controls.Add(this.textBoxName);
            this.infoTab.Controls.Add(this.label7);
            this.infoTab.Controls.Add(this.label6);
            this.infoTab.Controls.Add(this.label5);
            this.infoTab.Controls.Add(this.label4);
            this.infoTab.Location = new System.Drawing.Point(4, 28);
            this.infoTab.Name = "infoTab";
            this.infoTab.Padding = new System.Windows.Forms.Padding(3);
            this.infoTab.Size = new System.Drawing.Size(1069, 566);
            this.infoTab.TabIndex = 1;
            this.infoTab.Text = "修改信息";
            this.infoTab.UseVisualStyleBackColor = true;
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Location = new System.Drawing.Point(402, 182);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(51, 22);
            this.maleButton.TabIndex = 29;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "男";
            this.maleButton.UseVisualStyleBackColor = true;
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Location = new System.Drawing.Point(328, 182);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(51, 22);
            this.femaleButton.TabIndex = 28;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "女";
            this.femaleButton.UseVisualStyleBackColor = true;
            // 
            // buttonUpdKey
            // 
            this.buttonUpdKey.Location = new System.Drawing.Point(588, 304);
            this.buttonUpdKey.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdKey.Name = "buttonUpdKey";
            this.buttonUpdKey.Size = new System.Drawing.Size(136, 66);
            this.buttonUpdKey.TabIndex = 27;
            this.buttonUpdKey.Text = "修改密码";
            this.buttonUpdKey.UseVisualStyleBackColor = true;
            this.buttonUpdKey.Click += new System.EventHandler(this.buttonUpdKey_Click);
            // 
            // infoUpdate
            // 
            this.infoUpdate.Location = new System.Drawing.Point(340, 304);
            this.infoUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.infoUpdate.Name = "infoUpdate";
            this.infoUpdate.Size = new System.Drawing.Size(136, 66);
            this.infoUpdate.TabIndex = 26;
            this.infoUpdate.Text = "更新个人信息";
            this.infoUpdate.UseVisualStyleBackColor = true;
            this.infoUpdate.Click += new System.EventHandler(this.infoUpdate_Click);
            // 
            // textBoxPhn
            // 
            this.textBoxPhn.Location = new System.Drawing.Point(685, 181);
            this.textBoxPhn.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhn.Name = "textBoxPhn";
            this.textBoxPhn.Size = new System.Drawing.Size(168, 28);
            this.textBoxPhn.TabIndex = 24;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(685, 115);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(168, 28);
            this.textBoxAge.TabIndex = 23;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(328, 115);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(168, 28);
            this.textBoxName.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(585, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "手机";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(585, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "年龄";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "姓名";
            // 
            // adminTab
            // 
            this.adminTab.Controls.Add(this.button6);
            this.adminTab.Controls.Add(this.button5);
            this.adminTab.Controls.Add(this.button4);
            this.adminTab.Location = new System.Drawing.Point(4, 28);
            this.adminTab.Name = "adminTab";
            this.adminTab.Size = new System.Drawing.Size(1069, 566);
            this.adminTab.TabIndex = 3;
            this.adminTab.Text = "公司管理";
            this.adminTab.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(225, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 50);
            this.button5.TabIndex = 1;
            this.button5.Text = "添加地点";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(54, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 50);
            this.button4.TabIndex = 0;
            this.button4.Text = "增加员工";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.welcome.Location = new System.Drawing.Point(926, 9);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(103, 18);
            this.welcome.TabIndex = 2;
            this.welcome.Text = "欢迎，用户";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(396, 24);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 50);
            this.button6.TabIndex = 2;
            this.button6.Text = "查询所有员工";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 590);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeeForm";
            this.Text = "快递信息管理系统";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.taskTab.ResumeLayout(false);
            this.distributeTab.ResumeLayout(false);
            this.infoTab.ResumeLayout(false);
            this.infoTab.PerformLayout();
            this.adminTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage taskTab;
        private System.Windows.Forms.TabPage infoTab;
        private System.Windows.Forms.TabPage distributeTab;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button buttonUpdKey;
        private System.Windows.Forms.Button infoUpdate;
        private System.Windows.Forms.TextBox textBoxPhn;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage adminTab;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
    }
}