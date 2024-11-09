using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] A, int[] B) {
        int answer = 0;
        List<int> listA = A.ToList();
        List<int> listB = B.ToList();

        while (listA.Count > 0) {
            int min = int.MaxValue;  
            int max = int.MinValue;  
            int minIndex = -1;       
            int maxIndex = -1;      

            for (int j = 0; j < listB.Count; j++) {
                int currentB = listB[j];
                if (currentB > max) {
                    max = currentB;
                    maxIndex = j;
                }
            }

            for (int i = 0; i < listA.Count; i++) {
                int currentA = listA[i];
                if (currentA < min) {
                    min = currentA;
                    minIndex = i;
                }
            }

            answer += (max * min);

            listB.RemoveAt(maxIndex);  
            listA.RemoveAt(minIndex);  
        }

        return answer;
    }
}
