namespace Proxy.Service;

using Proxy.Models;
using Proxy.Service.Base;

public class APITranslateService : ITranslateService {
    public Task<Translation> TranslateAsync(string text, string fromLang, string toLang) {
        System.Console.WriteLine($"Log: Translate API service translating '{text}'... ");

        var fakeTranslate = new Translation() {
            ToText = "something",
            FromText = text,

            ToLang = toLang,
            FromLang = fromLang,
        };

        return Task.Run<Translation>(() => fakeTranslate);
    }
}