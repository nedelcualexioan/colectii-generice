using colectii_generice.colectii;
using System;
using System.Collections.Generic;
using colectii_generice.controllers;

namespace colectii_generice
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();

            controller.afisareMasini();
        }
    }
}
