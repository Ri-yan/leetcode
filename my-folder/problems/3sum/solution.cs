public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
          IList<IList<int>> result = new List<IList<int>>();
    int n = nums.Length;

    // for (int i = 0; i < n ; i++) {
    //     int sum=nums[i];
    //     for (int j = i; j < n ; j++) {
    //          int tsum=0;
    //         if(j>i)
    //         tsum=nums[j]+nums[i];
    //         for (int k = j; k < n; k++) {
    //             if(nums[k]+tsum==0 && i!=j &&j!=k && k>j) {
    //             var triplet = new List<int> { nums[i], nums[j], nums[k] };
    //             triplet.Sort(); 
    //             result.Add(triplet);
    //             }
                
    //         }
    //     }
    // }
   
    // foreach (var triplet in distinctLists) {
    //     Console.WriteLine($"[{string.Join(", ", triplet)}]");
    // }

    // return result; 

        Array.Sort(nums);
        for(int i=0;i<n;i++){
           int j=i+1;
           int k=n-1;
           if (i != 0 && nums[i] == nums[i - 1]) continue;
           while(j<k) {
            int t=nums[i]+nums[j]+nums[k];
            if(t<0){
                j++;
            } else if(t>0){
                k--;
            }else{
              result.Add(new List<int>{nums[i],nums[j],nums[k]});
              j++;
              k--;
                while(j<k && nums[j]==nums[j-1]){ j++;}
                while(j<k && nums[k]==nums[k+1]){ k--;}
            }
           
           }
        }

        return result;
    }
}