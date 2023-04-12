namespace NullObject.Models;

public class NullPerson : Person {
    public override string Name { 
        get => "Unknown"; 
        protected set => base.Name = value; 
    }

    public NullPerson() : base("Unknown") {}

    public override void SayHi() {}
}