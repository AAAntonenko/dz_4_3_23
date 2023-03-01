Console.Clear();
Console.WriteLine("введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите число n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Сумма элементов = {FindSum(m,n)}");

int FindSum (int start, int finish)
{   //int sum = start;
    if (start==finish) {return start;}
    int sum = FindSum(start,finish-1) + finish;
    return sum;
}

Console.WriteLine();
Console.WriteLine($"Сумма элементов = {FindSum2(m,n)}");
int FindSum2 (int start, int finish)
{   //int sum = start;
    if (start==finish) {return start;}
    return (FindSum(start,finish-1) + finish);
}