//1.int tipindən array və 1 int tipindən ədəd qəbul edən metod yazın. Metod bu ədədin bu arrayin hər hansı bir elementinə bərabər olub-olmadığını tapsın.

int[] myArray = { 1, 2, 3, 4, 5 };
int myNumber = 3;
static bool Does(int[] array, int num)
{
    foreach (int element in array)
    {
        if (element == num)
        {
            return true;
        }
    }
    return false;
}
Console.WriteLine("Array daxilində ədəd tapıldı: true");
Console.WriteLine("Array daxilində ədəd tapılmadı: false");
