int[] people = new int[10];

for (int i = 0; i < 10; i++)
{
    var s = Console.ReadLine().Split();
    int off = int.Parse(s[0]);
    int on = int.Parse(s[1]);

    if (i == 0)
    {
        people[i] = on;
        continue;   
    }

    people[i] = people[i - 1] - off + on;
}

Console.WriteLine(people.Max());
