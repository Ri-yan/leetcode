public class Solution {
    private static int findMax(int[][] mat,int mid){
        int max = int.MinValue;
        int ind = -1;
        for(int i=0;i<mat[mid].Length;i++){
            if(mat[mid][i]>max){
                ind = i;
                max = mat[mid][i];
            }
        }
        return ind;
    }
    public int[] FindPeakGrid(int[][] mat) {
        int low = 0;
        int m = mat[0].Length; //column
        int n = mat.Length; //rows
        int high = n-1;
        while(low<=high){
            int mid = (low+high)/2;

            int max =  findMax(mat,mid); // max col 

            int left = mid>0?mat[mid-1][max]:-1;
            int right = mid<n-1?mat[mid+1][max]:-1;
            int ele = mat[mid][max];
            if(ele>left && ele >right) return new int []{mid,max};
            else if(ele < left)
                high = mid - 1;
            else
                low = mid + 1;
        }
        return new int []{-1,-1};
    }
}