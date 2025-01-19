public class Solution {
    public bool Check(int[] nums) {
        int rotate=0;
       for(int i=0;i<nums.Length-1;i++){
        if(nums[i]>nums[i+1] ) rotate++;
       } 
       if(rotate>0 && nums[nums.Length-1]>nums[0]) return false;
       else if(rotate>1)return false;
       else return true;
    }
}