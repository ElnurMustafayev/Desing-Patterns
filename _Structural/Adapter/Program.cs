using Adapter.Adapters;
using Adapter.Adapters.Base;
using Adapter.Shapes;



// ⛔️⛔️⛔️
var line = new Line();
var circle = new Circle();
var rectangle = new Rectangle();

var shapes = new List<object>() {
    line, circle, rectangle,
};

foreach (var shape in shapes) {
    // shape.Draw // ???
}



// ✅✅✅
var adapters = new List<IShapeAdapter>() {
    new LineAdapter(line),
    new CircleAdapter(circle),
    new RectangleAdapter(rectangle),
};

foreach (var adapter in adapters) {
    // have one (adapted) interface
    adapter.Draw(0, 0, 10, 20);
}