public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> s = new Stack<int>();
        int n = asteroids.Length;
        int i = 0;

        while (i < n) {
            if (asteroids[i] > 0) { 
                s.Push(asteroids[i]);
            } 
            else {
                while (s.Count > 0 && s.Peek() > 0 && s.Peek() < Math.Abs(asteroids[i])) { 
                    s.Pop(); 
                }
                if (s.Count > 0 && s.Peek() == Math.Abs(asteroids[i])) { 
                    s.Pop(); 
                } 
                else if (s.Count == 0 || s.Peek() < 0) {
                    s.Push(asteroids[i]);
                }
            }
            i++; // Move this outside the if-else block
        }

        // Convert stack to array
        int[] res = new int[s.Count];
        for (int k = res.Length - 1; k >= 0; k--) {
            res[k] = s.Pop();
        }
        
        return res;
    }
}
