// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

float[] get_array(int num)
{
    float[] coord = new float[num];    
    for (int i = 1; i<=num; i++)
    {
        Console.Write("Введите "+i+" Элемент массива: ");
        coord[i-1] = (float)Convert.ToDouble(Console.ReadLine());
    }    
    return coord;
}
void output_array(float[] arr, int num)
{
    Console.Write("[");
    for (int i=1; i<num; i++)
    {
        Console.Write(arr[i-1]+", ");
    }
    Console.WriteLine(arr[num-1]+"]");
}
Console.Write("Введите размерность массива: ");
int arr_dim = Convert.ToInt32(Console.ReadLine());
float[] array = get_array(arr_dim);
output_array(array, arr_dim);