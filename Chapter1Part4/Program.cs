Console.WriteLine("Enter size of array");
int size = int.Parse((Console.ReadLine()));
int[] a = new int[size];
int minimum = 1000;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Enter {i} number");
    int x = int.Parse(Console.ReadLine());
    a[i] = x;
}

string[] result = (Array.ConvertAll(a, x => x.ToString()));
Console.WriteLine(String.Join(",", result));
Console.WriteLine(" ");

Console.WriteLine("minimum value of array using inbuilt array method-->" + a.Min());
Console.WriteLine(" ");
Array.Sort(a);
foreach (int i in a)
{
    Console.WriteLine("{0}", i);
}

Console.WriteLine("Minimum value using sorting is-->{0}", a[0]);
Console.WriteLine(" ");


foreach (int i in a)
{
    if (i < minimum)
    {
        minimum = i;
    }
    else
    {
        continue;
    }
}
Console.WriteLine("Minimum usin foreach loop is {0}", minimum);