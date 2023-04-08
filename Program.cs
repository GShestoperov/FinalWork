
// Итоговая контрольная работа по основному блоку

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// Максимальная длина строк в результирующем массиве
const int N = 3;

void OutputArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\"");
        if (i < array.Length - 1)
            Console.Write(", ");
    }
    Console.Write("]");
}

void Output(string msg)
{
    Console.Write(msg);
}

string[] CreateResultArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= N)
            count++;

    string[] resultArray = new string[count];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= N)
        {
            resultArray[k] = array[i];
            k++;
        }

    return resultArray;
}

string[] array = { "Hello", "2", "world", ":-)", "Привет", "Hi" };
OutputArray(array);

string[] resultArray = CreateResultArray(array);
Output(" -> ");
OutputArray(resultArray);

