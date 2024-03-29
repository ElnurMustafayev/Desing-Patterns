﻿using Builder.Builders;
using Builder.Directors;
using Builder.Directors.Base;
using Builder.Models;



HouseBuilder builder = new HouseBuilder();

var simpleHouse = builder.BuildWindows(4)
    .BuildDoors(2)
    .BuildWalls(8)
    .BuildGarage()
    .Build();

var houseWithRoof = builder
    .BuildDoors(3)
    .BuildWalls(12)
    .BuildGarage()
    .BuildSwimmingPool()
    .BuildRoof()
    .PlantDecoration(new Decoration("Tree"))
    .PlantDecoration(new Decoration("Tree"))
    .Build();

IHouseDirector director = new HouseDirector(builder);
var house = director.MakeSimpleHouse();