using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
 Dictionary<string, string> numberMap = new Dictionary<string, string> {
            { "zero", "0" },
            { "one", "1" },
            { "two", "2" },
            { "three", "3" },
            { "four", "4" },
            { "five", "5" },
            { "six", "6" },
            { "seven", "7" },
            { "eight", "8" },
            { "nine", "9" }
        };

        foreach (var item in numberMap) {
            s = s.Replace(item.Key, item.Value);
        }

        return int.Parse(s);
    }
}