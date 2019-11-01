namespace AutoSignQAZ
{
    partial class AutoSignQAZMainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoSignQAZMainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshConfig = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewUserAccount = new System.Windows.Forms.ListView();
            this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastSignTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUnusedTraffic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTraffic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLoginStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuUserAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewEventLog = new System.Windows.Forms.ListView();
            this.columnLogTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLogType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLogEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLogRet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLogMsg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerSignIn = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxProxy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.textBoxDelaySignModeTime = new System.Windows.Forms.TextBox();
            this.checkBoxDelaySignMode = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCheckInterval = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuUserAccount.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddUser);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加账户";
            // 
            // btnRefreshConfig
            // 
            this.btnRefreshConfig.Location = new System.Drawing.Point(237, 45);
            this.btnRefreshConfig.Name = "btnRefreshConfig";
            this.btnRefreshConfig.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshConfig.TabIndex = 5;
            this.btnRefreshConfig.Text = "刷新";
            this.btnRefreshConfig.UseVisualStyleBackColor = true;
            this.btnRefreshConfig.Click += new System.EventHandler(this.BtnRefreshUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(104, 76);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "添加";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_ClickAsync);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(59, 47);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(120, 21);
            this.textBoxPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(59, 20);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(120, 21);
            this.textBoxEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账户名:";
            // 
            // listViewUserAccount
            // 
            this.listViewUserAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewUserAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEmail,
            this.columnLastSignTime,
            this.columnUnusedTraffic,
            this.columnTraffic,
            this.columnLoginStatus});
            this.listViewUserAccount.ContextMenuStrip = this.menuUserAccount;
            this.listViewUserAccount.FullRowSelect = true;
            this.listViewUserAccount.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewUserAccount.HideSelection = false;
            this.listViewUserAccount.LabelWrap = false;
            this.listViewUserAccount.Location = new System.Drawing.Point(12, 124);
            this.listViewUserAccount.MultiSelect = false;
            this.listViewUserAccount.Name = "listViewUserAccount";
            this.listViewUserAccount.Size = new System.Drawing.Size(515, 171);
            this.listViewUserAccount.TabIndex = 1;
            this.listViewUserAccount.TabStop = false;
            this.listViewUserAccount.UseCompatibleStateImageBehavior = false;
            this.listViewUserAccount.View = System.Windows.Forms.View.Details;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "账户名";
            this.columnEmail.Width = 141;
            // 
            // columnLastSignTime
            // 
            this.columnLastSignTime.Text = "上次签到时间";
            this.columnLastSignTime.Width = 194;
            // 
            // columnUnusedTraffic
            // 
            this.columnUnusedTraffic.Text = "未用流量";
            this.columnUnusedTraffic.Width = 65;
            // 
            // columnTraffic
            // 
            this.columnTraffic.Text = "总流量";
            this.columnTraffic.Width = 68;
            // 
            // columnLoginStatus
            // 
            this.columnLoginStatus.Text = "状态";
            this.columnLoginStatus.Width = 46;
            // 
            // menuUserAccount
            // 
            this.menuUserAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDelete});
            this.menuUserAccount.Name = "menuUserAccount";
            this.menuUserAccount.Size = new System.Drawing.Size(101, 26);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.Size = new System.Drawing.Size(100, 22);
            this.menuItemDelete.Text = "删除";
            this.menuItemDelete.Click += new System.EventHandler(this.MenuItemDelete_Click);
            // 
            // listViewEventLog
            // 
            this.listViewEventLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewEventLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnLogTime,
            this.columnLogType,
            this.columnLogEmail,
            this.columnLogRet,
            this.columnLogMsg});
            this.listViewEventLog.HideSelection = false;
            this.listViewEventLog.Location = new System.Drawing.Point(12, 301);
            this.listViewEventLog.Name = "listViewEventLog";
            this.listViewEventLog.Size = new System.Drawing.Size(515, 185);
            this.listViewEventLog.TabIndex = 2;
            this.listViewEventLog.UseCompatibleStateImageBehavior = false;
            this.listViewEventLog.View = System.Windows.Forms.View.Details;
            // 
            // columnLogTime
            // 
            this.columnLogTime.Text = "时间";
            this.columnLogTime.Width = 124;
            // 
            // columnLogType
            // 
            this.columnLogType.Text = "操作";
            // 
            // columnLogEmail
            // 
            this.columnLogEmail.Text = "账户名";
            this.columnLogEmail.Width = 85;
            // 
            // columnLogRet
            // 
            this.columnLogRet.Text = "返回码";
            this.columnLogRet.Width = 52;
            // 
            // columnLogMsg
            // 
            this.columnLogMsg.Text = "信息";
            this.columnLogMsg.Width = 200;
            // 
            // timerSignIn
            // 
            this.timerSignIn.Enabled = true;
            this.timerSignIn.Interval = 180000;
            this.timerSignIn.Tick += new System.EventHandler(this.TimerSignIn_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefreshConfig);
            this.groupBox2.Controls.Add(this.textBoxProxy);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnSaveConfig);
            this.groupBox2.Controls.Add(this.textBoxDelaySignModeTime);
            this.groupBox2.Controls.Add(this.checkBoxDelaySignMode);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxCheckInterval);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(209, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 106);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置";
            // 
            // textBoxProxy
            // 
            this.textBoxProxy.Location = new System.Drawing.Point(53, 20);
            this.textBoxProxy.Name = "textBoxProxy";
            this.textBoxProxy.Size = new System.Drawing.Size(259, 21);
            this.textBoxProxy.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "代理: ";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(237, 74);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.btnSaveConfig.TabIndex = 5;
            this.btnSaveConfig.Text = "保存";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // textBoxDelaySignModeTime
            // 
            this.textBoxDelaySignModeTime.Location = new System.Drawing.Point(131, 76);
            this.textBoxDelaySignModeTime.Name = "textBoxDelaySignModeTime";
            this.textBoxDelaySignModeTime.Size = new System.Drawing.Size(100, 21);
            this.textBoxDelaySignModeTime.TabIndex = 4;
            this.textBoxDelaySignModeTime.Text = "8";
            // 
            // checkBoxDelaySignMode
            // 
            this.checkBoxDelaySignMode.AutoSize = true;
            this.checkBoxDelaySignMode.Checked = true;
            this.checkBoxDelaySignMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDelaySignMode.Location = new System.Drawing.Point(8, 78);
            this.checkBoxDelaySignMode.Name = "checkBoxDelaySignMode";
            this.checkBoxDelaySignMode.Size = new System.Drawing.Size(114, 16);
            this.checkBoxDelaySignMode.TabIndex = 3;
            this.checkBoxDelaySignMode.Text = "  几点前不签到:";
            this.checkBoxDelaySignMode.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 2;
            // 
            // textBoxCheckInterval
            // 
            this.textBoxCheckInterval.Location = new System.Drawing.Point(131, 47);
            this.textBoxCheckInterval.Name = "textBoxCheckInterval";
            this.textBoxCheckInterval.Size = new System.Drawing.Size(100, 21);
            this.textBoxCheckInterval.TabIndex = 1;
            this.textBoxCheckInterval.Text = "30";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "签到间隔时间(min): ";
            // 
            // AutoSignQAZMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listViewEventLog);
            this.Controls.Add(this.listViewUserAccount);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoSignQAZMainForm";
            this.Text = "潮汐自动签到";
            this.Load += new System.EventHandler(this.AutoSignQAZMainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuUserAccount.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ListView listViewUserAccount;
        private System.Windows.Forms.ColumnHeader columnEmail;
        private System.Windows.Forms.ColumnHeader columnLastSignTime;
        private System.Windows.Forms.ColumnHeader columnUnusedTraffic;
        private System.Windows.Forms.ColumnHeader columnTraffic;
        private System.Windows.Forms.ListView listViewEventLog;
        private System.Windows.Forms.ColumnHeader columnLogType;
        private System.Windows.Forms.ColumnHeader columnLogEmail;
        private System.Windows.Forms.ColumnHeader columnLogRet;
        private System.Windows.Forms.ColumnHeader columnLogMsg;
        private System.Windows.Forms.ColumnHeader columnLoginStatus;
        private System.Windows.Forms.ColumnHeader columnLogTime;
        private System.Windows.Forms.Timer timerSignIn;
        private System.Windows.Forms.Button btnRefreshConfig;
        private System.Windows.Forms.ContextMenuStrip menuUserAccount;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxDelaySignModeTime;
        private System.Windows.Forms.CheckBox checkBoxDelaySignMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCheckInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProxy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveConfig;
    }
}

