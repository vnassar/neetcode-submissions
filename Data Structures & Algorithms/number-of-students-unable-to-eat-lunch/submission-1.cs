public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        
        Dictionary<int, int> preferenceCount = new();
        foreach (int s in students)
        {
            preferenceCount[s] = preferenceCount.GetValueOrDefault(s) + 1;
        }

        for (int i = 0; i < sandwiches.Length; i++)
        {
            int type = sandwiches[i];

            if (preferenceCount.GetValueOrDefault(type, 0) > 0)
            {
                preferenceCount[type]--;
            }
            else
            {
                return sandwiches.Length - i;
            }
        }

        return 0;
    }
}