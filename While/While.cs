using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class While
    {
        static void Main(string[] args)
        {
            /*            int i = 0;
                        while (i < 6) { 
                            Console.WriteLine("i의 값:" + i);
                            i++;
                        }
            */
            /*            int i = 0;
                        do
                        {
                            Console.WriteLine("i의 값:" + i);
                            i++;
                        }
                        while (i < 0);

                        i = 0;
                        do
                        {
                            Console.WriteLine("i2의 값은?" + i);
                            i++;

                        } while (i < 1);
                        i = 0;
                        do
                        {
                            Console.WriteLine("i3의 값은?" + i);
                            i++;
                        } while (i < 5);*/

            /*            for (int i = 0; i < 6; i++)
                        {
                            Console.WriteLine("i의 값은?" + i);
                            //i++이 적용된 후에 다시 조건을 체크 하기 때문에 6이 안찍혔다.
            */
            /*            string[] strs = { "바나나", "사과", "파인애플", "망고" };

                        foreach (string i in strs)
                        {
                            Console.WriteLine("i의 값은?:" + i);
                        }*/

            //응용
            string[] strs = { "바나나", "사과", "파인애플", "망고" };

            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(i + "번째 배열의 요소" + strs[i]);
            }

            //중첩 for 문
            for (int i = 0; i < 3; i++)
            { 
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(i + "와" + j + "의 값");
                }
            }

            int[][] numbers = new int[3][];
            numbers[0] = new int[4] { 1, 2, 3, 4 };
            numbers[1] = new int[3] { 5, 6, 7 };
            numbers[2] = new int[2] { 8, 9 };

            for(int i = 0; i< numbers.Length; i++) 
            {
                for (int j = 0; j < numbers[i].Length; j++) 
                {
                    Console.WriteLine(i + "," + j + "번째 요소:" + numbers[i][j]);  
                }
            }
        }
    }
}
