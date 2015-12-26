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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            welcome.Text = "欢迎，" + ManageForm.username;

            MySqlCommand mComd = new MySqlCommand("select * from employee where employee_id=" + ManageForm.userid + ";", ManageForm.mConn);
            MySqlDataReader mRead = mComd.ExecuteReader();
            mRead.Read();
            textBoxName.Text = mRead["name"].ToString();
            textBoxAge.Text = mRead["age"].ToString();
            textBoxPhn.Text = mRead["phone"].ToString();
            if (mRead["gender"].ToString().Equals("False"))
            {
                femaleButton.Checked = true;
            }
            else
            {
                maleButton.Checked = true;
            }
            mRead.Dispose();
            mComd.Dispose();
        }

        private void infoUpdate_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
            String phone = textBoxPhn.Text;
            int age = 0;
            int gender;
            if (name.Equals(""))
            {
                MessageBox.Show("用户账号不能为空！", "提示", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else if (phone.Equals("") || phone.Length != 11)
            {
                MessageBox.Show("手机号码填写不正确！", "提示", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                try
                {
                    age = int.Parse(textBoxAge.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("年龄填写不正确！", "提示", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                gender = femaleButton.Checked ? 0 : 1;

                MySqlCommand mComd = new MySqlCommand(
                    "UPDATE `expressdata`.`employee`" +
                    "SET" +
                    "`name` = '" + name + "'," +
                    "`gender` = " + gender + "," +
                    "`age` = " + age + "," +
                    "`phone` = '" + phone + "'" +
                    "WHERE `employee_id` = " + ManageForm.userid + ";", ManageForm.mConn);      
                mComd.ExecuteNonQuery();
                mComd.Dispose();
                MessageBox.Show("更新个人资料成功！", "提示", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void buttonUpdKey_Click(object sender, EventArgs e)
        {
            PasswordForm pf = new PasswordForm();
            pf.ShowDialog();
        }
    }
}
