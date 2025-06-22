public class Solution {
    bool CalculateFlowers(int[] a, int m, int k,int day){
        int noB=0;
        int count =0;
        int n=a.Length;
        for(int i =0;i<n;i++){
            if(a[i]<=day) count++;
            else{
                noB+=count/k;
                count=0;
            }
        }
        noB+=count/k;
        return noB>=m;
    }
    public int MinDays(int[] bloomDay, int m, int k) {
        if(m*k>bloomDay.Length) return -1;
        int min = bloomDay.Min();
        int max = bloomDay.Max();
        int ans=-1;
        // for(int i=min;i<=max;i++){
        //     var p = CalculateFlowers(bloomDay, m,k,i);
        //     if(p) return i;
        // }
        while(min<=max){
            int mid= (min+max)/2;
            var p = CalculateFlowers(bloomDay, m,k,mid);
            if(p){
                ans= mid;
                max=mid-1;
            }else{
                min=mid+1;
            }
        }
        return ans;
    }
}