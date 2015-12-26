using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDM
{
    public partial class TransForm : Form
    {
        private DataTable dt;
        public TransForm(DataTable _dt)
        {
            dt = _dt;
            InitializeComponent();
        }

        private void transForm_Load(object sender, EventArgs e)
        {
            DataTable show_table = new DataTable();
            show_table.Columns.Add("货物名称");
            show_table.Columns.Add("出发地点");
            show_table.Columns.Add("目的地点");
            show_table.Columns.Add("出发时间");
            show_table.Columns.Add("送达时间");
            show_table.Columns.Add("负责人");
            show_table.Columns.Add("负责人电话");

            for (int i = 0; i < dt.Rows.Count; ++ i)
            {
                DataRow dr = show_table.NewRow();
                dr["货物名称"] = dt.Rows[i]["goods"];
                dr["出发地点"] = dt.Rows[i]["startAddr"];
                dr["目的地点"] = dt.Rows[i]["endAddr"];
                dr["出发时间"] = dt.Rows[i]["startTime"];
                dr["送达时间"] = dt.Rows[i]["endTime"];
                dr["负责人"] = dt.Rows[i]["charger"];
                dr["负责人电话"] = dt.Rows[i]["chargePhone"];
                show_table.Rows.Add(dr);
            }
            dataGridView1.DataSource = show_table;
            dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
