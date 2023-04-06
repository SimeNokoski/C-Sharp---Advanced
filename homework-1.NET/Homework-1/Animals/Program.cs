
using Animals.Entities;

Dog sarko = new Dog("Sarko",3,20,"Gray","Male");
Dog lusi = new Dog("Lusi",2,10,"Black","Female");

Cat maca = new Cat("Maca", 1, 5, "White", "Female");
Cat tom = new Cat("Tom",4,7,"Gray","Male");

sarko.Bark();
sarko.PrintAnimal();
lusi.Bark();
lusi.PrintAnimal();

maca.Eat("Fish");
maca.PrintAnimal();
tom.Eat("Meat");
tom.PrintAnimal();
