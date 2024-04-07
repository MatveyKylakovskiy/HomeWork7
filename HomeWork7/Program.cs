using HomeWork7;

/*var green = new Square(5, "green");
var blue = new Square(2, "blue");
var lightBlue = new Square(15, "light blue");


green.GetInfo();
blue.GetInfo();
lightBlue.GetInfo();

green.Rewriter(green, blue);
green.GetInfo();

*/


var pat1 = new Patient()
{
    Name = "Ivan",
    Age = 30,
    TypeOfTreatment = new TypeOfTreatment(1)
};

pat1.GetInfo();

var pat2 = new Patient()
{
    Name = "VAsia",
    Age = 56,
    TypeOfTreatment = new TypeOfTreatment(2)
};

pat2.GetInfo();

var pat3 = new Patient()
{
    Name = "Petia",
    Age = 23,
    TypeOfTreatment = new TypeOfTreatment(6)
};

pat3.GetInfo();