using Command.Commands;
using Command.Models;

var command = new SimpleCommand();
command.Execute();
command.Execute();
command.Execute();

var model = new TestModel() {
    Property1 = 123,
    Property2 = "Test",
    Field1 = 34.75,
    Field2 = false,
};

new TextVisualizerCommand<TestModel>(model).Execute();
new JsonVisualizerCommand<TestModel>(model).Execute();