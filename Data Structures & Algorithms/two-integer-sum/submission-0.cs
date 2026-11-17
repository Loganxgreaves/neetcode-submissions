public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //Nested for loop, but we would want a check in the inner for
        //loop that meant that we weren't trying to add the same indice
        //This however is O(n^2) time complexity and constant space
        //Complexity we can probably find a better solution through not
        //Repeating computation of pairs and instead storing them
        
        //This is to store our result and then the incecies that make it up from nums
        // Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (i == j ) continue;
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }

        return [];
    }
}
// I is not equal to J so that would mean the same number in a list couldnt add to itself to make the target

//Every input has one pair that is true

// Answer must be smaller index

//----------------
//So we want to find a good data structure to store pairs so that they can be accessed later we dont actually need to record what numbers stored only the indecies and the value and then check that value against the target 

