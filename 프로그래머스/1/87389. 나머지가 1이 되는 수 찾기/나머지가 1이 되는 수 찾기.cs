using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        for (int x = 2; x < n; x++) {
            if (n % x == 1) {
                return x; // 조건을 만족하는 첫 번째 x를 반환
            }
        }
        return n - 1; 
    }
}