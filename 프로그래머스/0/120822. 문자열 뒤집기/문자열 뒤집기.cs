using System;

public class Solution {
    public string solution(string my_string) {
        char[] charArray = my_string.ToCharArray();
        Array.Reverse(charArray);
        string answer = new string(charArray);

        return answer;
    }
}