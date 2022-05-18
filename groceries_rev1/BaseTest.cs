using System;
using System.Collections.Generic;
using System.Text;

namespace groceries_rev1
{
    [Serializable]
    class BaseTest
    {
        string s = "This came from base";
        int x;
        int y;
        int z;

        public BaseTest(int aX, int aY, int aZ)
        {
            this.x = aX;
            this.y = aY;
            this.z = aZ;
        }
        public BaseTest(int aX, int aY)
        {
            this.x = aX;
            this.y = aY;
            this.z = -1;
        }
        public BaseTest()
        {
            this.x = -1;
            this.y = -1;
            this.z = -1;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Z
        {
            get { return z; }
            set { z = value; }
        }
    }
}
