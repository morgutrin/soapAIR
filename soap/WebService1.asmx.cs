using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Web;
using System.Web.Services;

namespace soap
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/", Name = "Lab10")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod(Description = "Hello", MessageName = "Hello")]
        public string HelloWorld(string name, string surname)
        {
            return $"Witaj: {name} {surname}";
        }
        [WebMethod(Description = "Add", MessageName = "Add")]
        public double Add(double a, double b)
        {
            return a + b;
        }
        [WebMethod(Description = "Substract", MessageName = "Substract")]
        public double Substract(double a, double b)
        {
            return a - b;
        }
        [WebMethod]
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        [WebMethod]
        public double Divide(double a, double b)
        {
            return a / b;
        }
        [WebMethod]
        public double ChangeCurrency(double a, string currency)
        {
            if (currency.Equals("USD"))
            {
                return a * 4.22;
            }
            if (currency.Equals("EUR"))
            {
                return a * 4.55;
            }
            else
            {
                return 0;
            }
        }
        [WebMethod]
        public string ChangeCurrencies(double a)
        {
            return $"USD: {a * 4.22}, EUR: {a * 4.55}";
        }
    }
}
