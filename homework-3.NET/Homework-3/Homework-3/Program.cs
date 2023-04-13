

using Homework_3.Entities;

AmericanCar americanCar = new AmericanCar(1,"Ford","Focus",160,110, "Gasoline");
ItalianCar italianCar = new ItalianCar(2, "Alfa", "Romeo", 170, 140, "Gasoline");
FrenchCar frenchCar = new FrenchCar(3, "Peugeot", "408", 140, 90, "Diesel");
GermanCar germanCar = new GermanCar(4, "Audi", "Q5", 260, 210, "Diesel");

GenericDb<BaseEntity> db = new GenericDb<BaseEntity>();
db.InsertingCar(americanCar);
db.InsertingCar(italianCar);
db.InsertingCar(frenchCar);
db.InsertingCar(germanCar);

db.PrintAllCars();
Console.WriteLine("");

db.ChangeColor(db.GetCarById(1).GetType().Name,ConsoleColor.Green);
db.ChangeColor(db.GetCarById(2).GetType().Name,ConsoleColor.Magenta);
db.ChangeColor(db.GetCarById(3).GetType().Name,ConsoleColor.Cyan);
db.ChangeColor(db.GetCarById(4).GetType().Name,ConsoleColor.Red);




