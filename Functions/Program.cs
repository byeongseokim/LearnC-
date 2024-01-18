using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            class2.myfunction();
            class2.myAdd(3);
            int result = class2.myAdd(3,5);
            Console.WriteLine("결과는?" + result);
        }
    }
}
