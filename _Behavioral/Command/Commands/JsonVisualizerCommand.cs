namespace Command.Commands;

using System.Text.Json;
using Command.Commands.Base;

public class JsonVisualizerCommand<TEntity> : VisualizerCommand<TEntity> {
    public JsonVisualizerCommand(TEntity entity) : base(entity) {}
    
    public override void Execute() {
        System.Console.WriteLine($"'{nameof(JsonVisualizerCommand<TEntity>)}' command in progress...");
        System.Console.WriteLine($"{typeof(TEntity).Name}: ");

        var json = JsonSerializer.Serialize(this.entity);
        System.Console.WriteLine(json);
    }
}