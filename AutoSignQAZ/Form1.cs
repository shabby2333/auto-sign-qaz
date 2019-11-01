using AutoSignQAZ.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSignQAZ
{
    public partial class AutoSignQAZMainForm : Form
    {
        private const string DateFormat = "yyyy-MM-dd HH:mm:ss";
        private Config config;

        public AutoSignQAZMainForm()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            InitializeComponent();

            //Init();
        }

        private void Init()
        {
            //注册Log事件
            QAZProject.LoginStatusEvent += QAZProject_LoginStatusEvent;
            QAZProject.SignStatusEvent += QAZProject_SignStatusEvent;

            //加载配置文件
            if (File.Exists("./config.json"))
            {
                config = JsonConvert.DeserializeObject<Config>(File.ReadAllText("./config.json"));
                
            }

            if (config == null) config = new Config();
            if (config.Users == null) config.Users = new List<QAZProject>();

            RefreshUserView();
        }

        public void SaveConfig()
        {

            this.config.CheckInterval = (String.IsNullOrEmpty(textBoxCheckInterval.Text)
                || !Int32.TryParse(textBoxCheckInterval.Text, out int checkInterval))
                ? 30 : checkInterval % 3600;
            this.config.DelaySignModeSwitch = checkBoxDelaySignMode.Checked;
            this.config.DelaySignModeTime = (String.IsNullOrEmpty(textBoxDelaySignModeTime.Text)
                || !Int32.TryParse(textBoxDelaySignModeTime.Text, out int delaySignModeTime))
                ? 8 : delaySignModeTime % 24;
            this.config.Proxy = textBoxProxy.Text;

            this.timerSignIn.Interval = this.config.CheckInterval * 60 * 1000;
            if (!String.IsNullOrEmpty(this.config.Proxy))
            {
                    HttpUtil.httpClientHandler.Proxy = new WebProxy(this.config.Proxy);
            }

            File.WriteAllText("./config.json", JsonConvert.SerializeObject(config));

            this.RefreshUserView();
        }

        private async void BtnAddUser_ClickAsync(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxEmail.Text) || String.IsNullOrEmpty(textBoxPassword.Text))
            {
                _ = MessageBox.Show(this, "请输入用户名与密码", "输入错误辣~", MessageBoxButtons.OK);
                return;
            }

            foreach (var user in config.Users)
            {
                if (user.Email == textBoxEmail.Text)
                {
                    user.Password = textBoxPassword.Text;
                    _ = await user.Login();
                    SaveConfig();
                    _ = MessageBox.Show(this, "账户已存在 已更新密码", "操作完成~", MessageBoxButtons.OK);
                    RefreshUserView();
                    return;
                }
            }

            QAZProject project1 = new QAZProject(textBoxEmail.Text, textBoxPassword.Text);
            //_ = project1.Sign();
            _ = project1.Login().ConfigureAwait(false);


            //_ = await project1.Sign();
            config.Users.Add(project1);
            SaveConfig();
            RefreshUserView();

            MessageBox.Show(this, "账户已经添加啦~", "操作完成~", MessageBoxButtons.OK);

        }

        private void QAZProject_SignStatusEvent(string email, int retCode, string msg)
        {
            _ = this.Invoke(new Action(() =>
              {
                  ListViewItem item = new ListViewItem();
                  item.Text = DateTime.Now.ToString(DateFormat);
                  item.SubItems.Add("签到");
                  item.SubItems.Add(email);
                  item.SubItems.Add(retCode == 1 ? "成功" : retCode.ToString());
                  item.SubItems.Add(msg);

                  listViewEventLog.Items.Add(item);
              }));
        }

        private void QAZProject_LoginStatusEvent(string email, int retCode, string msg)
        {
            _ = this.Invoke(new Action(() =>
              {
                  ListViewItem item = new ListViewItem();
                  item.Text = DateTime.Now.ToString(DateFormat);
                  item.SubItems.Add("登录");
                  item.SubItems.Add(email);
                  item.SubItems.Add(retCode == 1 ? "成功" : retCode.ToString());
                  item.SubItems.Add(msg);

                  listViewEventLog.Items.Add(item);
              }));
        }

        private async void TimerSign_Tick(object sender, EventArgs e)
        {
            if (config == null || config.Users == null)
                return;
            if ( config.Users.Count == 0 || (config.DelaySignModeSwitch && config.DelaySignModeTime > DateTime.Now.Hour))
                return;

            bool signFlag = false;
            var users = new List<QAZProject>(config.Users.AsEnumerable<QAZProject>());
            foreach (var user in users)
            {
                if (!user.LoginStatus)
                    _ = await user.Login().ConfigureAwait(true);
                if (!signFlag && user.LastSignTime.Date != DateTime.Now.Date)
                {
                    _ = await user.Sign().ConfigureAwait(true);
                    signFlag = true;
                }

            }

            SaveConfig();
            RefreshUserView();
        }

        private void RefreshUserView()
        {
            _ = this.BeginInvoke(new Action(() =>
              {
                  textBoxCheckInterval.Text = config.CheckInterval.ToString();
                  textBoxDelaySignModeTime.Text = config.DelaySignModeTime.ToString();
                  textBoxProxy.Text = config.Proxy;
                  checkBoxDelaySignMode.Checked = config.DelaySignModeSwitch;

                  listViewUserAccount.Items.Clear();

                  foreach (var user in config.Users)
                  {
                      ListViewItem item = new ListViewItem();
                      item.Text = user.Email;
                      _ = item.SubItems.Add(text: user.LastSignTime.ToString(DateFormat));
                      item.SubItems.Add(String.IsNullOrEmpty(user.UnusedTraffic) ? "未更新" : user.UnusedTraffic);
                      item.SubItems.Add(String.IsNullOrEmpty(user.AllTraffic) ? "未更新" : user.AllTraffic);
                      item.SubItems.Add(user.LoginStatus ? "登录" : "离线");

                      listViewUserAccount.Items.Add(item);
                  }
              }));
        }

        private void AutoSignQAZMainForm_Load(object sender, EventArgs e)
        {
            Init();
            TimerSign_Tick(null, null);
        }

        private void BtnRefreshUser_Click(object sender, EventArgs e)
        {
            RefreshUserView();
        }

        private void MenuItemDelete_Click(object sender, EventArgs e)
        {
            if (listViewUserAccount.SelectedItems.Count < 1)
                return;
            for (int i = 0; i < listViewUserAccount.SelectedItems.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < config.Users.Count; j++)
                {
                    if (listViewUserAccount.SelectedItems[i].Text == config.Users[j].Email)
                    {
                        config.Users.RemoveAt(j);
                        flag = true;
                        break;
                    }
                }
                if (flag) continue;
            }

            SaveConfig();
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }
    }
}
