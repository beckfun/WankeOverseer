using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WankeOverseer.Entities.WKB
{
    public class GasInfo
    {
        public string fastGas { get; set; }
        public string normalGas { get; set; }
        public int isFree { get; set; }
    }

    public class WkbAccountInfo
    {
        public double balance { get; set; }
        public int isBindAddr { get; set; }
        public string addr { get; set; }
        public GasInfo gasInfo { get; set; }
    }

    public class WkbAccountInfoResponse
    {
        public int iRet { get; set; }
        public string sMsg { get; set; }
        public WkbAccountInfo data { get; set; }
    }
}
