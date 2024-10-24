using System;

public class Solution {
    public int solution(int slice, int n)
    {
        return (n + slice - 1) / slice;
    }
}
//원하는 조각 대로 잘라주는 slice
//먹는사람 n
//n이 피자를 최소 한개를 먹기 위해? 피자를 몇판 시킴 