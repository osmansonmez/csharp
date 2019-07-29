using System;
using System.Collections.Generic;
using System.Text;

namespace csharpbasicsstandart
{
    public delegate void UrunAzaldiEventHandler(object sender, EventArgs args);
    public class Urun
    {
        public event UrunAzaldiEventHandler UrunAzaldi;
        public string name { get; set; }

        private int _adet;
        public int adet
        {
            get
            {
                return _adet;
            }
            set
            {
                _adet = value;
                if (_adet < 5 && UrunAzaldi!=null)
                {
                    UrunAzaldi(this, null);
                }
            }
        }
        public override string ToString()
        {
            return name;
        }
    }

}
