public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        IList<IList<int>> result = new List<IList<int>>();
        int n= nums.Length;
        Array.Sort(nums);
        for(int i=0;i<n;i++){
            if(i!=0 && nums[i]==nums[i-1]) continue;
            for(int j=i+1;j<n;j++){
                if(j>i+1 && nums[j]==nums[j-1]) continue;
                int k=j+1;
                int l=n-1;
                while(k<l){
                    long sum = nums[i];
                    sum += nums[j];
                    sum += nums[k];
                    sum += nums[l];
                     if(sum==target){
                       
                        var arr= new List<int>(){nums[i] ,nums[j] ,nums[k],nums[l]};
                        result.Add(arr);
                        k++;
                        l--;
                        while (k < l && nums[k] == nums[k - 1]) k++;
                        while (k < l && nums[l] == nums[l + 1]) l--;
                    } else if (sum < target) k++;
                    else l--;
                }
            }
        }
        return result;


        // int n = nums.Length; // size of the array
        //  IList<IList<int>> result = new List<IList<int>>();

        // // sort the given array:
        // Array.Sort(nums);

        // // calculating the quadruplets:
        // for (int i = 0; i < n; i++) {
        //     // avoid the duplicates while moving i:
        //     if (i > 0 && nums[i] == nums[i - 1]) continue;
        //     for (int j = i + 1; j < n; j++) {
        //         // avoid the duplicates while moving j:
        //         if (j > i + 1 && nums[j] == nums[j - 1]) continue;

        //         // 2 pointers:
        //         int k = j + 1;
        //         int l = n - 1;
        //         while (k < l) {
        //             long sum = nums[i];
        //             sum += nums[j];
        //             sum += nums[k];
        //             sum += nums[l];
        //             if (sum == target) {
        //                 var arr= new List<int>(){nums[i] ,nums[j] ,nums[k],nums[l]};
        //                 result.Add(arr);
        //                 k++;
        //                 l--;

        //                 // skip the duplicates:
        //                 while (k < l && nums[k] == nums[k - 1]) k++;
        //                 while (k < l && nums[l] == nums[l + 1]) l--;
        //             } else if (sum < target) k++;
        //             else l--;
        //         }
        //     }
        // }

        // return result;
    }
}