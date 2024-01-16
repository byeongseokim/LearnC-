using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    class If
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            //if(true)
            if (b > a)
            {
                //a++로 인해 a값에 + 1추가 된다 그래서 5 + 1 해서 6이 출력 됨
                a++;
                Console.WriteLine("a의 값은?" + a); 
            }

            //if(false)
            if (b < a)
            {
                //a-- 로 5 - 1해서 4가 출력 되어야 하지만 b<a가 거짓이므로 실행 되지 않음
                a--;
                Console.WriteLine("a의 값은?" + a);
            }

            if (b < a)
            {
                // b<a가 거짓이라 실행 X
                b--;
                Console.WriteLine("b의 값은?" + b);
            }
            else
            {
                //b의 값이 2 감소하고, 그 값을 출력합니다.
                b = b - 2;
                Console.WriteLine("b의 값은?" + b);
            }

            Console.WriteLine("===========================================");
            int money = 8000;
            if (money < 5000)
            {
                Console.WriteLine("money가 5000미만일 때 동작");
            }
            else if (money < 7000)
            {
                Console.WriteLine("money가 5000이상 7000미만일 때 동작");
            }
            else if (money < 9000)
            {
                Console.WriteLine("money가 7000이상 9000미만일 때 동작");
            }
            else
            {
                Console.WriteLine("money가 9000이상일 때 동작.");
            }

            int week = 3;
            //switch문을 사용 할 때는 비교하자하는값이 같은 타입으로 이루어졌을 ㄱ경우,
            //switch(exprssion)에서 expression은 각각의 case와 값을 비교를 한다.
            switch (week)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                case 4:
                    Console.WriteLine("목요일");
                    break;
                //defalt는 없어도 상관 없음.
                default:
                    Console.WriteLine("선택 된게 없습니다.");
                    break;
            }
            //break실행으로 여기서 부터 다시 시작
            //if문으로 사용해도 차이가 없음, 다만 조건을 추가해도
            //동일한 용도및 타입으로 사용될 가능성이 높을 경우 
            //switch문으로 자주 사용함.

        }
    }
}

