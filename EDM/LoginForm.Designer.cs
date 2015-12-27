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
            this.loginBtn_User = new System.Windows.Forms.Button();
            this.passwordTextU = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.Label();
            this.account1 = new System.Windows.Forms.Label();
            this.accountTextU = new System.Windows.Forms.TextBox();
            this.empolyTab = new System.Windows.Forms.TabPage();
            this.loginBtn_Employ = new System.Windows.Forms.Button();
            this.passwordTextE = new System.Windows.Forms.TextBox();
            this.password2 = new System.Windows.Forms.Label();
            this.account2 = new System.Windows.Forms.Label();
            this.accountTextE = new System.Windows.Forms.TextBox();
            this.registerTab = new System.Windows.Forms.TabPage();
            this.registerButtton = new System.Windows.Forms.Button();
            this.ageText = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.nameText = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.confirmText = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Label();
            this.passwordTextR = new System.Windows.Forms.TextBox();
            this.password3 = new System.Windows.Forms.Label();
            this.accountTextR = new System.Windows.Forms.TextBox();
            this.account3 = new System.Windows.Forms.Label();
            this.loginTab.SuspendLayout();
            this.userTab.SuspendLayout();
            this.empolyTab.SuspendLayout();
            this.registerTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTab
            // 
            this.loginTab.Controls.Add(this.userTab);
            this.loginTab.Controls.Add(this.empolyTab);
            this.loginTab.Controls.Add(this.registerTab);
            this.loginTab.Location = new System.Drawing.Point(0, 2);
            this.loginTab.Margin = new System.Windows.Forms.Padding(2);
            this.loginTab.Name = "loginTab";
            this.loginTab.SelectedIndex = 0;
            this.loginTab.Size = new System.Drawing.Size(502, 353);
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
            this.userTab.Location = new System.Drawing.Point(4, 22);
            this.userTab.Margin = new System.Windows.Forms.Padding(2);
            this.userTab.Name = "userTab";
            this.userTab.Padding = new System.Windows.Forms.Padding(2);
            this.userTab.Size = new System.Drawing.Size(494, 327);
            this.userTab.TabIndex = 0;
            this.userTab.Text = "用户登录";
            // 
            // loginBtn_User
            // 
            this.loginBtn_User.Location = new System.Drawing.Point(154, 197);
            this.loginBtn_User.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn_User.Name = "loginBtn_User";
            this.loginBtn_User.Size = new System.Drawing.Size(75, 31);
            this.loginBtn_User.TabIndex = 4;
            this.loginBtn_User.Text = "登陆";
            this.loginBtn_User.UseVisualStyleBackColor = true;
            this.loginBtn_User.Click += new System.EventHandler(this.loginBtn_User_Click);
            // 
            // passwordTextU
            // 
            this.passwordTextU.Location = new System.Drawing.Point(141, 131);
            this.passwordTextU.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextU.Name = "passwordTextU";
            this.passwordTextU.PasswordChar = '*';
            this.passwordTextU.Size = new System.Drawing.Size(159, 21);
            this.passwordTextU.TabIndex = 3;
            // 
            // password1
            // 
            this.password1.AutoSize = true;
            this.password1.Location = new System.Drawing.Point(73, 133);
            this.password1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(53, 12);
            this.password1.TabIndex = 2;
            this.password1.Text = "用户密码";
            // 
            // account1
            // 
            this.account1.AutoSize = true;
            this.account1.Location = new System.Drawing.Point(73, 76);
            this.account1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.account1.Name = "account1";
            this.account1.Size = new System.Drawing.Size(53, 12);
            this.account1.TabIndex = 1;
            this.account1.Text = "用户账号";
            // 
            // accountTextU
            // 
            this.accountTextU.Location = new System.Drawing.Point(141, 74);
            this.accountTextU.Margin = new System.Windows.Forms.Padding(2);
            this.accountTextU.Name = "accountTextU";
            this.accountTextU.Size = new System.Drawing.Size(159, 21);
            this.accountTextU.TabIndex = 0;
            // 
            // empolyTab
            // 
            this.empolyTab.Controls.Add(this.loginBtn_Employ);
            this.empolyTab.Controls.Add(this.passwordTextE);
            this.empolyTab.Controls.Add(this.password2);
            this.empolyTab.Controls.Add(this.account2);
            this.empolyTab.Controls.Add(this.accountTextE);
            this.empolyTab.Location = new System.Drawing.Point(4, 22);
            this.empolyTab.Margin = new System.Windows.Forms.Padding(2);
            this.empolyTab.Name = "empolyTab";
            this.empolyTab.Padding = new System.Windows.Forms.Padding(2);
            this.empolyTab.Size = new System.Drawing.Size(494, 327);
            this.empolyTab.TabIndex = 1;
            this.empolyTab.Text = "员工登陆";
            this.empolyTab.UseVisualStyleBackColor = true;
            // 
            // loginBtn_Employ
            // 
            this.loginBtn_Employ.Location = new System.Drawing.Point(155, 197);
            this.loginBtn_Employ.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn_Employ.Name = "loginBtn_Employ";
            this.loginBtn_Employ.Size = new System.Drawing.Size(75, 31);
            this.loginBtn_Employ.TabIndex = 9;
            this.loginBtn_Employ.Text = "登陆";
            this.loginBtn_Employ.UseVisualStyleBackColor = true;
            this.loginBtn_Employ.Click += new System.EventHandler(this.loginBtn_Employ_Click);
            // 
            // passwordTextE
            // 
            this.passwordTextE.Location = new System.Drawing.Point(141, 131);
            this.passwordTextE.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextE.Name = "passwordTextE";
            this.passwordTextE.PasswordChar = '*';
            this.passwordTextE.Size = new System.Drawing.Size(159, 21);
            this.passwordTextE.TabIndex = 8;
            // 
            // password2
            // 
            this.password2.AutoSize = true;
            this.password2.Location = new System.Drawing.Point(73, 133);
            this.password2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(53, 12);
            this.password2.TabIndex = 7;
            this.password2.Text = "员工密码";
            // 
            // account2
            // 
            this.account2.AutoSize = true;
            this.account2.Location = new System.Drawing.Point(73, 76);
            this.account2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.account2.Name = "account2";
            this.account2.Size = new System.Drawing.Size(53, 12);
            this.account2.TabIndex = 6;
            this.account2.Text = "员工账号";
            // 
            // accountTextE
            // 
            this.accountTextE.Location = new System.Drawing.Point(141, 74);
            this.accountTextE.Margin = new System.Windows.Forms.Padding(2);
            this.accountTextE.Name = "accountTextE";
            this.accountTextE.Size = new System.Drawing.Size(159, 21);
            this.accountTextE.TabIndex = 5;
            // 
            // registerTab
            // 
            this.registerTab.Controls.Add(this.registerButtton);
            this.registerTab.Controls.Add(this.ageText);
            this.registerTab.Controls.Add(this.age);
            this.registerTab.Controls.Add(this.emailText);
            this.registerTab.Controls.Add(this.email);
            this.registerTab.Controls.Add(this.phoneText);
            this.registerTab.Controls.Add(this.phone);
            this.registerTab.Controls.Add(this.gender);
            this.registerTab.Controls.Add(this.maleButton);
            this.registerTab.Controls.Add(this.femaleButton);
            this.registerTab.Controls.Add(this.nameText);
            this.registerTab.Controls.Add(this.name);
            this.registerTab.Controls.Add(this.confirmText);
            this.registerTab.Controls.Add(this.confirm);
            this.registerTab.Controls.Add(this.passwordTextR);
            this.registerTab.Controls.Add(this.password3);
            this.registerTab.Controls.Add(this.accountTextR);
            this.registerTab.Controls.Add(this.account3);
            this.registerTab.Location = new System.Drawing.Point(4, 22);
            this.registerTab.Margin = new System.Windows.Forms.Padding(2);
            this.registerTab.Name = "registerTab";
            this.registerTab.Size = new System.Drawing.Size(494, 327);
            this.registerTab.TabIndex = 2;
            this.registerTab.Text = "用户注册";
            this.registerTab.UseVisualStyleBackColor = true;
            // 
            // registerButtton
            // 
            this.registerButtton.Location = new System.Drawing.Point(203, 223);
            this.registerButtton.Margin = new System.Windows.Forms.Padding(2);
            this.registerButtton.Name = "registerButtton";
            this.registerButtton.Size = new System.Drawing.Size(71, 36);
            this.registerButtton.TabIndex = 17;
            this.registerButtton.Text = "注册";
            this.registerButtton.UseVisualStyleBackColor = true;
            this.registerButtton.Click += new System.EventHandler(this.registerButtton_Click);
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(325, 71);
            this.ageText.Margin = new System.Windows.Forms.Padding(2);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(119, 21);
            this.ageText.TabIndex = 16;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(275, 73);
            this.age.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(29, 12);
            this.age.TabIndex = 15;
            this.age.Text = "年龄";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(325, 153);
            this.emailText.Margin = new System.Windows.Forms.Padding(2);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(119, 21);
            this.emailText.TabIndex = 14;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(251, 155);
            this.email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(53, 12);
            this.email.TabIndex = 13;
            this.email.Text = "联系邮箱";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(109, 151);
            this.phoneText.Margin = new System.Windows.Forms.Padding(2);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(119, 21);
            this.phoneText.TabIndex = 12;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(35, 153);
            this.phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(53, 12);
            this.phone.TabIndex = 11;
            this.phone.Text = "手机号码";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(275, 115);
            this.gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(29, 12);
            this.gender.TabIndex = 10;
            this.gender.Text = "性别";
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Location = new System.Drawing.Point(377, 113);
            this.maleButton.Margin = new System.Windows.Forms.Padding(2);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(35, 16);
            this.maleButton.TabIndex = 9;
            this.maleButton.Text = "男";
            this.maleButton.UseVisualStyleBackColor = true;
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Checked = true;
            this.femaleButton.Location = new System.Drawing.Point(329, 113);
            this.femaleButton.Margin = new System.Windows.Forms.Padding(2);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(35, 16);
            this.femaleButton.TabIndex = 8;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "女";
            this.femaleButton.UseVisualStyleBackColor = true;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(325, 30);
            this.nameText.Margin = new System.Windows.Forms.Padding(2);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(119, 21);
            this.nameText.TabIndex = 7;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(275, 32);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 12);
            this.name.TabIndex = 6;
            this.name.Text = "姓名";
            // 
            // confirmText
            // 
            this.confirmText.Location = new System.Drawing.Point(109, 109);
            this.confirmText.Margin = new System.Windows.Forms.Padding(2);
            this.confirmText.Name = "confirmText";
            this.confirmText.PasswordChar = '*';
            this.confirmText.Size = new System.Drawing.Size(119, 21);
            this.confirmText.TabIndex = 5;
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Location = new System.Drawing.Point(35, 111);
            this.confirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(53, 12);
            this.confirm.TabIndex = 4;
            this.confirm.Text = "确认密码";
            // 
            // passwordTextR
            // 
            this.passwordTextR.Location = new System.Drawing.Point(109, 71);
            this.passwordTextR.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextR.Name = "passwordTextR";
            this.passwordTextR.PasswordChar = '*';
            this.passwordTextR.Size = new System.Drawing.Size(119, 21);
            this.passwordTextR.TabIndex = 3;
            // 
            // password3
            // 
            this.password3.AutoSize = true;
            this.password3.Location = new System.Drawing.Point(35, 73);
            this.password3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password3.Name = "password3";
            this.password3.Size = new System.Drawing.Size(53, 12);
            this.password3.TabIndex = 2;
            this.password3.Text = "用户密码";
            // 
            // accountTextR
            // 
            this.accountTextR.Location = new System.Drawing.Point(109, 28);
            this.accountTextR.Margin = new System.Windows.Forms.Padding(2);
            this.accountTextR.Name = "accountTextR";
            this.accountTextR.Size = new System.Drawing.Size(119, 21);
            this.accountTextR.TabIndex = 1;
            // 
            // account3
            // 
            this.account3.AutoSize = true;
            this.account3.Location = new System.Drawing.Point(35, 30);
            this.account3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.account3.Name = "account3";
            this.account3.Size = new System.Drawing.Size(53, 12);
            this.account3.TabIndex = 0;
            this.account3.Text = "用户账号";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 355);
            this.Controls.Add(this.loginTab);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "“飞鸽”快递信息管理系统";
            this.loginTab.ResumeLayout(false);
            this.userTab.ResumeLayout(false);
            this.userTab.PerformLayout();
            this.empolyTab.ResumeLayout(false);
            this.empolyTab.PerformLayout();
            this.registerTab.ResumeLayout(false);
            this.registerTab.PerformLayout();
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
        private System.Windows.Forms.TabPage registerTab;
        private System.Windows.Forms.TextBox accountTextR;
        private System.Windows.Forms.Label account3;
        private System.Windows.Forms.Label confirm;
        private System.Windows.Forms.TextBox passwordTextR;
        private System.Windows.Forms.Label password3;
        private System.Windows.Forms.TextBox confirmText;
        private System.Windows.Forms.Button registerButtton;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label name;
    }
}