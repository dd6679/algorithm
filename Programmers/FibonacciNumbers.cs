using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        int f1 = 0;
        int f2 = 0;

        for (int i = 0; i <= n; i++)
        {
            if (i == 0 || i == 1)
            {
                f2 = i;
                continue;
            }

            int temp = f2;
            // 오버플로우 때문에 1234567로 나눈 나머지로 계산
            f2 = (f1 + f2) % 1234567;
            f1 = temp % 1234567;
        }
        
        answer = f2;
        
        return answer;
    }
}
