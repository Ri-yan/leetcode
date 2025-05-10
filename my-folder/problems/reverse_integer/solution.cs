public class Solution {
    public int Reverse(int x) {
        var res = 0;
        while (x != 0) {
            var pop = x % 10;
            x /= 10;

            // Check for overflow before it happens
            if (res > int.MaxValue / 10 || (res == int.MaxValue / 10 && pop > 7)) return 0;
            if (res < int.MinValue / 10 || (res == int.MinValue / 10 && pop < -8)) return 0;

            res = res * 10 + pop;
        }
        return res;
    }
}