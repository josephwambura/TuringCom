//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var solution = new Solution();
var space = new char[] { ' ' };

string[]? ops = Console.ReadLine()?.Split(space);
int output = solution.CalPoints(ops);
Console.Write(output.ToString());
