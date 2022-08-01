class Solution {
    public void merge(int[] nums1, int m, int[] nums2, int n) {
        if(n==0){
            return;
        }
        if(m==0){
            int i=0;
            while(i<=n-1){nums1[i]=nums2[i]; i++;}
        }      
        
       if(n!=0 ){
        for(int i=m,j=0;i<=nums1.length-1 && j<=nums2.length-1;i++,j++){
            nums1[i]=nums2[j];
        }
        Arrays.sort(nums1);}
    }
}