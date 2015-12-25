namespace EDM
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
            this.loginTab = new System.Windows.Forms.TabControl();
            this.userTab = new System.Windows.Forms.TabPage();
            this.account1 = new System.Windows.Forms.Label();
            this.accountTextU = new System.Windows.Forms.TextBox();
            this.empolyTab = new System.Windows.Forms.TabPage();
            this.password1 = new System.Windows.Forms.Label();
            this.passwordTextU = new System.Windows.Forms.TextBox();
            this.loginBtn_User = new System.Windows.Forms.Button();
            this.loginBtn_Employ = new System.Windows.Forms.Button();
            this.passwordTextE = new System.Windows.Forms.TextBox();
            this.password2 = new System.Windows.Forms.Label();
            this.account2 = new System.Windows.Forms.Label();
            this.accountTextE = new System.Windows.Forms.TextBox();
            this.loginTab.SuspendLayout();
            this.userTab.SuspendLayout();
            this.empolyTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTab
            // 
            this.loginTab.Controls.Add(this.userTab);
            this.loginTab.Controls.Add(this.empolyTab);
            this.loginTab.Location = new System.Drawing.Point(12, 12);
            this.loginTab.Name = "loginTab";
            this.loginTab.SelectedIndex = 0;
            this.loginTab.Size = new System.Drawing.Size(645, 489);
            this.loginTab.TabIndex = 0;
            // 
            // userTab
            // 
            this.userTab.BackColor = System.Drawing.Color.White;
            this.userTab.Controls.Add(this.loginBtn_User);
            this.userTab.Controls.Add(this.passwordTextU);
            this.userTab.Controls.Add(this.password1);
            this.userTab.Controls.Add(this.account1);
            this.userTab.Controls.Add(this.accountTextU);
            this.userTab.Location = new System.Drawing.Point(4, 28);
            this.userTab.Name = "userTab";
            this.userTab.Padding = new System.Windows.Forms.Padding(3);
            this.userTab.Size = new System.Drawing.Size(637, 457);
            this.userTab.TabIndex = 0;
            this.userTab.Text = "用户登录";
            // 
            // account1
            // 
            this.account1.AutoSize = true;
            this.account1.Location = new System.Drawing.Point(109, 114);
            this.account1.Name = "account1";
            this.account1.Size = new System.Drawing.Size(80, 18);
            this.account1.TabIndex = 1;
            this.account1.Text = "用户账号";
            // 
            // accountTextU
            // 
            this.accountTextU.Location = new System.Drawing.Point(211, 111);
            this.accountTextU.Name = "accountTextU";
            this.accountTextU.Size = new System.Drawing.Size(237, 28);
            this.accountTextU.TabIndex = 0;
            // 
            // empolyTab
            // 
            this.empolyTab.Controls.Add(this.loginBtn_Employ);
            this.empolyTab.Controls.Add(this.passwordTextE);
            this.empolyTab.Controls.Add(this.password2);
            this.empolyTab.Controls.Add(this.account2);
            this.empolyTab.Controls.Add(this.accountTextE);
            this.empolyTab.Location = new System.Drawing.Point(4, 28);
            this.empolyTab.Name = "empolyTab";
            this.empolyTab.Padding = new System.Windows.Forms.Padding(3);
            this.empolyTab.Size = new System.Drawing.Size(637, 457);
            this.empolyTab.TabIndex = 1;
            this.empolyTab.Text = "员工登陆";
            this.empolyTab.UseVisualStyleBackColor = true;
            // 
            // password1
            // 
            this.password1.AutoSize = true;
            this.password1.Location = new System.Drawing.Point(109, 200);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(80, 18);
            this.password1.TabIndex = 2;
            this.password1.Text = "用户密码";
            // 
            // passwordTextU
            // 
            this.passwordTextU.Location = new System.Drawing.Point(211, 197);
            this.passwordTextU.Name = "passwordTextU";
            this.passwordTextU.Size = new System.Drawing.Size(237, 28);
            this.passwordTextU.TabIndex = 3;
            // 
            // loginBtn_User
            // 
            this.loginBtn_User.Location = new System.Drawing.Point(231, 296);
            this.loginBtn_User.Name = "loginBtn_User";
            this.loginBtn_User.Size = new System.Drawing.Size(112, 46);
            this.loginBtn_User.TabIndex = 4;
            this.loginBtn_User.Text = "登陆";
            this.loginBtn_User.UseVisualStyleBackColor = true;
            this.loginBtn_User.Click += new System.EventHandler(this.loginBtn_User_Click);
            // 
            // loginBtn_Employ
            // 
            this.loginBtn_Employ.Location = new System.Drawing.Point(232, 296);
            this.loginBtn_Employ.Name = "loginBtn_Employ";
            this.loginBtn_Employ.Size = new System.Drawing.Size(112, 46);
            this.loginBtn_Employ.TabIndex = 9;
            this.loginBtn_Employ.Text = "登陆";
            this.loginBtn_Employ.UseVisualStyleBackColor = true;
            this.loginBtn_Employ.Click += new System.EventHandler(this.loginBtn_Employ_Click);
            // 
            // passwordTextE
            // 
            this.passwordTextE.Location = new System.Drawing.Point(212, 197);
            this.passwordTextE.Name = "passwordTextE";
            this.passwordTextE.Size = new System.Drawing.Size(237, 28);
            this.passwordTextE.TabIndex = 8;
            // 
            // password2
            // 
            this.password2.AutoSize = true;
            this.password2.Location = new System.Drawing.Point(110, 200);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(80, 18);
            this.password2.TabIndex = 7;
            this.password2.Text = "员工密码";
            // 
            // account2
            // 
            this.account2.AutoSize = true;
            this.account2.Location = new System.Drawing.Point(110, 114);
            this.account2.Name = "account2";
            this.account2.Size = new System.Drawing.Size(80, 18);
            this.account2.TabIndex = 6;
            this.account2.Text = "员工账号";
            // 
            // accountTextE
            // 
            this.accountTextE.Location = new System.Drawing.Point(212, 111);
            this.accountTextE.Name = "accountTextE";
            this.accountTextE.Size = new System.Drawing.Size(237, 28);
            this.accountTextE.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 513);
            this.Controls.Add(this.loginTab);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.loginTab.ResumeLayout(false);
            this.userTab.ResumeLayout(false);
            this.userTab.PerformLayout();
            this.empolyTab.ResumeLayout(false);
            this.empolyTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl loginTab;
        private System.Windows.Forms.TabPage userTab;
        private System.Windows.Forms.Label account1;
        private System.Windows.Forms.TextBox accountTextU;
        private System.Windows.Forms.TabPage empolyTab;
        private System.Windows.Forms.TextBox passwordTextU;
        private System.Windows.Forms.Label password1;
        private System.Windows.Forms.Button loginBtn_User;
        private System.Windows.Forms.Button loginBtn_Employ;
        private System.Windows.Forms.TextBox passwordTextE;
        private System.Windows.Forms.Label password2;
        private System.Windows.Forms.Label account2;
        private System.Windows.Forms.TextBox accountTextE;
    }
}