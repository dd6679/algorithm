// 과목의 개수
int n = int.Parse(Console.ReadLine());
List<double> arr = new List<double>();

string tmp = Console.ReadLine();
string[] tmpArray = tmp.Split(' ');
int[] scores = new int[n];
// string 배열에서 max 값을 찾으면 사전형으로 찾게 됨
for (int i = 0; i < n; i++)
{
    scores[i] = Convert.ToInt32(tmpArray[i]);
}

int maxScore = scores.Max();
for (int i = 0; i < n; i++)
{
    var score = Convert.ToInt32(tmpArray[i]);
    arr.Add((double) score / maxScore * 100);
}

Console.WriteLine(arr.Average());
