namespace Bridge {
    class Program {
        static void Main(string[] args) {
            HDD hdd = new HDD("BarraCuda", "Seagate", 0.256, 7200);
            Videocard videocard = new Videocard("GTX 1080 Ti", "NVIDIA", false, 8);
            CPU cpu = new CPU("I7-7500U", 4, 2.7, CPU.CPUType.INTEL);
            RAM ram = new RAM("Crucial", "Ballistix", 16, 3200);

            Computer computer = new Computer(hdd, cpu, ram, videocard);
            //computer.Viewer = new OldViewer();      // By default
            computer.Viewer = new NormalViewer();
            computer.Viewer = new GamingViewer();
            computer.ShowInfo();
        }
    }
}