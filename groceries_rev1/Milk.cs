using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

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

        private const double MILK_PRICE = 5.90;

        private static string[] arrstTypes = { "Soy", "Dairy", "Almond" };

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

        public Milk(Milk source) : base(source) { }

        //public Yogurt() : base(arrstTypes) { }
        public Milk() : base(dictImages, arrstTypes, MILK_PRICE) { }

        // Constructors
        //public Milk() : base(arrstTypes) { }
        public Milk(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate) :
            base(anCount, MILK_PRICE, aDT_ProductionDate, aDT_ExpiryDate, arrstTypes)
        { }

        public Milk(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adFat) :
            base(anCount, MILK_PRICE, aDT_ProductionDate, aDT_ExpiryDate, adFat, arrstTypes)
        { }

        public Milk(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, Image aImg, string astType) :
            base(anCount, MILK_PRICE, aDT_ProductionDate, aDT_ExpiryDate, arrstTypes, aImg, astType)
        { }

        public Milk(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adFat, Image aImg, string astType) :
            base(anCount, MILK_PRICE, aDT_ProductionDate, aDT_ExpiryDate, adFat, arrstTypes, aImg, astType)
        { }



    }
}
