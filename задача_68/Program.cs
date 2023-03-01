Console.Clear();
Console.WriteLine("введите число n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
if (m<0 || n<0) {Console.WriteLine("m и n должны быть положительными числами");return;}
Console.WriteLine($"{Function(n,m)}");

int Function (int a, int b)
{   
    if (a==0) {return (b+1);}
    if (a!=0 && b==0) {return (Function(a-1,1));}
    if (a>0 && b>0) {return (Function(a-1,Function(a,b-1)));}  
    return Function (a,b);
}