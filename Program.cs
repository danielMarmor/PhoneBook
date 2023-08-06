// See https://aka.ms/new-console-template for more information


using IteratorPhoneBook;

Console.WriteLine("Hello, World!");

Console.WriteLine("Phone Book:\n----------------");



PhoneBook yellowPages = new PhoneBook
{
    PersonList = new Person[10]
    {
    new Person("Avi", "1245-1245") { Address = "Netanya" },
    new Person("Bubble", "1245-1245") { Address = "Jerusalem" },
    new Person("Colman", "955-1245") { Address = "Netanya" },
    new Person("David", "955-5485") { Address = "Jerusalem" },
    new Person("Evgeni", "105-5485") { Address = "Netanya" },
    new Person("Federer", "105-5485") { Address = "Jerusalem" },
    new Person("Grisha", "105-1245") { Address = "Netanya" },
    new Person("Hyundai", "105-1245") { Address = "Jerusalem" },
    new Person("Yuvi", "03-9887") { Age = 54, Name = "pou", Address = "Tel Aviv" },
    new Person { Age = 23, Name = "Opel", Phone = "072-85420", Address = "Haifa" }
    }
};


Console.WriteLine("\nAll the people - default ordering\n----------------");
foreach (Person p in yellowPages)
{
    Console.WriteLine(p);
}

Console.WriteLine("\nAll people in reversed order\n----------------");
foreach (Person p in yellowPages.AllPeopleReversed)
{
    if (p.Name == "Evgeni") break;
    Console.WriteLine(p);
}

Console.WriteLine("\nPeople contains 'e'\n----------------");
foreach (Person p in yellowPages.PeopleContains("e"))
{
    Console.WriteLine(p);
}

Console.WriteLine("\nPeople until name starts with D\n----------------");
foreach (Person p in yellowPages.PeopleUntilD)
{
    Console.WriteLine(p);
}
