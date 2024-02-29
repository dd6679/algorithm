using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string three = "";
        // 10진법을 3진법으로 바꾸기
        while(n / 3 > 0)
        {
            three += (n % 3).ToString();
            n = n / 3;
        }
        three += n.ToString();
        for(int i = 0; i < three.Length; i++)
        {
            answer += Int32.Parse(three[i].ToString()) * (int)Math.Pow(3, three.Length -1 - i);
        }
        
        return answer;
    }
}
