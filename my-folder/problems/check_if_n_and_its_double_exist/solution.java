class Solution {
    public boolean checkIfExist(int[] arr) {
        if(arr.length==0 || arr.length==1)
            return false;
        for(int i=0;i<=arr.length-1;i++){
            for(int j=0;j<arr.length;j++){
                if(arr[i]==(arr[j]+arr[j]) && i!=j)
                    return true;
            }
        }
        return false;
    }
}