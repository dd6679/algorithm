var s = Console.ReadLine().Split();
int num1 = 0;
int num2 = 0;

if (int.Parse(s[0]) < int.Parse(s[1]))
{
    num1 = int.Parse(s[0]);
    num2 = int.Parse(s[1]);
}
else
{
    num2 = int.Parse(s[0]);
    num1 = int.Parse(s[1]);
}

for (int i = num1; i >= 1; i--)
{
    if (num1 % i == 0 && num2 % i == 0)
    {
        Console.WriteLine(i);
        break;
    }
}

int index = 1;
while (true)
{
    if (num2 * index % num1 == 0)
    {
        Console.WriteLine(num2 * index);
        break;
    }

    index++;
}
