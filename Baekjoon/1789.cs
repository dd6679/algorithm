// int로 하면 overflow 오류남
long s = Int64.Parse(Console.ReadLine());
List<int> nums = new List<int>();
nums.Add(1);

for(int i = 2; i < s; i++)
{
    if (nums.Last() < s)
    {
        s -= i;
        nums.Add(i);
    }
}

Console.WriteLine(nums.Count);
