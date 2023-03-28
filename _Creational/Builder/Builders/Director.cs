using Builder.Builders.Base;
using Builder.Models;

namespace Builder.Builders;

public class HouseDirector {
    private IHouseBuilder builder;

    public HouseDirector(IHouseBuilder builder) => this.builder = builder;

    public House BuildHouse() {
        builder.BuildRooms();
        builder.BuildDoors();
        builder.BuildWindows();

        var result = this.builder.GetResult();
        this.builder.Reset();

        return result;
    }

    public House BuildFacade() {
        builder.BuildRooms();
        builder.BuildDoors();
        builder.BuildDecorations();
        builder.BuildWindows();
        builder.SetHasGarage();
        builder.SetHasSwimmingPool();

        var result = this.builder.GetResult();
        this.builder.Reset();

        return result;
    }
}