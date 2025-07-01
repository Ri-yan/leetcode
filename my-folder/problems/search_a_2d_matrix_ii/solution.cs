public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // int n = matrix.Length;
        // int m = matrix[0].Length;
        // int l =0;
        // int h = m*n-1;
        // while(l<=h){
        //     int mid = (l+h)/2;
        //     int i = mid/m;
        //     int j = mid%m;
        //     if(matrix[i][j]==target) return true;
        //     if(matrix[i][j]<target){
        //         l=mid+1;
        //     }else{
        //         h=mid-1;
        //     }
        // }
        // return false;
        int n = matrix.Length;
        int m = matrix[0].Length;
        int r=0;
        int c=m-1;
        while(r<n && c>=0){
            if(matrix[r][c]==target) return true;
           else if (matrix[r][c] < target) r++;    // move down
            else c--;    
        }
        return false;
    }
}