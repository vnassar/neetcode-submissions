public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        
        int currentScore = 0;
        int maxScore = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                currentScore++;
                if (currentScore > maxScore)
                {
                    maxScore = currentScore;
                }
            }
            else
            {

                currentScore = 0;

            }
        }

        return maxScore;
    }
}