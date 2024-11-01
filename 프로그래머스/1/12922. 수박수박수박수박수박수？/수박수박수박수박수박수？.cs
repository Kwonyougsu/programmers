public class Solution {
    public string solution(int n) {
        string answer = "";
        int newnum = n;
        for(int i =0; i< newnum; i++)
        {
            if(newnum % 2 != 0)
            {
                if(n % 2 == 0)
                {
                    answer += "박";
                    n = n- 1;
                }
                else
                {
                    answer += "수";
                    n = n - 1;
                }    
            }
            else
            {
                if(n % 2 == 0)
                {
                    answer += "수";
                    n = n- 1;
                }
                else
                {
                    answer += "박";
                    n = n - 1;
                }
            }
            
        }
        return answer;
    }
}