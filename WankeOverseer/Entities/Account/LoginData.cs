using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WankeOverseer.Entities.Account
{
    public class LoginData
    {
        public string deviceid { get; set; }
        public string imeiid { get; set; }
        public string phone { get; set; }
        public string pwd { get; set; }
        public string account_type { get; set; }
    }
}
