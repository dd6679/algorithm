int n = int.Parse(Console.ReadLine());
var s = Console.ReadLine().Split();

int[] value = new int[n];
for (int j = 0; j < n; j++)
    value[j] = int.Parse(s[j]);

int result = 0;

for (int i = 0; i < n; i++)
{
    bool isDecimal = true;
    if (value[i] <= 1) continue;
    // 2도 소수이므로
    for (int j = 2; j < value[i]; j++)
    {
        if (value[i] % j == 0)
        {
            isDecimal = false;
            break;
        }
    }

    if(isDecimal)
        result += 1;
}

Console.WriteLine(result);
