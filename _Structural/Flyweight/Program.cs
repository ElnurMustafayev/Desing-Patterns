using System.Collections.Specialized;
using System.Runtime.Caching;
using Flyweight.Services;

MemoryCache cache = new MemoryCache(
    name: "countries cache", 
    config: new NameValueCollection());

var countryService = new CountryService(cache);

System.Console.WriteLine(await countryService.FindAsync("AZ"));
System.Console.WriteLine(await countryService.FindAsync("AZ"));
Thread.Sleep(3000);
System.Console.WriteLine(await countryService.FindAsync("AZ"));