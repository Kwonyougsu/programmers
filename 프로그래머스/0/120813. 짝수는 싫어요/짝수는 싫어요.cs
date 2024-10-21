using System;

public class Solution {
    public int[] solution(int n) {
        // 홀수의 개수 계산
        int count = (n + 1) / 2; // 0부터 n까지의 홀수 개수
        int[] answer = new int[count];
        
        // 홀수 저장
        int index = 0;
        for(int i = 0; i <= n; i++){
            if(i % 2 != 0){
                answer[index] = i;
                index++;
            }
        }
        return answer;
    }
}