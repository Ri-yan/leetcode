class Solution {
    public boolean validMountainArray(int[] arr) {
        if(arr.length==0 || arr.length==1 || arr.length==2){
            return false;
        }
        int count=0;
        while(count!=arr.length-1 && arr[count]<arr[count+1]){
            count++;
        }
        if(count==arr.length-1||count==0)
            return false;
        while(count!=arr.length-1 && arr[count]>arr[count+1]){
            count++;
        }
        
         if(count==arr.length-1)
             return true;
        return false;
    }
}