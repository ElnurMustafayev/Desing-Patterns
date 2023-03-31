using Facade.Models;
using Facade.Services;

AsposeCellsFacade service = new AsposeCellsFacade();

var data = new List<DataModel>() {
    new DataModel() { Number = 123, Amount = 65.67m, Text = "Something", Condition = true },
    new DataModel() { Number = 55000, Amount = -5m, Text = "", Condition = true },
    new DataModel() { Number = -10, Amount = 0.00007m, Text = "text", Condition = null },
};

service.CreateExcel("Result", data);