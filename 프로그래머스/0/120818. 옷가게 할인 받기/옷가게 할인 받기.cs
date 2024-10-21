public class Solution {
    public int solution(int price) {
        int discount = 0;
        
        if (price >= 500000) {
            discount = 20; 
        } else if (price >= 300000) {
            discount = 10;
        } else if (price >= 100000) {
            discount = 5;  
        }
        
        double discountAmount = price * discount / 100.0; 
        int answer = (int)(price - discountAmount); 
        return answer;
    }
}
