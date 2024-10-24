using System;

public class Solution {
    public bool solution(string s) {
        int Count = 0; 
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(') {
                Count++; 
            } else {
                Count--;
            }

            if (Count < 0) {
                return false; 
            }
        }

        return Count == 0; 
    }
}
