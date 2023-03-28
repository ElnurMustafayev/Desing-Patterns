namespace TemplateMethod.Templates;

using System.Text.Json;
using TemplateMethod.Templates.Base;

public class JsonFileDataParser : FileDataParser {
    private string json;

    protected override async Task ReadFileAsync(string filepath) => this.json = await File.ReadAllTextAsync(filepath);

    protected override async Task<TEntity> ParseAsync<TEntity>() => JsonSerializer.Deserialize<TEntity>(this.json);
}