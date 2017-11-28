using System.Net;

namespace WankeOverseer.Entities
{
    public class HttpMessage
    {
        public HttpStatusCode statusCode { get; set; }
        public object data { get; set; }
    }
}
