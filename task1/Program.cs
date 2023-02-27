// Задача 34: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, которая покажет
//   количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int currCount = 0;

int[] createArr()
{
    Console.WriteLine(" input number");
    int lenArr = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[lenArr];
    for (int i = 0; i < lenArr; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}


int[] arr = createArr();
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if ((arr[i] % 2) == 0)
    {
        count++;
    }
    Console.Write($"[{arr[i]}] ");
}
currCount = count;
Console.Write($"___->> {currCount}");
