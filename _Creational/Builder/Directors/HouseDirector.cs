namespace Builder.Directors;

using Builder.Builders;
using Builder.Builders.Base;
using Builder.Directors.Base;
using Builder.Models;

public class HouseDirector : IHouseDirector {
    public IHouseBuilder Builder { private get; set; }

    public HouseDirector(HouseBuilder builder) => Builder = builder;

    public House MakeSimpleHouse()
    {
        return Builder
            .BuildWindows(4)
            .BuildDoors(2)
            .BuildWalls(8)
            .BuildGarage()
            .PlantDecoration(new Decoration("Tree"))
            .PlantDecoration(new Decoration("Tree"))
            .Build();
    }
}