using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EDM
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.No;
        }

        private void loginBtn_User_Click(object sender, EventArgs e)
        {
            String account = accountTextU.Text;
            String password = passwordTextU.Text;

            if (account.Equals(""))
            {
                MessageBox.Show("用户账号不能为空！", "提示", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else if (password.Equals("")) 
            {
                MessageBox.Show("用户密码不能为空！", "提示", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (ManageForm.mConn.State.ToString().Equals("Open"))
                {
                    MySqlCommand mComd;
                    MySqlDataReader mRead;
                    mComd = new MySqlCommand( "select * from user where username='" + account + "';", ManageForm.mConn);
                    mRead = mComd.ExecuteReader();
                    if (!mRead.HasRows)
                    {
                        MessageBox.Show("用户不存在！\n登陆失败！", "提示", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        mRead.Read();
                        if (!mRead["user_password"].ToString().Equals(password))
                        {
                            MessageBox.Show("用户账号或密码错误！\n登陆失败！", "提示", MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            this.DialogResult = DialogResult.Yes;
                            ManageForm.isUser = true;
                            ManageForm.userid = mRead["id"].ToString();
                            ManageForm.username = mRead["user_name"].ToString();
                        }
                    }
                    mRead.Dispose();
                    mComd.Dispose();
                }
                else
                {
                    MessageBox.Show("远程数据库连接失败！", "连接失败", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void loginBtn_Employ_Click(object sender, EventArgs e)
        {
            String account = accountTextE.Text;
            String password = passwordTextE.Text;

            if (account.Equals(""))
            {
                MessageBox.Show("员工账号不能为空！", "提示", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("员工密码不能为空！", "提示", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (ManageForm.mConn.State.ToString().Equals("Open"))
                {
                    MySqlCommand mComd;
                    MySqlDataReader mRead;
                    mComd = new MySqlCommand("select * from employ where username='" + account + "';", ManageForm.mConn);
                    mRead = mComd.ExecuteReader();
                    if (!mRead.HasRows)
                    {
                        MessageBox.Show("员工不存在！\n登陆失败！", "提示", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        mRead.Read();
                        if (!mRead["user_password"].ToString().Equals(password))
                        {
                            MessageBox.Show("员工账号或密码错误！\n登陆失败！", "提示", MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            this.DialogResult = DialogResult.Yes;
                            ManageForm.isUser = true;
                            ManageForm.userid = mRead["id"].ToString();
                            ManageForm.username = mRead["name"].ToString();
                        }
                    }
                    mRead.Dispose();
                    mComd.Dispose();
                }
                else
                {
                    MessageBox.Show("远程数据库连接失败！", "连接失败", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
