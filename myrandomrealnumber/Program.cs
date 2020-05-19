using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            int a1;
            int a2 = 126;

            for (int i = 1; i <= 6; i++)
            {
                Console.Write("숫자를 입력해주세요 : ");
                a = Console.ReadLine();
                a1 = Convert.ToInt32(a);

                if (a2 > a1)
                {
                    Console.WriteLine(a1 + "보다는 큰 숫자 입니다.");
                }

                else if (a2 < a1)
                {
                    Console.WriteLine(a1 + "보다는 작은 숫자입니다.");
                }

                else if (a2 == a1)
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }

                else if (i == 5 && a2 > a1 || a2 < a1)
                {
                    Console.WriteLine("실패했습니다.");
                }
            }
        }
    }
}
