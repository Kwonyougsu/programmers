public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        int length = phone_number.Length;
        string maskedPart = new string('*', length - 4);
        string Digits = phone_number.Substring(length - 4);
        
        answer = maskedPart + Digits;
        
        return answer;
    }
}