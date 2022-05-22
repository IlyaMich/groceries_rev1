using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

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

        private const double CHEESE_PRICE = 2.9;

        private static string[] arrstTypes = { "Chedder", "Gauda", "Roquefort" };

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

        //public Yogurt() : base(arrstTypes) { }

        public Cheese(Cheese source) : base(source) { }

        public Cheese() : base(dictImages, arrstTypes, CHEESE_PRICE) { }

        //public Cheese() : base(arrstTypes) { }
        public Cheese(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate) :
            base(anCount, CHEESE_PRICE, aDT_ProductionDate, aDT_ExpiryDate, arrstTypes)
        { }

        public Cheese(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adFat) :
            base(anCount, CHEESE_PRICE, aDT_ProductionDate, aDT_ExpiryDate, adFat, arrstTypes)
        { }

        public Cheese(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, Image aImg, string astType) :
            base(anCount, CHEESE_PRICE, aDT_ProductionDate, aDT_ExpiryDate, arrstTypes, aImg, astType)
        { }

        public Cheese(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adFat, Image aImg, string astType) :
            base(anCount, CHEESE_PRICE, aDT_ProductionDate, aDT_ExpiryDate, adFat, arrstTypes, aImg, astType)
        { }

    }
}
