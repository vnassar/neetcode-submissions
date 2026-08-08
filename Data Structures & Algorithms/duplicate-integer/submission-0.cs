public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        HashSet<int> dictionary = new();

        foreach(var num in nums)
        {
            if(!dictionary.Add(num))
            {
                return true;
            }
        }

        return false;
    }
}