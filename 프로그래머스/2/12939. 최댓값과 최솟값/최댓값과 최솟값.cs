using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] san = s.Split(" ");
        
        int max = int.Parse(san[0]);
        int min = int.Parse(san[0]);

        for (int i = 1; i < san.Length; i++)
        {
            int current = int.Parse(san[i]);

            max = Math.Max(max, current);
            min = Math.Min(min, current);
        }

        answer = min + " " + max; 
        return answer;
    }
}

//