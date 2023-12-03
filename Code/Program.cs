// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

string[] GetThreeOrLessSymbols(string[] arr)
{string[] B = new string[4];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            B[i] = arr[i];
        }
        else
        {
            B[i] = string.Empty;
        }
    }
    return B;
}


System.Console.Write("Было:  ");
string[] A = new string[4] {"Работа", "Контроль", "Гит", "Да"};
PrintArray(A);
System.Console.WriteLine();
System.Console.Write("Стало:  ");
PrintArray(GetThreeOrLessSymbols(A));



