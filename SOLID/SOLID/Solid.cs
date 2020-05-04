namespace SOLID {
    class Solid {
        static void Main(string[] args) {
            // 1)
            // S - R - P

            // SRP.Storage<string> FileSaveLoader = new SRP.Storage<string>(new SRP.FileSave("test.txt"));
            // FileSaveLoader.SaveLoader = new SRP.FileSave("test2.txt");
            // FileSaveLoader.Save();



            // 2)
            // O - S - P

            // OSP.Barracks baracs = new OSP.Barracks();
            // OSP.Soldier soldierWithKalash = baracs.GetSoldier(new OSP.Kalashnikov());
            // OSP.Soldier soldierWithRpg = baracs.GetSoldier(new OSP.Rpg());



            // 3)
            // L - S - P

            // LSP.Hero hero = new LSP.Hero();
            // hero.ToFly();
            // hero.ToInvis();



            // 4)
            // I - S - P

            //ISP.FileSaveLoader fileSaveLoader = new ISP.FileSaveLoader("Text.txt");
            //fileSaveLoader.Save("Data");
            //ISP.FileLogger fileLogger = new ISP.FileLogger("Log.txt");
            //fileLogger.LogError(new System.IO.FileNotFoundException("File not found!"));



            // 5)
            // D - I - P

            //DIP.Hero hero = new DIP.Hero(100, 100, true, new Tuple<int, int>(0, 0),
            //    new List<DIP.IPower>() { new DIP.FlyPower(), new DIP.InvisibilityPower() });
            //hero.StartPower();
        }
    }
}
