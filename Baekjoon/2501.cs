string[] buff = Console.ReadLine().Split();

int n = int.Parse(buff[0]);
int k = int.Parse(buff[1]);

List<int> nums = new List<int>();

for (int i = 1; i <= n; i++)
{
    if (nums.Count >= k)
        break;
    if (n % i == 0)
        nums.Add(i);
}

if(nums.Count >= k)
    Console.WriteLine(nums.Last());
else
    Console.WriteLine(0);
