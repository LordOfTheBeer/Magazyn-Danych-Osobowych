using System;
using System.Collections.Generic;

namespace UserInformationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            Console.WriteLine("Witaj w aplikacji gromadzącej informacje o użytkownikach!");

            while (true)
            {
                Console.WriteLine("\nWybierz opcję:");
                Console.WriteLine("1. Dodaj nowego użytkownika");
                Console.WriteLine("2. Wyświetl wszystkich użytkowników");
                Console.WriteLine("3. Zakończ program");

                string input = Console.ReadLine();
                int choice;

                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        User newUser = CreateUser();
                        users.Add(newUser);
                        Console.WriteLine("Nowy użytkownik został dodany.");
                        break;
                    case 2:
                        Console.WriteLine("Lista użytkowników:");
                        foreach (User user in users)
                        {
                            Console.WriteLine(user.ToString());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Dziękujemy za korzystanie z aplikacji. Do widzenia!");
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                        break;
                }
            }
        }

        static User CreateUser()
        {
            Console.WriteLine("\nDodawanie nowego użytkownika");

            Console.Write("Podaj imię: ");
            string name = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string surname = Console.ReadLine();

            Console.Write("Podaj wiek: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Nieprawidłowy wiek. Spróbuj ponownie.");
            }

            Console.Write("Podaj miejsce urodzenia: ");
            string place = Console.ReadLine();

            Console.Write("Podaj miejsce zamieszkania: ");
            string house = Console.ReadLine();

            Console.Write("Podaj adres e-mail: ");
            string email = Console.ReadLine();

            User newUser = new User(name, surname, age, place, house, email);
            return newUser;
        }
    }

    class User
    {
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        public string Place { get; private set; }

        public string House { get; private set; }

        public string Email { get; private set; }

        public User(string name,string surname, int age, string place,string house, string email)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Place = place;
            House = house;
            Email = email;
        }

        public override string ToString()
        {
            return $"Imię: {Name}, Nazwisko: {Surname}, Wiek: {Age}, Miejsce urodzenia: {Place}, Miejsce zamieszkania: {House}, E-mail: {Email}";
        }
    }
}