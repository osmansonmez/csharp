
using System;
using System.Dynamic;

namespace ConsoleApp6
{
    public  enum  CinsiyetEnum
    {
        /// <summary>
        /// Kadın
        /// </summary>
        K,

        /// <summary>
        /// Erkek
        /// </summary>
        E
    }

    [Flags]
    public enum YetkiseviyesiEnum
    {
        Read = 1,
        Write = 2,
        Modify =4,
        Remove = 8,
        Execute = 16,
        Copy = 32
    }

    public class Person
    {
        public string Name { get; set; }
        public YetkiseviyesiEnum yetkiSeviyesi = YetkiseviyesiEnum.Read;
        public const string constDeger = "sdfsdf";
        public readonly string constreadonly = "sdfsdfsdf";
    }

    public class Dosya
    {
        public bool YetkiKontrol(YetkiseviyesiEnum yetkiSeviyesi, Person prs)
        {
          bool yetkisivar =   prs.yetkiSeviyesi.HasFlag(yetkiSeviyesi);

            if (yetkisivar)
            {
                Console.WriteLine(prs.Name +" Yetkiniz var...");
                return true;
            }
            Console.WriteLine(prs.Name + " Yetkiniz yok!!!!!...");
            return false;
        }
    }

    public class Model1
    {
        public string param1;
        public string param2;
        public string param3;

        public static explicit operator Model2(Model1 model)
        {
            return new Model2
            {
                param1 = model.param1,
                param2 = model.param2
            };
        }

    }

    public class Model2
    {
        public string param1;
        public string param2;
    }

    public class OperatorSamp
    {
        public int param1;
        public int param2;

        public static OperatorSamp operator +(OperatorSamp obj1, OperatorSamp obj2)
        {
            return new OperatorSamp() { param1 = obj1.param1 + obj2.param1 };
        }

        public static OperatorSamp operator -(OperatorSamp obj1)
        {
            obj1.param1 = obj1.param1 * -1;
            return obj1;
        }

        public static implicit operator int(OperatorSamp obj1)
        {
            return obj1.param1;
        }

        public static explicit operator OperatorSamp(int value)
        {
            return new OperatorSamp() { param1 = value };
        }

        public Model2 GetModel2(Model1 model)
        {
            return new Model2
            {
                param1 = model.param1,
                param2 = model.param2
            };
        }
    }
    public class myclass
    {
        public decimal param1;
        public myclass(decimal pr1)
        {
            param1 = pr1;
        }

        public static implicit operator decimal(myclass d)
        {
            return d.param1;
        }
        public static explicit operator myclass(decimal b)
        {
            return new myclass(b);
        }
    }

    public static class IntegerExtensions
    {
        public static string ExtraOzellik(this int deger)
        {
            return deger + "___";
        }

    }

