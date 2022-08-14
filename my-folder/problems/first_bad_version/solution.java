/* The isBadVersion API is defined in the parent class VersionControl.
      boolean isBadVersion(int version); */

public class Solution extends VersionControl {
    public int firstBadVersion(int n) {
        int start = 1;
        int end = n;
        
        while (start + 1 < end) {
            int mid = start + (end - start) / 2;
            if (isBadVersion(mid)) {
                end = mid;
            } else {
                start = mid;    
            }            
        }
        
        if (isBadVersion(start)) {
            return start;
        }
        return end;
    }
}
// int e=n;
//         int b=1;
//         while(b<=e){
//            int m=(b+e)/2;
//             if(isBadVersion(m)){ 
//                 e=m-1;
//             }
//             else{
//                  b=m+1; 
//             }
//         }
//         return b;
