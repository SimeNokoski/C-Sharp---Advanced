
using Homework_5;

Db db = new Db();
while (true)
{
    Console.WriteLine("Enter Dog Name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Enter Dog Age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Dog Color: ");
    string color = Console.ReadLine();

    Dog dog = new Dog(name, age, color);
    db.Insert(dog);
    List<Dog> allDog = db.GetAll();

    Console.WriteLine("Enter 1 to add a new dog or 2 to exit");
    int option = Convert.ToInt32(Console.ReadLine());

    if (option == 1)
    {
        continue;
    }
    if(option == 2)
    {
        Console.WriteLine("All dogs: ");
        foreach (Dog dog1 in allDog)
        {
            Console.WriteLine($"Name: {dog1.Name}, Age: {dog1.Age}, Color: {dog1.Color}");
        }
        break;
    }
}



