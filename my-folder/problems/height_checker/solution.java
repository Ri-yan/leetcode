class Solution {
    public int heightChecker(int[] heights) {
        if(heights.length==0)
            return 0;
        int nm=0;
        int []expected =new int[heights.length];
         for(int i=0;i<=heights.length-1;i++)
             expected[i]=heights[i];
        Arrays.sort(expected);
        System.out.println(Arrays.toString(expected));
        for(int i=0;i<=heights.length-1;i++){
             if(heights[i] != expected[i]){
                 nm++;
             }
        }
        
        return nm;
    }
}