public class Solution {
    int calculate(int[] weights, int capacity){
        int n = weights.Length;
        int load=0;
        int day=1;
        for(int i=0;i<n;i++){
             if(load+weights[i]>capacity){
                load=weights[i];
                day+=1;
             }else{
                load+=weights[i];
             }
        }
        return day;
    }
    public int ShipWithinDays(int[] weights, int days) {
        int n = weights.Length;
        int ans = -1;
        int max=0;
        for(int i=0;i<n;i++){ max+=weights[i];}
        int min = weights.Max();

        while(min<=max){
            int mid= (min+max)/2;
            if(calculate(weights,mid)<=days){
                ans=mid;
                max=mid-1;
            }else{
                min=mid+1;
            }
        }
        return ans;
    }
}