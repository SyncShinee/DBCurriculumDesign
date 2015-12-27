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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFinish = new System.Windows.Forms.DataGridView();
            this.dataGridViewToDo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.infoTab = new System.Windows.Forms.TabPage();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.distributeTab = new System.Windows.Forms.TabPage();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.adminTab = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.taskTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToDo)).BeginInit();
            this.infoTab.SuspendLayout();
            this.distributeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.adminTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.taskTab);
            this.tabControl1.Controls.Add(this.infoTab);
            this.tabControl1.Controls.Add(this.distributeTab);
            this.tabControl1.Controls.Add(this.adminTab);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 399);
            this.tabControl1.TabIndex = 0;
            // 
            // taskTab
            // 
            this.taskTab.Controls.Add(this.label2);
            this.taskTab.Controls.Add(this.label1);
            this.taskTab.Controls.Add(this.dataGridViewFinish);
            this.taskTab.Controls.Add(this.dataGridViewToDo);
            this.taskTab.Controls.Add(this.button1);
            this.taskTab.Location = new System.Drawing.Point(4, 22);
            this.taskTab.Margin = new System.Windows.Forms.Padding(2);
            this.taskTab.Name = "taskTab";
            this.taskTab.Padding = new System.Windows.Forms.Padding(2);
            this.taskTab.Size = new System.Drawing.Size(787, 373);
            this.taskTab.TabIndex = 0;
            this.taskTab.Text = "我的任务";
            this.taskTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "已完成的配送任务";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "待完成的配送任务";
            // 
            // dataGridViewFinish
            // 
            this.dataGridViewFinish.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewFinish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFinish.Location = new System.Drawing.Point(408, 90);
            this.dataGridViewFinish.Name = "dataGridViewFinish";
            this.dataGridViewFinish.RowTemplate.Height = 23;
            this.dataGridViewFinish.Size = new System.Drawing.Size(356, 236);
            this.dataGridViewFinish.TabIndex = 2;
            // 
            // dataGridViewToDo
            // 
            this.dataGridViewToDo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToDo.Location = new System.Drawing.Point(22, 90);
            this.dataGridViewToDo.Name = "dataGridViewToDo";
            this.dataGridViewToDo.RowTemplate.Height = 23;
            this.dataGridViewToDo.Size = new System.Drawing.Size(356, 236);
            this.dataGridViewToDo.TabIndex = 1;
            this.dataGridViewToDo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewToDo_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "查询我的任务";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // infoTab
            // 
            this.infoTab.Controls.Add(this.textBoxPlace);
            this.infoTab.Controls.Add(this.label3);
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
            this.infoTab.Location = new System.Drawing.Point(4, 22);
            this.infoTab.Margin = new System.Windows.Forms.Padding(2);
            this.infoTab.Name = "infoTab";
            this.infoTab.Padding = new System.Windows.Forms.Padding(2);
            this.infoTab.Size = new System.Drawing.Size(787, 373);
            this.infoTab.TabIndex = 1;
            this.infoTab.Text = "修改信息";
            this.infoTab.UseVisualStyleBackColor = true;
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(246, 174);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(113, 21);
            this.textBoxPlace.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "所在地点";
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Location = new System.Drawing.Point(314, 127);
            this.maleButton.Margin = new System.Windows.Forms.Padding(2);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(35, 16);
            this.maleButton.TabIndex = 29;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "男";
            this.maleButton.UseVisualStyleBackColor = true;
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Location = new System.Drawing.Point(258, 127);
            this.femaleButton.Margin = new System.Windows.Forms.Padding(2);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(35, 16);
            this.femaleButton.TabIndex = 28;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "女";
            this.femaleButton.UseVisualStyleBackColor = true;
            // 
            // buttonUpdKey
            // 
            this.buttonUpdKey.Location = new System.Drawing.Point(419, 230);
            this.buttonUpdKey.Name = "buttonUpdKey";
            this.buttonUpdKey.Size = new System.Drawing.Size(91, 44);
            this.buttonUpdKey.TabIndex = 27;
            this.buttonUpdKey.Text = "修改密码";
            this.buttonUpdKey.UseVisualStyleBackColor = true;
            this.buttonUpdKey.Click += new System.EventHandler(this.buttonUpdKey_Click);
            // 
            // infoUpdate
            // 
            this.infoUpdate.Location = new System.Drawing.Point(254, 230);
            this.infoUpdate.Name = "infoUpdate";
            this.infoUpdate.Size = new System.Drawing.Size(91, 44);
            this.infoUpdate.TabIndex = 26;
            this.infoUpdate.Text = "更新个人信息";
            this.infoUpdate.UseVisualStyleBackColor = true;
            this.infoUpdate.Click += new System.EventHandler(this.infoUpdate_Click);
            // 
            // textBoxPhn
            // 
            this.textBoxPhn.Location = new System.Drawing.Point(484, 127);
            this.textBoxPhn.Name = "textBoxPhn";
            this.textBoxPhn.Size = new System.Drawing.Size(113, 21);
            this.textBoxPhn.TabIndex = 24;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(484, 74);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(113, 21);
            this.textBoxAge.TabIndex = 23;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(246, 74);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(113, 21);
            this.textBoxName.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "手机";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "年龄";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "姓名";
            // 
            // distributeTab
            // 
            this.distributeTab.Controls.Add(this.dataGridViewOrder);
            this.distributeTab.Controls.Add(this.button3);
            this.distributeTab.Controls.Add(this.button2);
            this.distributeTab.Location = new System.Drawing.Point(4, 22);
            this.distributeTab.Margin = new System.Windows.Forms.Padding(2);
            this.distributeTab.Name = "distributeTab";
            this.distributeTab.Size = new System.Drawing.Size(787, 373);
            this.distributeTab.TabIndex = 2;
            this.distributeTab.Text = "分配任务";
            this.distributeTab.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(87, 77);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowTemplate.Height = 23;
            this.dataGridViewOrder.Size = new System.Drawing.Size(611, 244);
            this.dataGridViewOrder.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(441, 14);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "分配任务";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "查询未分配的任务";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // adminTab
            // 
            this.adminTab.Controls.Add(this.button7);
            this.adminTab.Controls.Add(this.dataGridViewEmployee);
            this.adminTab.Controls.Add(this.button6);
            this.adminTab.Controls.Add(this.button5);
            this.adminTab.Controls.Add(this.button4);
            this.adminTab.Location = new System.Drawing.Point(4, 22);
            this.adminTab.Margin = new System.Windows.Forms.Padding(2);
            this.adminTab.Name = "adminTab";
            this.adminTab.Size = new System.Drawing.Size(787, 373);
            this.adminTab.TabIndex = 3;
            this.adminTab.Text = "公司管理";
            this.adminTab.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(550, 16);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 33);
            this.button7.TabIndex = 4;
            this.button7.Text = "删除该员工";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(36, 65);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowTemplate.Height = 23;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(715, 262);
            this.dataGridViewEmployee.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(400, 16);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 33);
            this.button6.TabIndex = 2;
            this.button6.Text = "查询所有员工";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(242, 16);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 33);
            this.button5.TabIndex = 1;
            this.button5.Text = "添加地点";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(94, 16);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 33);
            this.button4.TabIndex = 0;
            this.button4.Text = "增加员工";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.welcome.Location = new System.Drawing.Point(645, 6);
            this.welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(70, 12);
            this.welcome.TabIndex = 2;
            this.welcome.Text = "欢迎，用户";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 371);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "“飞鸽”快递信息管理系统";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.taskTab.ResumeLayout(false);
            this.taskTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToDo)).EndInit();
            this.infoTab.ResumeLayout(false);
            this.infoTab.PerformLayout();
            this.distributeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.adminTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFinish;
        private System.Windows.Forms.DataGridView dataGridViewToDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.Label label3;
    }
}