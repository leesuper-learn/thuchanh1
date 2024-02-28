using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemtime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            Console.WriteLine("Datetime Now is :" + localDate);
            Console.ReadKey();
        }
    }
}
