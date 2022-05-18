using System;
using System.Collections.Generic;
using System.Text;

namespace groceries_rev1
{
    public abstract class Product
    {
        protected int nCount;
        protected double dPrice;
        protected DateTime DT_ProductionDate;
        protected DateTime DT_ExpiryDate;
        

        // Constructors
        public Product()
        {
            this.nCount = 0;
            this.dPrice = 0.0;
            this.DT_ProductionDate = DateTime.Today;
            this.DT_ExpiryDate = DateTime.Today.AddDays(15.0);
        }

        public Product(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate)
        {
            this.nCount = anCount;
            this.dPrice = adPrice;
            this.DT_ProductionDate = aDT_ProductionDate;
            this.DT_ExpiryDate = aDT_ExpiryDate;
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
    }
}
