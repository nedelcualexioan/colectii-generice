using colectii_generice.colectii;
using System;

namespace colectii_generice
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> l1 = new Lista<int>();
            l1.add(1);
            l1.add(2);
            l1.add(3);

            Lista<int> l2 = new Lista<int>();

            l2.add(5);
            l2.add(6);
            l2.add(7);

            l1.swap(ref l2);

            l2.afisare();
            
        }
    }
}
