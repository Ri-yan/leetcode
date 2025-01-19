public class Solution {
    static void Reverse(int[]arr ,int start,int end){
        while(start<=end){
            (arr[end],arr[start])= (arr[start],arr[end]);
            end--;
            start++;
        }
    }
    public void Rotate(int[] nums, int k) {
        
        // int s=0;
        // for(int i=0;i<k;i++){
        //     int temp=nums[0];
        //      for(int j=1;j<=n;j++){
        //         nums[j-1]=nums[j];
        //      }
        //     nums[n]=temp;
           
        // }
         int n=nums.Length;
         k=k%n;
       Reverse(nums,0,n-k-1);
       Reverse(nums,n-k,n-1);
       Reverse(nums,0,n-1);

    }
}