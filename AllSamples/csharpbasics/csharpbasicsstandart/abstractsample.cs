using System;
using System.Collections.Generic;
using System.Text;

namespace csharpbasics
{
    public abstract class abstractclass
    {
        public abstract void method1();
    }

    public class abstractsample: abstractclass
    {
     public abstractsample()
        {
          
        }

        public override void method1()
        {
            throw new NotImplementedException();
        }
    }
}
