/* Написать программу принимающую число и выдающее его квадрат
*/
Console.Write("Enter your number, please: ");
string number = Console.ReadLine();
int num = int.Parse(number);
int square = num * num;
Console.WriteLine($"Square of your number {number} is {square}");

