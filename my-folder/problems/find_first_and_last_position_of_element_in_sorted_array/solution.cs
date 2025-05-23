public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int f=-1,l=-1;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==target){
                if(f==-1){
                    f=i;
                }
                l=i;
            }
        }

        // int s=0;
        // int e=nums.Length-1;
        // while(s<=e){
        //     int m = (s+e)/2;
        //     if(nums[m]==target){
        //         if(f==-1){
        //             f=m;
        //         }
        //         l=m;
        //     }
        //     if(nums[m]<target){
        //         s=m+1;
        //     }else{
        //         e=m-1;
        //     } 
        // }
        return new int[]{f,l};
    }
}