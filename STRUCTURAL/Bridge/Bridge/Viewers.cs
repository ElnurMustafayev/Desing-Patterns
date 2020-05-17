using System;

namespace Bridge {
    public interface IViewer {
        public void Show(Computer computer);
    }

    // Gaming Viewer
    public class GamingViewer : IViewer {
        public void Show(Computer computer) {
            Console.WriteLine($"{this.GetType().Name}: ");

            computer.Models.ForEach(model => {
                Console.ForegroundColor = (ConsoleColor)new Random().Next(15);
                Console.BackgroundColor = (ConsoleColor)new Random().Next(15);
                model.ShowInfo();
            });
            Console.ResetColor();
        }
    }

    // Normal Viewer
    public class NormalViewer : IViewer {
        public void Show(Computer computer) {
            Console.WriteLine($"{this.GetType().Name}: ");

            computer.Models.ForEach(model => model.ShowInfo());
        }
    }

    // Old Viewer
    public class OldViewer : IViewer {
        public void Show(Computer computer) {
            Console.WriteLine($"{this.GetType().Name}: ");

            computer.Models.ForEach(model => {
                Console.Write($"{model.GetType().Name.ToUpper()}: ");
                Console.WriteLine($"{model.FirmName}: {model.ModelName}");
            });
        }
    }
}
