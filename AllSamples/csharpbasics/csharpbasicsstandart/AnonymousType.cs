using System;
using System.Collections.Generic;
using System.Text;

namespace csharpbasicsstandart
{
    public class AnonymousType
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public int Yas { get; set; }
        public object GetData()
        {
            return new
            {
                ad = Ad,
                soyad = Soyad
            };
        }
    }
}
