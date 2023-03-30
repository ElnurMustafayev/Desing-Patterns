using System.Text.Json;
using Proxy.Models;
using Proxy.Service.Base;

namespace Proxy.Service;

public class ProxyTranslateService : ITranslateService {
    private const string filePath = "transations.json";

    // proxied service
    private readonly ITranslateService translateService;

    public ProxyTranslateService(ITranslateService translateService) => this.translateService = translateService;

    public async Task<Translation> TranslateAsync(string text, string fromLang, string toLang) {
        var localTranslations = await GetAllTranslationsAsync();
        var foundInProxy = localTranslations?.FirstOrDefault(translation =>
            translation.FromText == text
            && translation.FromLang == fromLang
            && translation.ToLang == toLang);

        if(foundInProxy is not null) {
            return foundInProxy;
        }



        // Call proxied service
        var resultFromService = await translateService.TranslateAsync(text, fromLang, toLang);



        localTranslations?.Add(resultFromService);
        await UpdateAllTranslationsAsync(localTranslations);

        return resultFromService;
    }

    private async Task<ICollection<Translation>?> GetAllTranslationsAsync() {
        var json = await File.ReadAllTextAsync(filePath);
        return JsonSerializer.Deserialize<ICollection<Translation>>(json);
    }

    private async Task UpdateAllTranslationsAsync(ICollection<Translation>? translations) {
        translations ??= new List<Translation>();

        await File.WriteAllTextAsync(
            path: filePath, 
            contents: JsonSerializer.Serialize(translations));
    }
}