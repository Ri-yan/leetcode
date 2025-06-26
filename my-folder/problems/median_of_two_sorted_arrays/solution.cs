public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int n = nums1.Length;
        int m =nums2.Length;
        int q = n+m;
        bool iseven = q%2==0?true:false;
       int[] res = new int[q]; 
        int p=0;
        int i =0;
        int j = 0;
        while(i<n && j<m){
            if(nums1[i]<nums2[j]){
                res[p++]=nums1[i++];
            }else{
                res[p++]=nums2[j++];
            }
        }
        while(i<n){
            res[p++]=nums1[i++];
        }
         while(j<m){
            res[p++]=nums2[j++];
        }
        if(iseven){
            return (res[q/2] + res[(q/2)-1])/2.0;
        }
        return (res[q/2]);
    }
}