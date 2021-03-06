﻿using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string jsonrequest ="{\"Cinsiyet\" :\"E\"}";

        private void Button1_Click(object sender, EventArgs e)
        {
            dynamic d = JsonConvert.DeserializeObject(jsonrequest);
            Console.WriteLine(d.Cinsiyet);

            dynamic d1 = new ExpandoObject();
            d1.Ad = "sdfsdf";
            d1.Soyad = "dfgdfgdfg";

            d1.Param1 = 4;
            d1.Param2 = new Model1();


            dynamic result = new Model1();
            result.IslemYap();
            Console.WriteLine(result.Ad);
            Console.WriteLine(result.Soyad); 
        }

        private void Button1_Leave(object sender, EventArgs e)
        {
  
        }

        public object DinamikObje()
        {
            return new
            {
                Ad = "sdfsdfs",
                Soyad = "sdfsdf",
            };
        }

   

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Person[] plist = {
                new Person() { Name = "sdfsdf"},
                new Person() { Name = "sdfsdf" },
                new Person() { Name = "sdfsdf" },
                new Person() { Name = "sdfsdf" },
                new Person() { Name = "sdfsdf" }
            };

        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.GetAssemblies();
            MyClass mst = new MyClass();
            mst.SetValue("deneme");
            mst.SetValue(new Person() { Name = "sdfsdfsfd" });
            mst.SetValue(25);

            string deger = mst.GetValue<string>();
            Person prs = mst.GetValue<Person>();
            int intdeger = mst.GetValue<int>();
        }
    }

    internal class Model1
    {
        public Model1()
        {
            
        }

        public void IslemYap()
        {
            Console.WriteLine("İşlem Yapıldı");
        }
    }

    public class BusinessException : Exception
    {
        public BusinessException(string code,string message)
        {

        }

    }

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public String PersonId { get; set; }

    }

    public class Listemiz<T> : IEnumerable<T>
    {
       T[] liste;
       public Listemiz(T[] liste)
        {
            this.liste = liste;
        }

        public T this[int index]
        {
            get
            {
                return liste[index];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ListemizEnumerator<T>(liste);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class ListemizEnumerator<T> : IEnumerator<T>
    {
        T[] liste;
        public ListemizEnumerator(T[] liste)
        {
            this.liste = liste;
        }

        int currIndex = 0;
        public object Current
        {
            get
            {
                return liste[currIndex];
            }
        }

        T IEnumerator<T>.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            if (currIndex < liste.Length)
            {
                if(currIndex < liste.Length-1)
                currIndex++;

                return true;  
            }

            return false;
        }

        public void Reset()
        {
            currIndex = 0;
        }

        public void Dispose()
        {
           
        }
    }

    public class MyClass
    {
        SortedList arlist = new SortedList();
        public void SetValue<T>(T value)
        {
            if (!arlist.Contains(typeof(T).Name))
            {
                arlist.Add(typeof(T).Name, value);
            }
        }

        public T GetValue<T>() 
        {
            return (T)arlist[typeof(T).Name];
        }
    }
}
