// See https://aka.ms/new-console-template for more information

int[] numbers = [123, 5, 0, -10, 7];

int maxNum, minNum;

int i = 0;

maxNum = numbers[0];
minNum = numbers[0];
while (i < numbers.Length)
{
    if (numbers[i] > maxNum)
    {
        maxNum = numbers[i];
    }
    if (numbers[i] < minNum)
    {
        minNum = numbers[i];
    }

    i++;
}
Console.WriteLine("Largest number is " + maxNum);
Console.WriteLine("Smallest number is " + minNum);