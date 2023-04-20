
using Homework_4.Classes;

List<string> task1 = Db.People.OrderByDescending(x => x.Age)
                              .Select(x => x.FirstName)
                              .Where(x => x.StartsWith('R'))
                              .ToList();
Console.WriteLine($"Task1 - Names starting with R: {string.Join(", ",task1)}");


List<string> task2 = Db.Dogs.OrderBy(x => x.Age)
                            .Where(x => x.Color == "Brown" && x.Age > 3)
                            .Select(x => $"{x.Name} {x.Age}")
                            .ToList();
Console.WriteLine($"Task2 - Names of all brown dogs and older than 3 years: {string.Join(", ", task2)}");


List<Person> task3 = Db.People.Where(x => x.Dogs.Count > 2)
                              .OrderByDescending(x => x.FirstName)
                              .ToList();
Console.WriteLine("Task3 - People who have more than 2 dogs: ");
foreach (Person person in task3)
{
    Console.WriteLine($"- {person.FirstName} {person.LastName}");
}


List<string> task4 = Db.People.Single(x => x.FirstName == "Sime")
                              .Dogs.Where(x=>x.Age > 1)
                              .Select(x=>x.Name)
                              .ToList();
Console.WriteLine($"Task4 - All Sime's dogs names older than 1 year:  {string.Join(", ", task4)}");


Dog task5 = Db.People.Single(x => x.FirstName == "Marko").Dogs.First();
Console.WriteLine($"Task5 - First Marko dog: {task5.Name}");


List<string> task6 = Db.People.Where(x => x.FirstName == "Bojan" || x.FirstName == "Rajko" || x.FirstName == "Ritko")
                              .SelectMany(x => x.Dogs)
                              .Where (x => x.Color == "White")
                              .OrderBy(x => x.Name)
                              .Select(x => x.Name)
                              .ToList();
Console.WriteLine($"Task6 - All white dogs from Bojan,Rajko and Ritko: {string.Join(", ", task6)}");

