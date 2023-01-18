void input(int [] array)
{
    for (int i = 0; i< array.Length ; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
}
int release(int [] array)
{
    int result = 0;
    for (int i = 0; i< array.Length ; i++)
    {
        if(i%2!=0 && i!=0 )
        {
            result+=array[i];
        }
    }
    return result;
}
void output(int [] array)
{
        Console.WriteLine($"[{string.Join(", ", array)}]");
}
Console.Clear();
Console.Write("Введите кол-во элементов массива = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
input(array);
output(array);
Console.Write("Сумма чисел находящихся на нечетных позициях равна = ");
Console.Write(release(array));
