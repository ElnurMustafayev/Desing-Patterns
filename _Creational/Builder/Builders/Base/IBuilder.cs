namespace Builder.Builders.Base;

public interface IBuilder<IEntity> {
    IEntity GetResult();
    void Reset();
}