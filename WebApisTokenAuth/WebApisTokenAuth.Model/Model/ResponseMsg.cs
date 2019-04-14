using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApisTokenAuth.Model
{
    public class ResponseMsg
    {
        public string Response { get; set; }
        public int ResponseCode { get; set; }
        public string Message { get; set; }
    }
}
