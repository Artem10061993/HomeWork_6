// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void PrintArray(int[] arr)
{
    for(int i = 0; i<arr.Length; i++)
    {
        Console.Write(arr[i]+" ");
    }
}
Console.WriteLine("Введите, сколько чисел Вы планируете ввести");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
int result = 0;
Console.WriteLine("Введите Ваши числа");
for(int i = 0; i<m; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if(array[i]>0)
    {
        result++;
    }
}
PrintArray array);
Console.WriteLine();
Console.WriteLine("Чисел больше 0 = "+result);