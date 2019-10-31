﻿using Newtonsoft.Json;
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
        private List<QAZProject> projects = new List<QAZProject>();

        public AutoSignQAZMainForm()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            InitializeComponent();
        }

        private void Init()
        {
            //注册Log事件
            QAZProject.LoginStatusEvent += QAZProject_LoginStatusEvent;
            QAZProject.SignStatusEvent += QAZProject_SignStatusEvent;

            //加载配置文件
            if (File.Exists("./config.json"))
            {
                projects = JsonConvert.DeserializeObject<List<QAZProject>>(File.ReadAllText("./config.json"));
                RefreshUserView();

            }
        }

        public void SaveConfig()
        {
            File.WriteAllText("./config.json", JsonConvert.SerializeObject(projects));
            //MessageBox.Show("配置保存成功");
        }

        private async void BtnAddUser_ClickAsync(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxEmail.Text) || String.IsNullOrEmpty(textBoxPassword.Text))
            {
                _ = MessageBox.Show(this, "请输入用户名与密码", "输入错误辣~", MessageBoxButtons.OK);
                return;
            }

            foreach (var project in projects)
            {
                if (project.Email == textBoxEmail.Text)
                {
                    project.Password = textBoxPassword.Text;
                    _ = await project.Login();
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
            projects.Add(project1);
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

        private async void TimerSignIn_Tick(object sender, EventArgs e)
        {
            if (projects.Count == 0)
                return;

            bool signInFlag = false;
            var users = new List<QAZProject>(projects.AsEnumerable<QAZProject>());
            foreach (var user in users)
            {
                if (!user.LoginStatus)
                    _ = await user.Login().ConfigureAwait(true);
                if (!signInFlag && user.LastSignTime.Day < DateTime.Now.Day)
                {
                    _ = await user.Sign().ConfigureAwait(true);
                    signInFlag = true;
                }

            }

            SaveConfig();
            RefreshUserView();
        }

        private void RefreshUserView()
        {
            _ = this.BeginInvoke(new Action(() =>
              {
                  listViewUserAccount.Items.Clear();

                  foreach (var user in projects)
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
            TimerSignIn_Tick(null, null);
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
                for (int j = 0; j < projects.Count; j++)
                {
                    if (listViewUserAccount.SelectedItems[i].Text == projects[j].Email)
                    {
                        projects.RemoveAt(j);
                        flag = true;
                        break;
                    }
                }
                if (flag) continue;
            }

            RefreshUserView();
            SaveConfig();
        }
    }
}