    public static class Model1Extensions
    {
        public static Model2 ToModel2(this Model1 model)
        {
            return new Model2
            {
                param1 = model.param1,
                param2 = model.param2
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string dbdeger1 = "E";
            string dbdeger2 = "K";

            CinsiyetEnum cinsiyet1 = (CinsiyetEnum)Enum.Parse(typeof(CinsiyetEnum),
                dbdeger1);

            CinsiyetEnum cinsiyet2 = (CinsiyetEnum)Enum.Parse(typeof(CinsiyetEnum),
      dbdeger2);

            Person p1 = new Person()
            {
                Name="Personel1",
                yetkiSeviyesi = YetkiseviyesiEnum.Write | YetkiseviyesiEnum.Read

            };

            string s1 = "";
            if(s1==Person.constDeger)
            {

            }

            if(s1== "sdfsdf")
            {

            }

            Person p2 = new Person()
            {
                Name = "Personel2",
                yetkiSeviyesi = YetkiseviyesiEnum.Read | YetkiseviyesiEnum.Copy

            };

            Dosya d1 = new Dosya();
            d1.YetkiKontrol(YetkiseviyesiEnum.Read, p1);
            d1.YetkiKontrol(YetkiseviyesiEnum.Write, p1);
            d1.YetkiKontrol(YetkiseviyesiEnum.Copy, p1);
            d1.YetkiKontrol(YetkiseviyesiEnum.Read, p2);
            d1.YetkiKontrol(YetkiseviyesiEnum.Write, p2);

            foreach (var item in Enum.GetValues(typeof(YetkiseviyesiEnum)))
            {
                Console.WriteLine(item.ToString());
            }


            Model1 m1 = new Model1()
            {
                param1 = "sdfsdf",
                param2 = "sdfsdfs",
                param3 = "erfsdf"
            };

            Model2 model2 = m1.ToModel2();

            Model2 m2 = (Model2)m1;

            OperatorSamp osamp = new OperatorSamp()
            {
                param1 = 10,
                param2 = 21

            };

            string donus = osamp.param1.ExtraOzellik();
            int deger = 25;
            deger.ExtraOzellik();

            osamp = (OperatorSamp)36;
            osamp = -osamp;

            int prm = osamp;

            int i = 5;
            object o = i;
            i = (int)o;

            //myclass cls = (myclass)10;
            //decimal prmcls = (decimal)cls;

            dynamic d = new ExpandoObject();
            d.Param1 = new ExpandoObject();
            d.Param1.Alan1 = 25;
            d.Param1.Alan2 = 35;


            Console.WriteLine(d.Param1.Alan1);
            d.Param1.Alan2 = 85;
            Console.WriteLine(d.Param1.Alan2);

            var liste = HesapListesi(1);

            Urun urun1 = new Urun() { Isim = "Torku Çikolata", Miktar = 20 };
            Urun urun2 = new Urun() { Isim = "Lolipop", Miktar = 15 };
            HaberimOlsun haberimolsun = new HaberimOlsun();
            Mudur mudur = new Mudur();
            urun1.haberveriyorum += haberimolsun.UrunBilgisi;
            urun1.haberveriyorum += mudur.MudureHaberVer;

            urun2.haberveriyorum += haberimolsun.UrunBilgisi;

            urun1.Miktar = 10;
            urun1.Miktar = 8;
            urun1.Miktar = 5;
            urun1.Miktar = 4;

            urun2.Miktar = 10;
            urun2.Miktar = 8;
            urun2.Miktar = 5;
            urun2.Miktar = 4;

        }

        public static object HesapListesi(int kanalkodu)
        {
            if (kanalkodu == 1)
            {
                return new
                {
                    Hesap = "5345345",
                    Sube = "sdfsdfsfd",
                    Bakiye = 5
                };
            }
            else if (kanalkodu == 2)
            {
                if (kanalkodu == 1)
                {
                    return new
                    {
                        Hesap = "5345345",
                        Sube = "sdfsdfsfd",
                        Bakiye = 5,
                        Yatirimhesap = "2342342"
                    };
                }
            }

            return new
            {
                Hesap = "5345345",
                Sube = "sdfsdfsfd"
            };
        }
        public void Method1(object param)
        {

            int[] dizi = new int[5];
            int[] dizi1 = new int[] { 1, 2, 3, 4, 5 };
            object[] objdizi = new object[10];
            dizi[0] = 5;

            int[,] cbdizi = new int[2, 2] { { 2, 1 }, { 4, 6 } };
            int[,,] cb3d = new int[3, 2, 2]
            {
                { { 2, 1 }, { 4, 6 } },
                { { 2, 1 }, { 4, 6 } },
                { { 2, 1 }, { 4, 6 } }
            };

            int[][] jagged = new int[3][]
            {
                new int[3] {1,2,3},
                new int[5] {1,2,3,4,5},
                new int[4] {12,3,4,5}
            };
        }

        public class Aile
        {
            string[] uyeler;

            public Aile()
            {

            }

            public Aile(string[] uye)
            {
                uyeler = new string[] { "Baba", "anne", "cocuk1", "cocuk2" };
            }

            public string this[int index]
            {
                get
                {
                    return uyeler[index];
                }
            }
        }

        public class Kare
        {
            public int kenaruzunluk;

            public Kare(int uzunluk)
            {
                kenaruzunluk = uzunluk;
            }

            public static Kare operator +(Kare k1, Kare k2)
            {
                return new Kare(k1.kenaruzunluk + k2.kenaruzunluk);
            }

            public static Kare operator -(Kare k1, Kare k2)
            {
                return new Kare(k1.kenaruzunluk + k2.kenaruzunluk);
            }

            public int Topla(int param1, int param2)
            {
                return param1 + param2;
            }

            public int Topla(int param1, int param2, int param3 = 0, int param4 = 0)
            {
                return param1 + param2 + param3 + param4;
            }

            public void KareAlan()
            {
                Console.WriteLine("Karenin Alanı: " + kenaruzunluk * kenaruzunluk);

            }
        }

        public class Dikdortgen
        {
            public int genislik { get; set; }

            public int uzunluk { get; set; }

            public void DikdortgenAlan()
            {

                Console.WriteLine("Dikdortgen Alanı: " + genislik * uzunluk);

            }

        }

        public delegate void AlanDelegate();
        public class Nesneler
        {
            public AlanDelegate neslenerinAlanlari;
            public void Goster()
            {
                ///Transaction
                ///
                if (neslenerinAlanlari != null)
                {
                    neslenerinAlanlari();
                }
            }
        }
    }

    public class StokBilgisiEventArgs : EventArgs
    {
        public DateTime BitisZamani { get; set; }

        public int KalanAdet { get; set; }

        public string Isim { get; set; }
    }

    public class Urun
    {
        public event HaberVerEventHandler haberveriyorum;
        public string Isim { get; set; }

        int miktar;
        public int Miktar
        {
            get
            {
                return miktar;
            }
            set
            {
                miktar = value;
                Console.WriteLine($"{Isim} " +
    $"{Miktar} kaldı ");
                if (miktar < 5)
                {
                    if (haberveriyorum != null)
                    {
                        StokBilgisiEventArgs bilgi = new StokBilgisiEventArgs()
                        {
                            BitisZamani = DateTime.Now,
                            KalanAdet = miktar,
                            Isim = Isim
                        };

                        haberveriyorum(this, bilgi);
                    }
                }
            }
        }
    }

    public delegate void HaberVerEventHandler(object senderobj, EventArgs args);
    public class HaberimOlsun
    {
        public void UrunBilgisi(object senderobj, EventArgs args)
        {
            StokBilgisiEventArgs info = args as StokBilgisiEventArgs;
            Console.WriteLine($"Haber Geldi {info.Isim} " +
                $"{info.BitisZamani.ToString()} " +
                $"tarihinde {info.KalanAdet} kaldı ");
        }
    }

    public class Mudur
    {
        public void MudureHaberVer(object senderobj, EventArgs args)
        {
            StokBilgisiEventArgs info = args as StokBilgisiEventArgs;
            Console.WriteLine($"Mudure Geldi {info.Isim} " +
                $"{info.BitisZamani.ToString()} " +
                $"tarihinde {info.KalanAdet} kaldı ");
        }
    }
}
