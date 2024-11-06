using System;
using System.Text;

public class Solution {
    public string solution(string s) {
        StringBuilder answer = new StringBuilder();
        int index = 0;

        foreach (char c in s) {
            if (c == ' ') {
                answer.Append(c);
                index = 0; 
            } else {
                answer.Append(index % 2 == 0 ? char.ToUpper(c) : char.ToLower(c));
                index++;
            }
        }

        return answer.ToString();
    }
}
