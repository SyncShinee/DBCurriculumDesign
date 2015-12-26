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
            //todo
            mComd = new MySqlCommand("select * from order, ", ManageForm.mConn);

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;

            label_user.Text = "欢迎, " + ManageForm.username;
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                        if (dataGridView2.CurrentCell.Value.ToString() == "")
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
                        "`order_time`)" +
                        "VALUES" +
                        "(" +
                        ManageForm.userid + "," +
                        mp[startAddr] + "," +
                        mp[endAddr] + "," +
                        "0" + ",'" +
                        DateTime.Now.ToString() + "');select @@Identity";
                    MySqlCommand Mcomd = new MySqlCommand(orderIns, ManageForm.mConn);
                    int order_id = int.Parse(Mcomd.ExecuteScalar().ToString());
                    


                }
            }
        }
    }
}