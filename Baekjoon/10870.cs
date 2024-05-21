int n = int.Parse(Console.ReadLine());

int f1 = 0;
int f2 = 0;

for (int i = 0; i <= n; i++)
{
    if (i == 0 || i == 1)
    {
        f2 = i;
        continue;
    }

    int temp = f2;
    f2 = f1 + f2;
    f1 = temp;
}

Console.WriteLine(f2);
