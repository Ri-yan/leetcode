public class Solution
{
    int c = 0;
    void Merge(int[] arr, int low, int mid, int high)
    {
        var temp = new List<int>();
        int i = low;
        int j = mid + 1;
        while (i <= mid && j <= high)
        {
            if (arr[i] < arr[j])
            {
                temp.Add(arr[i]);
                i++;
            }
            else
            {
                temp.Add(arr[j]);
                j++;
            }
        }
        while (i <= mid)
        {
            temp.Add(arr[i]);
            i++;
        }
        while (j <= high)
        {
            temp.Add(arr[j]);
            j++;
        }


        for (int l = 0; l < temp.Count; l++)
        {
            arr[low + l] = temp[l];
        }

    }
    void MergeSort(int[] arr, int low, int high)
    {
        if (low >= high)
        {
            return;
        }
        int mid = (low + high) / 2;
        MergeSort(arr, low, mid);
        MergeSort(arr, mid + 1, high);
        CountPairs(arr, low, mid, high);
        Merge(arr, low, mid, high);
    }
    void CountPairs(int[] arr, int low, int mid, int high)
    {
        int r = mid + 1;
        for (int i = low; i <= mid; i++)
        {
            while (r <= high && arr[i] > 2L * arr[r]) { r++; }
            c += r - (mid + 1);
        }
    }
    public int ReversePairs(int[] nums)
    {
        MergeSort(nums, 0, nums.Length - 1);
        return c;
    }
}