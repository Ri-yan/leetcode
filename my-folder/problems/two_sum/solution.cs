public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> hash =new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            var remain=target-nums[i];
            if(hash.ContainsKey(remain)){
                 return new int[] { hash[remain], i };
            }else{
                hash[nums[i]]=i;
            }
        }
       return new int[] {};
    }
}