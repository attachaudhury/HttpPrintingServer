using System;
using System.Drawing;
using System.Printing;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Drawing.Printing;
using System.Windows.Media;
using Microsoft.Owin;
using Owin;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Diagnostics;
using System.Web.Http;
using System.Web.Http.Routing;

namespace HttpPrintingServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();
            configuration.MapHttpAttributeRoutes();  
            app.UseWebApi(configuration);
            app.Run(async owincontext => {
                owincontext.Response.ContentType = "text/plain";
                await owincontext.Response.WriteAsync("Api is availble at:  /print/receipt"); 
            });
        }
    }
}
