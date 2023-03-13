string[] array = { "hello", "2", "world", ";-)" };

void FindShortStrings(string[] array)
{
    int sizeResultArray = 0;
    foreach (string str in array)
    {
        if (str.Length <= 3)
        {
            sizeResultArray++;
        }
    }

    string[] resultArray = new string[sizeResultArray];
    int i = 0;
    foreach (string str in array)
    {
        if (str.Length <= 3)
        {
            resultArray[i] = str;
            i++;
        }
    }

    Console.WriteLine($"Результат:  [{String.Join(", ", resultArray)}]");
}

FindShortStrings(array);