using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long totalPrice = 0; 
        for (int i = 1; i <= count; i++)
        {
            totalPrice += price * i; 
        }
        
        long remainingMoney = money - totalPrice;

        if (remainingMoney >= 0)
        {
            return 0;
        }
        else
        {
            return -remainingMoney; 
        }
    }
}
