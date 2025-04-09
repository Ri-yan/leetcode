public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
        int n = cardPoints.Length;

        // Take the first k cards from the start
        int leftSum = 0;
        for (int i = 0; i < k; i++) {
            leftSum += cardPoints[i];
        }

        int maxScore = leftSum;
        int rightSum = 0;

        // Slide window: remove from left, add from right
        for (int i = 0; i < k; i++) {
            leftSum -= cardPoints[k - 1 - i];
            rightSum += cardPoints[n - 1 - i];
            maxScore = Math.Max(maxScore, leftSum + rightSum);
        }

        return maxScore;
    }
}
