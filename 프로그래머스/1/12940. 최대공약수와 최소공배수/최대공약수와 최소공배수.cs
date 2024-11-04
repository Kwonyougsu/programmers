using System;
public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        answer[0] = GCD(n,m);
        answer[1] = Math.Abs(n * m) / GCD(n, m);
        return answer;
    }
    public static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}