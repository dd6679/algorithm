using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        int dist = (int)'z' - (int)'a' + 1;
        foreach(var ch in s)
        {
            var count = index;
            char asc = 'a';
            for(int i = 1; i <= count; i++)
            {
                asc = (char)((int)ch + i);
                // 알파벳이 z를 여러번 넘어갈 경우를 계산하려 turn 계산
                if((int)'z' < (int)ch + i)
                {
                    var turn = (((int)ch + i) - (int)'a') / dist;
                    asc = (char)((int)ch + i - dist * turn);
                }
                // skip에 포함된 알파벳이면 count를 추가해 한번 더 계산하도록 함
                if(skip.Contains(asc))
                    count++;
            }
            answer += asc;
        }
        
        return answer;
    }
}
