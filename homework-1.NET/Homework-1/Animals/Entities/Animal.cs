using Animals.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Entities
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }    
        public int Age { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        public string Gender { get; set; }

        public abstract void PrintAnimal();
        public Animal(string name, int age, int weight, string color, string gender)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Color = color;
            Gender = gender;
        }
    }
}
