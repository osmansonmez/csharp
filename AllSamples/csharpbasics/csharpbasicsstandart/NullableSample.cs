using System;
using System.Collections.Generic;
using System.Text;

namespace csharpbasicsstandart
{
    public class NullableSample
    {
        public DateTime? Tarih { get; set; }

        public string Mesaj { get; set; }

        public NullableSample()
        {
        }

        public void ShowMessage(DateTime? trh = null)
        {
            DateTime zaman = trh!=null ? trh.Value : DateTime.Now;
            Console.WriteLine($"{zaman.ToString("dd.MM.yyyy HH:mm:ss")} - {Mesaj}");
        }
    }
}
