namespace Builder.Builders.Base;

public interface IBuilder<IEntity> {
    IEntity Build();
    void Reset();
}