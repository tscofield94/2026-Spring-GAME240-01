// See https://aka.ms/new-console-template for more information

// Loop 1
int i = 1;
while (i <= 5)
{
    Console.Write(i + " ");
    i++;
}
Console.WriteLine();

// Loop 2

i = 100;
while (i <= 150)
{
    Console.Write(i + " ");
    i++;
}
Console.WriteLine();

// Loop 3

i = 0;
while (i <= 100)
{
    if (i % 2 == 0)
        Console.Write(i + " ");
    i++;
}
Console.WriteLine();

// Loop 4

i = 20;
while (i >=  -20)
{
    Console.Write(i + " ");
    i--;
}
Console.WriteLine();

// Loop 5

i = 1;
while (i <= 100)
{
    Console.Write(i + " ");
    i += 3;
}
Console.WriteLine();

// Loop 6

i = 1;
while(i <= 1024)
{
    Console.Write(i + " ");
    i *= 2;
}
Console.WriteLine();

// Loop 7

string response;

do
{
    Console.WriteLine("Do you want the loop to stop?");
    response = Console.ReadLine();
} while (response != "yes");

//Loop 8

i = 0;
bool trueOrFalse = true;
while(i <= 10)
{
    Console.Write(trueOrFalse + " ");
    trueOrFalse = !trueOrFalse;
    i++;
}
Console.WriteLine();

// Loop 9

i = 1;
bool isEven = false;
while (i <= 20)
{
    if (isEven)
    {
        Console.Write(i + " is Even. ");
    }
    else
    {
        Console.Write(i + " is Odd. ");
    }
    isEven = !isEven;
    i++;
}
Console.WriteLine();

// Loop 10

string[] arr = {"once", "upon", "a", "midnight", "dreary"};
i = 0;
while (i < arr.Length)
{
    Console.WriteLine(arr[i]);
    i++;
}