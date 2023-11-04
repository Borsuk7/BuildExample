using BuildExample;

const double number1 = 3.5;
const double number2 = 2.5;

var addition = Calculator.Add(number1, number2);
var subtraction = Calculator.Subtract(number1, number2);
var multiplication = Calculator.Multiply(number1, number2);
var division = Calculator.Divide(number1, number2);

Console.WriteLine($"Addition: {number1} + {number2} = {addition}");
Console.WriteLine($"Subtraction: {number1} - {number2} = {subtraction}");
Console.WriteLine($"Multiplication: {number1} * {number2} = {multiplication}");
Console.WriteLine($"Division: {number1} / {number2} = {division}");
