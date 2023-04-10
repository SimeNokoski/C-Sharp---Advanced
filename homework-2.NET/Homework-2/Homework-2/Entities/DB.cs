

namespace Homework_2.Entities
{
    public static class DB
    {
        public static List<Vehicle> Vehicles = new List<Vehicle>()
        {
            new Car(1,"Sport",2012,1234,70,new List<string>{"Germany","Spain"}),
            new Bike(2,"Standard",2020,2121,"Red"),
            new Vehicle(3,"Sport",2022,5454)
        };
    }
}
