public class Solution {
   long mod = 1000000007;
    
    static int[] NSE(int[] arr) {
        int n = arr.Length;
        int[] res = new int[n];
        Stack<int> s = new Stack<int>();

        for (int i = 0; i < n; i++) {
            while (s.Count > 0 && arr[s.Peek()] > arr[i]) {
                s.Pop();
            }
            res[i] = (s.Count > 0) ? s.Peek() : -1;
            s.Push(i);
        }
        return res;
    }

    static int[] PSE(int[] arr) {
        int n = arr.Length;
        int[] res = new int[n];
        Stack<int> s = new Stack<int>();

        for (int i = n - 1; i >= 0; i--) {
            while (s.Count > 0 && arr[s.Peek()] >= arr[i]) {
                s.Pop();
            }
            res[i] = (s.Count > 0) ? s.Peek() : n;
            s.Push(i);
        }
        return res;
    }

    public int SumSubarrayMins(int[] arr) {
        int n = arr.Length;
        int[] nse = NSE(arr); // Next Smaller Element Indexes
        int[] pse = PSE(arr); // Previous Smaller Element Indexes
        long sum = 0;

        for (int i = 0; i < n; i++) {
            long left = i - pse[i];  // Number of subarrays where arr[i] is the minimum (left side)
            long right = nse[i] - i; // Number of subarrays where arr[i] is the minimum (right side)
            sum = (sum + (arr[i] * left % mod * right % mod) % mod) % mod;
        }

        return (int)sum;
    }
}


