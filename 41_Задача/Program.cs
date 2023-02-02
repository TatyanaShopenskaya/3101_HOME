// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 358


int[] CreateArray(int size, int min, int max)                                               
{  
    int[] array = new int[size]; 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array; 
}

//выводим на печать массив
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

//ищем количество чисел, которые > 0
int count=0;
int CountNumber(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            count=count+1;
        }
    }
    return count;
}

Console.WriteLine("Сначала укажите длину массива, а затем вводите числа, которые надо проверить");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] arrayNumb = CreateArray(sizeArray, -100, 100);
PrintArray(arrayNumb);
int countNumber = CountNumber(arrayNumb);
Console.WriteLine($"Количество чисел, которые больше 0 = {countNumber}");
