using System;
public class Solution {
    public string solution(int age) {
        string answer = "";
        
        while (age > 0)
        {
            answer = (char)(age % 10 + 97) + answer;
            age = age/10;
        }
        return answer;
    }
}
// 0~9를 => a~j로 변형하기 , age에 대입하기 
//97 98 99 100 101 102 103 104 105 106  