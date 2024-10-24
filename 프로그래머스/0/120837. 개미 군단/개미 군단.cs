using System;

public class Solution {
    public int solution(int hp) {
        int answer = 0;
        
        int G = hp / 5;
        int H = (hp - G*5) / 3 ;
        int C = (hp - G*5 - H*3) / 1;    
        answer = G+H+C;
        
        return answer;
    }
}
//장군개미 5, 병정개미 3, 일개미1
//hp값에 따라 장군,병정,일개미를 정한다. => hp를 개미의 공격력에 따라 나누기 