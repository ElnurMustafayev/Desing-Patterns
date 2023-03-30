namespace Proxy.Service.Base;

using Proxy.Models;

public interface ITranslateService {
    Task<Translation> TranslateAsync(string text, string fromLang, string toLang);
}