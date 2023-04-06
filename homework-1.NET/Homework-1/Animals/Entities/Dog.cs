using Animals.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Entities
{
    public class Dog : Animal, IDog
    {
        public Dog(string name, int age, int weight, string color, string gender) : base(name, age, weight, color, gender) 
        { 
        }
        public void Bark()
        {
            Console.WriteLine($"{Name} barks: Auuuu auuu auu");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"Dog - Name: {Name}, Age: {Age}, Weight: {Weight}kg, Color: {Color}, Gender: {Gender}");
        }
    }
}
