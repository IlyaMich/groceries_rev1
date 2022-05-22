using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace groceries_rev1
{
        public enum E_Type
        {
            Strawberry = 1,
            Blueberry = 2,
            Chocolate = 3
        };

    class Yogurt : Dairy
    {
        public E_Type E_Types;

        private const double YOGURT_PRICE = 4.9;

        private static string[] arrstTypes = { "Strawberry", "Blueberry", "Chocolate"};
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

        public Yogurt(Yogurt source) : base(source) { }

        public Yogurt() : base(dictImages, arrstTypes, YOGURT_PRICE) { }
                
        public Yogurt(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adFat) :
            base(anCount, YOGURT_PRICE, aDT_ProductionDate, aDT_ExpiryDate, adFat, arrstTypes)
        { }

        public Yogurt(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate) :
            base(anCount, YOGURT_PRICE, aDT_ProductionDate, aDT_ExpiryDate, arrstTypes)
        { }

        public Yogurt(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, Image aImg, string astType) :
            base(anCount, YOGURT_PRICE, aDT_ProductionDate, aDT_ExpiryDate, arrstTypes, aImg, astType)
        { }

        public Yogurt(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adFat, Image aImg, string astType) :
            base(anCount, YOGURT_PRICE, aDT_ProductionDate, aDT_ExpiryDate, adFat, arrstTypes, aImg, astType)
        { }
        
        public Yogurt(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adFat, string astType) :
            base(anCount, YOGURT_PRICE, aDT_ProductionDate, aDT_ExpiryDate, adFat, astType, dictImages)
        { }

        public E_Type TypesEnum
        {
            get { return E_Types; }
        }
    }
}
