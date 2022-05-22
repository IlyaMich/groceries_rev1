using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace groceries_rev1
{
    public abstract class Dairy : Product
    {

        /// <summary>
        /// Add Drawing
        /// Add Image and type property
        /// Add new all args constructor
        /// Add Constructor without special member
        /// add get set
        /// </summary>

        private int dFat;
        private string[] arrstTypes; /*= { "", "", ""};*/

        private Image imImg;
        //private string stType;

        private Dictionary<string, Image> dictImages = new Dictionary<string, Image>();

        public Dairy(Dairy source) : base(source) { this.dFat = source.dFat; this.dictImages = source.dictImages; this.arrstTypes = source.arrstTypes; }    

        public Dairy() : base() { dFat = 0; }
        
        public Dairy(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adFat, string[] aaTypes) : 
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate) { dFat = adFat; arrstTypes = aaTypes; }

        public Dairy(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, string[] aaTypes) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate)
        { dFat = 3; arrstTypes = aaTypes; }

        public Dairy(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, string[] aaTypes, Image aImg, string astType) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, aImg, astType)
        { dFat = 3; arrstTypes = aaTypes; }

        public Dairy(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adFat, string[] aaTypes, Image aImg, string astType) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, aImg, astType)
        { dFat = adFat; arrstTypes = aaTypes; }
        
        public Dairy(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adFat, string astType, Dictionary<string, Image> adictImages) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate, astType, adictImages)
        { dFat = adFat; dictImages = adictImages; }


        public Dairy(string[] aaTypes) : base() { dFat = 0; arrstTypes = aaTypes; }
        public Dairy(Dictionary<string, Image> adictImages, string[] aaTypes, double adPrice) : base(adPrice) { dFat = 0; dictImages = adictImages; arrstTypes = aaTypes; }

        public int Fat
        {
            get { return dFat; }
            set { dFat = value; }
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
        }*/

        /*public Image Image
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
