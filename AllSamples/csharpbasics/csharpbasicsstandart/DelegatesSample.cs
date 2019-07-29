using System;
using System.Collections.Generic;
using System.Text;

namespace csharpbasicsstandart
{
    public class Kare
    {
        public void MyInfo()
        {
            Console.WriteLine("Ben kareyim");
        }
    }

    public class Dikdörtgen
    {
        public void Info()
        {
            Console.WriteLine("Ben dikdörtgenim");
        }
    }
    public class DelegatesSample
    {

        public delegate void ShowMyInfoDelegate();
        public ShowMyInfoDelegate InfoMethod;
        public void Call()
        {
            if(InfoMethod!=null)
                InfoMethod();
        }

        public static List<string> DelegateMethod()
        {
            return new List<string>() { "sdfsdf", "sdfsdf" };
        }
    }
}
