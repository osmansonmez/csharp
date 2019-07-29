using System;
using System.Collections.Generic;
using System.Text;

namespace csharpbasics
{
    public class EnumSample
    {
        public AuthTree girebilenler = 
            AuthTree.Ogretmen 
            | AuthTree.Mudur
            | AuthTree.MudurYard
            | AuthTree.Veli;

        public EnumSample()
        {

        }

        public bool OdayaGirebilir(AuthTree at)
        {
            AuthTree icerilenYetki = at & girebilenler;
            bool yetki =icerilenYetki>0? girebilenler.HasFlag(icerilenYetki):false;
            if (yetki)
            {
                Console.WriteLine(at.ToString() + " odaya girebilir");
            }
            else
            {
                Console.WriteLine(at.ToString() + " odaya giremez");
            }

            return yetki;
        }
    }

    [Flags]
    public enum AuthTree
    {
        Ogrenci = 1,
        Ogretmen = 2,
        MudurYard = 4,
        Mudur = 8,
        Veli = 16
    }
}
