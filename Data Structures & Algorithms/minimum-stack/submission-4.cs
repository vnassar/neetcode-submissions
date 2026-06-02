public class MinStack {
    private List<int> s;
    private List<int> y; 

    public MinStack() {
       s = new List<int>();
       y = new List<int>();
    }
    
    public void Push(int val) {
        s.Add(val);
        if (s.Count == 1)
        {
            y.Add(val);
        }
        else
        {
            int min = y.Count == 0 ? val : Math.Min(val, y[y.Count - 1]);
            y.Add(min);
        }
    }
    
    public void Pop() {
        if (s.Count > 0) 
        { 
            s.RemoveAt(s.Count - 1);
            y.RemoveAt(y.Count - 1);
        }   
    }
    
    public int Top() {
        return s[s.Count - 1];
    }
    
    public int GetMin() {
        return y[y.Count - 1];
    }
}
