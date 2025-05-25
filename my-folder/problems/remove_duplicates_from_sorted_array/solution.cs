public class Solution {
    public int RemoveDuplicates(int[] nums) {
       HashSet<int> s =new HashSet<int>();
       for(int i=0;i<nums.Length;i++){
        s.Add(nums[i]);
       }
       int u=0;
       foreach(int num in s){
            nums[u]= num;
            u++;
       }
       return u;
    //    int u=0;
    //    for(int i=0;i<nums.Length;i++){
    //     if(nums[u]!=nums[i]){
           
    //         nums[u+1]=nums[i];   u++;
    //     }
    //    }
    //    return u+1;
    }
}