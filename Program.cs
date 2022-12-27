Console.Clear();
string[] array = new string[5] {"123", "Hello", "Russia", "-2", ": )"};
string[] text = new string[array.Length];
int n = 3;



void Find(string[] array, string[] text)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            text[count] = array[i];
            count++;
        }
        else
        {
            text[count] = string.Empty;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}


