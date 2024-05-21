var s = Console.ReadLine().Split();
int n1 = int.Parse(s[0]);
int n2 = int.Parse(s[1]);

List<int> nums = new List<int>();
int n = 0;

for (int i = 1; i <= 1000; i++)
{
    int temp = n;
    n += i;

    for (int j = n1; j <= n2; j++)
    {
        if (temp < j && j <= n)
        {
            nums.Add(i);
        } 
    }
}

Console.WriteLine(nums.Sum());
