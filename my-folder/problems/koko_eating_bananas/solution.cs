public class Solution {
    public int CalculateHours(int[] piles, int speed) {
        double hours = 0;
        foreach (int pile in piles) {
            hours += Math.Ceiling((double)pile/(double)speed); // ceil(pile / speed)
        }
        return (int)hours;
    }


    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = piles.Max();
        int answer = right;

        while (left <= right) {
            int mid = (left + right) / 2;
            int hours = CalculateHours(piles, mid);

            if (hours <= h) {
                answer = mid;       // mid is a valid speed
                right = mid - 1;    // try to find a smaller valid speed
            } else {
                left = mid + 1;     // too slow, increase speed
            }
        }
  // for (int k = 1; k <= max; k++) {
        //     int hours = CalculateHours(piles, k);
        //     if (hours <= h) {
        //         return k; // found the minimum speed that works
        //     }
        // }
        return answer;
    }
}