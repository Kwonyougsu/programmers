public class Solution {
    public int solution(string s) {
        int answer = 0;
        if(s.Length >= 1 && s.Length <= 5)
        {
            answer = int.Parse(s);
        }
        return answer;
    }
}