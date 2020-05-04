using System;
using System.IO;

// - - - - - I - S - P - - - - - -
// Interface Segregation Principle
// Принцип разделения интерфейса
// Много интерфейсов лучше чем один
namespace ISP {

    // BAD
    public interface IFileWriter<T> {
        void Log();
        void Save(T Data);
        T Load();
    }

    // GOOD
    // ISP
    public interface ILogger {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(Exception ex, string message = null);
    }

    // ISP
    public interface ISaveLoader<T> {
        void Save(T Data);
        T Load();
    }


    public class FileLogger : ILogger {
        public readonly string filePath;

        public FileLogger(string filePath) => this.filePath = filePath;

        public void LogInfo(string message) {
            File.AppendAllText(this.filePath, $"INFO: [{DateTime.Now}] : {message}\n");
        }
        public void LogWarning(string message) {
            File.AppendAllText(this.filePath, $"WARNING: [{DateTime.Now}] : {message}\n");
        }
        public void LogError(Exception ex, string message = null) {
            File.AppendAllText(this.filePath, $"ERROR: [{DateTime.Now}] : {message ?? ""} \nError: {ex.Message}\n");
        }
    }

    public class FileSaveLoader : ISaveLoader<string> {
        public readonly string filePath;

        public FileSaveLoader(string filePath) => this.filePath = filePath;

        public string Load() => File.ReadAllText(filePath);
        public void Save(string Data) => File.WriteAllText(filePath, Data);
    }
}
