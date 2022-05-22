using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

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

        private const double FISH_PRICE = 200;

        private static string[] arrstTypes = { "Salmon", "Tuna", "Bass" };

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

        public Fish(Fish source) : base(source) { }

        public Fish() : base(dictImages, arrstTypes, FISH_PRICE) { }

        //public Fish() : base(arrstTypes) { }
        public Fish(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, arrstTypes)
        { }

        public Fish(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adWeight) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, adWeight, arrstTypes)
        { }

        public Fish(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, Image aImg, string astType) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, arrstTypes, aImg, astType)
        { }

        public Fish(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adWeight, Image aImg, string astType) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, adWeight, arrstTypes, aImg, astType)
        { }
    }
}
