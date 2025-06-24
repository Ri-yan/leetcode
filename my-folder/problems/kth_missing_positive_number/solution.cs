public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        int res =-1;
        for(int i=0;i<arr.Length;i++){
            if(arr[i]<=k){
                k++;
            }else{
                break;
            }
        }
        return k;
    }
}