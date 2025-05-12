public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = int.MinValue;
        int sum = 0;
        int si=0,s=0,e=0;
        for(int i=0;i<nums.Length;i++){
            if(sum==0) si=i;
            sum+=nums[i];
            if(sum>max){
                max = sum;
                s=si;
                e=i;
            }
            if(sum<0){
                sum=0;
            }
        }
        Console.WriteLine("Start -{0} End-{1}",s,e);
        return  max;
    }
}