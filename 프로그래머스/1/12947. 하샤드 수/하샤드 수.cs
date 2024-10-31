public class Solution {
    public bool solution(int x) {
        int number = x;
        int sum = 0;
        while (x > 0) {
            sum += x % 10; 
            x /= 10; 
        }

        return number % sum == 0;
    }
}