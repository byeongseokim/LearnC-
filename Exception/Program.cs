using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try  //어떤 함수에서 오류가 났는지를 쉽게 파악하려는 목적 (try, catch, finally)
            {
                //오류가 발생할 것으로 예상되는 코드.


                //사용자로부터 입력받기.
                Console.WriteLine("값을 입력해주세요.");
                int i = Int32.Parse(Console.ReadLine());

                int[] numbers = { 1, 2, 3, 4, 5 };
                Console.WriteLine("요청된 값" + numbers[i]);
                //오류생성하기.
                //throw new Exception();
                //throw new Exception("사용자의 에러를 발생시켜보자");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("특정오류만 잡았습니다.Main함수의 IndexOutOf어쩌구저쩌구");
                Console.WriteLine("오류내용은" + e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("오류가 발생되어 코드가 실행됩니다.");
                Console.WriteLine("오류내용은" + e.ToString());
                //오류를 다시 던질 수 도 있음.
                //throw e;
            }
            finally
            {
                Console.WriteLine("오류발생,오류미발생이여도 무조건 실행되는 부분입니다.");
            }
        }
    }
}

