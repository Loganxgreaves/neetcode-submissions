public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new();
        for (var i = 0; i < nums.Length; i++) {
            var result = target - nums[i];
            // Tries to get the value of a number from our dictionary
            if (seen.TryGetValue(result, out var j)) {
                    return [j, i];
            }
            seen.TryAdd(nums[i], i);
        }

        // Target - a = b so
        // We want to loop through every number in nums and check if there is an answer in the
        // dictionary that would get us b

        return [];
    }
}
