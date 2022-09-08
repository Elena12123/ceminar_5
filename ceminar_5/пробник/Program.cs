int[] array = {2,8,7,6,4,75,12};


int max = array [0];
int min = array[0];


for (int i =0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    if (array[i] > max)
    {
        max = array[i];
    }
} 
Console.WriteLine(min);
Console.WriteLine(max);
Console.WriteLine( max - min);