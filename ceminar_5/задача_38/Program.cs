Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());
 
double[] FillArray ()
{
double[]array = new double[N];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1, 100);
if (i!=array.Length-1) Console.Write($"{array[i]}, ");
else Console.WriteLine($"{array[i]}");
}
return array;
}
double[] mas = FillArray();

double[] FindMinMax(double[] ars)
{
double max = ars [0];
double min = ars[0];

for (int i =0; i < ars.Length; i++)
{
    if (ars[i] < min)
    {
        min = ars[i];
    }
    if (ars[i] > max)
    {
        max = ars[i];
    }
} 
Console.WriteLine(min);
Console.WriteLine(max);
Console.WriteLine( max - min);
double[] rez = {max-min};
return rez;
}
double[] Result = FindMinMax(mas);





