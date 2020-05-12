using SoapTest.SoapWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SoapWeb.Lab10 service = new Lab10();

            Console.WriteLine(service.ChangeCurrencies(5));
            Console.Read();

        }
    }
}
