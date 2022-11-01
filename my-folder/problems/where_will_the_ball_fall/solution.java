class Solution {
    static int dsf(int i,int j,int[][] grid){
        if(i>=grid.length){
            return j;
        }
        else if(grid[i][j]==1 && j+1<grid[0].length && grid[i][j+1]==1 ){
            return dsf(i+1,j+1,grid);
        }
        else if(grid[i][j]==-1 && j-1>=0 && grid[i][j-1]==-1 ){
            return dsf(i+1,j-1,grid);
        }
        else if(grid[i][j]==1 && j+1>grid[0].length )
            return -1;
        else return -1;
    }
    public int[] findBall(int[][] grid) {
        int col= grid[0].length;
        int pos[]=new int[col];
        for(int j=0;j<col;j++){
            pos[j]=Solution.dsf(0,j,grid);
        }
        return pos;
    }
}