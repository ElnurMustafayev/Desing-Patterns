using Builder.Builders;
using Builder.Models;



// ⛔️⛔️⛔️ BAD PRACTICE:
House house = new House(
    windowsCount: 2, 
    doorsCount: 1, 
    roomsCount: 1, 
    hasGarage: false, 
    hasSwimmingPool: false, 
    decorations: null);



// ✅✅✅ GOOD PRACTICE:

// Manual with builder
SimpleHouseBuilder builder = new SimpleHouseBuilder();

builder.BuildRooms();
builder.BuildDoors();
builder.BuildDecorations();
builder.BuildWindows();
builder.SetHasGarage();
builder.SetHasSwimmingPool();

House builderResult = builder.GetResult();

// with director
HouseDirector director = new HouseDirector(new VillaBuilder());
var directorResult = director.Make(builder => {
    builder.BuildRooms();
    builder.BuildDoors();
    builder.BuildDecorations();
    builder.BuildWindows();
    builder.SetHasGarage();
    builder.SetHasSwimmingPool();
});

System.Console.WriteLine(directorResult);