using System;
using System.Collections.Generic;
using System.Text;

namespace groceries_rev1
{
    class Milk : Dairy
    {
        private enum E_Type
        {
            // TO DO \\
            Soy = 1,
            Dairy = 2,
            Almond = 3
        };

        private static string[] arrstTypes = { "Soy", "Dairy", "Almond" };

        // Constructors
        public Milk() : base(arrstTypes) { }
        public Milk(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, arrstTypes)
        { }

        public Milk(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adFat) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, adFat, arrstTypes)
        { }



    }
}
