

namespace Homework_4.Classes
{
    public static class Db
    {
        public static List<Person> People { get; set; }
        public static List<Dog> Dogs { get; set; }  
        
         static Db()
        {
            Dogs = new List<Dog>()
            {
                new Dog("Sarko",4,"Brown"),
                new Dog("Lusi",2,"Black"),
                new Dog("Zizi",1,"White"),
                new Dog("Leo",5,"Gray"),
                new Dog("Dzeki",3,"Brown"),
                new Dog("Aron",6,"Brown"),
                new Dog("Reks",7,"Black"),
                new Dog("Marko",2,"Gold"),
                new Dog("Toto",1,"White"),
                new Dog("Oskar",8,"Gray"),
                new Dog("Charlie",5,"White"),
            };

            People = new List<Person>()
            {
                new Person("Sime","Nokoski",24,new List<Dog>{Dogs[3],Dogs[5]}),
                new Person("Marko","Markoski",20,new List<Dog>{Dogs[1],Dogs[2],Dogs[4]}),
                new Person("Petar","Petkoski",33,new List<Dog>{Dogs[7] }),
                new Person("Rajko","Rajkoski",36,new List<Dog>{Dogs[8] }),
                new Person("Ritko","Ritkoski",41,new List<Dog>{Dogs[0],Dogs[6]}),
                new Person("Bojan","Bojanoski",28,new List<Dog>{Dogs[9],Dogs[10]}),
            };
        }
    }
}
