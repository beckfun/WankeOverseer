using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WankeOverseer.Entities.Account.Activate
{
    public class UserInfo
    {
        public int activate_days { get; set; }
        public double yes_wkb { get; set; }
        public int type { get; set; }
    }

    public class UserInfoResponse
    {
        public int iRet { get; set; }
        public string sMsg { get; set; }
        public UserInfo data { get; set; }
    }
}
