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

            mConn = new MySqlConnection("Host = localhost;" + "Database = expressdata;" + "Username = root;" + "Password = 123456");
            mConn.Open();
            
            LoginForm lf = new LoginForm();
            if (lf.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("登陆成功！\n欢迎来到本系统！");
            }
            else
            {
                this.Dispose();
            }
        }
    }
}
