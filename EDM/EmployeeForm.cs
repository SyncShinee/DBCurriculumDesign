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
    public partial class EmployeeForm : Form
    {
        private DataSet ds_ord_d;
        public EmployeeForm()
        {
            ds_ord_d = new DataSet();

            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            welcome.Text = "欢迎，" + ManageForm.username;

            dataGridViewEmployee.ReadOnly = true;
            dataGridViewFinish.ReadOnly = true;
            dataGridViewOrder.ReadOnly = true;
            dataGridViewToDo.ReadOnly = true;

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

            if (ManageForm.userid.Equals("1")) 
            {
                distributeTab.Parent = tabControl1;
                adminTab.Parent = tabControl1;
            }
            else
            {
                distributeTab.Parent = null;
                adminTab.Parent = null;
            }
        }

        private void infoUpdate_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
            String phone = textBoxPhn.Text;
            int age = 0;
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

        private void button4_Click(object sender, EventArgs e)
        {
            AddEmployeeForm aef = new AddEmployeeForm();
            aef.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddPlaceForm apf = new AddPlaceForm();
            apf.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlCommand mCmd = new MySqlCommand("select * from expressdata.employee", ManageForm.mConn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = mCmd;
            DataSet ds = new DataSet();
            int num = da.Fill(ds, "emp");
            mCmd.Dispose();
            DataTable dt = new DataTable();
            dt.Columns.Add("员工号");
            dt.Columns.Add("姓名");
            dt.Columns.Add("性别");
            dt.Columns.Add("年龄");
            dt.Columns.Add("联系电话");
            dt.Columns.Add("工作时长");
            dt.Columns.Add("当前所在位置");
            for (int i = 0; i < num; ++ i)
            {
                DataRow dr = dt.NewRow();
                dr["员工号"] = ds.Tables["emp"].Rows[i]["employee_id"];
                dr["姓名"] = ds.Tables["emp"].Rows[i]["name"];
                dr["性别"] = ds.Tables["emp"].Rows[i]["gender"].ToString();
                if (dr["性别"].ToString() == "True")
                {
                    dr["性别"] = "男";
                }
                else
                {
                    dr["性别"] = "女";
                }
                dr["年龄"] = ds.Tables["emp"].Rows[i]["age"];
                dr["联系电话"] = ds.Tables["emp"].Rows[i]["phone"];
                dr["工作时长"] = ds.Tables["emp"].Rows[i]["worktime"];
                MySqlCommand mc = new MySqlCommand("select * from expressdata.place where place_id = " + ds.Tables["emp"].Rows[i]["location"] + ";", ManageForm.mConn);
                MySqlDataReader mr = mc.ExecuteReader();
                mr.Read();
                dr["当前所在位置"] = mr["province"].ToString() + mr["city"].ToString() + mr["district"].ToString();
                dt.Rows.Add(dr);
                mr.Dispose();
            }
            dataGridViewEmployee.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand mCmd = new MySqlCommand("select transport_id from expressdata.employee_transport where employee_id = " + ManageForm.userid + ";", ManageForm.mConn);
            DataTable dt_todo = new DataTable();
            DataTable dt_finish = new DataTable();
            DataTable dt_tot = new DataTable();
            dt_tot.Columns.Add("transid");
            dt_todo.Columns.Add("配送任务流水号");
            dt_todo.Columns.Add("配送货物总重");
            dt_todo.Columns.Add("出发地点");
            dt_todo.Columns.Add("目的地点");
            dt_todo.Columns.Add("运输工具");
            dt_todo.Columns.Add("出发时间");
            dt_todo.Columns.Add("到达时间");
            dt_todo.Columns.Add("负责人");
            dt_finish.Columns.Add("配送任务流水号");
            dt_finish.Columns.Add("配送货物总重");
            dt_finish.Columns.Add("出发地点");
            dt_finish.Columns.Add("目的地点");
            dt_finish.Columns.Add("运输工具");
            dt_finish.Columns.Add("出发时间");
            dt_finish.Columns.Add("到达时间");
            dt_finish.Columns.Add("负责人");
            MySqlDataReader mReader = mCmd.ExecuteReader();
            while (mReader.Read())
            {
                DataRow dr = dt_tot.NewRow();
                dr["transid"] = mReader["transport_id"];
                dt_tot.Rows.Add(dr);
            }
            mReader.Dispose();
            for (int i = 0; i < dt_tot.Rows.Count; ++i)
            {
                MySqlCommand mc = new MySqlCommand("select * from expressdata.transport where transport_id = " + dt_tot.Rows[i]["transid"] + ";", ManageForm.mConn);
                MySqlDataReader mdr = mc.ExecuteReader();
                mdr.Read();
                if ("1000/1/1 0:00:00".Equals(mdr["endtime"].ToString()))
                {
                    DataRow dar = dt_todo.NewRow();
                    dar["配送任务流水号"] = mdr["transport_id"];
                    dar["配送货物总重"] = mdr["load_weight"];
                    dar["出发地点"] = mdr["startplace"].ToString();
                    dar["目的地点"] = mdr["endplace"].ToString();
                    dar["运输工具"] = mdr["vehicle"];
                    dar["出发时间"] = mdr["starttime"].ToString();
                    dar["到达时间"] = mdr["endtime"].ToString();
                    dar["负责人"] = mdr["person_id"].ToString();

                    if (dar["出发时间"].ToString() == "1000/1/1 0:00:00")
                    {
                        dar["出发时间"] = "未出发";
                    }
                    if (dar["到达时间"].ToString() == "1000/1/1 0:00:00")
                    {
                        dar["到达时间"] = "未送达";
                    }
                    dt_todo.Rows.Add(dar);
                }
                else
                {
                    DataRow dar = dt_finish.NewRow();
                    dar["配送任务流水号"] = mdr["transport_id"];
                    dar["配送货物总重"] = mdr["load_weight"];
                    dar["出发地点"] = mdr["startplace"].ToString();
                    dar["目的地点"] = mdr["endplace"].ToString();
                    dar["运输工具"] = mdr["vehicle"];
                    dar["出发时间"] = mdr["starttime"].ToString();
                    dar["到达时间"] = mdr["endtime"].ToString();
                    dar["负责人"] = mdr["person_id"].ToString();
                    if (dar["出发时间"].ToString() == "1000/1/1 0:00:00")
                    {
                        dar["出发时间"] = "未出发";
                    }
                    if (dar["到达时间"].ToString() == "1000/1/1 0:00:00")
                    {
                        dar["到达时间"] = "未送达";
                    }
                    dt_finish.Rows.Add(dar);
                }
                mdr.Dispose();
            }
            for (int i = 0; i < dt_todo.Rows.Count; ++i)
            {
                MySqlCommand msc = new MySqlCommand("select * from expressdata.place where place_id = " + dt_todo.Rows[i]["出发地点"] + ";", ManageForm.mConn);
                MySqlDataReader msdr = msc.ExecuteReader();
                msdr.Read();
                dt_todo.Rows[i]["出发地点"] = msdr["province"].ToString() + msdr["city"].ToString() + msdr["district"].ToString();
                msdr.Dispose();

                msc = new MySqlCommand("select * from expressdata.place where place_id = " + dt_todo.Rows[i]["目的地点"] + ";", ManageForm.mConn);
                msdr = msc.ExecuteReader();
                msdr.Read();
                dt_todo.Rows[i]["目的地点"] = msdr["province"].ToString() + msdr["city"].ToString() + msdr["district"].ToString();
                msdr.Dispose();

                msc = new MySqlCommand("select name from expressdata.employee where employee_id = " + dt_todo.Rows[i]["负责人"] + ";", ManageForm.mConn);
                msdr = msc.ExecuteReader();
                msdr.Read();
                dt_todo.Rows[i]["负责人"] = msdr["name"];
                msdr.Dispose();
            }
            for (int i = 0; i < dt_finish.Rows.Count; ++i)
            {
                MySqlCommand msc = new MySqlCommand("select * from expressdata.place where place_id = " + dt_finish.Rows[i]["出发地点"] + ";", ManageForm.mConn);
                MySqlDataReader msdr = msc.ExecuteReader();
                msdr.Read();
                dt_finish.Rows[i]["出发地点"] = msdr["province"].ToString() + msdr["city"].ToString() + msdr["district"].ToString();
                msdr.Dispose();

                msc = new MySqlCommand("select * from expressdata.place where place_id = " + dt_finish.Rows[i]["目的地点"] + ";", ManageForm.mConn);
                msdr = msc.ExecuteReader();
                msdr.Read();
                dt_finish.Rows[i]["目的地点"] = msdr["province"].ToString() + msdr["city"].ToString() + msdr["district"].ToString();
                msdr.Dispose();

                msc = new MySqlCommand("select name from expressdata.employee where employee_id = " + dt_finish.Rows[i]["负责人"] + ";", ManageForm.mConn);
                msdr = msc.ExecuteReader();
                msdr.Read();
                dt_finish.Rows[i]["负责人"] = msdr["name"];
                msdr.Dispose();
            }
            dataGridViewToDo.DataSource = dt_todo;
            dataGridViewFinish.DataSource = dt_finish;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt_ord_d = new DataTable();
            dt_ord_d.Columns.Add("订单号");
            dt_ord_d.Columns.Add("发货人姓名");
            dt_ord_d.Columns.Add("发货地点");
            dt_ord_d.Columns.Add("收货地点");
            dt_ord_d.Columns.Add("下单时间");

            MySqlCommand mComm = new MySqlCommand("select * from expressdata.order where order_state = 0;", ManageForm.mConn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = mComm;
            int num = da.Fill(ds_ord_d, "ord");
            mComm.Dispose();

            for (int i = 0; i < num; ++i)
            {
                DataRow dr = dt_ord_d.NewRow();
                dr["订单号"] = ds_ord_d.Tables["ord"].Rows[i]["order_id"];
                dr["下单时间"] = ds_ord_d.Tables["ord"].Rows[i]["order_time"];
                
                MySqlCommand mc = new MySqlCommand("select * from expressdata.user where user_id = " + ds_ord_d.Tables["ord"].Rows[i]["userid"].ToString() + ";", ManageForm.mConn);
                MySqlDataReader mdr = mc.ExecuteReader();
                mdr.Read();
                dr["发货人姓名"] = mdr["user_name"];
                mdr.Dispose();

                mc = new MySqlCommand("select province, city, district from expressdata.place where place_id = " + ds_ord_d.Tables["ord"].Rows[i]["startplace"].ToString() + ";", ManageForm.mConn);
                mdr = mc.ExecuteReader();
                mdr.Read();
                dr["发货地点"] = mdr["province"].ToString() + mdr["city"].ToString() + mdr["district"].ToString();
                mdr.Dispose();

                mc = new MySqlCommand("select province, city, district from expressdata.place where place_id = " + ds_ord_d.Tables["ord"].Rows[i]["endplace"].ToString() + ";", ManageForm.mConn);
                mdr = mc.ExecuteReader();
                mdr.Read();
                dr["收货地点"] = mdr["province"].ToString() + mdr["city"].ToString() + mdr["district"].ToString();
                mdr.Dispose();

                dt_ord_d.Rows.Add(dr);
            }
            dataGridViewOrder.DataSource = dt_ord_d;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt_goods_roads = new DataTable();
            dt_goods_roads.Columns.Add("st");
            dt_goods_roads.Columns.Add("ed");
            dt_goods_roads.Columns.Add("goods");
            dt_goods_roads.Columns.Add("goods_w");
            dataGridViewOrder.DataSource = null;
            for (int i = 0; i < ds_ord_d.Tables["ord"].Rows.Count; ++i)
            {
                DataTable dt_road = new DataTable();
                dt_road.Columns.Add("st");
                dt_road.Columns.Add("ed");

                String startid = ds_ord_d.Tables["ord"].Rows[i]["startplace"].ToString();
                String endid = ds_ord_d.Tables["ord"].Rows[i]["endplace"].ToString();
                String orderid = ds_ord_d.Tables["ord"].Rows[i]["order_id"].ToString();
                Dictionary<String, String> stp = new Dictionary<String, String>();
                Dictionary<String, String> edp = new Dictionary<String, String>();
                Dictionary<String, String> tmp = new Dictionary<String, String>();
                
                if (startid == endid) {
                    continue;
                }

                MySqlCommand mc;
                MySqlDataReader mdr;

                mc = new MySqlCommand("select * from expressdata.place where place_id = " + startid + ";", ManageForm.mConn);
                mdr = mc.ExecuteReader();
                mdr.Read();
                stp.Add("id", mdr["place_id"].ToString());
                stp.Add("prov", mdr["province"].ToString());
                stp.Add("city", mdr["city"].ToString());
                stp.Add("dist", mdr["district"].ToString());
                stp.Add("level", mdr["level"].ToString());
                mdr.Dispose();

                mc = new MySqlCommand("select * from expressdata.place where place_id = " + endid + ";", ManageForm.mConn);
                mdr = mc.ExecuteReader();
                mdr.Read();
                edp.Add("id", mdr["place_id"].ToString());
                edp.Add("prov", mdr["province"].ToString());
                edp.Add("city", mdr["city"].ToString());
                edp.Add("dist", mdr["district"].ToString());
                edp.Add("level", mdr["level"].ToString());
                mdr.Dispose();
                
                // tianjia zhongjian lu
                DataRow dr_road = dt_road.NewRow();
                dr_road["st"] = stp["id"];
                dr_road["ed"] = edp["id"];
                dt_road.Rows.Add(dr_road);

                mc = new MySqlCommand("select * from expressdata.goods where orderid = " + orderid + ";", ManageForm.mConn);
                mdr = mc.ExecuteReader();
                while (mdr.Read())
                {
                    for (int j = 0; j < dt_road.Rows.Count; ++ j) {
                        DataRow dr = dt_goods_roads.NewRow();
                        dr["st"] = dt_road.Rows[j]["st"].ToString();
                        dr["ed"] = dt_road.Rows[j]["ed"].ToString();
                        dr["goods"] = mdr["goods_id"];
                        dr["goods_w"] = mdr["weight"];
                        dt_goods_roads.Rows.Add(dr);
                    }
                }
                mdr.Dispose();
            }

            DataView dv = dt_goods_roads.DefaultView;
            dv.Sort = "st, ed";
            dt_goods_roads = dv.ToTable();
            //an zhongliang fenpei

            for (int i = 0; i < dt_goods_roads.Rows.Count; ++i)
            {
                String transport_ins =
                    "INSERT INTO `expressdata`.`transport`" +
                    "(" +
                    "`load_weight`," +
                    "`startplace`," +
                    "`endplace`," +
                    "`vehicle`," +
                    "`starttime`," +
                    "`endtime`," +
                    "`person_id`)" +
                    "VALUES" +
                    "(" +
                    dt_goods_roads.Rows[i]["goods_w"] + "," +
                    dt_goods_roads.Rows[i]["st"] + "," +
                    dt_goods_roads.Rows[i]["ed"] + "," +
                    "'汽车'," +
                    "'1000-01-01 00:00:00'," +
                    "'1000-01-01 00:00:00'," +
                    "1);select @@Identity";
                MySqlCommand msc = new MySqlCommand(transport_ins, ManageForm.mConn);
                String transport_id = msc.ExecuteScalar().ToString();
                
                String trans_goods_ins = 
                    "INSERT INTO `expressdata`.`transport_goods`(`transport_id`,`goods_id`)VALUES(" +
                    transport_id + "," +
                    dt_goods_roads.Rows[i]["goods"] + ");";
                msc = new MySqlCommand(trans_goods_ins, ManageForm.mConn);
                msc.ExecuteNonQuery();
                msc.Dispose();

                String trans_emp_ins =
                    "INSERT INTO `expressdata`.`employee_transport`(`employee_id`,`transport_id`,`charge`)VALUES(" +
                    "1" + "," +
                    transport_id + "," +
                    "1" + ");";
                msc = new MySqlCommand(trans_emp_ins, ManageForm.mConn);
                msc.ExecuteNonQuery();
                msc.Dispose();

                msc = new MySqlCommand("CALL ADD_TRANSPORT(" + transport_id + ");", ManageForm.mConn);
                msc.ExecuteNonQuery();
                msc.Dispose();
            }
            MessageBox.Show("配送任务分配成功！");
        }

        private void dataGridViewToDo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String transid = dataGridViewToDo.CurrentRow.Cells[0].Value.ToString();
            String transstarttime = dataGridViewToDo.CurrentRow.Cells[5].Value.ToString();
            String transendtime = dataGridViewToDo.CurrentRow.Cells[6].Value.ToString();
            String charger = dataGridViewToDo.CurrentRow.Cells[7].Value.ToString();
            //MessageBox.Show(transid + transstarttime + transendtime + charger);
            if (transstarttime == "未出发")
            {
                if (charger == ManageForm.username)
                {
                    StartTransForm stf = new StartTransForm(transid);
                    stf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("您不是该项配送任务的负责人，请等待负责人修改任务状态！");
                }
            }
            else if (transendtime == "未送达")
            {
                if (charger == ManageForm.username)
                {
                    EndTransForm etf = new EndTransForm(transid);
                    etf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("您不是该项配送任务的负责人，请等待负责人修改任务状态！");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String empid = dataGridViewEmployee.CurrentRow.Cells[0].Value.ToString();
            String sql = "";

            MySqlCommand mc = new MySqlCommand(sql, ManageForm.mConn);
        }

    }
}
