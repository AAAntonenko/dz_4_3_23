Console.Clear();
Console.WriteLine("введите n");
int n = int.Parse(Console.ReadLine());
PrintNumbers(n);


string PrintNumbers(int number)
{       if(number==1){
            Console.WriteLine($"{number}");
            return number.ToString();
        }
        string s = number.ToString()+ " " + PrintNumbers(number - 1);
        Console.WriteLine($"{s}");
        return s; }
    


