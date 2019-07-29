using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cs1 = new Customer()
            {
                Name = "Ali Veli",
                SurName = "Korkmaz",
                Age = 21,
                BirthDate = new DateTime(1998, 1, 1),
                IsStudent = true,
                Nationality = "TC"
            };

            Customer cs2 = new Customer()
            {
                Name = "Mehmet",
                SurName = "Salim",
                Age = 38,
                BirthDate = new DateTime(1981, 1, 1),
                IsStudent = false,
                Nationality = "TC"
            };

            Customer cs3 = new Customer()
            {
                Name = "Mehmet",
                SurName = "Kemal",
                Age = 56,
                BirthDate = new DateTime(1965, 1, 1),
                IsStudent = false,
                Nationality = "TC"
            };

            List<Customer> customers = new List<Customer>();
            customers.Add(cs1);
            customers.Add(cs2);
            customers.Add(cs3);

            IEnumerable<IGrouping<string,Customer>> filteredList = from cust in customers
                                group cust by cust.Name into custGroup
                               select custGroup;


            for (int i = 0; i < filteredList.Count(); i++)
            {
                IGrouping<string, Customer> groupItem= 
                    filteredList.ElementAt(0);

                var cs = groupItem.ElementAt(0);
                cs2.Age = 89;
            }

        }
    }

}
