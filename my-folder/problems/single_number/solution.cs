public class Solution {
    public int SingleNumber(int[] nums) {
        int s=0;
       foreach(int i in nums){
            s=i^s;
        }
        return s;
        Dictionary<int,int> hash =new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(hash.ContainsKey(nums[i])){
                hash[nums[i]]++;
            }else{
                hash[nums[i]]=1;
            }
        }
        foreach(var i in hash){
            if(i.Value==1){
                return i.Key;
            }
        }
        return -1;
    }
}