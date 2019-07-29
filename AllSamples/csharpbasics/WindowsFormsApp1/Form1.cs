using csharpbasics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using System.Windows.Forms;
using csharpbasicsstandart;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var sampleobj = Activator.CreateInstance("ReflectionSample",
                 "ReflectionSample.SampleClass").Unwrap();

            var methodreturn = sampleobj.GetType()?.GetMethod("GetProperty1")?.Invoke(sampleobj, null);
            sampleobj.GetType()?.GetProperty("property1")?.SetValue(sampleobj, "deneme");
            methodreturn = sampleobj.GetType()?.GetMethod("GetProperty1")?.Invoke(sampleobj, null);
            var refas = Assembly.Load("ReflectionSample").GetType("ReflectionSample.SampleClass");

            string location = typeof(EnumSample).Assembly.Location;
            var obj = Activator.CreateInstance("csharpbasicsstandart",
                "csharpbasics.AttributeSample");

            var properties = obj.GetType().GetProperties();
            EnumSample enumsamp = new EnumSample();
            enumsamp.OdayaGirebilir(AuthTree.Mudur);
            enumsamp.OdayaGirebilir(AuthTree.Ogrenci);
            AuthTree ogretmenVeli = (AuthTree.Veli | AuthTree.Ogretmen);
            enumsamp.OdayaGirebilir(ogretmenVeli);
            enumsamp.OdayaGirebilir(AuthTree.Ogretmen);
            enumsamp.OdayaGirebilir(AuthTree.MudurYard);
            enumsamp.OdayaGirebilir(AuthTree.Veli | AuthTree.Ogrenci);
            enumsamp.OdayaGirebilir(AuthTree.Mudur | AuthTree.Ogretmen);
            MessageBox.Show(enumsamp.girebilenler.ToString());
            int number = 10;
            int number2 = number++;
            Console.WriteLine((number2));
            Console.WriteLine((number));
            Console.WriteLine((++number));
            Console.WriteLine((number));

            PartialSample1 prt = new PartialSample1();
            csharpbasics.A a1 = new A(5, 6);
            csharpbasics.A a2 = new A(5, 6);
            a1 += a2;
            csharpbasics.A a3 = a1 + a2;
            BoxingUnboxing.BoxandUnboxSample();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            csharpbasicsstandart.Kare kare = new csharpbasicsstandart.Kare();
            csharpbasicsstandart.Dikdörtgen dr = new csharpbasicsstandart.Dikdörtgen();

            csharpbasicsstandart.DelegatesSample dl = new csharpbasicsstandart.DelegatesSample();
            var del = (csharpbasicsstandart.DelegatesSample.ShowMyInfoDelegate)Delegate.CreateDelegate(typeof(csharpbasicsstandart.DelegatesSample.ShowMyInfoDelegate), kare, kare.GetType().GetMethod("MyInfo"));
            dl.InfoMethod += del;
            dl.InfoMethod += dr.Info;
            dl.Call();

            var delegateInfo = csharpbasicsstandart.DelegatesSample.DelegateMethod();
            delegateInfo.Add("deneme");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Urun cikolata = new Urun() { adet = 100, name = "Torku" };
            Urun seker = new Urun() { adet = 12, name = "Madlen" };

            UrunAzaldiEventHandler print = delegate (object senderobj, EventArgs args)
            {
                Console.WriteLine(senderobj?.ToString() + " azaldi");
            };

            cikolata.UrunAzaldi += print;
            seker.UrunAzaldi += print;

            cikolata.adet = 50;
            cikolata.adet = 30;
            cikolata.adet = 4;
            seker.adet = 50;
            seker.adet = 30;
            seker.adet = 4;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AnonymousType tp = new AnonymousType() { Ad = "osman", Soyad = "sönmez", Yas = 21 };
            var datas =  tp.GetData();
            var value1 = datas.GetType().GetProperty("ad").GetValue(datas);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            System.Collections.Hashtable table = new System.Collections.Hashtable();
            table.Add("1", "2");
            table.Add("2", "2");

            DynamicSample tp = new DynamicSample() { Ad = "osman", Soyad = "sönmez", Yas = 21 };
            dynamic datas = tp.GetData();

            Console.WriteLine(datas.ad);
            Console.WriteLine(datas.soyad);

            string data = "{\"ad\":\"Ali veli\",\"soyad\":\"korkmaz\"}";
            dynamic datas2 = tp.GetData(data);

            System.Collections.Hashtable ht = new System.Collections.Hashtable {{"deneme", "345345v345345"}};
            ht.Add("deneme", "345345v345345");

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            NullableSample sample = new NullableSample() { Mesaj = "Geldim",Tarih = DateTime.Now.AddDays(2) };
            sample.ShowMessage();
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ExceptionSample smp = new ExceptionSample();
            smp.Method2();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            InOutRef ior = new InOutRef();
            ior.Method2();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
          Hashtable
            liste2.Where()
            dynamic d = new ExpandoObject();
            ArithmeticsSample arp = new ArithmeticsSample();
            var data = arp.GetListe();
            foreach (var item in data)
            {
                Console.WriteLine("Main Thread :"+ item);
            }
        }
    }
}
