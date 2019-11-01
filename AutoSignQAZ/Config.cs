using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSignQAZ
{
    class Config
    {
        public List<QAZProject> Users { get; set; }
        public int CheckInterval { get; set; }
        public string Proxy { get; set; }
        public bool DelaySignModeSwitch { get; set; }
        public int DelaySignModeTime { get; set; }
    }
}
