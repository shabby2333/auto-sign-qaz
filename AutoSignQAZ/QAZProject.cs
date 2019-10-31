using AutoSignQAZ.Util;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AutoSignQAZ
{
    class QAZProject
    {
        public static string QAZ_BASE_URL = "https://qaz.moe";
        private static readonly string LOGIN_URL = QAZ_BASE_URL + "/auth/login";
        private static readonly string SIGN_IN_URL = QAZ_BASE_URL + "/user/checkin";

        [Newtonsoft.Json.JsonIgnore()]
        public readonly HttpUtil httpUtil = new HttpUtil();

        public static event Action<string, int, string> LoginStatusEvent;
        public static event Action<string, int, string> SignStatusEvent;

        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime LastSignTime { get; set; }
        public string AllTraffic { get; set; }
        public string UnusedTraffic { get; set; }
        [Newtonsoft.Json.JsonIgnore()]
        public bool LoginStatus { get; set; }

        public QAZProject(string username, string password)
        {
            this.Email = username;
            this.Password = password;
        }

        public async Task<bool> Login()
        {

            try
            {
                HttpResponseMessage response = await httpUtil.PostFormAsync(LOGIN_URL, new Dictionary<string, string>()
                {
                    { "email", Email },
                    { "passwd", Password },
                    { "code", "" },
                    {"remember_me", "week" }
                });
                if (!(response.StatusCode == HttpStatusCode.OK))
                {
                    return false;
                }

                var body = Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(await response.Content.ReadAsStringAsync());
                var ret = body.Value<int>("ret");
                var msg = body.Value<string>("msg");

                LoginStatusEvent?.Invoke(Email, ret, msg);
                Console.WriteLine(body.ToString());

                if (ret == 1)
                {

                    this.LoginStatus = true;
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return false;
        }

        public async Task<bool> Sign()
        {
            if (!this.LoginStatus)
                return false;

            try
            {
                HttpResponseMessage response = await httpUtil.PostFormAsync(SIGN_IN_URL, new Dictionary<string, string>
                {
                }).ConfigureAwait(false);

                if (!(response.StatusCode == HttpStatusCode.OK))
                {
                    if (response.StatusCode == HttpStatusCode.Redirect)
                        this.LoginStatus = false;
                    return false;
                }


                var body = Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(await response.Content.ReadAsStringAsync());
                Console.WriteLine(body.ToString());
                var ret = body.Value<int>("ret");
                var msg = body.Value<string>("msg");
                SignStatusEvent?.Invoke(Email, ret, msg);
                if (ret == 1)
                {
                    this.AllTraffic = body.Value<string>("traffic");
                    this.UnusedTraffic = body["trafficInfo"].Value<string>("unUsedTraffic");
                    this.LastSignTime = DateTime.Now;
                    return true;
                }
                else
                {
                    if (ret == 0 && msg == "您似乎已经签到过了...")
                    {
                        this.LastSignTime = DateTime.Now;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return false;
        }
    }
}
