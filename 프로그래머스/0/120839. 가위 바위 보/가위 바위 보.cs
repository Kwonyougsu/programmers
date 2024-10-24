using System;

public class Solution {
    public string solution(string rsp) {
        string answer = "";
        
        foreach (char A in rsp) {
            if (A == '2') {
                answer += '0'; 
            } else if (A == '0') {
                answer += '5'; 
            } else if (A == '5') {
                answer += '2'; 
            }
        }
        return answer; 
    }
}

// 가위는 2, 바위 0, 보 5
// rsp를 무조건 이기는 값만 출력 , 문자열을 다 돌기 => foreach