using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        if (arr.Length == 1) return new int[] { -1 }; 

        int minValue = arr.Min(); 
        List<int> list = arr.ToList();
        list.Remove(minValue); 
        return list.ToArray(); 
    }
}
