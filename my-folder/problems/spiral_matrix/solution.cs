public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
            int row =matrix.Length-1;
            int col = matrix[0].Length-1;

            IList<int> list = new List<int>();

            int top=0;
            int right=col;
            int bottom=row;
            int left = 0;

           while (top <= bottom && left <= right) {
                for(int i=left;i<=right;i++)
                    list.Add(matrix[left][i]);
                top++;
                
                for(int i=top;i<=bottom;i++)
                    list.Add(matrix[i][right]);
                right--;
                
                if(top<=bottom){
                    for(int i=right;i>=left;i--)
                    list.Add(matrix[bottom][i]);
                     bottom--;
                }
                
                if(left<=right){
                    for(int i=bottom;i>=top;i--)
                    list.Add(matrix[i][left]);
                    left++;
                }
                
                
            }
            return list;
    }
}