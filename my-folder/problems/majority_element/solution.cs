public class Solution {
    public int MajorityElement(int[] nums) {
        int n =nums.Length;
        //optimal
        // Dictionary<int,int> hash = new Dictionary<int,int>();
        // for(int i=0;i<n;i++){
        //     if(hash.ContainsKey(nums[i])){
        //         hash[nums[i]]=hash[nums[i]]+1;
        //     }else{
        //         hash.Add(nums[i],1);
        //     }
        // }
        // foreach(var j in hash){
        //     if(j.Value>n/2){
        //         return j.Key;
        //     }
        // }

        //best
        int e=0;
        int c=0;

        for(int i=0;i<n;i++){
            if(c==0){
                c=1;
                e=nums[i];
            }else if(e!=nums[i]){
                c--;
            }else if(e==nums[i]){
                c++;
            }
        }
        return e;
    }
}