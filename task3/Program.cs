// Задача 38: Задайте массив 
// вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int createArr()
{
    Console.WriteLine(" input number");
    int lenArr = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[lenArr];

    for (int i = 0; i < lenArr; i++)
    {
        arr[i] = new Random().Next(1, 1000);
        Console.Write($"[{arr[i]}] ");
    }
    int min = arr[0];
    int max = arr[0];

    for (int i = 0; i < lenArr; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        else if (arr[i] > max)
        {
            max = arr[i];
        }
    }

    int result = max - min;
    Console.Write($"  MAX - MIN = |{result}|");
    return result;
}
createArr();