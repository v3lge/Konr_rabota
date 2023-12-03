// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] GetThreeOrLessSymbols(string[] arr)
{string[] B = new string[4];
    for (int i = 0; i < arr.Length; i++)
    {
        if (i.Length <= 3)
        {
            B[i] = i;
        }
        else
        {
            B[i] = string.Empty;
        }
    }
    return B;
}



string [] A = new string[4] {"Работа", "Контроль", "Гит", "Да", "Net"};
System.Console.WriteLine(GetThreeOrLessSymbols(A));



