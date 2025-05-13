public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;

        var numSet = new HashSet<int>(nums);
        int maxLength = 0;

        foreach (int num in numSet) {
            // Only start counting if it's the beginning of a sequence
            if (!numSet.Contains(num - 1)) {
                int currentNum = num;
                int currentStreak = 1;

                while (numSet.Contains(currentNum + 1)) {
                    currentNum++;
                    currentStreak++;
                }

                maxLength = Math.Max(maxLength, currentStreak);
            }
        }

        return maxLength;
    }
}
