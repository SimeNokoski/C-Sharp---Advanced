using Animals.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Entities
{
    public class Cat : Animal, ICat
    {
        public Cat(string name, int age, int weight, string color, string gender) : base(name, age, weight, color, gender)
        { 
        }

        public void Eat(string food)
        {
            Console.WriteLine($"The {Name} cat eats {food}");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"Cat - Name: {Name}, Age: {Age}, Weight: {Weight}kg, Color: {Color}, Gender: {Gender}");

        }
    }
}
