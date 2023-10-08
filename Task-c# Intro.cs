#region Task - 1

int Bal = 100;
if (Bal <= 100 && Bal >= 0)
{
    if (Bal >= 91)
    {
        Console.WriteLine("Netice : " + "A");
    }
    else if (Bal >= 81)
    {
        Console.WriteLine("Netice : " + "B");
    }
    else if (Bal >= 71)
    {
        Console.WriteLine("Netice : " + "C");

    }
    else if (Bal >= 61)
    {
        Console.WriteLine("Netice : " + "D");
    }
    else if (Bal >= 51)
    {
        Console.WriteLine("Netice : " + "E");
    }
    else
    {
        Console.WriteLine("Netice : " + "Kesildiniz");
    }
}
else
{
    Console.WriteLine("Daxil etdiyiniz qiymet yanlisdir!");
}

#endregion

#region Task - 2

int[] Numbers = { -5, 7, 9, -3, 0, 1, 3 };
int i = 0;
int Positive = 0;
int Negative = 0;
while (i < Numbers.Length)
{
    if (Numbers[i] > 0)
    {
        Positive++;
    }
    else if (Numbers[i] < 0)
    {
        Negative++;
    }
    i++;
}
Console.WriteLine("Positive numbers :" + " " + Positive);
Console.WriteLine("Negative numbers :" + " " + Negative);

#endregion

# region Task - 3

int[] Numbers = { 1, 77, 5, 45, 7, 0, 9 };
int BigNumber = Numbers[0];
foreach (var a in Numbers)
{
    if(a > BigNumber)
    {
        BigNumber = a;
    }
}
Console.WriteLine("Big number : " + BigNumber);

#endregion