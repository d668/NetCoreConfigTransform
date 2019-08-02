using System;
using System.Configuration;

namespace NetCoreConfigTransform
{
    class Program
    {
        static void Main(string[] args)
        {
            var value1 = ConfigurationManager.AppSettings["value1"];
            Console.WriteLine($"Hello World! value1 is now {value1} ");
        }


    }
}
