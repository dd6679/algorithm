using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int answer = 0;
        for(int i = 0; i < absolutes.Length; i++)
        {
            // 양의 정수일 때
            if(signs[i])
                answer += absolutes[i];
            // 음의 정수일 때
            else
                answer -= absolutes[i];
        }
        return answer;
    }
}
