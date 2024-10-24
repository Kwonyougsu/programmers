using System;
using System.Linq;
using System.Text;

public class Solution
{
    public string solution(string X, string Y)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 9; i >= 0; i--)
        {
            var duplicatedCount = CheckCount(X, Y, i);
            if (duplicatedCount != 0)
            {
                sb.Append(i.ToString()[0], duplicatedCount);
            }
        }

        var rtn = sb.ToString();

        if (rtn == string.Empty)
        {
            return "-1";
        }
        else if (int.TryParse(rtn, out var count) && count == 0)
        {
            return "0";
        }

        return rtn;
    }

    private int CheckCount(string a, string b, int value)
    {
        char findValue = value.ToString()[0];

        if (!a.Contains(findValue) || !b.Contains(findValue))
        {
            return 0;
        }

        int countA = a.Count(ch => ch == findValue);
        int countB = b.Count(ch => ch == findValue);

        return countA > countB ? countB : countA;
    }
}
