using System;
using System.Collections.Generic;
using System.Text;

namespace csharpbasics
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
   public class LengthControlAttribute : Attribute
    {
        int _minlength;
        public LengthControlAttribute(int minLength)
        {
            this._minlength = minLength;
        }
    }

    public class AttributeSample
    {
        [LengthControl(5)]
        public int Alan2;

        [LengthControl(5)]
        public string Alan1 { get; set; }
    }
}
