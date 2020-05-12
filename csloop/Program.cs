using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csloop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5.8(금) 실습
            long start = DateTime.Now.Ticks;
            long count = 0;
            while (start + (10000000) >DateTime.Now.Ticks)
            {
                count++;
            }
            Console.WriteLine(count + "만큼 반복했습니다.");

            String[] array = { "사과", "배", "포도", "딸기", "바나나" };

            foreach(string item in array)
            {
                Console.WriteLine(item);
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }*/

            //5.12(화)실습
            //int[] array = new int[20];
            //int[] array = new int[3] { 1, 2, 3 };
            //오류발생: int[] array = int[]{ 1,2,3};
            int[] array = { 1, 2, 3 };

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
