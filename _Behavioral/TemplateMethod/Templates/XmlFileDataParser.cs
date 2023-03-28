namespace TemplateMethod.Templates;

using System.Xml.Serialization;
using TemplateMethod.Templates.Base;

public class XmlFileDataParser : FileDataParser {
    Stream stream;
    protected override Task ReadFileAsync(string filepath) {
        this.stream = new FileStream(filepath, mode: FileMode.Open, access: FileAccess.Read);

        return Task.CompletedTask;
    } 

    protected override Task ProceedTextAsync() {
        System.Console.WriteLine("Xml text proceeding...");

        return Task.CompletedTask;
    }

    protected override async Task<TEntity> ParseAsync<TEntity>() {
        var serializer = new XmlSerializer(typeof(TEntity));

        var result = serializer.Deserialize(stream);

        return (TEntity)result;
    }
}