using System;
using System.Collections.Generic;
using System.Text;

namespace groceries_rev1
{
    class Steak : Meat
    {
        private enum E_Type
        {
            Brisket = 1,
            TBone = 2,
            Porterhouse = 3
        };

        private static string[] arrstTypes = { "Brisket", "T-Bone", "Porterhouse" };

        public Steak() : base(arrstTypes) { }
        public Steak(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, arrstTypes)
        { }

        public Steak(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adWeight) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, adWeight, arrstTypes)
        { }
    }
}
