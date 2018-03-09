using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 1
            string hn = Dns.GetHostName();
            Console.Write("Host Name: ", hn);
            IPHostEntry iphe = Dns.Resolve(hn);
            Console.WriteLine(iphe.HostName);
            foreach (IPAddress s in iphe.AddressList)
            {
                Console.WriteLine("IP: {0}", s);
            }
        }
    }
}
