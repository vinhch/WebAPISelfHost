using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPISelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = ConfigurationManager.AppSettings["BaseAddress"];

            using (WebApp.Start<Startup>(baseAddress))
            {
                Console.WriteLine(" WebApi Server is running at " + baseAddress);
                Console.WriteLine("Press any key to quit.");
                Console.ReadLine();
            }
        }
    }
}
