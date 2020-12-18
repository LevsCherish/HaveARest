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
    public partial class start : Form
    {
        private int worktime, resttime;

        private int cost = 1;   //倒计时用，表示秒
        private int total;//倒计时用，表示总分钟数
        private bool isRest;

        private static string path = @"XMLSET.xml";
        private static bool skip, allscreen;
        private string work, rest;

        public start(int work, int rest)
        {
            InitializeComponent();
            worktime = work;
            resttime = rest;
            total = work - 1;
        }
        private void start_Load(object sender, EventArgs e)
        {
            // 读取设置
            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            XmlNode root = xml.SelectSingleNode("setting");
            skip = Convert.ToBoolean(root.SelectNodes("checkBox_skip").Item(0).InnerText);
            allscreen = Convert.ToBoolean(root.SelectNodes("checkBox_allScreen").Item(0).InnerText);
            work = root.SelectNodes("workTips").Item(0).InnerText;
            rest = root.SelectNodes("restTips").Item(0).InnerText;

            // 设置初始化
            timer1.Enabled = true;
            timer1.Start();
            string worktime2;
            if (worktime < 10)
                worktime2 = "0" + worktime.ToString();
            else
                worktime2 = worktime.ToString();
            this.label2.Text = worktime2 + ":00";
            this.label1.Text = work;

            // 设置布局
            LayOutSet layoutset = new LayOutSet(Size.Width, Size.Height);
            layoutset.setXCenter(this.label2);
            layoutset.setXCenter(this.label1);
            layoutset.setXCenter(this.button_skip);

            // 设置当前状态
            isRest = false;
        }
        
        private void havearest()
        {
            // 休息
            if (skip)
            {
                this.button_skip.Visible = true;
            }
            if (allscreen)
            {
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = true;
            }
            this.label_close.Visible = false;
            isRest = true;

            // 初始化倒计时
            string resttime2;
            if (resttime < 10)
                resttime2 = "0" + resttime.ToString();
            else
                resttime2 = resttime.ToString();
            this.label2.Text = resttime2 + ":00";
            this.label1.Text = rest;

            // 设置布局
            LayOutSet layoutset = new LayOutSet(Size.Width, Size.Height);
            layoutset.setXCenter(this.label2);
            layoutset.setXCenter(this.label1);
            layoutset.setXCenter(this.button_skip);

            // 重置倒计时
            cost = 1;
            this.total = resttime - 1;
            timer1.Start();
        }

        private void beginwork()
        {
            // 工作
            if (skip)
            {
                this.button_skip.Visible = false;
            }
            if (allscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.TopMost = false;
            }
            this.label_close.Visible = true;
            isRest = false;

            // 初始化倒计时
            string worktime2;
            if (worktime < 10)
                worktime2 = "0" + worktime.ToString();
            else
                worktime2 = worktime.ToString();
            this.label2.Text = worktime2 + ":00";
            this.label1.Text = work;

            // 设置布局
            LayOutSet layoutset = new LayOutSet(Size.Width, Size.Height);
            layoutset.setXCenter(this.label2);
            layoutset.setXCenter(this.label1);
            layoutset.setXCenter(this.button_skip);

            // 重置倒计时
            cost = 1;
            this.total = worktime - 1;
            timer1.Start();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_skip_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            beginwork();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 倒计时
            if (total < 0)
            {
                timer1.Stop();
                if (!isRest)
                    havearest();
                else
                    beginwork();
            }
            string cost2, total2;
            if (cost < 60)
            {
                if (cost > 50)
                    cost2 = "0" + (60 - cost).ToString();
                else
                    cost2 = (60 - cost).ToString();
                if (total < 10)
                    total2 = "0" + total.ToString();
                else
                    total2 = total.ToString();
                cost++;
                this.label2.Text = total2+":"+cost2;
            }
            else
            {
                total--;
                cost = 1;
            }
        }
        
    }
}
