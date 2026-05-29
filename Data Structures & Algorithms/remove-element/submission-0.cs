public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        var notEqualToVal = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                notEqualToVal++;
                nums[notEqualToVal - 1] = nums[i];
            }
        }
        return notEqualToVal;
    }
}