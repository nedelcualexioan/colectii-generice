using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colectii_generice
{
    public class ComparatorPersNume : Comparer<Persoana>
    {
        public override int Compare(Persoana x, Persoana y)
        {
            if (x.FullName.CompareTo(y.FullName) > 0)
                return 1;
            if (x.FullName.CompareTo(y.FullName) < 0)
                return -1;

            return 0;
        }
    }
}
