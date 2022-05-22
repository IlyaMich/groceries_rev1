using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace groceries_rev1
{
    public abstract class Meat : Product
    {
        private int dWeight;
        private string[] arrstTypes;

        Image imImg;
        private string stType;

        private Dictionary<string, Image> dictImages = new Dictionary<string, Image>();

        public Meat(Meat source) : base(source) { this.dWeight = source.dWeight; this.dictImages = source.dictImages; this.arrstTypes = source.arrstTypes; }

        public Meat() : base() { dWeight = 0; }
        
        public Meat(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adWeight, string[] aaTypes) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate)
        { dWeight = adWeight; arrstTypes = aaTypes; }
        
        public Meat(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, string[] aaTypes) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate)
        { dWeight = 1000; arrstTypes = aaTypes; }

        public Meat(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, string[] aaTypes, Image aImg, string astType) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, aImg, astType)
        { dWeight = 1000; arrstTypes = aaTypes; }

        public Meat(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adWeight, string[] aaTypes, Image aImg, string astType) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, aImg, astType)
        { dWeight = adWeight; arrstTypes = aaTypes; }

        public Meat(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adWeight, Dictionary<string, Image> adictImages, string astType) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, astType, adictImages)
        { dWeight = adWeight; dictImages = adictImages; }

        public Meat(string[] aaTypes) : base() { dWeight = 0; arrstTypes = aaTypes; }

        public Meat(Dictionary<string, Image> adictImages, string[] aaTypes, double adPirce) : base(adPirce) { dWeight = 0; dictImages = adictImages; arrstTypes = aaTypes; }

        public int Weight
        {
            get { return dWeight; }
            set { dWeight = value; }
        }

        public string[] Types
        {
            get { return arrstTypes; }
            set { arrstTypes = value; }
        }

        /*public string Type
        {
            get { return stType; }
            set { stType = value; }
        }

        public Image Image
        {
            get { return imImg; }
            set { imImg = value; }
        }*/

        public Dictionary<string, Image> Images
        {
            get { return dictImages; }
            set { dictImages = value; }
        }
    }
}
