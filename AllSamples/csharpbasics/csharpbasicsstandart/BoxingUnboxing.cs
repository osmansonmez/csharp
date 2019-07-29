using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static csharpbasics.BoxingUnboxing;

namespace csharpbasics
{
    public class ThreadSample
    {
        public  void ControlInstance()
        {
            var instance = SI.Instance;
        }
    }
    public class BoxingUnboxing
    {
      
        public static void BoxandUnboxSample()
        {
            Thread th1 = new Thread(new ThreadStart((new ThreadSample()).ControlInstance));
            Thread th2 = new Thread(new ThreadStart((new ThreadSample()).ControlInstance));
            Thread th3 = new Thread(new ThreadStart((new ThreadSample()).ControlInstance));
            Thread th4 = new Thread(new ThreadStart((new ThreadSample()).ControlInstance));
            Thread th5 = new Thread(new ThreadStart((new ThreadSample()).ControlInstance));
            th1.Start();
            th2.Start();
            th3.Start();
            th4.Start();
            th5.Start();

            th1.Join();
            th2.Join();
            th3.Join();

            th4.Join();

            th5.Join();

            //int i = 5;
            //object o = i;
            //o = (int)o + 2;
            //i++;
            //Console.WriteLine("i - Value =" + i);
            //Console.WriteLine("o - Value =" + o);
            //mystruct ms = new mystruct();
            //ms.Deneme = "erertert";
            //ms.Deneme1 = 5;
            //ms.Deneme2 = 5;
            //Artir(ref ms);

            //float f1 = 23.343478782259F;
            //double d1 = 23.3434787822598769;
            //decimal d2 = 23.343478782259876956756756756756756433989889M;

            //Console.WriteLine($"f1:{f1}");
            //Console.WriteLine($"d1:{d1}");
            //Console.WriteLine($"d2:{d2}");

            //A a = new A();
            //B b = new B();


        }

        public static void Artir(ref mystruct mst)
        {
            mst.Deneme1 = 25;
        }
        public struct mystruct
        {
            public string Deneme { get; set; }
            public int Deneme1 { get; set; }
            public decimal Deneme2 { get; set; }
        }

        public class A
        {

            protected string myworld = "";
        }

        public class B:A
        {
            public B()
            {
                myworld = "wfewrer";
            }
        }

        public class SI
        {
            static volatile SI _instance;
            private static Object kanalKontrol = new Object();
            public static SI Instance
            {
                get
                {
                    if(_instance == null)
                    {
                        lock (kanalKontrol)
                        {
                            if (_instance == null)
                            {
                                _instance = new SI();
                                Console.WriteLine("İnstance yaratıldı");
                            }
                            else
                            {
                                Console.WriteLine("İnstance kullanıldı");
                            }
                        }
                    }else
                    {
                        Console.WriteLine("İnstance kullanıldı");
                    }

                    return _instance;
                }
            }
        }
    }
}
