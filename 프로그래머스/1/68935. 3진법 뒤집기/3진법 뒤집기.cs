using System;

using System;

public class Solution {
    public int solution(int n) {
        string ternary = "";
        while (n > 0) {
            ternary += (n % 3).ToString(); 
            n /= 3;                        
        }
        

        int result = 0;
        for (int i = 0; i < ternary.Length; i++) {
            result += (ternary[i] - '0') * (int)Math.Pow(3, ternary.Length - 1 - i);
        }
        
        return result;
    }
}

//매개변수 n, 3진법상에서 앞뒤로 뒤집은 후, 다시 10진법으로 표현한 수 return. 
// 1 2 4 8 16 32 64 128
// 1 3 9 27