public class Solution {
    public void SetZeroes(int[][] matrix) {
       int row = matrix.Length;        
       int col = matrix[0].Length; 
       Dictionary<int,int[]> hash = new Dictionary<int,int[]>();
       int c=0;
        for(int i=0;i<row;i++){
            for(int j=0;j<col;j++){
                if(matrix[i][j]==0)
                {
                    hash.Add(c++,new[]{i,j});
                   // hash[i]=j;
                }
            }
        }
        foreach(var v in hash){
            for(int i=0;i<col;i++){
                matrix[v.Value[0]][i]=0;
            }
            for(int j=0;j<row;j++){
                matrix[j][v.Value[1]]=0;
            }
        }
    }
}