public class Solution {
    public int[][] Merge(int[][] intervals) {
        int i=0;
        int n = intervals.Length; //total intervals
        Array.Sort(intervals, (a, b) => a[0] - b[0]);

        Stack<int[]> s = new Stack<int[]>();
        while(i<n){
            if(s.Count==0){
                s.Push(intervals[i]);
            }else{
                var a = s.Peek();
                if( a[1]>=intervals[i][0]){
                    s.Pop();
                    s.Push(new []{a[0],Math.Max(intervals[i][1],a[1])});
                }
                else{
                     s.Push(intervals[i]);
                }
            }
            i++;
        }
        return s.Reverse().ToArray();
    }
}