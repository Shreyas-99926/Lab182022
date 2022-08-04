Console.WriteLine("Enter value of row");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Enter value of column");
int j = 1;
int column = int.Parse(Console.ReadLine());
int[,] a = new int[row, column];
Console.WriteLine("Enter values");
string arrayTemp = Convert.ToString(Console.ReadLine());
string[] temp = arrayTemp.Split(' ');
int z = 0;
Console.WriteLine("Number of rows -->{0}", a.GetLength(0));
Console.WriteLine("Number of columns -->{0}", a.GetLength(1));
for (int i = 0; i < row; i++)

{
    for (int k = 0; k < column; k++)
    {
        int value = Convert.ToInt32(temp[z]);
        a[i, k] = value;
        z++;
    }
}
foreach (int i in a)
{
    Console.WriteLine("Element {0} is {1}", j, i);
    j++;
}