int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    var s = Console.ReadLine().Split();
    int[] value = new int[10];
    for (int j = 0; j < 10; j++)
        value[j] = int.Parse(s[j]);
    Array.Sort(value);
    Array.Reverse(value);
    Console.WriteLine(value[2]);
}
