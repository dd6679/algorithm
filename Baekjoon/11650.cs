// 점의 차수
int n = int.Parse(Console.ReadLine());
List<int[]> arr = new List<int[]>();
// i번점의 위치 x, y
for (int i = 0; i < n; i++)
{
    string tmp = Console.ReadLine();
    string[] tmpArray = tmp.Split(' ');
    arr.Add(new int[]
    {
        Convert.ToInt32(tmpArray[0]), Convert.ToInt32(tmpArray[1])
    });
}

// 첫번째 인자를 기준으로 오름차순 정렬
// 첫번째 인자가 같을 경우 두번째 인자를 기준으로 오름차순 정렬
arr.Sort((a, b) =>
{
    int result = a[0].CompareTo(b[0]);
    if (result == 0)
    {
        result = a[1].CompareTo(b[1]);
    }

    return result;
});

// 입출력 함수는 실행시간이 긴 편이기에 한번에 모아서 실행하는게 좋음
List<string> answers = new List<string>();
for (int i = 0; i < n; i++)
{
    answers.Add(arr[i][0] + " " + arr[i][1]);
}
Console.WriteLine(String.Join("\n", answers));
