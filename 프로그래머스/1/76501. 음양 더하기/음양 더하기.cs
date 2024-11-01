using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int answer = 0;
        for(int i=0; i < absolutes.Length; i++)
        {  
            absolutes[i] = signs[i] == true ? absolutes[i] : -absolutes[i];
            answer += absolutes[i];
        }
        return answer;
    }
}

//절댓값 배열 absolutes , 부호를 담은배열 signs, 
//signs이 true -> 양수 / false -> 음수