// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] createArr()
{
    Console.WriteLine(" input number");
    int lenArr = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[lenArr];
    for (int i = 0; i < lenArr; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        Console.Write($"[{arr[i]}] ");
    }
    return arr;
}

void show(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + arr[i];
        }

    }
    Console.WriteLine($"   Summ = {sum}");

}
show(createArr());