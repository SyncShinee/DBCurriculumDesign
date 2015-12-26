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
    public partial class AddPlaceForm : Form
    {
        public AddPlaceForm()
        {
            InitializeComponent();
            textBoxProvince.ReadOnly = true;
            textBoxCity.ReadOnly = true;
            textBoxDistrict.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String province;
            String city;
            String district;
            int level = 0;
            if (comboBoxLevel.SelectedItem.ToString().Equals("省级"))
            {
                province = textBoxProvince.Text;
                city = province;
                district = province;
                level = 1;

            }
            else if (comboBoxLevel.SelectedItem.ToString().Equals("市级"))
            {
                province = textBoxProvince.Text;
                city = textBoxCity.Text;
                district = city;
                level = 2;
            }
            else   //comboBoxLevel.SelectedItem.ToString().Equals("镇/区级")
            {
                province = textBoxProvince.Text;
                city = textBoxCity.Text;
                district = textBoxDistrict.Text;
                level = 3;
            }
            MySqlCommand mComd = new MySqlCommand(
                "INSERT INTO `expressdata`.`place`" +
                "(`province`,`city`,`district`,`level`)" +
                "VALUES('" + province + "','" + city + "','" + district + "'," + level + ");", ManageForm.mConn);
            mComd.ExecuteNonQuery();
            mComd.Dispose();
            MessageBox.Show("增加新地点成功！", "提示", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }

        private void comboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLevel.SelectedItem.ToString().Equals("省级"))
            {
                textBoxProvince.ReadOnly = false;
                textBoxCity.ReadOnly = true;
                textBoxDistrict.ReadOnly = true;
                textBoxCity.Clear();
                textBoxDistrict.Clear();
            }
            else if (comboBoxLevel.SelectedItem.ToString().Equals("市级"))
            {
                textBoxProvince.ReadOnly = false;
                textBoxCity.ReadOnly = false;
                textBoxDistrict.ReadOnly = true;
                textBoxDistrict.Clear();
            }
            else   //comboBoxLevel.SelectedItem.ToString().Equals("镇/区级")
            {
                textBoxProvince.ReadOnly = false;
                textBoxCity.ReadOnly = false;
                textBoxDistrict.ReadOnly = false;
            }
        }
    }
}
