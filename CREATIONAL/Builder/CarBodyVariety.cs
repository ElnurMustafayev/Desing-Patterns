using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Builder {
    public abstract class CarBodyVariety {
        public string Name{ get; set; }
        public CarBodyVariety(string name) => this.Name = name;
    }

    public class Sedan : CarBodyVariety {
        public Sedan() : base("Sedan") { }
    }

    public class Cupe : CarBodyVariety {
        public Cupe() : base("Cupe") { }
    }

    public class Universal : CarBodyVariety {
        public Universal() : base("Universal") { }
    }

    public class Hatchback : CarBodyVariety {
        public Hatchback() : base("Hatchback") { }
    }
}
