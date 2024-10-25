using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int n) {
        StringBuilder answer = new StringBuilder();

        foreach (char c in my_string) {
            for (int i = 0; i < n; i++) {
                answer.Append(c);
            }
        }

        return answer.ToString();
    }
}

// 0번째 -> 0 1 2 // 1번 3 4 5 // 2번은 6 7 8 // 3번 9 10 11 / 4번 12 13 14