//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("\n\nHow many numbers are you going to enter?");
int n = int.Parse(Console.ReadLine());

int [] CreateArray (int b)
{
    int [] arr = new int [n];

    for (int i = 0; i < n; i++)
    {
        System.Console.Write($"Enter your {i+1} number: ");
        arr[i] = int.Parse(Console.ReadLine());
        
    }
    return arr;
}

void ShowArray (int []a)
{
    int cnt=0;
    foreach (var item in a)
    {
        if(item>0) cnt++;
    }
    System.Console.WriteLine("***************************************");
    System.Console.WriteLine($"Quantity of your positive numbers is: {cnt}\n\n");
}

int [] a = CreateArray(n);

ShowArray(a);