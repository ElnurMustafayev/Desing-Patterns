namespace TemplateMethod.Templates.Base;

public abstract class FileDataParser {
    
    // Template Method
    public async Task<TEntity?> GetAsync<TEntity>(string filepath) {
        this.Start();

        await this.ReadFileAsync(filepath);
        await this.ProceedTextAsync();
        return await this.ParseAsync<TEntity>();
    }

    // default
    private void Start() => System.Console.WriteLine($"'{this.GetType().Name}' template function started...");

    // non-required
    protected virtual Task ProceedTextAsync() => Task.CompletedTask;

    // required
    protected abstract Task ReadFileAsync(string filepath);
    protected abstract Task<TEntity> ParseAsync<TEntity>();
}