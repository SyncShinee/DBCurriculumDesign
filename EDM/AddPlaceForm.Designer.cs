namespace EDM
{
    partial class AddPlaceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.label_level = new System.Windows.Forms.Label();
            this.label_province = new System.Windows.Forms.Label();
            this.label_city = new System.Windows.Forms.Label();
            this.label_district = new System.Windows.Forms.Label();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxDistrict = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "省级",
            "市级",
            "镇/区级"});
            this.comboBoxLevel.Location = new System.Drawing.Point(207, 85);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(121, 26);
            this.comboBoxLevel.TabIndex = 0;
            this.comboBoxLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevel_SelectedIndexChanged);
            // 
            // label_level
            // 
            this.label_level.AutoSize = true;
            this.label_level.Location = new System.Drawing.Point(78, 88);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(80, 18);
            this.label_level.TabIndex = 1;
            this.label_level.Text = "地点级别";
            // 
            // label_province
            // 
            this.label_province.AutoSize = true;
            this.label_province.Location = new System.Drawing.Point(101, 136);
            this.label_province.Name = "label_province";
            this.label_province.Size = new System.Drawing.Size(26, 18);
            this.label_province.TabIndex = 2;
            this.label_province.Text = "省";
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(101, 188);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(26, 18);
            this.label_city.TabIndex = 3;
            this.label_city.Text = "市";
            // 
            // label_district
            // 
            this.label_district.AutoSize = true;
            this.label_district.Location = new System.Drawing.Point(104, 237);
            this.label_district.Name = "label_district";
            this.label_district.Size = new System.Drawing.Size(53, 18);
            this.label_district.TabIndex = 4;
            this.label_district.Text = "镇/区";
            // 
            // textBoxProvince
            // 
            this.textBoxProvince.Location = new System.Drawing.Point(207, 133);
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(100, 28);
            this.textBoxProvince.TabIndex = 5;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(207, 185);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 28);
            this.textBoxCity.TabIndex = 6;
            // 
            // textBoxDistrict
            // 
            this.textBoxDistrict.Location = new System.Drawing.Point(207, 234);
            this.textBoxDistrict.Name = "textBoxDistrict";
            this.textBoxDistrict.Size = new System.Drawing.Size(100, 28);
            this.textBoxDistrict.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "增加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddPlaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDistrict);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxProvince);
            this.Controls.Add(this.label_district);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.label_province);
            this.Controls.Add(this.label_level);
            this.Controls.Add(this.comboBoxLevel);
            this.Name = "AddPlaceForm";
            this.Text = "增加地点";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.Label label_province;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.Label label_district;
        private System.Windows.Forms.TextBox textBoxProvince;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxDistrict;
        private System.Windows.Forms.Button button1;
    }
}