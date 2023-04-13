

namespace Homework_3.Entities
{
    public class FrenchCar : BaseEntity
    {
        public FrenchCar(int id, string brand, string model, int maxSpeed, int horsePower, string fuelType) : base(id, brand, model, maxSpeed, horsePower, fuelType)
        {
        }

        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Driving French car {Brand} {Model} to {destinationName}");

        }
    }
}
