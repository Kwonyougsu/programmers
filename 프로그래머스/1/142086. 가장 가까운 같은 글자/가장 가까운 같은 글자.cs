using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        int[] lastIndex = new int[26]; 
        Array.Fill(lastIndex, -1); 
        
        for (int i = 0; i < s.Length; i++) {
            char currentChar = s[i];
            int charIndex = currentChar - 'a';

            if (lastIndex[charIndex] != -1) {
                answer[i] = i - lastIndex[charIndex];
            } else {
                answer[i] = -1;
            }

            lastIndex[charIndex] = i;
        }

        return answer;
    }
}