public class MyQueue {
    Stack<int> s1,s2;

    public MyQueue() {
        s1=new Stack<int>();
        s2=new Stack<int>();
    }
    
    public void Push(int x) {
       while(s1.Count>0){
        s2.Push(s1.Pop());
       }
       s1.Push(x);
       while(s2.Count>0){
        s1.Push(s2.Pop());
       }
    }
    
    public int Pop() {
        return s1.Pop();
    }
    
    public int Peek() {
        return s1.Peek();
    }
    
    public bool Empty() {
        return s1.Count ==0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */