using HomeWork7;

var green = new Square(5, "green");
var blue = new Square(2, "blue");
var lightBlue = new Square(15, "light blue");


green.GetInfo();
blue.GetInfo();
lightBlue.GetInfo();

green.Rewriter(green, blue);
green.GetInfo();

