using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace HttpPrintingServer
{
    [RoutePrefix("print")]
    public class PrintController : ApiController
    {
        [HttpPost]
        [Route("receipt")]
        public dynamic receipt(dynamic stringifyobj)
        {
            PrintingUtils p = new PrintingUtils();
            p.print(stringifyobj);
            return stringifyobj;
        }
    }
}
