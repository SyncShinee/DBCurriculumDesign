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
    public partial class CustomerForm : Form
    {

        private Dictionary<String, String> mp;

        public CustomerForm()
        {
            mp = new Dictionary<String, String>();
            mp.Clear();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand mComd;
            mComd = new MySqlCommand("select order_id as 订单号,userid as 发货人,startplace as 发货地点, endplace as 收货地点, order_state as 订单状态, order_time as 下单时间 from `expressdata`.`order` where userid = " + ManageForm.userid +　";", ManageForm.mConn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = mComd;
            DataSet ds = new DataSet();
            int num = da.Fill(ds, "order");
            mComd.Dispose();
            DataTable dt = new DataTable();
            dt.Columns.Add("订单号");
            dt.Columns.Add("发货人");
            dt.Columns.Add("发货地点");
            dt.Columns.Add("收货地点");
            dt.Columns.Add("订单状态");
            dt.Columns.Add("下单时间");
            for (int i = 0; i < num; ++i)
            {
                MySqlCommand mCmd;
                MySqlDataReader mrd;
                
                mCmd = new MySqlCommand("select user_name from expressdata.user where user_id = " + ManageForm.userid + ";", ManageForm.mConn);
                String stmp = mCmd.ExecuteScalar().ToString();
                DataRow dr = dt.NewRow();
                dr["订单号"] = ds.Tables["order"].Rows[i]["订单号"].ToString();
                dr["发货人"] = stmp;
                mCmd.Dispose();
               
                mCmd = new MySqlCommand("select province, city, district from expressdata.place where place_id = " + ds.Tables["order"].Rows[i]["发货地点"].ToString() + ";", ManageForm.mConn);
                mrd = mCmd.ExecuteReader();
                mrd.Read();
                dr["发货地点"] = mrd["province"].ToString() + mrd["city"].ToString() + mrd["district"].ToString();
                mrd.Dispose();

                mCmd = new MySqlCommand("select province, city, district from expressdata.place where place_id = " + ds.Tables["order"].Rows[i]["收货地点"].ToString() + ";", ManageForm.mConn);
                mrd = mCmd.ExecuteReader();
                mrd.Read();
                dr["收货地点"] = mrd["province"].ToString() + mrd["city"].ToString() + mrd["district"].ToString();
                mrd.Dispose();

                dr["订单状态"] = ds.Tables["order"].Rows[i]["订单状态"].ToString() == "0" ? "未配送" : ds.Tables["order"].Rows[i]["订单状态"].ToString() == "1" ? "正在配送" : "已送达";
                dr["下单时间"] = ds.Tables["order"].Rows[i]["下单时间"].ToString();

                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String orderid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MySqlCommand mComd;
            MySqlDataReader mRed;
            //todo
            mComd = new MySqlCommand("select goods_id, goods_name from expressdata.goods where orderid = " + orderid + ";", ManageForm.mConn);
            mRed = mComd.ExecuteReader();
            DataTable goodsList = new DataTable();
            goodsList.Columns.Add("goodsName");
            goodsList.Columns.Add("goodsid");
            DataTable transList = new DataTable();
            transList.Columns.Add("transid");
            transList.Columns.Add("goods");
            transList.Columns.Add("startAddrid");
            transList.Columns.Add("endAddrid");
            transList.Columns.Add("startAddr");
            transList.Columns.Add("endAddr");
            transList.Columns.Add("startTime");
            transList.Columns.Add("endTime");
            transList.Columns.Add("chargerid");
            transList.Columns.Add("charger");
            transList.Columns.Add("chargePhone");
            while (mRed.Read())
            {
                DataRow dr = goodsList.NewRow();
                dr["goodsname"] = mRed["goods_name"].ToString();
                dr["goodsid"] = mRed["goods_id"].ToString();
                goodsList.Rows.Add(dr);
            }
            mRed.Dispose();

            for (int i = 0; i < goodsList.Rows.Count; ++i)
            {
                MySqlCommand mCmd = new MySqlCommand("select transport_id from expressdata.transport_goods where goods_id = " + goodsList.Rows[i]["goodsid"] + ";", ManageForm.mConn);
                MySqlDataReader mdr = mCmd.ExecuteReader();
                while (mdr.Read())
                {
                    DataRow dr = transList.NewRow();
                    dr["goods"] = goodsList.Rows[i]["goodsName"];
                    dr["transid"] = mdr["transport_id"];
                    transList.Rows.Add(dr);
                }
                mdr.Dispose();
            }
            for (int i = 0; i < transList.Rows.Count; ++ i)
            {
                MySqlCommand mCmd = new MySqlCommand("select * from expressdata.transport where transport_id = " + transList.Rows[i]["transid"] + ";", ManageForm.mConn);
                MySqlDataReader mdr = mCmd.ExecuteReader();
                mdr.Read();
                transList.Rows[i]["startAddrid"] = mdr["startplace"];
                transList.Rows[i]["endAddrid"] = mdr["endplace"];
                transList.Rows[i]["startTime"] = mdr["starttime"].ToString();
                transList.Rows[i]["endTime"] = mdr["endtime"].ToString();
                transList.Rows[i]["chargerid"] = mdr["person_id"];
                mdr.Dispose();
            }
            for (int i = 0; i < transList.Rows.Count; ++i)
            {
                MySqlCommand mCmd = new MySqlCommand("select name, phone from expressdata.employee where employee_id = " + transList.Rows[i]["chargerid"] + ";", ManageForm.mConn);
                MySqlDataReader mdr = mCmd.ExecuteReader();
                mdr.Read();
                transList.Rows[i]["charger"] = mdr["name"];
                transList.Rows[i]["chargePhone"] = mdr["phone"];
                mdr.Dispose();
            }
            for (int i = 0; i < transList.Rows.Count; ++i)
            {
                MySqlCommand mCmd = new MySqlCommand("select * from expressdata.place where place_id = " + transList.Rows[i]["startAddrid"] + ";", ManageForm.mConn);
                MySqlDataReader mdr = mCmd.ExecuteReader();
                mdr.Read();
                transList.Rows[i]["startAddr"] = mdr["province"].ToString() + mdr["city"].ToString() + mdr["district"].ToString();
                mdr.Dispose();
            }
            for (int i = 0; i < transList.Rows.Count; ++i)
            {
                MySqlCommand mCmd = new MySqlCommand("select * from expressdata.place where place_id = " + transList.Rows[i]["endAddrid"] + ";", ManageForm.mConn);
                MySqlDataReader mdr = mCmd.ExecuteReader();
                mdr.Read();
                transList.Rows[i]["endAddr"] = mdr["province"].ToString() + mdr["city"].ToString() + mdr["district"].ToString();
                mdr.Dispose();
            }
            TransForm tf = new TransForm(transList);
            tf.ShowDialog();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;

            welcome.Text = "欢迎, " + ManageForm.username;
            MySqlCommand mComd;
            MySqlDataReader reader;
            mComd = new MySqlCommand("select * from place", ManageForm.mConn);
            reader = mComd.ExecuteReader();

            AutoCompleteStringCollection source = new AutoCompleteStringCollection();

            while (reader.Read()) {
                String tmp = reader["province"].ToString() + reader["city"].ToString() + reader["district"].ToString();
                source.Add(tmp);
                mp.Add(tmp, reader["place_id"].ToString());
            }
            reader.Dispose();
            
            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBox2.AutoCompleteCustomSource = source;
            textBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;

            welcome.Text = "欢迎，" + ManageForm.username;

            mComd = new MySqlCommand("select * from user where user_id=" + ManageForm.userid + ";", ManageForm.mConn);
            MySqlDataReader mRead = mComd.ExecuteReader();
            mRead.Read();
            textBoxAccount.Text = mRead["user_account"].ToString();
            textBoxName.Text = mRead["user_name"].ToString();
            textBoxAge.Text = mRead["user_age"].ToString();
            textBoxPhn.Text = mRead["user_phone"].ToString();
            textBoxMail.Text = mRead["user_email"].ToString();
            if (mRead["user_gender"].ToString().Equals("False"))
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

        private void button2_Click(object sender, EventArgs e)
        {
            String startAddr = textBox1.Text;
            String endAddr = textBox2.Text;
            if (!mp.ContainsKey(startAddr))
            {
                MessageBox.Show("出发地点不合法！");
            }
            else if (!mp.ContainsKey(endAddr))
            {
                MessageBox.Show("到达地点不合法！");
            }
            else
            {
                bool flag = true;
                for (int i = 0; i < dataGridView2.RowCount - 1; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        dataGridView2.CurrentCell = dataGridView2[j, i];
                        if (dataGridView2.CurrentCell.Value == null)
                        {
                            flag = false;
                            MessageBox.Show("货物信息填写不完整！");
                            break;
                        }
                    }
                    if (!flag)
                    {
                        break;
                    }
                }
                if (flag)
                {
                    String orderIns =
                        "INSERT INTO `expressdata`.`order`" +
                        "(" +
                        "`userid`," +
                        "`startplace`," +
                        "`endplace`," +
                        "`order_state`," +
                        "`order_time`,`order_count`)" +
                        "VALUES" +
                        "(" +
                        ManageForm.userid + "," +
                        mp[startAddr] + "," +
                        mp[endAddr] + "," +
                        "0" + ",'" +
                        DateTime.Now.ToString() + 
                        "',0);select @@Identity";
                    MySqlCommand Mcomd = new MySqlCommand(orderIns, ManageForm.mConn);
                    String order_id = Mcomd.ExecuteScalar().ToString();
                    Mcomd.Dispose();

                    for (int i = 0; i < dataGridView2.RowCount - 1; ++i)
                    {
                        String goods_name, goods_weight, goods_type;
                        dataGridView2.CurrentCell = dataGridView2[0, i];
                        goods_name = dataGridView2.CurrentCell.Value.ToString();
                        dataGridView2.CurrentCell = dataGridView2[1, i];
                        goods_type = dataGridView2.CurrentCell.Value.ToString();
                        dataGridView2.CurrentCell = dataGridView2[2, i];
                        goods_weight = dataGridView2.CurrentCell.Value.ToString();
                        String goods_ins = 
                            "INSERT INTO `expressdata`.`goods`" +
                            "(" +
                            "`weight`," +
                            "`type`," +
                            "`orderid`," +
                            "`goods_name`)" +
                            "VALUES" +
                            "(" +
                            goods_weight + ",'" +
                            goods_type + "'," +
                            order_id + ",'" +
                            goods_name + "');";
                        //MessageBox.Show(goods_ins);
                        Mcomd = new MySqlCommand(goods_ins, ManageForm.mConn);
                        Mcomd.ExecuteNonQuery();
                        Mcomd.Dispose();
                    }
                    dataGridView2.Rows.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    MessageBox.Show("下单成功，请等待配送员配送。");

                }
            }
        }

        private void buttonUpdKey_Click(object sender, EventArgs e)
        {
            PasswordForm pf = new PasswordForm();
            pf.ShowDialog();
        }

        private void infoUpdate_Click(object sender, EventArgs e)
        {
            String account = textBoxAccount.Text;
            String name = textBoxName.Text;
            String phone = textBoxPhn.Text;
            String email = textBoxMail.Text;
            int age = 0;
            int gender;
            if (account.Equals("")) {
                MessageBox.Show("用户账号不能为空！", "提示", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else if (name.Equals(""))
            {
                MessageBox.Show("用户姓名不能为空！", "提示", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else if (phone.Equals("") || phone.Length != 11)
            {
                MessageBox.Show("手机号码填写不正确！", "提示", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else if (email.Equals("")) {
                MessageBox.Show("联系邮箱不能为空！", "提示", MessageBoxButtons.OK,
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
                    "UPDATE `expressdata`.`user`" +
                    "SET" +
                    "`user_account` = '" + account + "'," +
                    "`user_name` = '" + name + "'," +
                    "`user_gender` = " + gender + "," +
                    "`user_age` = " + age + "," +
                    "`user_phone` = '" + phone + "'," +
                    "`user_email` = '" + email + "'" +
                    "WHERE `user_id` = " + ManageForm.userid + ";", ManageForm.mConn);
                mComd.ExecuteNonQuery();
                mComd.Dispose();
                MessageBox.Show("更新个人资料成功！", "提示", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
    }
}