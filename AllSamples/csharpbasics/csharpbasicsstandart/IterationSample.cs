using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace csharpbasicsstandart
{
   public class IterationSample
    {
        public void iterate()
        {
            Person p1 = new Person()
            {
                Name = "Osman",
                Sicil = "234234",
                Surname = "sdfsdf"
            };
            Person p2 = new Person()
            {
                Name = "Osman",
                Sicil = "234234",
                Surname = "sdfsdf"
            };
            Person p3 = new Person()
            {
                Name = "Osman",
                Sicil = "234234",
                Surname = "sdfsdf"
            };

            Person[] plist = new Person[]
            {
                p1,
                p2,
                p3
            };

            Personel personel = new Personel(plist);
            var enumarator = personel.GetEnumerator();

            foreach (var item in personel)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Sicil { get; set; }
    }

    public class Personel :IEnumerable
    {
        Person[] list;

        public Personel(Person[] items)
        {
            list = new Person[items.Length];
            int index = 0;
            foreach (var item in items)
            {
                list[index] = item;
                index++;
            }
        }

        public Person this[int index]
        {
            get
            {
                return list[index];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new PersonIterator(list);
        }
    }

    public class PersonIterator : IEnumerator
    {
        Person[] items;
        int position = 0;
        public PersonIterator(Person[] items)
        {
            this.items = items;
        }

        public object Current
        {
            get
            {
                return items[position];
            }
        }

        public bool MoveNext()
        {
           if(position< items.Length-1)
            {
                position++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            position = 0;
        }
    }
}
