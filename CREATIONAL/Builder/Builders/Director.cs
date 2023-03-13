using Builder.Builders.Base;
using Builder.Models;

namespace Builder.Builders;

public class HouseDirector {
    private IHouseBuilder builder;

    public HouseDirector(IHouseBuilder builder) => this.builder = builder;

    public House Make(Action<IHouseBuilder> builderAction) {
        builderAction.Invoke(this.builder);
        var result = this.builder.GetResult();
        this.builder.Reset();

        return result;
    }
}