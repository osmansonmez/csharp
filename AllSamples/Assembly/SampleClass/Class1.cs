using System;

namespace SampleClass
{
    public class SampleClass1
    {
        public string SampleMethod(string s1)
        {
            return (s1 + variableID++);
        }

        public static int variableID { get; set; }
    }
}
