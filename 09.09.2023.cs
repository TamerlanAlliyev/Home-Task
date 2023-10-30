//1.int tipindən array və 1 int tipindən ədəd qəbul edən metod yazın. Metod bu ədədin bu arrayin hər hansı bir elementinə bərabər olub-olmadığını tapsın.

int[] array = { 1, 2, 3, 4, 5, 5, 5, 5, 7, 5, 9, 1, 6, 4, 8 };
Console.WriteLine("Search Number");
int num = int.Parse(Console.ReadLine());

bool thereis = Varmi(array, num);
bool Varmi(int[] a, int b)
{
    bool Status = false;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] == b)
        {
            Status = true;
        }
    }
    return Status;
}
Console.WriteLine(thereis);
