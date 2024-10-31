using System.Linq;

public class Solution {
    public int[] solution(long n) {
       return n.ToString()
                .Reverse()               // 문자열을 뒤집음
                .Select(c => c - '0')    // 각 문자를 숫자로 변환
                .ToArray(); 
    }
}