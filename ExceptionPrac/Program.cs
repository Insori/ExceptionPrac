using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "가", "나" };
            Console.Write("숫자를 입력하세요: ");

            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("입력한 위치의 값은 '" + array[input] + " '입니다.");
            } catch (IndexOutOfRangeException e) {
                Console.WriteLine("인덱스 범위를 벗어났습니다.");
            } catch (FormatException e) {
                Console.WriteLine("숫자를 입력하세요.");
            } catch (Exception e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
