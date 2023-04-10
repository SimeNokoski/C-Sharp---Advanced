

namespace Homework_2.Entities
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> Countries { get; set; } = new List<string>();
        public Car(int id, string type, int yearOfProduction, int batchNumber,int fuelTank,List<string> countries) : base(id, type, yearOfProduction, batchNumber)
        {
            FuelTank = fuelTank;
            Countries = countries;
        }
        public override void PrintVehicle()
        {
            Console.WriteLine($"Car - Type: {Type},Production Countries: {string.Join("/",Countries)}");
        }

    }
}
