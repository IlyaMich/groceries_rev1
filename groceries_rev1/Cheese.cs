using System;
using System.Collections.Generic;
using System.Text;

namespace groceries_rev1
{
    class Cheese : Dairy
    {
        private enum E_Type
        {
           Chedder = 1,
           Gauda = 2,
           Roquefort = 3
        };

        private static string[] arrstTypes = { "Chedder", "Gauda", "Roquefort" };

        public Cheese() : base(arrstTypes) { }
        public Cheese(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, arrstTypes)
        { }

        public Cheese(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adFat) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, adFat, arrstTypes)
        { }

    }
}
