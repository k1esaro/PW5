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
    int min = array[0];
    int max = array[0];
    for (int i = 0; i< array.Length ; i++)
    {
        if(array[i]>max)
        {
            max = array[i];
        }
        else if(array[i]<min)
        {
            min = array[i];
        }
    }
    result = max - min;
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
Console.Write("Разница между максимальным и минимальным значениями = ");
Console.Write(release(array));
