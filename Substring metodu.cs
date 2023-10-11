string[] Name = { "HelloP237group" };
int say = 1;
foreach (var name in Name)
{
    for (int i = 0; i < name.Length; i++)
    {
        Console.WriteLine(say);
        say++;
    }
}