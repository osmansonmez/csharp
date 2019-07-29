using System;

namespace ReflectionSample
{
    public class SampleClass
    {
        string variable1;

        public string property1
        { get; set; }

        public string property2
        { get; set; }

        public void Method1(int var1,string var2)
        {

        }

        public string Method1(string var)
        {
            return var + " aaabbb";
        }

        public string GetVariable1()
        {
            return variable1;
        }

        public string GetProperty1()
        {
            return property1;
        }

        public string GetProperty2()
        {
            return property2;
        }
    }
}
