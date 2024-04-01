using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string[] friends, string[] gifts) {
        List<int> answers = Enumerable.Repeat(0, friends.Length).ToList();
        List<List<int>> table = new List<List<int>>();
        for (int i = 0; i < friends.Length; i++)
        {
            List<int> list = Enumerable.Repeat(0, friends.Length).ToList();
            table.Add(list);  
        }
        
        foreach (var gift in gifts)
        {
            string[] splits = gift.Split(' ');
            int give = Array.IndexOf(friends, splits[0]);
            int take = Array.IndexOf(friends, splits[1]);
            table[give][take] += 1;
        }
        
        // 선물지수 구하기
        // 선물 지수는 친구들에게 준 선물의 수 - 받은 선물의 수
        List<int> factors = Enumerable.Repeat(0, friends.Length).ToList();
        for (int i = 0; i < friends.Length; i++)
        {
            int takeFactor = 0;
            for (int j = 0; j < friends.Length; j++)
            {
                takeFactor += table[j][i];
            }
            factors[i] = table[i].Sum() - takeFactor;
        }
        
        for (int i = 0; i < friends.Length; i++)
        {
            for (int j = 0; j < friends.Length; j++)
            {
                // 두 사람이 선물을 주고받지 않거나 수가 같다면 선물 지수로 비교
                // 두 사람의 선물 지수가 같다면 주고받지 않고 끝남
                if(table[i][j] == table[j][i])
                {
                    if(factors[i] > factors[j])
                    {
                        answers[i] += 1;
                    }
                }
                // 두 사람 사이 더 많은 선물을 준 사람이 다음 달에 선물 받음
                else if(table[i][j] > table[j][i])
                {
                    answers[i] += 1;
                }
            }
        }
        
        return answers.Max();
    }
}
