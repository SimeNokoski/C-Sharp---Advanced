
using CarService.Entities;

Car bmw = new Car("BMW","X5");
Car audi = new Car("Audi", "A6");
Truck volvo = new Truck("Volvo", "FH4");
CarCenter carCenter = new CarCenter();

bmw.Drive();
carCenter.WashCar(bmw);
carCenter.CheckVehicle(bmw);
carCenter.FixVehicle(audi);
carCenter.PumpGas(audi);

volvo.Drive();
carCenter.WashTrailer(volvo);
carCenter.CheckVehicle(volvo);
carCenter.FixVehicle(volvo);
carCenter.PumpGas(volvo);
