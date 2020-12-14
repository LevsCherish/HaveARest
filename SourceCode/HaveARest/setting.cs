using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HaveARest
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }
        private CheckBox[] cbarray =new CheckBox[2];
        private static string path = @"XMLSET.xml";

        private void setting_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;//设置边框为不可调节
            this.MaximizeBox = false; //取消最大化按键
            this.MinimizeBox = false;//取消最小化按键

            cbarray[0] = this.checkBox_skip;
            cbarray[1] = this.checkBox_allScreen;
            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            XmlNode root = xml.SelectSingleNode("setting");
            foreach (CheckBox cb in cbarray)
            {
                cb.Checked = Convert.ToBoolean(root.SelectNodes(cb.Name).Item(0).InnerText);
            }
        }

        private void button_saveset_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            XmlNode root = xml.SelectSingleNode("setting");
            foreach (CheckBox cb in cbarray)
            {
                root.SelectNodes(cb.Name).Item(0).InnerText = cb.Checked.ToString();
            }
            xml.Save(path);
        }
    }
}
