using System;
using System.Collections.Generic;
using System.Text;

namespace groceries_rev1
{
    class Fish : Meat
    {
        private enum E_Type
        {
            Salmon = 1,
            Tuna = 2,
            Bass = 3
        };

        private static string[] arrstTypes = { "Salmon", "Tuna", "Bass" };

        public Fish() : base(arrstTypes) { }
        public Fish(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, arrstTypes)
        { }

        public Fish(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adWeight) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, adWeight, arrstTypes)
        { }
    }
}
