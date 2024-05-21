int t = int.Parse(Console.ReadLine());
for (int i = 1; i <= t; i++)
{
    List<int> num = new List<int>();
    
    int n = int.Parse(Console.ReadLine());

    while (n > 1)
    {
        num.Add(n % 2);
        n /= 2;
    }
    
    if (n == 1)
        num.Add(n);

    for (int j = 0; j < num.Count; j++)
    {
        if(num[j] == 1)
            Console.Write(j + " ");
    }
}
