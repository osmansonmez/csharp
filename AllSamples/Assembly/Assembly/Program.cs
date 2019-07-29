using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AssemblySample
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain ad = AppDomain.CurrentDomain;
            Assembly[] assembly = ad.GetAssemblies();
            Console.WriteLine("Toplam assembly sayısı: " + assembly.Length);
            for (int i = 0; i < assembly.Length; i++)
                Console.WriteLine("Assembly yeri: " + assembly[i].Location);
         

            Assembly as1 = Assembly.Load("SampleClass");
            object obj = as1.CreateInstance("SampleClass.SampleClass1");
            var returnValue =  obj.GetType().GetMethods()[0].Invoke(obj,new object[] { "Method çağrıldı" });

            Assembly nesne = Assembly.GetExecutingAssembly();
            Console.WriteLine("Assemblynin başlangıç metodu: " + nesne.EntryPoint);


            string yol = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll";
            Assembly nesne2= Assembly.LoadFrom(yol);
            Console.WriteLine("Assemblynin başlangıç metodu: " + nesne2.EntryPoint);
            

          
            // Set up the AppDomainSetup
            AppDomainSetup setup = new AppDomainSetup();
            setup.ApplicationBase = AppDomain.CurrentDomain.BaseDirectory;

            // Set up the Evidence
            Evidence baseEvidence = AppDomain.CurrentDomain.Evidence;
            Evidence evidence = new Evidence(baseEvidence);

            // Create the AppDomain      
            AppDomain newDomain = AppDomain.CreateDomain("newDomain", evidence, setup);
            Assembly as3 = newDomain.Load("SampleClass");
            object ob3 = as1.CreateInstance("SampleClass.SampleClass1");
            var returnValue2 = obj.GetType().GetMethods()[0].Invoke(obj, new object[] { "Method çağrıldı" });
            var returnValue4 = obj.GetType().GetMethods()[0].Invoke(obj, new object[] { "Method çağrıldı" });

        
            Console.ReadLine();
        }
    }
}
