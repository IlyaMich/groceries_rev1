using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace groceries_rev1
{
    [Serializable]
    public /*abstract*/ class Product
    {
        /// <summary>
        /// Implement:
        /// Image property
        /// String Type property
        /// Total property
        /// </summary>


        protected int nCount;
        protected double dPrice;
        protected DateTime DT_ProductionDate;
        protected DateTime DT_ExpiryDate;
        private string stImagePath;
        string TEMP_IMG = "IMAGE";

        Image imImg;
        string stType;
        double dTotal;
        

        // Constructors
        public Product()
        {
            this.nCount = 0;
            this.dPrice = 0.0;
            this.DT_ProductionDate = DateTime.Today;
            this.DT_ExpiryDate = DateTime.Today.AddDays(15.0);
            this.imImg = null;
            this.stType = "";
            this.dTotal = 0.0;
        }


        public Product(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate)
        {
            this.nCount = anCount;
            this.dPrice = adPrice;
            this.DT_ProductionDate = aDT_ProductionDate;
            this.DT_ExpiryDate = aDT_ExpiryDate;
        }
        
        public Product(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, Image aImg, string astType)
        {
            this.nCount = anCount;
            this.dPrice = adPrice;
            this.DT_ProductionDate = aDT_ProductionDate;
            this.DT_ExpiryDate = aDT_ExpiryDate;
            this.imImg = aImg;
            this.stType = astType;
            this.dTotal = dPrice * nCount;
        }
        
        public Product(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, string astType, Dictionary<string, Image> adictImages)
        {
            this.nCount = anCount;
            this.dPrice = adPrice;
            this.DT_ProductionDate = aDT_ProductionDate;
            this.DT_ExpiryDate = aDT_ExpiryDate;
            //this.imImg = aImg;
            this.stType = astType;
            this.dTotal = dPrice * nCount;
            this.imImg = adictImages[astType];
        }

        public Product(Product source)
        {
            this.nCount = source.nCount;
            this.dPrice = source.dPrice;
            this.DT_ProductionDate = source.DT_ProductionDate;
            this.DT_ExpiryDate = source.DT_ExpiryDate;
            this.stType = source.stType;
            this.dTotal = source.dTotal;
            this.imImg = source.imImg;
        }

        public Product(double adPrice)
        {
            this.nCount = 0;
            this.dPrice = adPrice;
            this.DT_ProductionDate = DateTime.Today;
            this.DT_ExpiryDate = DateTime.Today.AddDays(15.0);
            this.imImg = null;
            this.stType = "";
            this.dTotal = 0.0;
        }

        /*public Product(DateTime aDT_ProductionDate)
        {

        }*/

        // Properties (Getters & setters)
        public int Count
        {
            get { return nCount; }
            set { nCount = value; }
        }
        
        public double Price
        {
            get { return dPrice; }
            set { dPrice = value; }
        }
        
        public DateTime ProductionDate
        {
            get { return DT_ProductionDate; }
            set { DT_ProductionDate = value; }
        }
        
        public DateTime ExpiryDate
        {
            get { return DT_ExpiryDate; }
            set { DT_ExpiryDate = value; }
        }

        /*public string Image
        {
            get { return TEMP_IMG; }
            set { TEMP_IMG = value; }
        }*/
        
        public Image Image
        {
            get { return imImg; }
            set { imImg = value; }
        }

        public string Type
        {
            get { return stType; }
            set { stType = value; }
        }

        public double Total
        {
            get { return dTotal; }
            set { dTotal = value; }
        }
    }
}
