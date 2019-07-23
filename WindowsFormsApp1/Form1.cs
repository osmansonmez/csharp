using Newtonsoft.Json;
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

            Personeller prs = new Personeller(plist);

            var liste = prs.GetListe();
            Console.WriteLine("Datayı İşle");
            foreach (var item in liste)
            {
                Console.WriteLine("Datayı Aldım");
            }
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

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public String PersonId { get; set; }
    }

    public class Personeller : IEnumerable
    {
       Person[] liste;
       public Personeller(Person[] liste)
        {
            this.liste = liste;
        }

        public Person this[int index]
        {
            get
            {
                return liste[index];
            }
        }

      
        public IEnumerator GetEnumerator()
        {
            return new PersonEnumerator(liste);
        }

        public IEnumerable<Person> GetListe()
        {
            foreach (var item in liste)
            {
                Console.WriteLine("Datayı Verdim");
                yield return  item;
            }
        }
    }

    public class PersonEnumerator : IEnumerator
    {
        Person[] liste;
        public PersonEnumerator(Person[] liste)
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

    }

}
