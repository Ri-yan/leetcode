public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();
        Array.Sort(nums);
        int l= nums.Length;
        for(int i=0;i<l;i++){
            int j = i+1;
            int k=l-1;
            if (i > 0 && nums[i] == nums[i - 1]) continue;
          
            while(j<k){
                var r = nums[i]+nums[j]+nums[k];
               if(r>0){
                    k--;
                }else if(r<0){
                    j++;
                }else{
                  res.Add(new List<int>{nums[i],nums[j],nums[k]});
                  j++;
                  k--;
                     while(j<k && nums[j]==nums[j-1]){ j++;}
                     while(j<k && nums[k]==nums[k+1]){ k--;}
                }
            }
            }
        return res;
    }
}

//[-1,0,1,2,-1,-4]