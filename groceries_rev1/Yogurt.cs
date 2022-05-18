using System;
using System.Collections.Generic;
using System.Text;

namespace groceries_rev1
{
    class Yogurt : Dairy
    {
        private enum E_Type
        {
            Strawberry = 1,
            Blueberry = 2,
            Chocolate = 3
        };

        private static string[] arrstTypes = { "Strawberry", "Blueberry", "Chocolate"};

        public Yogurt() : base(arrstTypes) { }

        public Yogurt(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adFat) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, adFat, arrstTypes)
        { }

        public Yogurt(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, arrstTypes)
        { }
    }
}
