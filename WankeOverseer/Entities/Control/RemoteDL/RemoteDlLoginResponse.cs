using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WankeOverseer.Entities.Control.RemoteDL
{
    public class RemoteDlLoginResponse
    {
        public int rtn { get; set; }
        public List<string> pathList { get; set; }
        public int clientVersion { get; set; }
    }
}
