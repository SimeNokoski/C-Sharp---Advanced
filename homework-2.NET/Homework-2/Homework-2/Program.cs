
using Homework_2.Entities;

foreach(Vehicle vehicle in DB.Vehicles)
{
    vehicle.PrintVehicle();
}

Car audi = new Car(4,"Suv",2017,5555,80,new List<string> { "Germany","France"});
Car bmw = new Car(0, "Sport", 2019, 3232, 60, new List<string> { "Macedonia", "Srbija" });
Car alfa = new Car(5, "", 2000, 9999, 60, new List<string> { "Italy", "USA" });

Bike bike1 = new Bike(6, "", 2022, 3333, "Red");
Bike bike2 = new Bike(7, "Road", 0, 4544, "Black");
Bike bike3 = new Bike(8, "Sport", 2021, 1111, "Gray");

List<Vehicle> vehicles = new List<Vehicle>() { audi,bmw,alfa,bike1,bike2,bike3 };
Console.WriteLine("");
foreach (Vehicle vehicle in vehicles)
{
    Console.WriteLine($"The result of the validation for the vehicle with ID {vehicle.Id}: {Validator.Validate(vehicle)}");
}
