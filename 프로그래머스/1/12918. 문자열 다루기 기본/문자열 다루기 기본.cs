public class Solution {
    public bool solution(string s) {
        if (s.Length != 4 && s.Length != 6)
            return false;
        
        foreach (char c in s)
        {
            if (!char.IsDigit(c))
                return false;
        }
        
        return true;
    }
}

//s의 길이 4 or 6 
//숫자면 true, 영,숫자면 false
//