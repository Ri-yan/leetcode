class Solution {
    public List<Integer> findDisappearedNumbers(int[] nums) {
        Arrays.sort(nums);
        System.out.println(Arrays.toString(nums));
        List<Integer> missing=new ArrayList<>();
        HashSet<Integer> e = new HashSet<>();
        for(int i:nums){
            e.add(i);
        }
        for(int i=1;i<=nums.length;i++){
            if(!e.contains(i)){
                missing.add(i);
            }
        }
        return missing;
    }
}