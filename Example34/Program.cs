void input(int [] array)
{
    for (int i = 0; i< array.Length ; i++)
    {
        array[i] = new Random().Next(100 ,999);
    }
}
int release(int [] array)
{
    int result = 0;
    for (int i = 0; i< array.Length ; i++)
    {
        if(array[i]%2==0)
        {
            result+=1;
        }
    }
    return result;
}
void output(int [] array)
{
    for (int i = 0; i< array.Length ; i++)
    {
        Console.WriteLine($"[{string.Join(", ", array)}]");
    }
}
Console.Clear();
Console.Write("Введите кол-во элементов массива = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
input(array);
output(array);
Console.Write("Колл-во четных чисел равняется = ");
Console.Write(release(array));