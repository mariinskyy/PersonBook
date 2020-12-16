using System;
using System.Collections.Generic;
using System.Text;

namespace PersonBook
{
     class PersonBook
     {
        public Person[] persons;
        public PersonBook()
        {
            persons = new Person[3];
        }

        public bool Add(string name, string surname, string id)
        {
            if (!ContainsInfo(name))
            {
                Person AddPerson = new Person(name, surname, id);
                for (int i = 0; i < persons.Length; i++)
                {
                    if (persons[i] == null)
                    {
                        persons[i] = AddPerson;
                        Console.WriteLine("Person Book Updated");
                        return true;
                    }
                }
            }
            return false;
        }

        public bool Update(string changeName)
        {
            Console.Write($"Update {changeName}'s name, surname or id. TYPE - 'Name' for name, 'Surname' for surname: and 'Id' for id: ");
            string infoToUpdate = Console.ReadLine();

            Console.Write($"Enter new {infoToUpdate} here: ");
            string userUpdatedInfo = Console.ReadLine();

            int index = GetInfoIndex(changeName);
            if (infoToUpdate == "name")
            {
                persons[index].Name = userUpdatedInfo;
                Console.WriteLine($"{changeName} updated to {userUpdatedInfo}");
                return true;
            }
            if (infoToUpdate == "surname")
            {
                persons[index].Surname = userUpdatedInfo;
                Console.WriteLine($"{changeName}'s {infoToUpdate} updated to {userUpdatedInfo}");
                return true;
            }
            if (infoToUpdate == "id")
            {
                persons[index].Id = userUpdatedInfo;
                Console.WriteLine($"{changeName}'s {infoToUpdate} updated to {userUpdatedInfo}");
                return true;
            }
            return false;
        }

        public int GetInfoIndex(string name)
        {
            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i] != null && persons[i].Name == name)
                    return i;
            }
            return -1;
        }

        bool ContainsInfo(string name)
        {
            return GetInfoIndex(name) != -1;
        }

        public void Remove(string name)
        {
            var index = GetInfoIndex(name);
            if (index != -1)
            {
                persons[index] = null;
                Console.WriteLine($"{name} Removed");
            }
        }
        
        public string ListPersonBook()
        {
            string list = "";
            foreach (Person person in persons)
            {
                if (person == null)
                {
                    continue;
                }
                list += String.Format("Id: {2}      Name: {0}      Surname: {1}" + Environment.NewLine, person.Name, person.Surname, person.Id);
            }
            return (list != String.Empty) ? list : "Person Book is empty.";
        }
     }
}
