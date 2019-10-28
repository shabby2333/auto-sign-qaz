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
            this.btnRefreshUser = new System.Windows.Forms.Button();
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
            this.listViewEventLog = new System.Windows.Forms.ListView();
            this.columnLogTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLogType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLogEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLogRet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLogMsg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerSignIn = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefreshUser);
            this.groupBox1.Controls.Add(this.btnAddUser);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加账户";
            // 
            // btnRefreshUser
            // 
            this.btnRefreshUser.Location = new System.Drawing.Point(434, 18);
            this.btnRefreshUser.Name = "btnRefreshUser";
            this.btnRefreshUser.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshUser.TabIndex = 5;
            this.btnRefreshUser.Text = "刷新";
            this.btnRefreshUser.UseVisualStyleBackColor = true;
            this.btnRefreshUser.Click += new System.EventHandler(this.BtnRefreshUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(353, 18);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "添加";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_ClickAsync);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(226, 20);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(121, 21);
            this.textBoxPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 23);
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
            this.listViewUserAccount.HideSelection = false;
            this.listViewUserAccount.Location = new System.Drawing.Point(12, 76);
            this.listViewUserAccount.Name = "listViewUserAccount";
            this.listViewUserAccount.Size = new System.Drawing.Size(515, 171);
            this.listViewUserAccount.TabIndex = 1;
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
            this.listViewEventLog.Location = new System.Drawing.Point(6, 253);
            this.listViewEventLog.Name = "listViewEventLog";
            this.listViewEventLog.Size = new System.Drawing.Size(521, 185);
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
            // AutoSignQAZMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.listViewEventLog);
            this.Controls.Add(this.listViewUserAccount);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoSignQAZMainForm";
            this.Text = "潮汐自动签到";
            this.Load += new System.EventHandler(this.AutoSignQAZMainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnRefreshUser;
    }
}

