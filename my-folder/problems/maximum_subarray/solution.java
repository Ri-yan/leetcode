class Solution {
    int cross_sum(int a[],int b,int m,int e){
       int lsum=Integer.MIN_VALUE;
       int rsum=Integer.MIN_VALUE;
       int sum=0;
        for (int i = m; i >= b; i--) {
            sum+=a[i];
            if(sum>lsum){
                lsum=sum;
            }
        }
        sum=0;
         for(int i=m+1;i<=e;i++){
           sum+=a[i];
            if(sum>rsum){
                rsum=sum;
            }
        }
        return Math.max((lsum+rsum),Math.max(lsum,rsum));
    }
    
    
    int max_sum(int a[],int b,int e){
        if(b==e){
            return a[b];
        }
        int m=(b+e)/2;
        
        return Math.max(max_sum(a,b,m),Math.max(max_sum(a,m+1,e),cross_sum(a,b,m,e)));
    }
    
    public int maxSubArray(int[] nums) {
        return max_sum(nums,0,nums.length-1);
    }
}