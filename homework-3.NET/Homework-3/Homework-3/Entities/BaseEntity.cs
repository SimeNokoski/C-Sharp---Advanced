

namespace Homework_3.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public int HorsePower { get; set; }
        public string FuelType { get; set; }
        public abstract void Drive(string destinationName);
        public BaseEntity(int id, string brand, string model, int maxSpeed, int horsePower, string fuelType)
        {
            Id = id;
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
            HorsePower = horsePower;
            FuelType = fuelType;
        }
    }
}
