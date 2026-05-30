public class Solution {
    public int[] ReplaceElements(int[] arr) {
        var rightMax = -1;
        var currentPos = 0;

        for (int i = arr.Length -1; i >= 0; i--)
        {
            currentPos = Math.Max(rightMax, arr[i]);
            arr[i] = rightMax;
            rightMax = currentPos;
        }
        return arr;
    }
}