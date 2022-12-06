/*  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2     
1, -7, 567, 89, 223-> 4 */

/* Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}"); */



/* Написать программу, которая на вход принимает массив из любого количества элементов 
(не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный 
по возрастанию(от меньшего числа к большему). */

/*  int[] array = GetArrayRandom(7, 0, 100);
Console.WriteLine($"Вывод массива в строку: [ {String.Join(", ", array)} ]");
Console.WriteLine($"Сортировка по возрастанию: [ {String.Join(", ", SotrArray(array))} ]");
int[] SotrArray(int[] array)
{
    int tempVar=0;
    bool flag=true;
    while (flag)
    {
        flag=false;
        for (int j = 0; j < array.Length-1; j++)
        {
            if (array[j] > array[j + 1])
            {
                tempVar = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tempVar;
                flag = true;
            }
        }
    }
    return array;
}
int[] GetArrayRandom(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}  */
