using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HaveARest
{
    public partial class HaveARest : Form
    {
        public HaveARest()
        {
            InitializeComponent();
        }
        private void HaveARest_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;//设置边框为不可调节
            this.MaximizeBox = false; //取消最大化按键

            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            XmlNode root = xml.SelectNodes("setting").Item(0);
            this.textBox_worktime.Text = root.SelectNodes("work").Item(0).InnerText;
            this.textBox_resttime.Text = root.SelectNodes("rest").Item(0).InnerText;
        }

        private static string path = @"XMLSET.xml";

        private void button_Start_Click(object sender, EventArgs e)
        {
            int worktime, resttime;
            try
            {
                worktime = Convert.ToInt32(this.textBox_worktime.Text);
                resttime = Convert.ToInt32(this.textBox_resttime.Text);
                XmlDocument xml = new XmlDocument();
                xml.Load(path);
                XmlNode root = xml.SelectNodes("setting").Item(0);
                root.SelectNodes("work").Item(0).InnerText = this.textBox_worktime.Text;
                root.SelectNodes("rest").Item(0).InnerText = this.textBox_resttime.Text;
                xml.Save(path);
                start s = new start(worktime, resttime);
                s.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("请输入数字，且不支持小数！");
            }
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setting set = new setting();
            set.ShowDialog();
        }

    }
}
