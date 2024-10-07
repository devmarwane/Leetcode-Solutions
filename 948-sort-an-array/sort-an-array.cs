public class Solution {
    public int[] SortArray(int[] nums) {
        QuickSort(nums, 0, nums.Length-1);  
        return nums;      
    }


    private void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            // Partition the array and get the pivot index
            int pivotIndex = Partition(arr, low, high);

            // Recursively sort the left and right subarrays
            QuickSort(arr, low, pivotIndex - 1);   // Left subarray
            QuickSort(arr, pivotIndex + 1, high);  // Right subarray
        }
    }


    private int Partition(int[] nums, int low, int high)
    {
        // Step 1: Choose pivot using median of three method
        int pivotIndex = MedianOfThree(nums, low, high);
        // Step 2: Swap the pivot with the last element in the array
        Swap(nums, pivotIndex, high);

        
        // Initialize pointers
        /*
        i: This starts at the first element of the array.
        j: This starts at the last element minus 1 (because the last element is the pivot now). 
        */
        int i = low;
        int j = high - 1;
        int pivot = nums[high];  // The pivot value is now at the end of the array

        // Step 3: Partition the array around the pivot
        /*
        The goal here is to rearrange the array such that all elements 
        smaller than the pivot are on the left and all elements greater than the pivot are on the right.
        */
        while(i<=j)
        {
            // Move 'i' to the right to find an element greater than or equal to pivot
            while (i <= j && nums[i] < pivot)
            {
                i++;
            }

            // Move 'j' to the left to find an element less than or equal to pivot
            while (i <= j && nums[j] > pivot)
            {
                j--;
            }

             // Swap elements if i is still less than or equal to j
            if (i <= j)
            {
                Swap(nums, i, j);
                i++;
                j--;
            }
        }

        // Step 4: After the pointers have crossed, swap the pivot back to its correct position
        Swap(nums, i, high);

        return i;
    }

     // Find the median of the first, middle, and last elements of the array
    private static int MedianOfThree(int[] arr, int low, int high)
    {
        int mid = (low + high) / 2;

        // Compare low, mid, and high and sort them
        if (arr[low] > arr[mid])
        {
            Swap(arr, low, mid);
        }
        if (arr[low] > arr[high])
        {
            Swap(arr, low, high);
        }
        if (arr[mid] > arr[high])
        {
            Swap(arr, mid, high);
        }

        // The median is now at the middle position
        return mid;
    }

     // Swap elements at two positions in the array
    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}