using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask_Form.com
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first side of the triangle");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second side of the triangle");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third side of the triangle");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(new Figure().TriangleType(a, b, c));

            Console.ReadLine();
        }
    }

    public class Figure
    {
        public int TriangleType(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return 4;

            if (a == b && a == c)
                return 3;

            if (a == b && a != c || a == c && a != b || b == c && b != a)
                return 2;

            return 1;
        }
    }
}
