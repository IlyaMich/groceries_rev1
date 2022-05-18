using System;
using System.Collections.Generic;
using System.Text;

namespace groceries_rev1
{
    public abstract class Dairy : Product
    {
        private int dFat;
        private string[] arrstTypes; /*= { "", "", ""};*/
        private string stType;

        public Dairy() : base() { dFat = 0; }
        
        public Dairy(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, int adFat, string[] aaTypes) : 
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate) { dFat = adFat; arrstTypes = aaTypes; }

        public Dairy(int anCount, double adPrice, DateTime aDT_ProductionDate, DateTime aDT_ExpiryDate, string[] aaTypes) :
            base(anCount, adPrice, aDT_ProductionDate, aDT_ExpiryDate)
        { dFat = 3; arrstTypes = aaTypes; }

        public Dairy(string[] aaTypes) : base() { dFat = 0; arrstTypes = aaTypes; }

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

        public string Type
        {
            get { return stType; }
            set { stType = value; }
        }
    }
}
