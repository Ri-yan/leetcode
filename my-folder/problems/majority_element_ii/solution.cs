public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        IList<int> result = new List<int>();
        int n = nums.Length;
        Dictionary<int,int> hash = new Dictionary<int,int>();
        foreach(int i in nums){
            if(hash.ContainsKey(i))
            hash[i]++;
            else
            hash.Add(i,1);
        }
        foreach(var d in hash){
            if(d.Value >n/3){
                result.Add(d.Key);
            }
        }
        return result;
    }
}