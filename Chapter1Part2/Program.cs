Console.WriteLine("Enter the value of k");
int k = int.Parse(Console.ReadLine());
double total = 0;
double sum = 0;
for (int i = 0; i < k; i++)
{
    sum = 1.0 / ((2 * i) + 1);
    Console.WriteLine(sum);
    if (i % 2 == 0)
    {
        total += 1.0 / ((2 * i) + i);
    }
    else
    {
        total -= 1.0 / ((2 * i) + i);
    }
}
Console.WriteLine(total);