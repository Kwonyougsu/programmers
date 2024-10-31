public class Solution {
    public long[] solution(int x, int n) {
        long[] answer = new long[n];
        long newX = x;
        for(int i =0; i< answer.Length; i++)
        {
            answer[i] = newX*(i+1);
        }
        return answer;
    }
}