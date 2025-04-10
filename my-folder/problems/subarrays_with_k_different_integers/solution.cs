public class Solution {
    public int T_SubarraysWithKDistinct(int[] nums, int k) {
        int r=0,l=0,s=0,c=0,n=nums.Length;
        Dictionary<int,int> map = new Dictionary<int,int>();
        while(r<n){
            if(map.ContainsKey(nums[r]))
            map[nums[r]]++;
            else
            map.Add(nums[r],1);
            while(map.Count>k){
                map[nums[l]]--; 
                if(map[nums[l]]<=0) map.Remove(nums[l]);
                l++;
            }
            
            c+=r-l+1;
            r++;
        }
        return c;
    }
     public int SubarraysWithKDistinct(int[] nums, int k) {
        
        return T_SubarraysWithKDistinct(nums, k)-T_SubarraysWithKDistinct(nums, k-1);
    }
}