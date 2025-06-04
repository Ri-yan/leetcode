public class Solution {
    int FirstOccurence(int[] nums, int target ){
        int s=0;
        int e=nums.Length-1;
        int f=-1;
        while(s<=e){
            int m = (s+e)/2;
            if(nums[m]==target){
                f=m;
                e=m-1;
            }else if(nums[m]<target) s=m+1;
            else  e=m-1;
        }
        return f;
    }
    int LastOccurence(int[] nums, int target ){
        int s=0;
        int e=nums.Length-1;
        int l=-1;
        while(s<=e){
            int m = (s+e)/2;
            if(nums[m]==target){
                l=m;
                s=m+1;
            }else if(nums[m]<target) s=m+1;
            else e=m-1;
        }

        return l;
    }
    public int[] SearchRange(int[] nums, int target) {
        int f=-1,l=-1;
        f=FirstOccurence(nums,target );
        if(f==-1)return new int[]{f,l};
        l=LastOccurence(nums,target );
        return new int[]{f,l};
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==target){
                if(f==-1){
                    f=i;
                }
                l=i;
            }
        }
        return new int[]{f,l};
    }
}