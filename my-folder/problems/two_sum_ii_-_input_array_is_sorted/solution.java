class Solution {
    public int[] twoSum(int[] numbers, int target) {
        int slow = 0, fast = numbers.length - 1;
      while(slow < fast){
          if(numbers[slow] + numbers[fast] == target) return new int[]{slow + 1, fast + 1};
          else if(numbers[slow] + numbers[fast] < target) slow++;
          else fast--;
      }
      return new int[]{-1, -1};
    }
}
// for(int i=0;i<=numbers.length-1;i++){
//             for(int j=numbers.length-1;j>=0 && j!=i;j--){
//                 if(numbers[i]+numbers[j]==target){
//                     return new int[]{i+1,j+1};
//                 }
//             }
//         }
//         return new int[]{};