using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        long Pvalue = long.Parse(p);
        
        for (int i = 0; i <= t.Length - p.Length; i++)
        {
            long substringValue = long.Parse(t.Substring(i, p.Length));

            if (substringValue <= Pvalue)
            {
                answer++;
            }
        }              
        
        return answer;
    }
}
// 문자열 추출 Substring