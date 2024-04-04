string tmp = Console.ReadLine().ToUpper();
Dictionary<char, int> dic = new Dictionary<char, int>();

foreach (var i in tmp)
{
    if(!dic.ContainsKey(i))
        dic.Add(i, 1);
    else
        dic[i] += 1;
}

var maxKeyValuePair = dic.MaxBy(x => x.Value);
var duplication = dic.Where(x => x.Value == maxKeyValuePair.Value);

// 가장 많이 사용된 알파벳이 여러 개 존재하는 경우
if (duplication.Count() > 1)
    Console.WriteLine("?");
else
    Console.WriteLine(maxKeyValuePair.Key);
