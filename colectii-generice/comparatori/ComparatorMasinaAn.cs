using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colectii_generice
{
    public class ComparatorMasinaAn : Comparer<Masina>
    {
        public override int Compare(Masina x, Masina y)
        {
            if (x.AnFabricatie.CompareTo(y.AnFabricatie) > 0)
                return 1;

            if (x.AnFabricatie.CompareTo(y.AnFabricatie) < 0)
                return -1;

            return 0;
        }
    }
}
