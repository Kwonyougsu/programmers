using System;

public class Solution
{
    public int solution(int[] d, int budget)
    {
        int answer = 0;
        Array.Sort(d);
        for(int i =0; i< d.Length; i++)
        {
            if(budget - d[i] >= 0)
            {
                budget -= d[i];
                answer++;
            }
            else
                return answer;
        }
        
        return answer;
    }
}
//S사 예산, 신청한 금액보다 적은금액은 불가능, 신청금액 배열 D, 예산 budget , 최대 몇?