using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

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

        private const double CHICKEN_PRICE = 300;

        private static string[] arrstTypes = { "Schnitzel", "Grilled Chicken", "Nuggets" };

        private static string[] arrstPaths =
        {
            @"C:\Users\ilmih\OneDrive\Desktop\Study\CS\OOP\groceries_rev1\groceries_rev1\smallCow.bmp",
            @"C:\Users\ilmih\OneDrive\Desktop\Study\CS\OOP\groceries_rev1\groceries_rev1\smallDog.bmp",
            @"C:\Users\ilmih\OneDrive\Desktop\Study\CS\OOP\groceries_rev1\groceries_rev1\smallSnake.bmp"
        };

        private static Dictionary<string, Image> dictImages = new Dictionary<string, Image>
        {
            {arrstTypes[0], Image.FromFile(arrstPaths[0])},
            {arrstTypes[1], Image.FromFile(arrstPaths[1])},
            {arrstTypes[2], Image.FromFile(arrstPaths[2])}
        };
        public Chicken(Chicken source) : base(source) { }

        public Chicken() : base(dictImages, arrstTypes, CHICKEN_PRICE) { }

        //public Chicken() : base(arrstTypes) { }
        public Chicken(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, arrstTypes)
        { }

        public Chicken(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adWeight) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, adWeight, arrstTypes)
        { }

        public Chicken(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, Image aImg, string astType) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, arrstTypes, aImg, astType)
        { }

        public Chicken(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adWeight, Image aImg, string astType) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, adWeight, arrstTypes, aImg, astType)
        { }
    }
}
