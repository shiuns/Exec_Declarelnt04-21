using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業_Exec_Declarelnt_第四題計算___21謝孟勳
{
    //根據兩個變數大小，視需要對調兩個變數的值
    internal class Program
    {
        static void Main(string[] args)
        {
            int begin = 100;
            int end = 20;

            if (begin > end)
            {
                int temp = begin;
                begin = end;
                end = temp;
            }

            Console.WriteLine($"{begin} ~ {end}");
        }
    }
}
