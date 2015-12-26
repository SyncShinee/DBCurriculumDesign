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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
            String phone = textBoxPhn.Text;
            int age = 0;
            int location = 1;
            int gender;
            if (name.Equals(""))
            {
                MessageBox.Show("员工姓名不能为空！", "提示", MessageBoxButtons.OK,
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

                try
                {
                    location = int.Parse(locationText.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("地点应为一个整数！", "提示", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                MySqlCommand mComd = new MySqlCommand("select * from place where place_id = " + location + ";", ManageForm.mConn);
                MySqlDataReader mRead = mComd.ExecuteReader();
                if (!mRead.HasRows)
                {
                    MessageBox.Show("该地点不存在！", "提示", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                mComd.Dispose();
                mRead.Dispose();
                gender = femaleButton.Checked ? 0 : 1;

                mComd = new MySqlCommand(
                    "INSERT INTO `expressdata`.`employee`" +
                    "(`password`,`name`,`gender`,`age`,`phone`,`worktime`,`location`)" +
                    "VALUES('123456','" + name + "'," + gender + "," + age + ",'" + phone + "',0," + location + ");select @@Identity", ManageForm.mConn);
                String s = mComd.ExecuteScalar().ToString();
                mComd.Dispose();
                MessageBox.Show("增加员工成功！\n新员工账号为" + s + ",密码为123456", "提示", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                textBoxName.Clear();
                textBoxAge.Clear();
                textBoxPhn.Clear();
                locationText.Clear();
                femaleButton.Checked = false;
                maleButton.Checked = false;
            }
        }
    }
}
