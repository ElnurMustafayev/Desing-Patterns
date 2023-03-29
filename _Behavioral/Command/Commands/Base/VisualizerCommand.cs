namespace Command.Commands.Base;

public abstract class VisualizerCommand<TEntity> : ICommand {
    protected TEntity entity;

    protected VisualizerCommand(TEntity entity) => this.entity = entity;

    public abstract void Execute();
}