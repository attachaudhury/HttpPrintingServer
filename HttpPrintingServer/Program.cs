using Owin;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpPrintingServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Microsoft.Owin.Hosting.WebApp.Start("http://localhost:8010"))
            {
                Console.WriteLine("Open http://localhost:8010?SaleId=321&DiscountedBill=1500&Change=500&Font=Verdana&SaleList=Pepsi@100@10@1000*Lux150g@50@10@500*Nesfruta@10@10@100 to get default printer name and some parameters");
                Console.ReadLine();   
            }
            
        }
    }
}
