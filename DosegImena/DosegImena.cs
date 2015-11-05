using System;

namespace Vsite.CSharp
{
    class DosegImena
    {
        static void Main(string[] args)
        {
            DosegImena p = new DosegImena();
            p.IspišiAove();

            Console.ReadKey();
        }

        void IspišiAove()
        {
            string a = "Lokalna varijabla";

            Console.WriteLine(a);

          
            Console.WriteLine(this.a);

            {
                
            }
        }

        string a = "Član klase";
    }
}
