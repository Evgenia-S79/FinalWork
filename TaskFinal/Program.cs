// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string GetTextFromConsole(string text) //метод запроса информации у пользовотеля.
{
    Console.Write(text);
    return Console.ReadLine();
}

string[] FillArray() //метод заполнения массива данными, вводимыми пользователем. 
{
    int quantity = Convert.ToInt32(GetTextFromConsole("Введите количество элементов в массиве: "));
    string[] elements = new string[quantity];
    for (int i = 0; i < quantity; i++)
    {
        elements[i] = GetTextFromConsole($"Введите {i + 1}-й элемент: ");
    }
    return elements;
}

void PrintArray(string[] array) // метод для вывода массива с пользовательскими данными.
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]} ");
        }
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write(" ]");
    Console.Write(" - массив элементов введённых пользователем.");
    Console.WriteLine ();
}

void GetNumberOfElements(string[] array, int valueLimit) //метод поиска и вывода элементов длинной не более четырёх символов.
{
    int count = 0;
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= valueLimit)
        {
            count++;
            Console.Write ($"{array[i]} ");
        }
    }
    Console.Write("]");
    if(count != 0)
    {
        Console.Write(" - массив с элементами соответствующими условию.");
    }
    if(count == 0)
    {
        Console.Write(" - условие не выполняется, в массиве нет элементов меньше четырёх.");
    }
}

string[] array = FillArray();
int valueLimit = 3; // максимальное количество символов элемента (строки) не должно превышать в рассматриваемой задаче 4 (четыре)
PrintArray(array);
GetNumberOfElements(array, valueLimit);