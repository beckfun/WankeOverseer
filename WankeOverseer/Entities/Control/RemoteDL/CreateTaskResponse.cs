using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WankeOverseer.Entities.Control.RemoteDL
{
    public class CreateTaskResponseTask
    {
        public string name { get; set; }
        public string url { get; set; }
        public int result { get; set; }
        public string taskid { get; set; }
        public string msg { get; set; }
        public int id { get; set; }
    }

    public class CreateTaskResponse
    {
        public List<CreateTaskResponseTask> tasks { get; set; }
        public int rtn { get; set; }
    }
}
