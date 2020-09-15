// - - - - - S - R - P - - - - - -
// The Single Responsibility Principle
// Принцип единой ответственности
// Каждый класс должен иметь одну и только одну причину для изменений
namespace SRP {

    public interface ISaveLoader<T> {
        T Load();
        void Save(T Data);
    }

    public class FileSave : ISaveLoader<string> {
        private readonly string filePath;

        public FileSave(string filePath) => this.filePath = filePath;

        public string Load() => System.IO.File.ReadAllText(this.filePath);
        public void Save(string data) => System.IO.File.WriteAllText(this.filePath, data);
    }

    public class Storage<T> {
        // SRP
        public ISaveLoader<T> SaveLoader;
        public T Data { get; set; }

        // Injection
        public Storage(ISaveLoader<T> saveLoader) {
            this.SaveLoader = saveLoader;
            this.Data = this.Load();
        }

        public void Save() => this.SaveLoader.Save(this.Data);
        public T Load() => this.SaveLoader.Load();
    }
}
