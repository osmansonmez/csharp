using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class2
    {
        public string Prop1 { get; set; }
    }

    public class Class3 : Class2
    {
        public Class3()
        {

        }

        public Class2 GetClass2()
        {
            return new Class2();
        }
    }
}
