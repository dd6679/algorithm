using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] pron = {"aya", "ye", "woo", "ma"};
        // aya, ye, woo, ma를 한번씩 조합한 단어의 개수
        for(int i = 0; i < babbling.GetLength(0); i++)
        {
            foreach(var p in pron)
            {
                babbling[i] = babbling[i].Replace(p, " ");
                if(String.IsNullOrWhiteSpace(babbling[i]))
                {
                    answer++;
                    break;
                }
            }
        }
        return answer;
    }
}
