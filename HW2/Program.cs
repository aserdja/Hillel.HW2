using HW2;

var testVector = new Vector(5, 3, 2, 1);
testVector.CalculateLength();

Console.WriteLine();

var testCircle = new Circle();
testCircle.Move(1, 3);

Console.WriteLine();

var testRect = new Rectangle();
testRect.Move(2, 0);
testRect.Resize(testVector);
testRect.Resize(new Vector(1, 3, 6, 0));