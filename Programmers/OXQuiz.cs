using System;

public class Solution {
    public string[] solution(string[] quiz) {
        string[] answer = new string[quiz.GetLength(0)];
        for(int i = 0; i< quiz.GetLength(0); i++)
        {
            string[] array = quiz[i].Split(' ');
            string real_answer = "";
            
            if(array[1] == "+")
                real_answer = (Int32.Parse(array[0]) + Int32.Parse(array[2])).ToString();
            else if(array[1] == "-")
                real_answer = (Int32.Parse(array[0]) - Int32.Parse(array[2])).ToString();

            if(real_answer == array[4])
                answer[i] = "O";
            else
                answer[i] = "X";
        }
        return answer;
    }
}
