using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;
using Microsoft.CSharp;

namespace csharpbasicsstandart
{
    public class DynamicSample
    {

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public int Yas { get; set; }
        public dynamic GetData()
        {
            dynamic d = new ExpandoObject();
            d.ad = Ad;
            d.soyad = Soyad;
            return d;
        }

        public dynamic GetData(string data)
        {
            dynamic result =  Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(data);
            return result;  
        }
    }


}
