using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Class2
    {
        public void myfunction()
        {
        Console.WriteLine("함수를 호출하였습니다!");
        }

    public void myAdd(int a)
    {
        Console.WriteLine("매개변수가 하나만 존재하고 a의값은?" + a);
    }
        public int myAdd(int a,int b) 
        {
            int c;
            Console.WriteLine("덧셈 함수를 호출하였습니다!");
            c = a + b;
            return c;
        }
    }
}
