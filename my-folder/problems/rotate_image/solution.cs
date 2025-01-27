public class Solution {
    public void Rotate(int[][] matrix) {
        int row = matrix.Length;
        int col = matrix[0].Length;
        for(int i=0;i<row;i++){
            for(int j=i;j<row;j++){
                (matrix[i][j],matrix[j][i])=(matrix[j][i],matrix[i][j]);
            }
        }
         for(int i=0;i<row;i++){
            for(int j=0;j<row/2;j++){
                (matrix[i][j],matrix[i][row-1-j])=(matrix[i][row-1-j],matrix[i][j]);
            }
        }
    }
}