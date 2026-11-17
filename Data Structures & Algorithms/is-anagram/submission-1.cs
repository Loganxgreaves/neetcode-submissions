public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var counts = new Dictionary<char, int>();

        foreach (var c in s)
        {
            counts.TryAdd(c, 0);
            counts[c]++;
        }

        foreach (var c in t)
        {
            if (!counts.ContainsKey(c) || counts[c] == 0){
                return false;
            }
            counts.TryAdd(c, 0);
            counts[c]--;
        }

        return true;
    }
}
