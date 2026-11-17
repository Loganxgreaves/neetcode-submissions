public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();
        List<List<string>> result = [];
        foreach (var str in strs)
        {
            var sortedStr = new string(str.Order().ToArray());
            
            //Essentially with this bit we need to find a way to ensure that if they do exist we know what words to put them with 
            // I am now thinking after thinking about it for a bit the only way I can think to make this work and I might be tunnel visioned when I say this 
            // I would store the characters as a key sorted in order and then a list of words next to them that way I could quickly find if a word was an anagram
            // Disavantages is that I would need to then put this back into the list in the end to sort it out 
            if (!results.TryAdd(sortedStr, [str]))
            {
                results[sortedStr].Add(str);
            }
        }

        result.AddRange(results.Select(row => row.Value));
        return result;
    }
}
