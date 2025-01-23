public class Solution {
    public void SortColors(int[] nums) {
        // int[] color=new []{0,0,0};
        // for(int i=0;i<nums.Length;i++){
        //     color[nums[i]]++;
        // }
        // int s=0;
        //  for(int i=0;i<3;i++){
        //     int p=color[i];
        //     while(p>0 ){
        //         nums[s++]=i;
        //         p--;
        //     }
        //  }

        int low = 0, mid = 0, high = nums.Length-1; // 3 pointers

        while (mid <= high) {
            if (nums[mid] == 0) {
                 (nums[mid],nums[low])=(nums[low],nums[mid]);

                low++;
                mid++;

            } else if (nums[mid] == 1) {
                mid++;

            } else {
                // swapping nums[mid] and nums[high]
               (nums[mid],nums[high])=(nums[high],nums[mid]);

                high--;
            }}
    }
}