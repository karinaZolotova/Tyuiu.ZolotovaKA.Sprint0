using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZolotovaKA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.ZolotovaKA.Sprint0.Task6.V0
{
     class Program
     {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5, };
            Console.WriteLine("Сумма элементов массива =" + DataService.AdditionArray(numsArray));
            Console.WriteLine("Разность элементов массива =" + DataService.SubtractionArray(numsArray));
            Console.WriteLine("произведение элементов массива =" + DataService.MultiplicationArray(numsArray));
            Console.ReadKey();
        }
     }
}
