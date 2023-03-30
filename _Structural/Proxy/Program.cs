using Proxy.Service;

APITranslateService originalTranslateService = new APITranslateService();
ProxyTranslateService proxyTranslateService = new ProxyTranslateService(originalTranslateService);

System.Console.WriteLine(await proxyTranslateService.TranslateAsync("Hello", "en", "ru"));
System.Console.WriteLine(await proxyTranslateService.TranslateAsync("Hello", "en", "ru"));