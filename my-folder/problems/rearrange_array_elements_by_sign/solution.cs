public class Solution {
    public int[] RearrangeArray(int[] nums) {
    //    Queue<int> po= new Queue<int>();
    //    Queue<int> ne= new Queue<int>();
    //    int n = nums.Length;
    //    for(int i=0;i<n;i++){
    //         if(nums[i]>0)
    //             po.Enqueue(nums[i]);
    //         else
    //             ne.Enqueue(nums[i]);
    //    }
    //     for(int j=0;j<n;j++){
    //             if(j%2==0)
    //                 nums[j]=po.Dequeue();
    //             else
    //                 nums[j]=ne.Dequeue();
    //         }
    //     return nums;
    int[] temp = new int[nums.Length];
Array.Copy(nums, temp, nums.Length);

        int p=0;
        int n=1;
        for(int i=0;i<nums.Length;i++){
            if(temp[i]>0){
                nums[p]=temp[i];
                p+=2;
            }else{
                nums[n]=temp[i];
                n+=2;
            }
        }
    return nums;
    }
}