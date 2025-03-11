public class MinStack {

    private Stack<Tuple<int, int>> s;
    
    public MinStack() {
        s = new Stack<Tuple<int, int>>();
    }
    
    public void Push(int val) {
        if (s.Count == 0) {
            // Push a tuple with the value and its own value as the min
            s.Push(new Tuple<int, int>(val, val));
        } else {
            // Get the current minimum from the top of the stack
            int currentMin = s.Peek().Item2;
            // Push a tuple with the value and the minimum value
            s.Push(new Tuple<int, int>(val, Math.Min(val, currentMin)));
        }
    }
    
    public void Pop() {
        s.Pop();
    }
    
    public int Top() {
        return s.Peek().Item1;
    }
    
    public int GetMin() {
        return s.Peek().Item2;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */