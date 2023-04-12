using NullObject;

var storage = new PeopleStorage();

Console.WriteLine("Person: ");
var person = storage.GetPerson();
person.Info();

Console.WriteLine("NullPerson: ");
var nullPerson = storage.GetPerson();
nullPerson.Info();