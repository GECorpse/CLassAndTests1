using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary19;

namespace SvyatovMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = {1,2,3,4,5,6,7,7};
            Console.WriteLine(Geometry2.FirstEx(3,4));
            Console.WriteLine(Geometry2.SecondEx(7, 9));
            Console.WriteLine(Geometry2.ThirdEx(3, 9));
            Console.WriteLine(Geometry2.FourthEx(5, 5));
            Console.WriteLine(Geometry2.FifthEx(7, 7, 9));

            Console.WriteLine(Trigonometry2.FirstTask(17,19));
            Console.WriteLine(Trigonometry2.SecondTask(9,11));
            Console.WriteLine(Trigonometry2.ThirdTask(3,7));
            Console.WriteLine(Trigonometry2.FourthTask(9,13));
            Console.WriteLine(Trigonometry2.FifthTask(12,14));
                                          
            //Console.WriteLine(Algebra.FirstAssign());
            Console.WriteLine(Algebra2.SecondAssign(21,6));
            Console.WriteLine(Algebra2.ThirdAssign(arr));
            Console.WriteLine(Algebra2.FourthAssign(arr));
            Console.WriteLine(Algebra2.FifthAssign(arr));

            Console.ReadKey();
        }
    }
}
