using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "";
        var index1 = new List<int>();
        var index2 = new List<int>();
        for(int i = 0; i < cards1.Length; i++)
        {
            int index = Array.IndexOf(goal, cards1[i]);
            // 카드에는 goal에 없는 단어도 있을 수 있음
            if(index == -1)
                index = 100;
            index1.Add(index);
        }
        
        for(int i = 0; i < cards2.Length; i++)
        {
            int index = Array.IndexOf(goal, cards2[i]);
            if(index == -1)
                index = 100;
            index2.Add(index);
        }
        
        // 주어진 카드 단어의 goal index가 오름차순이라면 원하는 순서의 단어 배열 만들 수 있음
        var sortIndex1 = index1.OrderBy(i => i).ToList();
        var sortIndex2 = index2.OrderBy(i => i).ToList();
        if(Enumerable.SequenceEqual(index1, sortIndex1) && Enumerable.SequenceEqual(index2, sortIndex2))
            answer = "Yes";
        else
            answer = "No";
        return answer;
    }
}
