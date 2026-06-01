public class Solution {
    public int CalPoints(string[] operations) {
        var score = 0;
        var stack = new List<int>();

        for(int i = 0; i < operations.Length; i++)
        {
            var e = 0;
            if (stack.Count > 1)
            {
                if (operations[i] == "+")
                {
                    int last = stack[stack.Count - 1];
                    int secondLast = stack[stack.Count - 2];
                    e = last + secondLast;
                    stack.Add(e);
                    score += e;
                    continue;
                }
            }
            if (operations[i] == "D")
                {
                    e = (int)stack[stack.Count - 1] * 2;
                    stack.Add(e);
                    score += e;
                    continue;
                }

                if (operations[i] == "C")
                {
                    score -= stack[stack.Count - 1];
                    stack.RemoveAt(stack.Count - 1);
                    continue;
                }

            stack.Add(int.Parse(operations[i]));
            score += int.Parse(operations[i]);
            
        }
        return score;
        
    }
}