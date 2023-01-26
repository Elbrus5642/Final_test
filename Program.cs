/*Создать программу, которая из 
имеющегося массива строк формирует массив из строк,
длина которых менее либо равна 3 символам. 
Массив можно ввести с клавиатуры , или задать на старте выполнения алгоритма*/

/* Задание массива строк для дальнейшей обработки*/
string[] arrayTextStr = { "hello", "2", "world", ":-)" };
/* Метод формирования нового массива со строками длинной <=3"*/
string[] GetArrayThreeSymbolElement(string[] array)
{
    string[] arrayResult = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i].Length <= 3)
        {
            arrayResult[i] = array[i];
        }
        else
        {
            continue;
        }
    }
    arrayResult = arrayResult.Where(x => x != null).ToArray();
    return arrayResult;
};

void PrintArrayStr(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\"");
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
}

Console.Write("[");
PrintArrayStr(arrayTextStr);
Console.Write("]");
string[] arrayNorm = GetArrayThreeSymbolElement(arrayTextStr);
Console.Write(" -> ");
Console.Write("[");
PrintArrayStr(arrayNorm);
Console.Write("]");
