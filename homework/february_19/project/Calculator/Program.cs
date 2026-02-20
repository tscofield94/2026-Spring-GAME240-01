// See https://aka.ms/new-console-template for more information

Console.WriteLine("This program can run 4 operations: addition, subtraction, multiplication, and division.");

Console.WriteLine("Which operation would you like to calculate with?");

string operand = Console.ReadLine();

operand = operand.ToLower();

bool isDivision = false;
if (operand == "division"){
    isDivision = true;

}

Console.WriteLine("What is your first number?");

double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("What is your second number?");

double num2 = double.Parse(Console.ReadLine());

if (isDivision && (num2 == 0))
{
    Console.WriteLine("Cannot divide by zero.");
} else if (operand == "addition"){
    Console.WriteLine("The result is: " + (num1 + num2));
} else if (operand == "subtraction"){
    Console.WriteLine("The result is: " + (num1 - num2));
} else if (operand == "mutiplication"){
    Console.WriteLine("The result is: " + (num1 * num2));
} else if (operand == "division"){
    Console.WriteLine("The result is: " + (num1 / num2));
}

