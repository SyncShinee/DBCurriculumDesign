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
            mComd = new MySqlCommand("select * from expressdata.order where userid='" + ManageForm.userid + "';", ManageForm.mConn);
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

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;


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
                int tx = 0, ty = 0;
                
            }
        }
    }
}
