List<int> dwarf = new List<int>();

for (int i = 0; i < 9; i++)
{
    int n = int.Parse(Console.ReadLine());
    dwarf.Add(n);
}

dwarf.Sort();

int diff = dwarf.Sum() - 100;

for (int i = 8; i >= 0; i--)
{
    if (dwarf[i] < diff)
    {
        int temp = diff - dwarf[i];
        if (dwarf.Contains(temp))
        {
            dwarf.Remove(dwarf[i]);
            dwarf.Remove(temp);
            break;
        }
    }
}

for(int i = 0; i < 7; i++)
    Console.WriteLine(dwarf[i]);
