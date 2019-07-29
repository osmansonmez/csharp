using System;
using System.Collections.Generic;
using System.Text;

namespace csharpbasicsstandart
{
    class GenericsSample
    {
        public void MakeGeneric<T>(T param) where T:new()
        {
            var d1 = typeof(string);
            Type[] typeArgs = { typeof(string) };
            var p = d1.MakeGenericType(typeArgs);
            ArithmeticsSample sample = new ArithmeticsSample();
           
   
        }

    }

    public class ArithmeticsSample
    {
        List<string> liste = new List<string>()
        {

            "1",
            "2",
            "3",
            "4",
            "5"
        };
        public  IEnumerable<string> GetListe()
        {
            foreach (var item in liste)
            {
                Console.WriteLine("Yield Thread :" + item);
                yield return  item;
            }
        }
    }
}
