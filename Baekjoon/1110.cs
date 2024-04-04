int result = 0;
string N = Console.ReadLine();

void calculation(string n)
{
    if(result != 0 && N == n)
        return;
    
    string sum = (int.Parse(n[0].ToString()) + int.Parse(n[1].ToString())).ToString();

    if (10 > int.Parse(sum))
    {
        sum = "0" + sum;
    }

    n = n[1] + sum[1].ToString();
    result++;
    calculation(n);
}

if (10 > int.Parse(N))
{
    N = "0" + N;
}

calculation(N);

Console.WriteLine(result);
