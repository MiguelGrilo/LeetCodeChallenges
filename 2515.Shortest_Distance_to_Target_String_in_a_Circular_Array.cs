using System;

public class Solution {
    public int ClosestTarget(string[] words, string target, int startIndex) {
        int n = words.Length;
        int minDist = int.MaxValue;
        bool found = false;

        for (int i = 0; i < n; i++) {
            if (words[i] == target) {
                found = true;
                
                int d = Math.Abs(i - startIndex);
                int actualDist = Math.Min(d, n - d);
                
                if (actualDist < minDist) {
                    minDist = actualDist;
                }
            }
        }

        return found ? minDist : -1;
    }
}
