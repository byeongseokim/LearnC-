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
                 

            //int a = 5;
            //int b = 6;
            //b = a; //b에 a값을 저장함
            //string c = "";
            ////형변환을 동해 문자타입에 숫자를 저장하는 방법
            //c = a.ToString(); //함수를 통해서 결과를 얻기

            ////Console.WriteLine(c);
            ////string문자열 타입에 5 -> int num
            //int num = Int32.Parse(c);
            ////num에 수자타입으로 변경해서 저장함
            //Console.WriteLine(num);

            ////단항 연산자
            //int a = 5;
            //a++; //1더해서 증가
            //Console.WriteLine(a);

            /*
            //이항 연산자
            int a = 5;
            int b = 3;
            int c = 0;

            c = a - b;
            c = a + b;
            Console.WriteLine(c);*/

            ////조건 연산자
            //int c = (5 < 3) ? 2 : 0;
            //Console.WriteLine(c);

            ////대입 연산자
            //int num1 = 1;
            //int numm2 = 4;
            //numm2 = num1;

            //Console.WriteLine("numm2는" + numm2);

            /*            //산술 연산자
                        int num1 = 1;
                        int num2 = 2;
                        int num3 = 3;

                        num3 = num1 + num2;
                        Console.WriteLine("결과는num1+num2?" + num3);
                        Console.WriteLine("===========\n===============");
                        Console.WriteLine("num2값은?" + num3);
                        num3 = num2 - 3;
                        Console.WriteLine("결과는 num2-3?" + num3);
                        num3 = num2 * 2;
                        Console.WriteLine("결과는 num2*2?" + num3);
                        num3 = num2 / 2;
                        Console.WriteLine("결과는 num2/3?" + num3);
                        num3 = num2 %3;
                        Console.WriteLine("결과는 num2%3?" + num3);*/

            /*            //증감연산자
                        int num1 = 1;
                        int num2 = 4;
                        int num3 = 0;

                        num1++;
                        Console.WriteLine("결과는 num1?"+num1);

                        num2--;
                        Console.WriteLine("결과는 num2?" + num2);*/

            /*            //복합 대입 연산자
                        int num1 = 1;
                        //num1 = num1+3과 같다. 연산을 줄여서 표현
                        num1 += 3;
                        Console.WriteLine("결과는 num1?" + num1);
                        //num1 = num1-2와 같다. 연산을 ㅈㄹ여서 표현
                        num1 -= 2;
                        Console.WriteLine("결과는 num1?" + num1);*/

            /*//비교연산자
            bool result = false;
            bool result2 = false;
            bool result3 = false;
            bool result4 = false;
            bool result5 = false;
            int a = 5;
            int b = 10;
            string str = "abcd";

            result = (a == b);
            Console.WriteLine("결과는?" + result);
            result2 = (a != b);
            Console.WriteLine("결과는?" + result2);
            result3 = (a > b);
            Console.WriteLine("결과는?" + result3);
            result4 = (a < b);
            Console.WriteLine("결과는?" + result4);
            result5 = (str.Contains("abc")); //abc를 포함하는지
            Console.WriteLine("결과는?" + result5);*/

            /*//조건 연산자
            int a = 5;
            a = (a > 10) ? 1 : 0;
            Console.WriteLine("a의 값은?" + a);

            //숫자 1은 True의 의미로 , 0은 False의 의미로 , -1은 오류상태로 많이 사용.*/

            /*//논리 연산지
            if (true) {
                Console.WriteLine("true일 때만 동작");
            }
            else
            {
                Console.WriteLine("false일 때만 동작"); 
            }

            bool result = false;
            result = !false;
            Console.WriteLine("!결과는?" + result);
            bool result2 = true;
            bool result3 = false;
            Console.WriteLine("&&결과는?" + (result2 && result3));
            result3 = true;
            Console.WriteLine( "&&결과는?" + (result2 && result3));

            result3 = false;
            //result2 = false;
            Console.WriteLine("||결과는?" + (result2 || result3));*/

            /*//비트 연산자
            int a = 1;
            int b = 5;
            int c = 0;
            //&연산
            c = a & b;
            Console.WriteLine("c의 값은?" + c);

            //|연산
            c = a | b;
            Console.WriteLine("c의 값은?" + c);

            //^연산
            c = a ^ b;
            Console.WriteLine("c의 값은?" + c);*/


            //1차원 배열
            int[] a = { 1, 2, 3, 4 };
            string[] vars = { "파인애플", "사과", "바나나" };
            //string ba = "파인애플";
            //string ba2 = "사과";

            //vars는 0부터 시작하는 인덱스를 가지고 있어서 0, 1, 2로 3번째인 바나나가 출력됨
            Console.WriteLine(vars[2]);
            //-1은 바나나 -2는 사과 -3은 파인애플 순으로 나옴
            Console.WriteLine(vars[vars.Length-2]);
            //vars는 "파인애플", "사과", "바나나" 세 개의 요소를 가지고 있으므로 vars.Length는 3이 출력됨
            Console.WriteLine(vars.Length);

            //2차원 배열은 1차원 배열을 여러개를 가질 수 있으며, 3차원 배열은 2차원배열을 여러개 가질 수 있음
            int[,] abc = { { 1, 2, 3, 5 }, { 4, 5, 6, 7 }, { 4, 5, 6, 7 } };
            //int[,] abc = { { 1, 2, 3, 5 }, { 4, 5, 6, 7 }, { 4, 5, 6, 7 } }; 여기서 [0, 3]을 했을때 왜 5가 나오는지 -> 0부터 시작하는 인덱스 / [0, 3]일때 0은  { 1, 2, 3, 5 } , 3은 0 1 2 3 이니 4번째인 5가 출력됨
            Console.WriteLine(abc[0, 3]);
            //마찬가지로 [1,2]로 했을 경우에는 1은 { { 1, 2, 3, 5 }, { 4, 5, 6, 7 }, { 4, 5, 6, 7 } }; 여기서 0 , 1 , 2 순으로 여기서 2번째인 { 4, 5, 6, 7 }이 나오고, 2는 0 1 2 3 순이니 5가 나오므로 6이 출력됨
            Console.WriteLine(abc[1, 2]);

            //가변배열
            int[][] ab = new int[3][];

            //int[,] ab = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 4 } };
            ab[0] = new int[4];
            ab[1] = new int[4];
            ab[2] = new int[3];
            ab[2][2] = 4;

            Console.WriteLine("길이는?"+ab.Length);

            //길이가 3인 이유 = 1차원 배열에 있는 vars.Length처럼 ab가 몇 개있는지 알려주는 것 / ab[0],ab[2],ab[2] 총 3개 있어서 3이 나옴 / 또는 처음부터 3개로 지정 해줬기 때문에 int[][] ab = new int[3][];

        }
    }
}
//단축키 (ctrl + Shif + b ) => build
//Ctrl + F5 = Start
//ctrl + k + D = 자동 정렬
//주석 ctrl + K + C
// 주석 해제 ctrl + k + U
//Visual studio 22 기준*/