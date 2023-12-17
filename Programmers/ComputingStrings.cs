using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string[] my_array = my_string.Split(' ');
        for(int i = 0; i < my_array.GetLength(0); i++)
        {
            if(my_array[i] == "+")
            {
                answer = Int32.Parse(my_array[i-1]) + Int32.Parse(my_array[i+1]);
                my_array[i-1] = "";
                my_array[i] = "";
                my_array[i+1] = answer.ToString();
                continue;
            }
            if(my_array[i] == "-")
            {
                answer = Int32.Parse(my_array[i-1]) - Int32.Parse(my_array[i+1]);
                my_array[i-1] = "";
                my_array[i] = "";
                my_array[i+1] = answer.ToString();
            }
        }
        return answer;
    }
}
