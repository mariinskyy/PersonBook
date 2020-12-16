using System;

namespace PersonBook
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonBook personBook = new PersonBook();
            PromptUser();
            void Menu()
            {
                Console.WriteLine("1 - LIST");
                Console.WriteLine("2 - ADD PERSON");
                Console.WriteLine("3 - UPDATE PERSON");
                Console.WriteLine("4 - REMOVE PERSON");
                Console.WriteLine("5 - EXIT");
            }

            void EditPersonBook(string userInput)
            {
                string name;
                string surname;
                string id;
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine(personBook.ListPersonBook());
                        break;
                    case "2":
                        Console.WriteLine("Enter name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter surname: ");
                        surname = Console.ReadLine();
                        Console.WriteLine("Enter id: ");
                        id = Console.ReadLine();
                        personBook.Add(name, surname, id);
                        break;
                    case "3":
                        Console.WriteLine("Name: ");
                        name = Console.ReadLine();
                        personBook.Update(name);
                        break;
                    case "4":
                        Console.WriteLine("Enter a name to remove: ");
                        name = Console.ReadLine();
                        switch (name)
                        {
                            case "5":
                                break;
                            default:
                                personBook.Remove(name);
                                break;
                        }
                        break;
                    case "5":
                        Console.WriteLine("Exit");
                        break;
                }
            }
            
            void PromptUser()
            {
                Menu();
                string userInput = "";
                while (userInput != "5")
                {
                    EditPersonBook(userInput);
                    userInput = Console.ReadLine();
                    
                }
            }
        }
    }
}
