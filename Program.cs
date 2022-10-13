string[] tutorialArray = new string[5] {"Orphean beholder scry doubt",
                                        "Капустин яр",
                                        "Wjq;bd",
                                        "0xFF",
                                        ":-)"};

PrintArraysOfStrings(tutorialArray, ResultArray(tutorialArray)); // вывод максимально соответствует примеру из задачи

string[] ResultArray(string[] array)
{
    int ValidStringCounter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            ValidStringCounter++;
        }
    }
    string[] result = new string[ValidStringCounter];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

void PrintArraysOfStrings(string[] array1,string[] array2)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {
        if (i < array1.Length - 1)
        {
            Console.Write($"\"{array1[i]}\", ");
        }
        else
        {
            Console.Write($"\"{array1[i]}\"");
        }
    }
    Console.Write("] -> [");
    for (int i = 0; i < array2.Length; i++)
    {
        if (i < array2.Length - 1)
        {
            Console.Write($"\"{array2[i]}\", ");
        }
        else
        {
            Console.Write($"\"{array2[i]}\"");
        }
    }
    Console.Write("]");
}