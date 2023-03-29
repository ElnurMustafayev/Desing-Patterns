namespace Command.Commands;

using Command.Commands.Base;

public class TextVisualizerCommand<TEntity> : VisualizerCommand<TEntity> {
    public TextVisualizerCommand(TEntity entity) : base(entity) {}

    public override void Execute() {
        System.Console.WriteLine($"'{nameof(TextVisualizerCommand<TEntity>)}' command in progress...");
        System.Console.WriteLine($"{typeof(TEntity).Name}: ");

        var props = typeof(TEntity).GetProperties();
        foreach (var prop in props) {
            System.Console.WriteLine($"{prop.Name}: {prop.GetValue(this.entity)}");
        }

        var fields = typeof(TEntity).GetFields();
        foreach (var field in fields) {
            System.Console.WriteLine($"{field.Name}: {field.GetValue(this.entity)}");
        }
    }
}