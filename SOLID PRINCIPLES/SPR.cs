using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

// Принцип единственной ответственности
// single-responsibility principle, SRP
/* 
    Каждый класс занимается только своим делом 
    Скажи нет божественным классам!

    Использование: При написании clean-code, нормального production-enterprise проекта
*/
namespace SPR {

    // Example:
    // У нас есть обычный класс, хранящий какие-либо данные
    public class ToDoList {
        private List<string> Tasks { get; }
        public ToDoList(params string[] tasks) => this.Tasks = new List<string>(tasks);

        public void AddTask(params string[] tasks) => this.Tasks.AddRange(tasks);
        public int Remove(string task) => this.Tasks.RemoveAll(t => t == task);
        public override string ToString() => string.Join(Environment.NewLine, this.Tasks);

        // Тут мы хотим добавить новые методы, которые отвечают за сохранение данных, например, в файл
        // Всё работает, но, в случае с новым классом, нам придется реализовывать для него методы отдельно.
        // При корневых изменения в проекте придется делать изменения во всех методах отдельно. Все не централизовано
        // ⛔⛔⛔
        public async Task SaveInFile(string filePath, bool overwrite = true) {
            // check exists
            if(!File.Exists(filePath))
                throw new FileNotFoundException($"{filePath} not found in project directory!");

            // get oldcontent if it is necessary
            string oldContent = string.Empty;
            if(!overwrite) {
                oldContent = await File.ReadAllTextAsync(filePath, System.Text.Encoding.UTF8);
                if(!string.IsNullOrWhiteSpace(oldContent))
                    oldContent += Environment.NewLine;
            }
            string content = oldContent + this.ToString();

            // write current content
            await File.WriteAllTextAsync(filePath, content, System.Text.Encoding.UTF8);
        }
    }

    // Создадим отдельный класс, который будет ответсвенный только за сохранение разных типов данных разными способами.
    // В случае чего - изменения коснутся только реализации того или иного метода этого класса
    // ✅✅✅
    public static class Saver {
        public static async Task SaveToStringInFile<T>(string filePath, T data, bool overwrite = true) {
            // check exists
            if(!File.Exists(filePath))
                throw new FileNotFoundException($"{filePath} not found in project directory!");

            // get oldcontent if it is necessary
            string oldContent = string.Empty;
            if(!overwrite) {
                oldContent = await File.ReadAllTextAsync(filePath, System.Text.Encoding.UTF8);
                if(!string.IsNullOrWhiteSpace(oldContent))
                    oldContent += Environment.NewLine;
            }
            string content = oldContent + data.ToString();

            // write current content
            await File.WriteAllTextAsync(filePath, content, System.Text.Encoding.UTF8);
        }
    } 
}