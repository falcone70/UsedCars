using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassifiedAd
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassifiedAd classifiedAd = new ClassifiedAd();

            classifiedAd.Category = "Used Cars";
            classifiedAd.Words = 8;
            WriteLine(classifiedAd.Price);
        }
    }
}
