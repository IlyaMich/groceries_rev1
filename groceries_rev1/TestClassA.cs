using System;
using System.Collections.Generic;
using System.Text;

namespace groceries_rev1
{
    [Serializable]
    class TestClassA : BaseTest
    {
        int x; /*{ get; set; }*/
        int y; /*{ get; set; }*/
        int z; /*{ get; set; }*/

        public TestClassA(int aX, int aY, int aZ) : base(aX, aY, aZ) { }
        /*{
            this.x = aX;
            this.y = aY;
            this.z = aZ;
        }*/
        public TestClassA() : base() { }

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
