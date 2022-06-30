using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        int[] answer = new int[] {};
        List<int> lAnswer = new List<int>();
        Queue<int> counts = new Queue<int>();
        // progresses 안에 있는 진도가 100프로일 때 서비스에 반영됨
        // 뒤에 있는 기능은 앞에 있는 기능이 배포될 때 함께 배포됨
        // -> answer 안에 배포 가능일을 추가하고 앞에 있는 일자와 비교해 삭제..?
        // 하루에 speeds 만큼 개발이 이루어짐
        // 100일때까지 더해줌..?
        for(int i = 0; i < progresses.Length; i++)
        {
            int count = 0;
            int progress = progresses[i];
            while(progress < 100)
            {
                progress += speeds[i];
                count++;
            }
            counts.Enqueue(count);
        }
        
        int num = counts.Dequeue();
        int function = 1;
        
        while(counts.Count > 0)
        {
            if(num >= counts.Peek())
            {
                counts.Dequeue();
                function += 1;
            }
            else
            {
                num = counts.Dequeue();
                lAnswer.Add(function);
                function = 1;
            }
        }
        lAnswer.Add(function);
        answer = lAnswer.ToArray<int>();
        return answer;
    }
}
