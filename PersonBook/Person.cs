using System;
using System.Collections.Generic;
using System.Text;

namespace PersonBook
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        

        public Person()
        {
            
        }

        public Person(string name, string surname, string id)
        {
            Name = name;
            Surname = surname;
            Id = id;
        }
    }
}
