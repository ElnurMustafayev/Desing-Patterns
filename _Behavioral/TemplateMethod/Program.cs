using TemplateMethod.Entities;
using TemplateMethod.Templates;

var userFromJson = await new JsonFileDataParser().GetAsync<User>("user.json");
var userFromXml = await new XmlFileDataParser().GetAsync<User>("user.xml");

System.Console.WriteLine($"Json: {userFromJson}");
System.Console.WriteLine($"Xml: {userFromXml}");