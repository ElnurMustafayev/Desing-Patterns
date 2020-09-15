using System;

namespace Bridge {
    public abstract class ModelBase {
        public string ModelName;
        public string FirmName;

        protected ModelBase(string modelName, string firmName) {
            this.ModelName = modelName;
            this.FirmName = firmName;
        }

        public virtual void ShowInfo() {
            Console.WriteLine($"==============={this.GetType().Name.ToUpper()}================");
            Console.WriteLine($"Model: {this.ModelName}");
            Console.WriteLine($"Firm: {this.FirmName}");
        }
    }

    // VIDEOCARD
    public class Videocard : ModelBase {
        public bool IsDiscrete;
        public double MemoryGb;

        public Videocard(string modelName, string firmName, bool isDiscrete, double MemoryGb) 
            : base(modelName, firmName) {
            this.IsDiscrete = isDiscrete;
            this.MemoryGb = MemoryGb;
        }

        public override void ShowInfo() {
            base.ShowInfo();
            Console.WriteLine($"{(this.IsDiscrete ? "" : "Not ")}discrete");
            Console.WriteLine($"Memory: {this.MemoryGb} Gb");
        }
    }

    // CPU
    public class CPU : ModelBase {
        public enum CPUType { AMD, INTEL };

        public sbyte Cores;
        public double GHz;

        public CPU(string modelNumberName, sbyte cores, double gHz, CPUType Type) 
            : base(modelNumberName, Type.ToString()) {
            this.Cores = cores;
            this.GHz = gHz;
        }

        public override void ShowInfo() {
            base.ShowInfo();
            Console.WriteLine($"Cores: {this.Cores}");
            Console.WriteLine($"Speed: {this.GHz} GHz");
        }
    }

    // HDD
    public class HDD : ModelBase {
        public double Memory;
        public uint RPM;

        public HDD(string modelName, string firmName, double memoryGb, uint RPM) 
            : base(modelName, firmName)  {
            this.Memory = memoryGb;
            this.RPM = RPM;
        }

        public override void ShowInfo() {
            base.ShowInfo();
            Console.WriteLine($"Memory: {this.Memory} Gb");
            Console.WriteLine($"Resolutions per minute: {this.RPM} res");
        }
    }

    // RAM
    public class RAM : ModelBase {
        public ushort MemoryGb;
        public ushort MHz;

        public RAM(string modelName, string firmName, ushort memoryGb, ushort mHz)
            : base(modelName, firmName) {
            this.MemoryGb = memoryGb;
            this.MHz = mHz;
        }

        public override void ShowInfo() {
            base.ShowInfo();
            Console.WriteLine($"Memory: {this.MemoryGb} Gb");
            Console.WriteLine($"Frequency: {this.MHz} MHz");
        }
    }
}
