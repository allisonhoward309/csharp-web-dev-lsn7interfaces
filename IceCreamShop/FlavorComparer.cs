using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{

    class FlavorComparer : IComparer<Flavor>
    {
        public FlavorComparer()
        {
        }
/*        public int Compare(Flavor x, Flavor y)
        {
            return string.Compare(x.Name, y.Name);
        }*/
        public int Compare(Flavor x, Flavor y)
        {
            int diff = x.Allergens.Count - y.Allergens.Count;
            return diff;

        }

    }
}
