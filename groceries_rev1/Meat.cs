using System;
using System.Collections.Generic;
using System.Text;

namespace groceries_rev1
{
    public abstract class Meat : Product
    {
        private int dWeight;
        private string[] arrstTypes;
        private string stType;

        public Meat() : base() { dWeight = 0; }
        
        public Meat(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adWeight, string[] aaTypes) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate)
        { dWeight = adWeight; arrstTypes = aaTypes; }
        
        public Meat(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, string[] aaTypes) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate)
        { dWeight = 1000; arrstTypes = aaTypes; }

        public Meat(string[] aaTypes) : base() { dWeight = 0; arrstTypes = aaTypes; }

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

        public string Type
        {
            get { return stType; }
            set { stType = value; }
        }
    }
}
