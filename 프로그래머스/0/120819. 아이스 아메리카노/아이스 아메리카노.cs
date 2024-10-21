using System;

public class Solution {
    public int[] solution(int money) {
        int[] answer = new int[2];
        int coffee = 5500;
        int maxcoffee = money / coffee;
        int remainmoney = money % coffee;
        answer[0] = maxcoffee;
        answer[1] = remainmoney;
        return answer;
    }
}