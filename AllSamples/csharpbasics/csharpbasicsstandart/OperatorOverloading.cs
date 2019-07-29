using System;
using System.Collections.Generic;
using System.Text;

namespace csharpbasics
{
    public class A
    {
        enum Day { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };
        enum DayByte : byte { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };

        public int[,,] dizi = new int[2, 2, 3]
        {{{0,1,3},{3,7,7} }, {{0,1,3},{3,7,7} }};

        int[] dizi2;

        int[][] jarray = new int[3][]
        {
                new int[2]{1,2},
                new int[3]{1,2,3},
                new int[3]{1,2,4}
        };


        public int this[int x, int y, int z]
        {
            get
            {
                return dizi[x, y, z];
            }
        }

        public int Value1 { get; set; }

        public int Value2 { get; set; }

        public A(int val1, int val2)
        {
            this.Value1 = val1;
            this.Value2 = val2;
        }

        public static A operator +(A a1, A a2)
        {
            return new A(a1.Value1 + a2.Value1, a1.Value2 + a2.Value2);
        }

        public static A operator -(A a1, A a2)
        {
            return new A(a1.Value1 - a2.Value1, a1.Value2 - a2.Value2);
        }

        public static A operator ++(A a1)
        {
            a1.Value1++;
            a1.Value2++;
            return a1;
        }

        public static A operator -(A a1)
        {
            a1.Value1 = a1.Value1 * -1;
            a1.Value2 = a1.Value2 * -1;
            return a1;
        }

    }
}
