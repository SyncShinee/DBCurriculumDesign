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
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand mComd;
            mComd = new MySqlCommand("select * from order where userid='" + ManageForm.userid + "';", ManageForm.mConn);
            dataGridView1.ReadOnly = true;
            MySqlDataAdapter da = new MySqlDataAdapter(mComd);
            DataSet ds = new DataSet();
            da.Fill(ds, "order");
            dataGridView1.DataSource = ds;
            mComd.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String orderid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MySqlCommand mComd;
            //todo
            mComd = new MySqlCommand("select * from order, ", ManageForm.mConn);

        }
    }
}
