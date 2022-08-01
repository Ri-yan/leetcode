class Solution {
    public int[] replaceElements(int[] arr) {
        if(arr.length==0)
            return arr;
        if(arr.length==1){
            arr[0]=-1; 
            return arr;
        }
           
       if(arr.length==2){
           arr[arr.length-2]=arr[arr.length-1];
           arr[arr.length-1]=-1;
           return arr;
       }
        for(int i=0;i<arr.length-2;i++){
             int t=0;
            for(int j=i+1;j<=arr.length-1;j++){
                if(arr[j]>t){
                    t=arr[j];
                }
                arr[i]=t;
            }
        }
        arr[arr.length-2]=arr[arr.length-1];
        arr[arr.length-1]=-1;
        return arr;
    }
}