using System;
using System.Collections.Generic;
using System.Text;

namespace groceries_rev1
{
    [Serializable]
    class TestClassB : BaseTest
    {
        int x; /*{ get; set; }*/
        int y; /*{ get; set; }*/

        public TestClassB(int aX, int aY) : base(aX, aY) { }
        /*{
            this.x = aX;
            this.y = aY;
        }*/

        public TestClassB() : base() { }

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

        /*public int Z
        {
            get { return z; }
            set { z = value; }
        }*/
    }
}
