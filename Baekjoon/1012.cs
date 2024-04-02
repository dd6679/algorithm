int m, n, k;
int[,] cabbageField;

bool dfs(int x, int y)
{
    if (x <= -1 || x >= n || y <= -1 || y >= m)
        return false;
    if (cabbageField[x, y] == 1)
    {
        cabbageField[x, y] = 9;
        dfs(x - 1, y);
        dfs(x, y - 1);
        dfs(x + 1, y);
        dfs(x, y + 1);
        return true;
    }
    return false;
}

int t = int.Parse(Console.ReadLine());
int[] result = new int[t];

for (int i = 0; i < t; i++)
{
    string tmpField = Console.ReadLine();
    string[] tmpArray = tmpField.Split(' ');
    
    m = Convert.ToInt32(tmpArray[0]);
    n = Convert.ToInt32(tmpArray[1]);
    k = Convert.ToInt32(tmpArray[2]);
    
    cabbageField = new int[n,m];

    for (int j = 0; j < k; j++)
    {
        string pos = Console.ReadLine();
        string[] posArray = pos.Split(' ');
        cabbageField[Convert.ToInt32(posArray[1]), Convert.ToInt32(posArray[0])] = 1;
    }

    for (int j = 0; j < n; j++)
    {
        for (int l = 0; l < m; l++)
        {
            if (dfs(j, l))
                result[i] += 1;
        }
    }
}

for (int i = 0; i < t; i++)
{
    Console.WriteLine(result[i]);
}
