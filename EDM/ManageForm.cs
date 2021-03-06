﻿using System;
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
    public partial class ManageForm : Form
    {
        public static MySqlConnection mConn;
        public static MySqlCommand    mComd;
        public static MySqlDataReader mRead;

        public static bool isUser;
        public static String userid;
        public static String username;

        public ManageForm()
        {
            InitializeComponent();
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            this.Hide();

            mConn = new MySqlConnection("Host = localhost;" + "Username = root;" + "Password = 123456");
            mConn.Open();
            if (mConn.State.ToString().Equals("Open"))
            { 
                initDatabase();
            }
            else
            {
                MessageBox.Show("远程数据库连接失败！", "连接失败", MessageBoxButtons.OK,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
            LoginForm lf = new LoginForm();
            if (lf.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("登陆成功！\n欢迎来到本系统！");
                if (isUser)
                {
                    CustomerForm cf = new CustomerForm();
                    cf.ShowDialog();
                }
                else
                {
                    EmployeeForm ef = new EmployeeForm();
                    ef.ShowDialog();
                }
                this.Dispose();
            }
            else
            {
                this.Dispose();
            }
        }

        private void initDatabase()
        {
            mComd = new MySqlCommand("CREATE SCHEMA IF NOT EXISTS expressdata;", mConn);
            mComd.ExecuteNonQuery();
            mComd.Dispose();
            mConn.Dispose();

            mConn = new MySqlConnection("Host = localhost;" + "Database = expressdata;" + "Username = root;" + "Password = 123456");
            mConn.Open();

            mComd = new MySqlCommand(
                "CREATE TABLE IF NOT EXISTS `expressdata`.`user` (" +
                "`user_id` INT NOT NULL AUTO_INCREMENT," +
                "`user_account` VARCHAR(45) NOT NULL," +
                "`user_password` VARCHAR(45) NOT NULL," +
                "`user_name` VARCHAR(45) NOT NULL," +
                "`user_gender` TINYINT(1) NOT NULL," +
                "`user_age` INT NOT NULL," +
                "`user_phone` VARCHAR(20) NOT NULL," +
                "`user_email` VARCHAR(45) NOT NULL," +
                "PRIMARY KEY (`user_id`)," +
                "UNIQUE INDEX `user_account_UNIQUE` (`user_account` ASC));", mConn);
            mComd.ExecuteNonQuery();
            mComd.Dispose();

            mComd = new MySqlCommand(
                "CREATE TABLE IF NOT EXISTS `expressdata`.`order` (" +
                "`order_id` INT NOT NULL AUTO_INCREMENT," +
                "`userid` INT NOT NULL," +
                "`startplace` INT NOT NULL," +
                "`endplace` INT NOT NULL," +
                "`order_state` INT NOT NULL," +
                "`order_time` DATETIME NOT NULL," +
                "`order_count` INT NOT NULL," +
                "PRIMARY KEY (`order_id`));", mConn);
            mComd.ExecuteNonQuery();
            mComd.Dispose();

            mComd = new MySqlCommand(
                "CREATE TABLE IF NOT EXISTS `expressdata`.`goods` (" +
                "`goods_id` INT NOT NULL AUTO_INCREMENT," +
                "`weight` INT NOT NULL," +
                "`type` VARCHAR(45) NOT NULL," +
                "`orderid` INT NOT NULL," +
                "`goods_name` VARCHAR(45) NOT NULL," +
                "PRIMARY KEY (`goods_id`));", mConn);
            mComd.ExecuteNonQuery();
            mComd.Dispose();

            mComd = new MySqlCommand(
                "CREATE TABLE IF NOT EXISTS `expressdata`.`transport` (" +
                "`transport_id` INT NOT NULL AUTO_INCREMENT," +
                "`load_weight` INT NOT NULL," +
                "`startplace` INT NOT NULL," +
                "`endplace` INT NOT NULL," +
                "`vehicle` VARCHAR(45) NOT NULL," +
                "`starttime` DATETIME NOT NULL," +
                "`endtime` DATETIME NOT NULL," +
                "`person_id` INT NOT NULL," +
                "PRIMARY KEY (`transport_id`));", mConn);
            mComd.ExecuteNonQuery();
            mComd.Dispose();

            mComd = new MySqlCommand(
                "CREATE TABLE IF NOT EXISTS `expressdata`.`employee` (" +
                "`employee_id` INT NOT NULL AUTO_INCREMENT," +
                "`password` VARCHAR(45) NOT NULL," +
                "`name` VARCHAR(45) NOT NULL," +
                "`gender` TINYINT(1) NOT NULL," +
                "`age` INT NOT NULL," +
                "`phone` VARCHAR(20) NOT NULL," +
                "`worktime` TIME NOT NULL," +
                "`location` INT NOT NULL," +
                "PRIMARY KEY (`employee_id`));", mConn);
            mComd.ExecuteNonQuery();
            mComd.Dispose();

            mComd = new MySqlCommand(
                "CREATE TABLE IF NOT EXISTS `expressdata`.`place` (" +
                "`place_id` INT NOT NULL AUTO_INCREMENT," +
                "`province` VARCHAR(45) NOT NULL," +
                "`city` VARCHAR(45) NOT NULL," +
                "`district` VARCHAR(45) NOT NULL," +
                "`level` INT NOT NULL," +
                "PRIMARY KEY (`place_id`));", mConn);
            mComd.ExecuteNonQuery();
            mComd.Dispose();

            mComd = new MySqlCommand(
                "CREATE TABLE IF NOT EXISTS `expressdata`.`transport_goods` (" +
                "`transport_goods_id` INT NOT NULL AUTO_INCREMENT," +
                "`transport_id` INT NOT NULL," +
                "`goods_id` INT NOT NULL," +
                "PRIMARY KEY (`transport_goods_id`));", mConn);
            mComd.ExecuteNonQuery();
            mComd.Dispose();

            mComd = new MySqlCommand(
                "CREATE TABLE IF NOT EXISTS `expressdata`.`employee_transport` (" +
                "`employee_transport_id` INT NOT NULL AUTO_INCREMENT," +
                "`employee_id` INT NOT NULL," +
                "`transport_id` INT NOT NULL," +
                "`charge` TINYINT(1) NOT NULL," +
                "PRIMARY KEY (`employee_transport_id`));", mConn);
            mComd.ExecuteNonQuery();
            mComd.Dispose();

            mComd = new MySqlCommand("select * from employee", mConn);
            mRead = mComd.ExecuteReader();
            if (!mRead.HasRows)
            {
                mRead.Dispose();
                mComd.Dispose();

                mComd = new MySqlCommand(
                    "INSERT INTO `expressdata`.`employee`" +
                    "(`password`,`name`,`gender`,`age`,`phone`,`worktime`,`location`)" +
                    "VALUES('123456','管理员',1,30,'13070118279',0,1);", mConn);
                mComd.ExecuteNonQuery();
                mComd.Dispose();

                mComd = new MySqlCommand(
                   "INSERT INTO `expressdata`.`place`" +
                   "(`province`,`city`,`district`,`level`)" +
                   "VALUES('北京市','省级','中转站',1);", mConn);
                mComd.ExecuteNonQuery();
                mComd.Dispose();

                mComd = new MySqlCommand(
                    "CREATE TRIGGER `expressdata`.`employee_BEFORE_DELETE` " +
                    "BEFORE DELETE ON `employee` " +
                    "FOR EACH ROW " +
                    "BEGIN " +
                        "UPDATE `transport` " +
                        "SET `person_id` = 1 " +
                        "WHERE `person_id` IN " +
                            "(SELECT `employee_id` " +
                             "FROM `employee_transport` " +
                             "WHERE `charge` = 1 AND old.employee_id = `employee_transport`.`employee_id`); " +
                        "UPDATE `employee_transport` " +
                        "SET `employee_transport`.`employee_id` = 1 " +
                        "WHERE old.employee_id = `employee_transport`.`employee_id`; " +
                    "END", mConn);
                mComd.ExecuteNonQuery();
                mComd.Dispose();

                mComd = new MySqlCommand(
                    "CREATE PROCEDURE `ADD_TRANSPORT`(IN id INT) " +
                    "BEGIN " +
                    "UPDATE `order` " +
                    "SET `order_count` = `order_count` + 1 " +
                    "WHERE `order_id` IN " +
                        "(SELECT dISTINCT `orderid` " +
                         "FROM `goods` " +
                         "WHERE `goods_id` IN " +
                            "(SELECT `goods_id` " +
                             "FROM `transport_goods` " +
                             "WHERE `transport_id` = id)); " +
                    "UPDATE `order` " +
                    "SET `order_state` = 1 " +
                    "WHERE `order_state` = 0 AND `order_id` IN " +
                        "(SELECT dISTINCT `orderid` " +
                         "FROM `goods` " +
                         "WHERE `goods_id` IN " +
                            "(SELECT `goods_id` " +
                             "FROM `transport_goods` " +
                             "WHERE `transport_id` = id)); " +
                    "END", mConn);
                mComd.ExecuteNonQuery();
                mComd.Dispose();

                mComd = new MySqlCommand(
                    "CREATE PROCEDURE `FINISH_TRANSPORT`(IN id INT) " +
                    "BEGIN " +
	                    "UPDATE `order` " +
	                    "SET `order_count` = `order_count` - 1 " +
	                    "WHERE `order_id` IN " +
		                    "(SELECT DISTINCT `orderid` " +
                             "FROM `goods` " +
                             "WHERE `goods_id` IN " +
			                    "(SELECT `goods_id` " +
                                 "FROM `transport_goods` " +
			                     "WHERE `transport_id` = id)); " +
	                    "UPDATE `order` " +
                        "SET `order_state` = 2 " +
                        "WHERE `order_count` = 0 AND `order_state` = 1; " +
                    "END", mConn);
                mComd.ExecuteNonQuery();
                mComd.Dispose();
            }
            else
            {
                mRead.Dispose();
                mComd.Dispose();
            }
        }
    }
}
