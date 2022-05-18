using System;
using System.Collections.Generic;
using System.Text;

namespace groceries_rev1
{
    class Chicken : Meat
    {
        private enum E_Type
        {
            Schnitzel = 1,
            Grilled_Chicken = 2,
            Nuggets = 3
        };

        private static string[] arrstTypes = { "Schnitzel", "Grilled Chicken", "Nuggets" };

        public Chicken() : base(arrstTypes) { }
        public Chicken(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, arrstTypes)
        { }

        public Chicken(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adWeight) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, adWeight, arrstTypes)
        { }
    }
}
