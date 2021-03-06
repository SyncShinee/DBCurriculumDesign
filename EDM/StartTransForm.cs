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
    public partial class StartTransForm : Form
    {
        private String transid;
        public StartTransForm(string _transid)
        {
            transid = _transid;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String trans_upd =
                "UPDATE `expressdata`.`transport` SET" +
                "`starttime` ='" + DateTime.Now.ToString() +
                "' WHERE `transport_id` = " + transid + ";";
            MySqlCommand mc = new MySqlCommand(trans_upd, ManageForm.mConn);
            mc.ExecuteNonQuery();
            this.Dispose();
        }
    }
}
