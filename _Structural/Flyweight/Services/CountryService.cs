using System.Runtime.Caching;
using System.Text.Json;
using Flyweight.Models;

namespace Flyweight.Services;

public class CountryService {
    private const string filePath = "countries.json";

    // Flyweight factory
    private readonly ObjectCache cache;

    public CountryService(ObjectCache cache) => this.cache = cache;

    public async Task<Country?> FindAsync(string code) {
        // search in cache
        var cacheResult = cache.Get(code);

        if(cacheResult is not null && cacheResult is Country resultFromCache) {
            System.Console.WriteLine("Found in <Cache>");
            return resultFromCache;
        }

        // else search in storage
        var json = await File.ReadAllTextAsync(filePath);
        var data = JsonSerializer.Deserialize<IEnumerable<Country>>(json);
        var resultFromJson = data?.FirstOrDefault(country => country.Code == code);

        if(resultFromJson is not null) {
            // write in cache
            var item = new CacheItem(code, resultFromJson);
            this.cache.Add(item, 
                policy: new CacheItemPolicy() {
                    AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(3.0),
                    RemovedCallback = (arg) => System.Console.WriteLine($"log: Cache item with key: '{item.Key}' was autoremoved..."),
                });
        }

        System.Console.WriteLine("Found from <Storage>");
        return resultFromJson;
    }
}