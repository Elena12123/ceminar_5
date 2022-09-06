Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());
 
int[] FillArray ()
{
int[]array = new int[N];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1, 100);
if (i!=array.Length-1) Console.Write($"{array[i]}, ");
else Console.WriteLine($"{array[i]}");
}
return array;
}
int[] mas = FillArray();

int[] FindSum(int[] array)
{
int chet = 0;
int ne_chet = 0;


foreach (int item in array)
{
    if (item%2==0) chet+= item;
    else ne_chet+= item; 
         
}
int[] arr={chet, ne_chet};
return arr;

}
int[] result = FindSum(mas);
Console.WriteLine($"Сумма четных чисел в массиве {result[0]}");
Console.WriteLine($"Сумма нечетных чисел в массиве {result[1]}");
