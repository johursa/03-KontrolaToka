using System;

namespace Vsite.CSharp
{
    class UsporedbeRealnihBrojeva
    {
        static void Main(string[] args)
        {
            double tri = 3.0;
            double epsilon = 1e-10;
           
            if (Math.Abs((1.0 - 1.0 / tri) - (2.0 / tri))<=epsilon)
                Console.WriteLine("1 - 1/3 jednako je 2/3");
            else
                Console.WriteLine("1 - 1/3 nije jednako 2/3!");

           
            if (Math.Abs(tri * 0.1 - 0.3)<=epsilon)
                Console.WriteLine("3 * 0.1 je jednako 0.3");
            else
                Console.WriteLine("3 * 0.1 nije jednako 0.3!");
            Console.ReadKey();
        }
    }
}
