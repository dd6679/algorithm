int result = 0;
// 다항식 차수
int n = int.Parse(Console.ReadLine());
// 다항식 계수
string tmp = Console.ReadLine();
string[] tmpArray = tmp.Split(' ');

result += 2 * (n - 1);
for (int i = 0; i < tmpArray.Length; i++)
{
    if (tmpArray[i] == "1")
    {
        result += 2;
    }
    else if (tmpArray[i] != "0")
    {
        result += tmpArray[i].Length + 1;
    }

    n--;
}

Console.WriteLine(result);
