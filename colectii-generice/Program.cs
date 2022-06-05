using colectii_generice.colectii;
using System;

namespace colectii_generice
{
    class Program
    {
        static void Main(string[] args)
        {
            Masina m = new Masina("BMW", "X5", "Albastru", 2009);
            Masina m2 = new Masina("Tesla", "ModelX", "Alb", 2021);

            Lista<Masina> list = new Lista<Masina>();

            list.addStart(m);
            list.addStart(m2);

            Masina m3 = new Masina("Dacia", "Logan", "Alb", 2005);

            list.add(m3);

            list.set(new Masina("Dacia", "Sandero", "Alb", 2005), 2);

            list.sortCr();

            list.afisare();
        }
    }
}
