using System;

namespace csharpbasics
{
    class Program
    {
        static void Main(string[] args)
        {
            EnumSample enumsamp = new EnumSample();
            enumsamp.OdayaGirebilir(AuthTree.Mudur);
            enumsamp.OdayaGirebilir(AuthTree.Ogrenci);
            AuthTree ogretmenVeli = (AuthTree.Veli | AuthTree.Ogretmen);
            enumsamp.OdayaGirebilir(ogretmenVeli);
            enumsamp.OdayaGirebilir(AuthTree.Ogretmen);
            enumsamp.OdayaGirebilir(AuthTree.MudurYard);
            enumsamp.OdayaGirebilir(AuthTree.Veli | AuthTree.Ogrenci);
            enumsamp.OdayaGirebilir(AuthTree.Mudur | AuthTree.Ogretmen);

            int number = 10;
            int number2 = number++;
            Console.WriteLine((number2));
            Console.WriteLine((number));
            Console.WriteLine((++number));
            Console.WriteLine((number));

            PartialSample1 prt = new PartialSample1();
            csharpbasics.A a1 = new A(5,6);
            csharpbasics.A a2 = new A(5, 6);
            a1 += a2;
            csharpbasics.A a3 = a1 + a2;
            BoxingUnboxing.BoxandUnboxSample();
        }
    }
}
