//  Задача:
//      Написать программу, которая из имеющегося массива строк формирует
//      новый массив из строк, длина которых меньше, либо равна 3 символам.
//      Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//      При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] GetShortStringsArray(string[] array, int maxLineLength)
{
    // Подсчитываем количество строк с длиной <= 3
    int count = 0;
    foreach (string str in array)
    {
        if (str.Length <= maxLineLength)
        {
            count++;
        }
    }

    // Создаем новый массив нужной длины
    string[] result = new string[count];
    int j = 0;

    // Копируем короткие строки в новый массив
    foreach (string str in array)
    {
        if (str.Length <= maxLineLength)
        {
            result[j] = str;
            j++;
        }
    }

    return result;
}


void PrintArray(string[] array)
{
    if (array.Length > 0) {
        foreach (string str in array)
        {
            Console.Write(str + " ");
        }
    }

    Console.WriteLine();
}


void Main(string[] array)
{
    int maxLineLength = 3;

    string[] resultArray = GetShortStringsArray(array, maxLineLength);

    Console.Write("Исходный массив: ");
    PrintArray(array);
    Console.Write("Новый массив: ");
    PrintArray(resultArray);

}

string[] inputArray1 = new string[] {"Hello", "2", "world", ":-)"};
string[] inputArray2 = new string[] {"1234", "1567", "-2", "computer science"};
string[] inputArray3 = new string[] {"Russia", "Denmark", "Kazan"};

Main(inputArray1);
Main(inputArray2);
Main(inputArray3);
