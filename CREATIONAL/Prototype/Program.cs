using Prototype;
using Prototype.Models;

CarManager manager = new CarManager();

var car = manager[CarType.Sedan];

System.Console.WriteLine(car);