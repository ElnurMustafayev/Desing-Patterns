using NullObject.Models;

namespace NullObject;

public class PeopleStorage {
    private int counter = 0;

    public Person GetPerson() {
        return (counter++ % 2 == 0)
            ? new Person("Bob")
            : new NullPerson();
    }
}