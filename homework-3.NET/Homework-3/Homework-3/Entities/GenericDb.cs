

using System.Runtime.CompilerServices;

namespace Homework_3.Entities
{
    public class GenericDb<T> where T : BaseEntity
    {
        public List<T> List { get; set; } = new List<T>();
        public void InsertingCar(T car)
        {
            List.Add(car);
        }
        public T GetCarById(int id)
        {
            return List.FirstOrDefault(x => x.Id == id);
        }
        public void PrintAllCars()
        {
            foreach (var car in List)
            {
                Console.WriteLine($"Id: {car.Id}, Brand: {car.Brand}, Model: {car.Model}, MaxSpeed: {car.MaxSpeed}, HorsePower: {car.HorsePower}, FuelType: {car.FuelType}");
            }
        }
        public void ChangeColor(string text,ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

    }
}
