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
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            String oldpwd = oldPswdText.Text;
            String newpwd = newPswdText.Text;
            String confirm = confirmText.Text;
            MySqlCommand mComd;
            MySqlDataReader mRead;

            if (ManageForm.isUser) {
                mComd = new MySqlCommand("select * from user where user_id = " + ManageForm.userid + ";", ManageForm.mConn);
                mRead = mComd.ExecuteReader();
                mRead.Read();
                if (!mRead["user_password"].ToString().Equals(oldpwd))
                {
                    MessageBox.Show("旧密码错误！", "提示", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else if (!newpwd.Equals(confirm))
                {
                    MessageBox.Show("两次输入的新密码不匹配！", "提示", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    mComd.Dispose();
                    mRead.Dispose();
                    mComd = new MySqlCommand(
                        "UPDATE `expressdata`.`user` SET" + "`user_password` = '" + newpwd + "'" +
                        "WHERE `user_id` = " + ManageForm.userid + ";", ManageForm.mConn);
                    mComd.ExecuteNonQuery();
                    MessageBox.Show("修改密码成功！", "提示", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    this.Dispose();
                }
            }
            else
            {
                mComd = new MySqlCommand("select * from employee where employee_id = " + ManageForm.userid + ";", ManageForm.mConn);
                mRead = mComd.ExecuteReader();
                mRead.Read();
                if (!mRead["password"].ToString().Equals(oldpwd))
                {
                    MessageBox.Show("旧密码错误！", "提示", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else if (!newpwd.Equals(confirm))
                {
                    MessageBox.Show("两次输入的新密码不匹配！", "提示", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    mComd.Dispose();
                    mRead.Dispose();
                    mComd = new MySqlCommand(
                        "UPDATE `expressdata`.`employee` SET" + "`password` = '" + newpwd + "'" +
                        "WHERE `employee_id` = " + ManageForm.userid + ";", ManageForm.mConn);
                    mComd.ExecuteNonQuery();
                    MessageBox.Show("修改密码成功！", "提示", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    this.Dispose();
                }
            }
        }
    }
}
