using System; //System 네임 스페이스 사용
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 //네임 스페이스 선언
{
    class Program //클래스 선언
    {
        static void Main(string[] args) //Main
        {
            /*    bool logic = true;
                bool logic2 = true;
                int num = 0;
                long bigNum = 9999999999999999L;
                short shortNum = 200;
                byte byteNum = 40;
                char chr = 'a';
                string str = "abc";
                float floatNum = 35.1F;
                double doubleNum = 35.235D;
                Console.WriteLine(logic); ;
                Console.WriteLine(logic2);
                Console.WriteLine(str);
                Console.WriteLine(floatNum);
                Console.WriteLine(doubleNum);
                Console.WriteLine(chr);
                Console.WriteLine(str);
                Console.WriteLine(byteNum);
                Console.WriteLine(shortNum);
                Console.WriteLine(bigNum);
                Console.WriteLine(num);
            */    /* System.Console.WriteLine("글자찍기");
                 Console.WriteLine("글자찍기");
                 //단축키 (ctrl + Shif + b ) => build
                 //Ctrl + F5 = Start
                 //ctrl + k + D = 자동 정렬
                 //주석 ctrl + K + C
                 // 주석 해제 ctrl + k + U
                 //Visual studio 22 기준*/

            int a = 5;
            int b = 6;
            b = a; //b에 a값을 저장함
            string c = "";
            //형변환을 동해 문자타입에 숫자를 저장하는 방법
            c = a.ToString(); //함수를 통해서 결과를 얻기

            //Console.WriteLine(c);
            //string문자열 타입에 5 -> int num
            int num = Int32.Parse(c);
            //num에 수자타입으로 변경해서 저장함
            Console.WriteLine(num);
        }
    }
}
