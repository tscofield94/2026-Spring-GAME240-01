// See https://aka.ms/new-console-template for more information
String special;
int total_fish = 0;
int special_count = 0;


while (true)
{
    
    Console.WriteLine("What is the file path for today's special?");
    string special_file = Console.ReadLine();
   

    try
    {
        StreamReader reader = new StreamReader(special_file);
        string readLine = reader.ReadLine();
        string[] specials =  readLine.Split(' ');
        special = specials[specials.Length - 1];
        reader.Close();
        break;
    }
    catch (FileNotFoundException e)
    {
        Console.WriteLine("Could not find the specials file.");
    }
}


Console.WriteLine(special);
while (true)
{
    
    Console.WriteLine("What is the file path for the fishmonger's log?");
    string logs_file = Console.ReadLine();
   

    try
    {
        StreamReader reader1 = new StreamReader(logs_file);
        while (true)
        {
            string readLine = reader1.ReadLine();
            if (readLine == null)
            {
                break;
            }
            string[] logs =  readLine.Split(' ');
            total_fish += int.Parse(logs[0]);
            if (logs[1] == special)
            {
                special_count = int.Parse(logs[0]);
            }
        }
        reader1.Close();
        break;
    }
    catch (FileNotFoundException e)
    {
        Console.WriteLine("Could not find the logs file.");
    }
}



Console.WriteLine("Where do you want to save the result?");

string result_file = Console.ReadLine();

StreamWriter writer = new StreamWriter(result_file);
writer.WriteLine("Today's special is " + special);
writer.WriteLine("Total " + special + " caught: " + special_count);
writer.WriteLine("Total fish caught: " + total_fish);

writer.Close();



