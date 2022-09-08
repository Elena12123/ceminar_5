Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());
 
int[] FillArray ()
{
int[]array = new int[N];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(100, 1000);
if (i!=array.Length-1) Console.Write($"{array[i]}, ");
else Console.WriteLine($"{array[i]}");
}
return array;
}
int[] mas = FillArray();

int[] ChisloChet(int[] array)
{
int chet = 0;
int ne_chet = 0;
int count = 0;

foreach (int item in array)
{
    if (item%2==0) 
    {
        chet= count+1;
        count++;
    }
   
   
}
int[] arr={chet, ne_chet};
return arr;

}
int[] result = ChisloChet(mas);
Console.WriteLine($"Количество четных в массиве {result[0]}");



