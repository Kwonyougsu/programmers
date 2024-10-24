public class Solution {
    int GCD(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    int LCM(int a, int b) {
        return (a * b) / GCD(a, b);
    }

    public int solution(int n) {
        return LCM(6, n) / 6;
    }
}

