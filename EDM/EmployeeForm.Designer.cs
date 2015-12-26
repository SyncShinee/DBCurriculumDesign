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
            this.infoTab = new System.Windows.Forms.TabPage();
            this.distributeTab = new System.Windows.Forms.TabPage();
            this.welcome = new System.Windows.Forms.Label();
            this.nameU = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.infoTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.taskTab);
            this.tabControl1.Controls.Add(this.distributeTab);
            this.tabControl1.Controls.Add(this.infoTab);
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1267, 613);
            this.tabControl1.TabIndex = 0;
            // 
            // taskTab
            // 
            this.taskTab.Location = new System.Drawing.Point(4, 28);
            this.taskTab.Name = "taskTab";
            this.taskTab.Padding = new System.Windows.Forms.Padding(3);
            this.taskTab.Size = new System.Drawing.Size(936, 553);
            this.taskTab.TabIndex = 0;
            this.taskTab.Text = "我的任务";
            this.taskTab.UseVisualStyleBackColor = true;
            // 
            // infoTab
            // 
            this.infoTab.Controls.Add(this.nameText);
            this.infoTab.Controls.Add(this.nameU);
            this.infoTab.Location = new System.Drawing.Point(4, 28);
            this.infoTab.Name = "infoTab";
            this.infoTab.Padding = new System.Windows.Forms.Padding(3);
            this.infoTab.Size = new System.Drawing.Size(1259, 581);
            this.infoTab.TabIndex = 1;
            this.infoTab.Text = "修改信息";
            this.infoTab.UseVisualStyleBackColor = true;
            // 
            // distributeTab
            // 
            this.distributeTab.Location = new System.Drawing.Point(4, 28);
            this.distributeTab.Name = "distributeTab";
            this.distributeTab.Size = new System.Drawing.Size(936, 553);
            this.distributeTab.TabIndex = 2;
            this.distributeTab.Text = "分配任务";
            this.distributeTab.UseVisualStyleBackColor = true;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.welcome.Location = new System.Drawing.Point(1124, 9);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(103, 18);
            this.welcome.TabIndex = 2;
            this.welcome.Text = "欢迎，用户";
            this.welcome.Click += new System.EventHandler(this.username_Click);
            // 
            // nameU
            // 
            this.nameU.AutoSize = true;
            this.nameU.Location = new System.Drawing.Point(71, 28);
            this.nameU.Name = "nameU";
            this.nameU.Size = new System.Drawing.Size(44, 18);
            this.nameU.TabIndex = 0;
            this.nameU.Text = "姓名";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(135, 25);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 28);
            this.nameText.TabIndex = 1;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 610);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeeForm";
            this.Text = "快递信息管理系统";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.infoTab.ResumeLayout(false);
            this.infoTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage taskTab;
        private System.Windows.Forms.TabPage infoTab;
        private System.Windows.Forms.TabPage distributeTab;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label nameU;
    }
}