
namespace Homework_2.Entities
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }
        public Bike(int id, string type, int yearOfProduction, int batchNumber,string color) : base(id, type, yearOfProduction, batchNumber)
        {
            Color = color;
        }
        public override void PrintVehicle()
        {
            Console.WriteLine($"Bike - YearOfProduction: {YearOfProduction}, Color: {Color}");
        }


    }
}
