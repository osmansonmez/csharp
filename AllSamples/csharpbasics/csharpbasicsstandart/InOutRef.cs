using System;
using System.Collections.Generic;
using System.Text;

namespace csharpbasicsstandart
{
   public class InOutRef
    {
        public void method1(in int param1, out int param2,ref int param3,int param4)
        {
            param2 = param1;
            param3++;
            param4++;
        }

        public void Method2()
        {
            int param1 = 12;
            int param2; ;
            int param3 = 25;
            int param4 = 5 ;

            method1(param1,out param2,ref param3, param4);
        }
    }
}
