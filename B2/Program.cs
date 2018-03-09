using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap Domain Hoac IP: ");
            string hn = Console.ReadLine();
            IPHostEntry iphe = Dns.Resolve(hn);
            Console.WriteLine("Host Name: {0}", iphe.HostName);
            foreach (IPAddress s in iphe.AddressList)
            {
                Console.WriteLine("IP: {0}", s);
            }
        }
    }
}
