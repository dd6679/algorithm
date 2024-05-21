int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

List<int> num = new List<int>();

for (int i = m; i <= n; i++)
{
    // 1은 소수에 포함되지 않으므로
    if(i == 1) continue;
    bool isPrime = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;   
        }
    }
    if(isPrime) num.Add(i);
}

if (num.Count > 0)
{
    Console.WriteLine(num.Sum());
    Console.WriteLine(num.Min());   
}
else
{
    Console.WriteLine(-1);
}
