//  used https://stackoverflow.com/questions/13956244/to-check-if-var-is-string-type 
// https://stackoverflow.com/questions/894263/identify-if-a-string-is-a-number 


double answer = 0;
double num1 = 0;
double num2 = 0;
bool prevAnswer = false;
while (true)
{
    
    
    Console.WriteLine("This calculator can perform 5 operations: addition (+), subtraction (-), multiplication (*), division, and modulus (%).");
    Console.WriteLine("Please type a mathematical expression (with spaces), or type \"quit\" to shut down the calculator.");
    String response = Console.ReadLine();
    if (response.ToLower() == "quit")
    {
        break;
    }
    String[] arr = response.Split(' ');
    bool num1IsNumber = double.TryParse(arr[0], out num1);
    bool num2IsNumber = double.TryParse(arr[2], out num2);
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i].ToLower();
    }
    if (arr[1].Equals("+"))
    {
        if (arr[0].Equals("answer"))
        {
            if (prevAnswer)
            {
                num1 = answer;
            }
            else
            {
                Console.WriteLine("No Previous Answer Found.");
                continue;
            }
        }
         else if (num1IsNumber == false)
        {
            Console.WriteLine("Not Real Operation, Cannot Compute.");
            continue;
        }
        
        if (arr[2].ToLower().Equals("answer"))
        {
            if (prevAnswer)
            {
                num2 = answer;
            }
            else
            {
                Console.WriteLine("No Previous Answer Found.");
                continue;
            }
        }
         else if (num2IsNumber == false)
        {
            Console.WriteLine("Not Real Operation, Cannot Compute.");
            continue;
        }
        
        answer =  num1 + num2;
        Console.WriteLine(num1 + " " + arr[1]  + " " + num2 + " = " + answer);
        
    }
    if (arr[1].Equals("-"))
    {
        if (arr[0].Equals("answer"))
        {
            if (prevAnswer)
            {
                num1 = answer;
            }
            else
            {
                Console.WriteLine("No Previous Answer Found.");
                continue;
            }
        }
        else if (num1IsNumber == false)
        {
            Console.WriteLine("Not Real Operation, Cannot Compute.");
            continue;
        }
        
        if (arr[2].ToLower().Equals("answer"))
        {
            if (prevAnswer)
            {
                num2 = answer;
            }
            else
            {
                Console.WriteLine("No Previous Answer Found.");
                continue;
            }
        }
        else if (num2IsNumber == false)
        {
            Console.WriteLine("Not Real Operation, Cannot Compute.");
            continue;
        }
        
        answer =  num1 - num2;
        Console.WriteLine(num1 + " " + arr[1]  + " " + num2 + " = " + answer);
        
    }
    if (arr[1].Equals("*"))
    {
        if (arr[0].Equals("answer"))
        {
            if (prevAnswer)
            {
                num1 = answer;
            }
            else
            {
                Console.WriteLine("No Previous Answer Found.");
                continue;
            }
        }
        else if (num1IsNumber == false)
        {
            Console.WriteLine("Not Real Operation, Cannot Compute.");
            continue;
        }
        
        if (arr[2].ToLower().Equals("answer"))
        {
            if (prevAnswer)
            {
                num2 = answer;
            }
            else
            {
                Console.WriteLine("No Previous Answer Found.");
                continue;
            }
        }
        else if (num2IsNumber == false)
        {
            Console.WriteLine("Not Real Operation, Cannot Compute.");
            continue;
        }
        
        answer =  num1 * num2;
        Console.WriteLine(num1 + " " + arr[1]  + " " + num2 + " = " + answer);
        
    }
    if (arr[1].Equals("/"))
    {
        if (arr[0].Equals("answer"))
        {
            if (prevAnswer)
            {
                num1 = answer;
            }
            else
            {
                Console.WriteLine("No Previous Answer Found.");
                continue;
            }
        }
        else if (num1IsNumber == false)
        {
            Console.WriteLine("Not Real Operation, Cannot Compute.");
            continue;
        }
        
        if (arr[2].ToLower().Equals("answer"))
        {
            if (prevAnswer)
            {
                num2 = answer;
            }
            else
            {
                Console.WriteLine("No Previous Answer Found.");
                continue;
            }
        }
        else if (num2IsNumber == false)
        {
            Console.WriteLine("Not Real Operation, Cannot Compute.");
            continue;
        }

        if (num2 == 0)
        {
            Console.WriteLine("Cannot Divide by Zero.");
            continue;
        }
        
        answer =  num1 / num2;
        Console.WriteLine(num1 + " " + arr[1]  + " " + num2 + " = " + answer);
        
    }
    if (arr[1].Equals("%"))
    {
        if (arr[0].Equals("answer"))
        {
            if (prevAnswer)
            {
                num1 = answer;
            }
            else
            {
                Console.WriteLine("No Previous Answer Found.");
                continue;
            }
        }
        else if (num1IsNumber == false)
        {
            Console.WriteLine("Not Real Operation, Cannot Compute.");
            continue;
        }
        
        if (arr[2].ToLower().Equals("answer"))
        {
            if (prevAnswer)
            {
                num2 = answer;
            }
            else
            {
                Console.WriteLine("No Previous Answer Found.");
                continue;
            }
        }
        else if (num2IsNumber == false)
        {
            Console.WriteLine("Not Real Operation, Cannot Compute.");
            continue;
        }

        if (num2 == 0)
        {
            Console.WriteLine("Cannot Divide by Zero.");
            continue;
        }
        
        answer =  num1 % num2;
        Console.WriteLine(num1 + " " + arr[1]  + " " + num2 + " = " + answer);
        
    }
    prevAnswer = true;
}