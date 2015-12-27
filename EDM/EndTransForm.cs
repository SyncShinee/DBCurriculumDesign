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
    public partial class EndTransForm : Form
    {
        String transid;
        public EndTransForm(String _t)
        {
            transid = _t;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand mc;
            mc = new MySqlCommand("select starttime from expressdata.transport where transport_id = " + transid + ";", ManageForm.mConn);
            DateTime dtimt = DateTime.Parse(mc.ExecuteScalar().ToString());
            mc.Dispose();
            TimeSpan ts = DateTime.Now - dtimt;

            mc = new MySqlCommand("select worktime from expressdata.employee where employee_id = " + ManageForm.userid + ";", ManageForm.mConn);
            ts = ts + TimeSpan.Parse(mc.ExecuteScalar().ToString());
            mc.Dispose();
            String employee_upd =
                "UPDATE `expressdata`.`employee`" +
                "SET" +
                "`worktime` = '" + ts.ToString() + "'" +
                "WHERE `employee_id` =" + ManageForm.userid + ";";

            mc = new MySqlCommand(employee_upd, ManageForm.mConn);
            mc.ExecuteNonQuery();
            mc.Dispose();

            String trans_upd =
                "UPDATE `expressdata`.`transport` SET" +
                "`endtime` ='" + DateTime.Now.ToString() +
                "' WHERE `transport_id` = " + transid + ";";
            mc = new MySqlCommand(trans_upd, ManageForm.mConn);
            mc.ExecuteNonQuery();
            mc.Dispose();

            mc = new MySqlCommand("CALL FINISH_TRANSPORT(" + transid + ");", ManageForm.mConn);
            mc.ExecuteNonQuery();
            mc.Dispose();

            this.Dispose();
        }
    }
}
