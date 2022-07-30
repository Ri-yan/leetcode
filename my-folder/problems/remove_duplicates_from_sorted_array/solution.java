class Solution {
    public int removeDuplicates(int[] nums) {
        TreeSet<Integer> h = new TreeSet<>();
        for(int i=0;i<=nums.length-1;i++){
            h.add(nums[i]);
        }
        System.out.println(h);
       
        Integer a[] = new Integer[h.size()];
        a = h.toArray(a); 
        for(int i=0;i<a.length;i++)
            nums[i]=a[i].intValue();
         for(int i=a.length;i<nums.length;i++)
            nums[i]=9999;
        for(Integer i:nums)
        System.out.println(i);
         int t =nums.length-a.length;
                System.out.println(t);

        return a.length;
    }
}